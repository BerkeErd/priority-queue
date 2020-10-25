using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{
    public class OncelikliSira : IKuyruk
    {
        public Araba[] OKuyruk;
        public int front = -1;
        //Not1: rear değeri hep 0 olduğu için değişmez.
        //Not2: size ve count değişkenlerinden birisi
        //istenirse kullanılmayabilir
        private int size = 0;
        public int count = 0;
        public OncelikliSira(int size)
        {
            this.size = size;
            OKuyruk = new Araba[size];
        }

        public void Insert(Araba o)
        {
            if (count == size)
                throw new Exception("Queue is full");
            if (IsEmpty())
            {
                front++;
                OKuyruk[front] = o;
            }
            else
            {
                int i;
                //Not3:
                //Son elemandan başlayarak geriye doğru kuyruk kontrol ediliyor
                //Eklenecek elemanın pozisyonu belirleniyor
                //Var olan elemanlar kaydırılıyor
                for (i = count - 1; i >= 0; i--)
                {
                    if (o.IslemSuresi > OKuyruk[i].IslemSuresi)
                        OKuyruk[i + 1] = OKuyruk[i];
                    else
                        break;
                }
                OKuyruk[i + 1] = o;
                front++;
            }
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return OKuyruk[front];
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Kuyruk Boştur.");
            }
            object temp = OKuyruk[front];
            OKuyruk[front] = null;
            front--;
            count--;
            return temp;
        }
    }
}
