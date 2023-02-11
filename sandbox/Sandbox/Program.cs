using System;

class Program
{
    static void Main(string[] args)
    {
        /*
            https://parzibyte.me/blog
            */
        string ubicacionArchivo = @"C:\Users\dicma\OneDrive\Documents\byui\cse210\cse210-hw\prove\Develop03\ScriptureList.csv";
        System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionArchivo);
        string separador = ",";
        string linea;
        // Si el archivo no tiene encabezado, elimina la siguiente línea
        archivo.ReadLine(); // Leer la primera línea pero descartarla porque es el encabezado

        while ((linea = archivo.ReadLine()) != null)
        {
            string[] fila = linea.Split(separador);
            string descripcion = fila[0];
            double precio = Convert.ToDouble(fila[1]);
            double existencia = Convert.ToDouble(fila[2]);
            Console.WriteLine("Producto {0} con precio {1} y existencia {2}", descripcion, precio, existencia);
        }
    }
}