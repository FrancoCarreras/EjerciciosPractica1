using System;
using System.Threading;

namespace Ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                Console.WriteLine("Ingrese la opción de lo que desea imprimir:");
                Console.WriteLine("1 - Remito");
                Console.WriteLine("2 - Facturas");
                Console.WriteLine("3 - Recibo de sueldo");
                Console.WriteLine("4 - Impuestos");
                string respuesta = Console.ReadLine();

                switch (respuesta)
                {
                    case "1":
                        Remito remito1 = new Remito();
                        remito1.SetInfoRemito(12, "17/07/2019");
                        remito1.SetNumeroDocumento(1);
                        Console.WriteLine(remito1.GetInfoRemito());
                        Console.WriteLine(remito1.GetNumeroDocumento());
                        break;
                    case "2":
                        Factura factura1 = new Factura();
                        factura1.SetInfoFactura("13/03/2020", 4500);
                        factura1.SetNumeroDocumento(8);
                        Console.WriteLine(factura1.GetInfoFactura());
                        Console.WriteLine(factura1.GetNumeroDocumento());
                        break;
                    case "3":
                        ReciboDeSueldo recibo1 = new ReciboDeSueldo();
                        recibo1.SetInfoReciboDeSueldo(456, 20000);
                        recibo1.SetNumeroDocumento(5);
                        Console.WriteLine(recibo1.GetInfoReciboDeSueldo());
                        Console.WriteLine(recibo1.GetNumeroDocumento());
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Seleccione que opción de impuesto desea imprimir:");
                        Console.WriteLine("1 - Luz");
                        Console.WriteLine("2 - Municipalidad");
                        string respuesta2 = Console.ReadLine();
                        switch (respuesta2)
                        {
                            case "1":
                                FacturaLuz facturaLuz1 = new FacturaLuz();
                                facturaLuz1.SetInfoFacturaLuz(3434, 2500);
                                facturaLuz1.SetNumeroDocumento(3);
                                Console.WriteLine(facturaLuz1.GetInfoFacturaLuz());
                                Console.WriteLine(facturaLuz1.GetNumeroDocumento());
                                break;
                            case "2":
                                Municipalidad municipalidad1 = new Municipalidad();
                                municipalidad1.SetInfoMunicipalidad(6700, 123);
                                municipalidad1.SetNumeroDocumento(17);
                                Console.WriteLine(municipalidad1.GetInfoMunicipalidad());
                                Console.WriteLine(municipalidad1.GetNumeroDocumento());
                                break;
                            default:
                                Console.WriteLine("Opción seleccionada invalida");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Opción seleccionada invalida");
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Desea imprimir otro recibo: ");
                Console.WriteLine("1 - Si");
                Console.WriteLine("2 - No");
                opcion = Console.ReadLine();
                Console.Clear();
            } while (opcion == "1");
        }
    }

    class ClasePadre
    {
        private int numeroDocumento = 0;
        public ClasePadre()
        {

        }

        public void SetNumeroDocumento(int numeroDocumento)
        {
            this.numeroDocumento = numeroDocumento;
        }

        public string GetNumeroDocumento()
        {
            return "El numero de documento es: " + numeroDocumento;
        }
    }

    class Remito : ClasePadre
    {
        public Remito() : base()
        {

        }

        private int cantBultos;
        private string fecha;

        public void SetInfoRemito(int cantBultos, string fecha)
        {
            this.cantBultos = cantBultos;
            this.fecha = fecha;
        }

        public string GetInfoRemito()
        {
            Console.Clear();
            return "La información del remito es: \nCantidad de bultos: " + cantBultos + "\nFecha: " + fecha;
        }
    }

    class Factura : ClasePadre
    {
        public Factura() : base()
        {

        }

        private string fecha;
        private int importe;

        public void SetInfoFactura(string fecha, int importe)
        {
            this.fecha = fecha;
            this.importe = importe;
        }

        public string GetInfoFactura()
        {
            Console.Clear();
            return "La información de la factura es:\nFecha: " + fecha + "\nImporte: " + importe;
        }
    }

    class ReciboDeSueldo : ClasePadre
    {
        public ReciboDeSueldo() : base()
        {

        }

        private int legajo;
        private int total;

        public void SetInfoReciboDeSueldo(int legajo, int total)
        {
            this.legajo = legajo;
            this.total = total;
        }

        public string GetInfoReciboDeSueldo()
        {
            Console.Clear();
            return "La información del recibo de sueldo es:\nLegajo: " + legajo + "\nTotal: " + total;
        }
    }

    class FacturaLuz : ClasePadre
    {
        public FacturaLuz() : base()
        {

        }

        private int codigoPago;
        private int importe;

        public void SetInfoFacturaLuz(int codigoPago, int importe)
        {
            this.codigoPago = codigoPago;
            this.importe = importe;
        }

        public string GetInfoFacturaLuz()
        {
            Console.Clear();
            return "La información de la factura de luz es:\nCodigo de pago: " + codigoPago + "\nImporte: " + importe;
        }
    }
    class Municipalidad : ClasePadre
    {
        public Municipalidad() : base()
        {

        }

        private int importe;
        private int partida;

        public void SetInfoMunicipalidad(int importe, int partida)
        {
            this.importe = importe;
            this.partida = partida;
        }

        public string GetInfoMunicipalidad()
        {
            Console.Clear();
            return "La información de la factura de municipalidad es:\nImporte: " + importe + "\nPartida: " + partida;
        }
    }
}
