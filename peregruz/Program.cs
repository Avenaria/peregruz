using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peregruz
{
    class Peregruz
    {
        public int x, y;
        public Peregruz (int x, int y)
        {
            this.x = x; 
            this.y = y;
        }
        public static Peregruz operator +(Peregruz a, Peregruz b)=>// перегрузка +
            new Peregruz(a.x + b.y, a.y + b.x);

        public static Peregruz operator -(Peregruz a, Peregruz b) =>// перегрузка -
            new Peregruz(a.x - b.y, a.y - b.x);
        public static bool operator ==(Peregruz a, Peregruz b)
        {
            if (a == null || b == null) return false;

            return true;
            
        }
        public static bool operator !=(Peregruz a, Peregruz b)
        {
            if (a == null || b == null) return true;

            return false;

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
