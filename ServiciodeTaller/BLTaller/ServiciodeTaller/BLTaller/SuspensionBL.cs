using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLTaller
{
    public class SuspensionBL
    {
        public BindingList<Suspension> ListaSuspension { get; set; }
        public SuspensionBL()
        { 

            ListaSuspension = new BindingList<Suspension>();

            var Suspension1 = new Suspension();

            Suspension1.Codigo = 01200141;
            Suspension1.NoParte = "801951"; 
            Suspension1.Descripcion = "Amortiguador Delantero RH /Sedan (Corolla 93-02)"; 
            Suspension1.Inventario = 4;
            Suspension1.Precio = 1800;

            ListaSuspension.Add(Suspension1);


            var Suspension2 = new Suspension();

            Suspension2.Codigo = 01200142;
            Suspension2.NoParte = "801952";
            Suspension2.Descripcion = "Amortiguador Delantero LH /Sedan (Corolla 93-02)";
            Suspension2.Inventario = 4;
            Suspension2.Precio = 1900;

            ListaSuspension.Add(Suspension2);

            var Suspension3 = new Suspension();

            Suspension3.Codigo = 01200143;
            Suspension3.NoParte = "808144";
            Suspension3.Descripcion = "Amortiguador Trasero RH /Sedan (Corolla 93-02)";
            Suspension3.Inventario = 6;
            Suspension3.Precio = 1915;

            ListaSuspension.Add(Suspension3);

            var Suspension4 = new Suspension();

            Suspension4.Codigo = 01200144;
            Suspension4.NoParte = "801954";
            Suspension4.Descripcion = "Amortiguador Trasero LH /Sedan (Corolla 93-02)";
            Suspension4.Inventario = 8;
            Suspension4.Precio = 1915;

            ListaSuspension.Add(Suspension4);

            var Suspension5 = new Suspension();

            Suspension5.Codigo = 01200145;
            Suspension5.NoParte = "48510AB031";
            Suspension5.Descripcion = "Amortiguador Delantero RH /Sedan (Corolla 03-08)";
            Suspension5.Inventario = 5;
            Suspension5.Precio = 2148;

            ListaSuspension.Add(Suspension5);

            var Suspension6 = new Suspension();

            Suspension6.Codigo = 01200146;
            Suspension6.NoParte = "4852002321";
            Suspension6.Descripcion = "Amortiguador Delantero LH /Sedan (Corolla 03-08)";
            Suspension6.Inventario = 4;
            Suspension6.Precio = 1800;

            ListaSuspension.Add(Suspension6);



            var Suspension7 = new Suspension();

            Suspension7.Codigo = 01200147;
            Suspension7.NoParte = "314159MM";
            Suspension7.Descripcion = "Amortiguador Trasero R/L Sedan (Corolla/Matrix/Vibe 03-08)";
            Suspension7.Inventario = 2;
            Suspension7.Precio = 1612;

            ListaSuspension.Add(Suspension7);


            var Suspension8 = new Suspension();

            Suspension8.Codigo = 01200148;
            Suspension8.NoParte = "72597";
            Suspension8.Descripcion = "Amortiguador Delantero RH Sedan (Corolla 09-13)";
            Suspension8.Inventario = 7;
            Suspension8.Precio = 3500;

            ListaSuspension.Add(Suspension8);

            var Suspension9 = new Suspension();

            Suspension9.Codigo = 01200149;
            Suspension9.NoParte = "72598";
            Suspension9.Descripcion = "Amortiguador Delantero LH Sedan (Corolla 09-13)";
            Suspension9.Inventario = 8;
            Suspension9.Precio = 3700;

            ListaSuspension.Add(Suspension9);

            var Suspension10 = new Suspension();

            Suspension10.Codigo = 01200150;
            Suspension10.NoParte = "4853002220";
            Suspension10.Descripcion = "Amortiguador Trasero R/L Sedan (Corolla/Matrix/Vibe 09-13)";
            Suspension10.Inventario = 9;
            Suspension10.Precio = 1852;

            ListaSuspension.Add(Suspension10);

            var Suspension11 = new Suspension();

            Suspension11.Codigo = 01200151;
            Suspension11.NoParte = "4860912190";
            Suspension11.Descripcion = "Soporte de Amortiguador R/L (Corolla 88-02)";
            Suspension11.Inventario = 1;
            Suspension11.Precio = 578;

            ListaSuspension.Add(Suspension11);

            var Suspension12 = new Suspension();

            Suspension12.Codigo = 01200152;
            Suspension12.NoParte = "4860920471";
            Suspension12.Descripcion = "Soporte de Amortiguador R/L (Corolla 03-08)";
            Suspension12.Inventario = 15;
            Suspension12.Precio = 600;

            ListaSuspension.Add(Suspension12);

        }

        public BindingList<Suspension> ObtenerSuspension()
        {
            return ListaSuspension;
        }
        

    public class Suspension
    {
       
            public double Codigo { get; set; }
            public string NoParte { get; set; }
            public string Descripcion { get; set; }
            public int Inventario { get; set; }
            public double Precio { get; set; }
            
              
         }
     }
}
