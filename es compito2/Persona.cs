using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_compito2
{
    internal class Persona
    {
        public DateTime Datadinascita {  get; set; }
        public int Calcolaeta()
        {
           DateTime oggi= DateTime.Today;
            
            
            if (oggi.Day>=Datadinascita.Day)
            
               return (oggi.Year - Datadinascita.Year); 
            
            else
           
                return oggi.Year - Datadinascita.Year-1;
            

        }
    }
}
