using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_compito2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Console.WriteLine("inserire data di nascita:");
            persona.Datadinascita=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ha {0} anni", persona.Calcolaeta());
            Console.ReadLine();
        }
    }
}
