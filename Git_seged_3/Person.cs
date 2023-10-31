using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_seged_3
{
    internal class Person
    {
        public string Nev { get; set; } 
        public int Kor {get; set; }
        public string Munkakor{get;set;}
        
        public Person(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }
    }
}
