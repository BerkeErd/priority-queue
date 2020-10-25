using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{
   public class Araba
    {
        public int AracNo { get; set; }
        public int IslemSuresi { get; set; }
        
        public Araba()
        {

            
            Random r = new Random();
            IslemSuresi = r.Next(10, 100);
            
            
     
        }
        
    }

   
}
