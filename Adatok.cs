using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ujprojekt_2023._02
{
    internal class Adatok
    {
        
        public string nev { get; set; }

       
        public string hazi1 { get; set; }
        public string hazi2 { get; set; }
        public string hazi3 { get; set; }
        public string hazi4 { get; set; }

        public string hazi5 { get; set; }

        public string hazi6 { get; set; }

        public string hazi7 { get; set; }

        public string hazi8 { get; set; } 
        



        



        public Adatok(string sor)
        {   
            string[] reszek = sor.Split(',');
            
            nev = reszek[0];
            hazi1 = reszek[1];
            hazi2 = reszek[2];
            hazi3 = reszek[3];
            hazi4 = reszek[4];
            hazi5 = reszek[5];
            hazi6 = reszek[6];
            hazi7 = reszek[7];
            hazi8 = reszek[8];
            
            
        }
    }
}
