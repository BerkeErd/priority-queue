using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{
    public interface IKuyruk
 
    {
        void Insert(Araba o);
        object Remove();
        object Peek();
        Boolean IsEmpty();
    }
}
