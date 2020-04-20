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
        private string aet { get; set; }
        private int port { get; set; }

        public PACS_Klient(string aet, int port) {
            this.Update(aet, port);
        }
        public string GetAet()
        {
            return this.aet;
        }
        public int GetPort()
        {
            return this.port;
        }
        public PACS_Klient Update(string aet, int port)
        {
            this.aet = aet;
            this.port = port;
            return this;
        }                
        override public string ToString()
        {
            return "PACS klient aet: " + aet + " port number: " + port.ToString();
        }

    }
}
