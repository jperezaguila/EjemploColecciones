using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColecciones
{
    public class Listas

    {
        public static void Mai(string[] args)
        {
            List<Persoona> p= new List<Persoona>();

            p.Add(new Persoona()
            {
                Apellidos = "Gomez",
                Nombre = "Albero",
            });
            p.Add(new Persoona()
            {
                Apellidos = "Jimenez",
                Nombre = "Luis",
            });
            p.Add(new Persoona()
            {
                Apellidos = "Dominguez",
                Nombre = "Eva",
            });
            //Borraremos de la lista el 1 de la lista, la lista es de  0 , 1, 2, 3,.....
            p.RemoveAt(1);

            for (int i = 0; i < p.Count; i++)
            {
                Console.WriteLine(p[i].Nombre);
            }
            Console.ReadLine();
        }
    }
}

