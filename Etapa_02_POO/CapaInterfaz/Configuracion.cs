using System;
using System.Collections.Generic;
using System.Text;

namespace CapaInterfaz
{
    public class Configuracion // Cadena de conexion
    {
        public static string getConnectionString
        {
            get
            {
                return Properties.Settings.Default.ConnectionString;// llamamos la conexion creada en setting capainterfaz
            }
        }
    }//Fin getConnectionString
}//fin namespace configuracion
