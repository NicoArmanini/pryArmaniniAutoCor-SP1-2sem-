using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryArmaniniAutoCor_SP1
{
    internal class Archivo
    {
        public string NombreArchivo { get; set; }

        public bool GrabarRepuesto(clsRepuestos repuesto)
        {
            // recibe un objeto de tipo Repuesto y lo graba en el archivo
            bool resultado = false;
            if (NombreArchivo != "")
            {
                
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
               
                sw.WriteLine(repuesto.Codigo + "," + repuesto.Nombre + "," + repuesto.Marca + "," +
                repuesto.Precio.ToString("#.00", CultureInfo.InvariantCulture) + "," + repuesto.origen);
                sw.Close(); 
                sw.Dispose(); 
                resultado = true;
            }
            return resultado;
        }
        public bool BuscarCodigoRepuesto(string codigo)
        {
            // recibe el código del repuesto a buscar
            // devuelve falso si el código no existe en el archivo
            // devuelve verdadero si el código ya está grabado
            bool resultado = false;
            string Linea;
            string CodigoRepuesto;
            
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                
                StreamReader sr = new StreamReader(NombreArchivo);
                
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // lee una linea completa
                                          
                    CodigoRepuesto = Linea.Split(',')[0];
                    // comparar el código buscado con el del archivo
                    if (codigo == CodigoRepuesto)
                    {
                        
                        resultado = true;
                        break; 
                    }
                }
                sr.Close(); 
                sr.Dispose(); 
            }
            return resultado;
        }
        public List<clsRepuestos> ObtenerRepuestos()
        {
            
            List<clsRepuestos> Lista = new List<clsRepuestos>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // lee una linea del archivo
                                           // crea un objeto 'Repuesto' y rellena sus propiedades
                    clsRepuestos repuesto = new clsRepuestos();
                    repuesto.Codigo = Linea.Split(',')[0];
                    repuesto.Nombre = Linea.Split(',')[1];
                    repuesto.Marca = Linea.Split(',')[2];
                   
                    repuesto.Precio = decimal.Parse(Linea.Split(',')[3], CultureInfo.InvariantCulture);
                    repuesto.origen = Linea.Split(',')[4];
                    Lista.Add(repuesto); // se agrega el repuesto a la lista
                }
                sr.Close(); 
                sr.Dispose(); 
            }
            // devuelve la lista de repuestos completa
            return Lista;
        }

        public List<clsRepuestos> ObtenerRepuestosOrdenados()
        {
            
            List<clsRepuestos> Lista = ObtenerRepuestos();
            // convertir la lista en un arreglo con el método "ToArray()"
            clsRepuestos[] repuestosArray = Lista.ToArray();
            // ordenar el arreglo con el método de Burbuja
           
            for (int i = 0; i < repuestosArray.Length - 1; i++)
            {
                for (int j = 0; j < repuestosArray.Length - 1; j++)
                {
                    // se comparan los nombres de los repuestos
               
                    if (string.Compare(repuestosArray[j].Nombre,
                    repuestosArray[j + 1].Nombre) > 0)
                    {
                        // se intercambian si el nombre en j es mayor al nombre en j+1
                        clsRepuestos aux = repuestosArray[j];
                        repuestosArray[j] = repuestosArray[j + 1];
                        repuestosArray[j + 1] = aux;
                    }
                }
            }
            // convertir el arreglo ya ordenado en una lista
            List<clsRepuestos> Ordenados = repuestosArray.ToList<clsRepuestos>();
            // devuelve la lista de respuestos ordenada por nombre en forma ascendente
            return Ordenados;
        }
    }
}

