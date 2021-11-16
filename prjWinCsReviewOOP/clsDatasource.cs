using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prjWinCsReviewOOP
{
   public  static class clsDatasource
    {
        public static clsListClient getAllClients()
        {
            clsListClient allClients = new clsListClient();
            StreamReader myfile = new StreamReader("Clients.txt");
            while (myfile.EndOfStream == false)
            {
                string num = myfile.ReadLine();
                string nam = myfile.ReadLine();
                string stat = myfile.ReadLine();
                string pin = myfile.ReadLine();
                clsClient aclient = new clsClient(num, nam, pin, stat);
                allClients.Add(aclient);
            }
            myfile.Close();
            return allClients;



        }
    }
}
