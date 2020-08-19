using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Inwerteryzacja
{
    class BaseConnect
    {
        //LoginBase login = new LoginBase();
        //public static string pass { get; set; }
        public OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\krenca.m\\Baza_komputery.accdb; Jet OLEDB:Database Password =Pr0gre5_#");
        public bool connectionToDataBase()
        {
            string message;
            //string pass = ""; //login.passText.Text;
            if (con.State.ToString() == "Closed" || con.State.ToString() == null)
            {
                try
                {
                    //con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Baza_komputery.accdb; Jet OLEDB:Database Password =" + pass.ToString());
                    con.Open();
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
            }

            if (con.State.ToString() == "Open")
                return true;
            else
                return false;
        }
    }
}
