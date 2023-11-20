using InstanceStaticMethods.Entities;

namespace InstanceStaticMethods.Business
{
    public class ClienteGestion
    {
        //Propiedades
        public Cliente Cliente { get; set; }
        public int AniosAntiguedad { get; set; }
        public double MontoComprasAcumuladas { get; set; }
        public double MontoDeudaActual { get; set; }

        //Propiedad estática
        public static double TotalIngresos;

        //Métodos de instancia
        public string obtenerStatus()
        {
            //Lógica del negocio
            var response = "";

            if (AniosAntiguedad > 1)
            {
                if (MontoDeudaActual == 0)
                {
                    response = MontoComprasAcumuladas >= 1000 ? "Cliente premium" : "Cliente preferencial";
                }
                else
                {
                    response = MontoDeudaActual / MontoComprasAcumuladas <= 0.25 ? "Cliente comun" : "Cliente riesgoso";
                }
            }
            else
            {
                response = "Cliente sin historial suficiente";
            }

            return response;
        }

        //Métodos estáticos
        public static void CalculateTax()
        {            
            Console.WriteLine($"Tus impuestos son: {TotalIngresos * 0.2}");
        }

        public static void CalculateTax(double totalIngresos)
        {
            Console.WriteLine($"Tus impuestos son:{totalIngresos * 0.2}");
        }
    }
}
