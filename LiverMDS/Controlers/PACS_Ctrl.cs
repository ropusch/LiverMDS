using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gdcm;
namespace LiverMDS.Controlers
{
    class PACS_Ctrl
    {
        static bool IsConnection(PACS_Klient klient, PACS_Serwer serwer)
        {
            return gdcm.CompositeNetworkFunctions.CEcho(serwer.GetAec(), serwer.GetPort(), klient.GetAet());
        }

        static bool Store(PACS_Klient klient, PACS_Serwer serwer, string fileName)
        {
            gdcm.FilenamesType files = new gdcm.FilenamesType();
            pliki.Add(fileName);
          
            bool response = gdcm.CompositeNetworkFunctions.CStore(serwer.get(), serwer.GetPort(), files, klient.GetAet(), serwer.GetPort());

            if (response)
                return true;
            else                
                return false;
        }

        static bool Find(PACS_Klient klient, PACS_Serwer serwer, PACS_Query query)
        {
            gdcm.DataSetArrayType results = new gdcm.DataSetArrayType(); 
            bool stan = gdcm.CompositeNetworkFunctions.CFind(serwer.GetAec(), serwer.GetPort(), query.GetQuery(), results, klient.GetAet(), klient.GetPort());

            return result;
        }
    }
}
