using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{
    //Sınıf Tanımı
    public class BasitKuyruk : IKuyruk
    {
        //Üye Değişkenleri
        public Araba[] Bkuyruk;
        public int front = -1;
        private int rear = -1;
        private int size = 0;
        public int count = 0;

        //Constructor
        public BasitKuyruk(int size)
        {
            this.size = size;
            Bkuyruk = new Araba[size];
        }

        public void Insert(Araba o)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Kuyruk dolu.");
            if (front == -1)
                front = 0;
            Bkuyruk[++rear] = o;
  
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Bkuyruk[front];
        }

        public object Remove()
        {
            if (IsEmpty())
            { 
                throw new Exception("Kuyruk Boştur.");
            }
            object temp = Bkuyruk[front];
            Bkuyruk[front] = null;
            front++;
            count--;
            return temp;
        }
    }
}
