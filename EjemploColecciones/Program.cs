using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColecciones
{
    class Program
    {
        static void Mai(string[] args)
        {
            Queue q= new Queue();
            q.Enqueue("A");
            q.Enqueue(new Persoona());

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            ArrayList l=new ArrayList();
            l.Add(new Persoona());
            l.Add(new Persoona());
            l.Add("Pepo");
            l.Add(new Persoona());
            l.Add(new Persoona());
            l.Add(23);
            l.Add(new Persoona());

            Console.WriteLine(l[2]);
            Console.ReadLine();
        }
    }
}
