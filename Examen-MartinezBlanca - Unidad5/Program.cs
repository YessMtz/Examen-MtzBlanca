using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_MartinezBlanca___Unidad5
{
    class Program
    {
        class AmazonStok
        {
            public string nombreProd, descripcion;
            public int cantidad;
            public float precio;

            public AmazonStok(string nombreProd, string descripcion, int cantidad, float precio)
            {
                this.nombreProd = nombreProd;
                this.descripcion = descripcion;
                this.cantidad = cantidad;
                this.precio = precio;

            }

            public void desplegarDatos()
            {
                Console.WriteLine("Nombre del producto: " + nombreProd +
                    "\nDescripción: " + descripcion +
                    "\nCantidad: " + cantidad +
                    " Precio: " + precio);
            }
            //destructor de la clase
            ~AmazonStok()
            {
                Console.WriteLine("Memoria de la clase derivada");
            }
        }

        static void Main(string[] args)
        {
            //GENRADOR DE ARCHIVO
            StreamWriter CapturaProductos = null;
            String CapProdc;

            CapturaProductos = new StreamWriter("Productos.txt");
            
            //captura datos
            Console.Write("Ingrese el Nombre del producto: ");
            string nameproduct = Console.ReadLine().ToString();

            Console.Write("Descripcion del producto ingresado: ");
            string descripcionProducto = Console.ReadLine().ToString();

            Console.Write("Cantidad de productos en Stok: ");
            int cantidadproducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Precio unitario del producto: ");
            float preciounitario = Single.Parse(Console.ReadLine());

            AmazonStok CapturaProducto1 = new AmazonStok(nameproduct, descripcionProducto, cantidadproducto, preciounitario);
            CapturaProducto1.desplegarDatos();

            CapturaProductos.WriteLine(nameproduct, descripcionProducto, cantidadproducto, preciounitario);
            CapProdc = Console.ReadLine();
            while (CapProdc.Length != 0) ;


            if (CapProdc != null) CapturaProductos.Close();
        }
    }
}
