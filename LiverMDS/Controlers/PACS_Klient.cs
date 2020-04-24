using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gdcm;

namespace LiverMDS.Controlers
{
    class PACS_Klient
    {
        private string _aet;
        private ushort _port;

        public PACS_Klient(string aet, ushort port) {
            this.Update(aet, port);
        }
        public string AET
        {
            get { return _aet; }
            set { _aet = value; }
        }

        public ushort Port
        {
            get { return _port; }
            set { _port = value; }
        }
        public PACS_Klient Update(string aet, ushort port)
        {
            this._aet = aet;
            this._port = port;
            return this;
        }                
        override public string ToString()
        {
            return "PACS klient aet: " + _aet + " port number: " + _port.ToString();
        }

    }
}
