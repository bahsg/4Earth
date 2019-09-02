using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Earth_Barbara_1708856.Classes;

namespace _4Earth_Barbara_1708856
{
    class Program
    {
        static void Main(string[] args)
        {
            Login l = new Login();
            l.Email = "rodriguinho.p@hotmail.com";
            l.Nome = "Rodrigo";
            l.ID = 24;

            Console.WriteLine("Identificação: " + l.ObterNome());
            Console.WriteLine("Identificação: " + l.ObterEmail());
            Console.WriteLine(l.GerarHash());

            foreach (var item in l.GerarLista())
            {
                Console.WriteLine(item);

            }

            Console.ReadKey();
        }
    }
}
