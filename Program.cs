using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Class1 c1 = new Class1(); // объявляю экземплляр класса
            Console.Write("введите А: "); 
            
            c1.A = double.Parse(Console.ReadLine()); // ввод значения переменной А и передача значеня в закрытую переменную
            Console.Write("введите В: ");
            c1.B = double.Parse(Console.ReadLine()); // ввод значения переменной А и передача значеня в закрытую переменную
            Console.Write("введите С: ");
            c1.C = double.Parse(Console.ReadLine());// ввод значения переменной А и передача значеня в закрытую переменную
            c1.math(); // Запускаю метод в котором прописаны операции для вычисления значения переменных "p" и "s"
            Console.WriteLine("Площадь равна: {0}",c1.S); // вывод резульата
            Console.ReadKey(); // точка выхода из программы
        }

    }
}
