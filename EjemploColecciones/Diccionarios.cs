using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColecciones
{
    public  class Diccionarios
    {
        public static void Main(string[] args)
        {
            
            Dictionary<String,Persoona> d= new Dictionary<string, Persoona>();
            
            d.Add("Uno", new Persoona() {Apellidos = "Gomez", Nombre = "Luis"});
            d.Add("Dos", new Persoona() { Apellidos = "Gomez", Nombre = "Eva" });
            d.Add("Tres", new Persoona() { Apellidos = "Gomez", Nombre = "Maria" });
            //para acceder a un elemento
            Console.WriteLine(d["Dos"].Nombre);

            if (d.ContainsKey("Tres"))
            {
                d.Remove("Tres");
            }

            foreach (var key in d.Keys)
            {
            Console.WriteLine(d[key].Nombre);    
            }
            Console.ReadLine();
        }
    }

}
