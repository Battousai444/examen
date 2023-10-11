using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libExamenTour.ExamenTour
{
    public class clsExamenTour
    {
            public clsExamenTour()
            {
                Descuento = 0;
                valorper = 0;

            }



            #region propiedades
            public string Tour { private get; set; }
            public Int16 Npersonas { private get; set; }
            public bool Almuerzo { private get; set; }
            public string Error { get; private set; }
            public double valortotal { get; private set; }
            public double Subtotal { get; private set; }
            public double valorIva { get; private set; }
            public double valorDescuento { get; private set; }

            public double valorSinDes { get; private set; }

            private double Descuento;


            private double valorper;






            #endregion

            #region metodos
            public bool CalcularTotal()
            {
                if (validar())
                {
                    tipoDeTour();
                    desc();
                    valorSinDes = Npersonas * valorper;
                    valorDescuento = Descuento;
                    valortotal = valorSinDes - Descuento;
                    valorIva = valortotal * 0.19;
                    Subtotal = valortotal - valorIva;

                    return true;

                }
                return false;
            }

            public bool validar()
            {
                if (Npersonas < 1 || Npersonas > 20)
                {
                    Error = "papi tiene que ser por lo menos una persona y maximo 20";
                    return false;
                }
                return true;
            }
            public double desc()
            {

                if (Npersonas >=5 && Npersonas <= 10)
                {
                    Descuento = (Npersonas * valorper) * 0.1;

                }
                if (Npersonas >= 11 && Npersonas <= 20)
                {
                    Descuento = (Npersonas * valorper) * 0.2;

                }
                return Descuento;

            }

            public bool tipoDeTour()
            {
                
                switch (Tour)
                {
                    case "Ciudad amurallada y Castillo San Felipe":
                        if (Almuerzo)
                        {
                            valorper = 45000;
                        }
                        else
                        {
                            valorper = 25000;
                        }
                        return true;

                    case "Playas":
                        if (Almuerzo)
                        {
                            valorper = 70000;
                        }
                        else
                        {
                            valorper = 45000;
                        }

                        return true;
                    case "Isla Barú":
                        if (Almuerzo)
                        {
                            valorper = 70000;
                        }
                        else
                        {
                            valorper = 40000;
                        }
                        return true;

                    default:
                        Error = "No definió un tipo de tour loca";
                        return false;
                }
            }


            #endregion
    }
}


