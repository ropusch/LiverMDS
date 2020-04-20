using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gdcm;

namespace LiverMDS.Controlers
{
    class PACS_Query
    {
        private gdcm.ERootType queryType { get; set; }
        private gdcm.EQueryLevel queryLevel { get; set; }
        private gdcm.BaseRootQuery query { get; set; }
        private gdcm.KeyValuePairArrayType keys { get; }

        public PACS_Query(ERootType type = ERootType.ePatientRootType, EQueryLevel level = EQueryLevel.ePatient)
        {
            queryType = type;
            queryLevel = level;
        }

        public bool Validate()
        {
            if (!query.ValidateQuery())            
                return false;            
            else
                return true;
        }

        public gdcm.KeyValuePairArrayType AddKey(gdcm.Tag tag, string value)
        {
            gdcm.KeyValuePairType newKey = new gdcm.KeyValuePairType(tag, value);
            keys.Add(newKey);            
            return keys;
        }
        
        private void Update()
        {
            query = gdcm.CompositeNetworkFunctions.ConstructQuery(queryType, queryLevel, keys, true);
        }

        public gdcm.BaseRootQuery GetQuery()
        {
            this.Update();
            return query;
        }
    }
}
