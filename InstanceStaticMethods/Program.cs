using InstanceStaticMethods.Business;
using InstanceStaticMethods.Entities;

Console.WriteLine("Métodos de instancia vs métodos estáticos");

/****** Método de instancia ******/
Cliente cliente = new Cliente();
cliente.Id = 1;
cliente.Nombre = "Juan Valdez";

ClienteGestion objetoGestion = new ClienteGestion();
objetoGestion.Cliente = cliente;
objetoGestion.AniosAntiguedad = 2;
objetoGestion.MontoComprasAcumuladas = 1000;
objetoGestion.MontoDeudaActual = 0;

Console.WriteLine(objetoGestion.obtenerStatus());

/****** Métodos estáticos ******/
ClienteGestion.TotalIngresos = 3000;
ClienteGestion.CalculateTax();

ClienteGestion.CalculateTax(2500);