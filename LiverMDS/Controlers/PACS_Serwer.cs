using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiverMDS.Controlers
{
    class PACS_Serwer
    {
        private string _aec;
        private ushort _port;
        private string _adres;    

        public PACS_Serwer(string aec, ushort port)
        {
            this.Update(aec, port);
        }
        public string AEC
        {
            get { return _aec; } 
            set { _aec = value; } 
        }

        public ushort Port
        {
        get { return _port; }
        set { _port = value; }
        }

         public string Adres
         {
            get { return _adres; }
            set { _adres = value; }
         }

        private PACS_Serwer Update(string aet, ushort port)
        {
            this._aec = aet;
            this._port = port;
            return this;
        }

        override public string ToString()
        {
            return "PACS klient aet: " + _aec + " port number: " + _port.ToString();
        }
    }
}
