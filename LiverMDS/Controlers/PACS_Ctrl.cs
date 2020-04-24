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
            static bool Echo(PACS_Klient klient, PACS_Serwer serwer)
            {
                return gdcm.CompositeNetworkFunctions.CEcho(serwer.Adres, serwer.Port, klient.AET, serwer.AEC);
            }

            static bool Store(PACS_Klient klient, PACS_Serwer serwer, string fileName)
            {
                gdcm.FilenamesType files = new gdcm.FilenamesType();
                files.Add(fileName);

                bool response = gdcm.CompositeNetworkFunctions.CStore(serwer.Adres, serwer.Port, files, klient.AET, serwer.AEC);

                if (response)
                    return true;
                else                
                    return false;
            }

            static gdcm.DataSetArrayType Find(PACS_Klient klient, PACS_Serwer serwer, PACS_Query query)
            {
                gdcm.DataSetArrayType results = new gdcm.DataSetArrayType();

                try { 
                    bool stan = gdcm.CompositeNetworkFunctions.CFind(serwer.Adres, serwer.Port, query.GetQuery(), results, klient.AET, serwer.AEC); 
                }
                catch { 
                    System.Console.Out.WriteLine("Something wrong"); 
                    return null;  
                }

                return results;
            }

            static string Move(PACS_Klient klient, PACS_Serwer serwer, PACS_Query query, String directory)
        {
            try
            {
                bool stan = gdcm.CompositeNetworkFunctions.CMove(serwer.Adres, serwer.Port, query.GetQuery(), klient.Port, klient.AET, serwer.AEC, directory);
            }
            catch
            {
                System.Console.Out.WriteLine("Something wrong");
                return null;
            }
            return directory;
        }
    }
}
