using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.clases
{
    public static class globales
    {

        static public string dbn = "NIC";
        static public string server = "LAPTOP-UVIC0HB6";
        static public string password = "1888206";
        static public string seguridad = "Integrated Security=True";
        static public string userID = "SA";

        static public string miconexion = @"Data Source = " + server + "; Initial Catalog = " + dbn + "; Persist Security info = True; User ID = SA; Password = " + password;

        static public byte nivel = 0;
        static public bool nive = false;
        static public string lusuario = "";
        static public string lnombre = "";
        static public string lpuesto = "";
    }
}
