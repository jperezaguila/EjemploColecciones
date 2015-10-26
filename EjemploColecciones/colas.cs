using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColecciones
{

    class Colas
    {
        public static void Mai(string[] args)
        {
            Queue colaG=new Queue();

            colaG.Enqueue("Hola");
            colaG.Enqueue("Soy");
            colaG.Enqueue(new Persoona() {Apellidos = "Gomez", Nombre = "Pepe"});
            colaG.Enqueue(22);

            foreach (var elem in colaG)
            {
                //    var p = elem as persoona;
                //    //si p es diferente de null, hazlo.
                //    if (p !=null)
                //    Console.WriteLine(p.Apellidos);
                //    else
                //    {
                Console.WriteLine(elem);
            }
            // de esta manera obtendremos listas de objetos de manera inversa con Push
            Stack<Persoona> stackP = new Stack<Persoona>();
            //De esta manera obtendremos listas de objetos
            //Queue<Persoona> colaP = new Queue<Persoona>();

            stackP.Push(new Persoona()
            
            //colaP.Enqueue(new Persoona()
            {
                Apellidos = "Gomez",
                Nombre ="Albero",
                
            });
            stackP.Push(new Persoona()
            //colaP.Enqueue(new Persoona()
            {
                Apellidos = "Jimenez",
                Nombre = "Luis",

            });
            stackP.Push(new Persoona()
            //colaP.Enqueue(new Persoona()
            {
                Apellidos = "Dominguez",
                Nombre = "Eva",

            });
            //foreach (var elem in colaP)
            //{
            //    Console.WriteLine(elem);
            //}
            foreach (var elem in stackP)
            {
                Console.WriteLine(elem);
            }

            Console.ReadLine();
        }
    }
}
