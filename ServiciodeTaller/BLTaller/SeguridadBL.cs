using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLTaller
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contraseña)
        {
            if(usuario== "Moorellana" && contraseña == "1470")
            {
                return true;
            }
            else
            {
                if (usuario == "Nooliveros" && contraseña == "1234")
                {
                    return true;
                }

                return false;
            }
        }

        
    }
}
