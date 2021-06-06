using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        private double p; // периметр

        
        
        public double A; // открытый вариант переменной "а" для передачи значения в закрытую переменную 
          
        private double a
        {
            get { return A; }
            set { a = A; }
        }
        
        
        public double B; // открытый вариант переменной "b" для передачи значения в закрытую переменную 
        private double b
        {
            get { return B; }
            set { b = B; }
        }
        

        public double C; // открытый вариант переменной "c" для передачи значения в закрытую переменную 
        private double c
        {
            get { return C; }
            set { c = C; }
        }

        public double S; // переменная, которая принимает результат и выводит значение на экран





        public void math() //Все операции выполнялись над закрытыми переменными
        {
            p = a + b + c; // нахождение периметра
            S = Math.Sqrt(p/2 * (p/2 - a) * (p/2 - b) * (p/2 - c)); // сама формула площади
        }
    }
}
