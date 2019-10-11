using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    class ejercicio2
    {
        public struct Producto
        {
            public string Nombre;
            private int Cant;
            private double Costo;
            private const double iva = 0.13;
            public void setCantidad(int cantidad)
            {
                if (cantidad > 0)
                {
                    this.Cant = cantidad;
                }
            }
            public int getCantidad()
            {
                return Cant;
            }
            public void setPrecio(double precio)
            {
                if (precio > 0.00)
                {
                    this.Costo = precio;
                }
            }
            public double getPrecio()
            {
                double pago;
                pago = Costo * iva;
                return Costo + pago;
            }
        }
        static void Main(string[] args)
        {
            int cant;
            Console.Write("Ingrese el registro de la cantidad de productos a ingresar: ");
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Producto[] prod = new Producto[cant];

            for (int i = 0; i < prod.Length; i++)
            {
                Console.WriteLine("Producto N°{0}", i + 1);
                Console.Write("Escriba el Nombre del producto: ");
                prod[i].Nombre = Console.ReadLine();
                Console.Write("Escriba la cantidad de productos ingresados: ");
                prod[i].setCantidad(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Escriba el costo del producto: ");
                prod[i].setPrecio(Convert.ToDouble(Console.ReadLine()));
            }
            for (int i = 0; i < prod.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Precio <Espacio>  para mostrar el registro del total a pagar por el cliente");
                Console.ReadKey();
                Console.Clear();
                double total;
                total = prod[i].getCantidad() * prod[i].getPrecio();
                Console.WriteLine("{0,5}   {1,-10}   {2,7}   {3,9} ", "Producto", "Cantidad", "Precio", "Total");
                Console.WriteLine("===========================================================================");
                foreach (Producto p in prod)
                {
                    Console.WriteLine("{0,5}  {1,8}  {2, 13}   {3,10} ",
                        prod[i].Nombre,
                        prod[i].getCantidad(),
                        prod[i].getPrecio(),
                        total);
                }
            }
            Console.ReadKey();
        }
    }
}