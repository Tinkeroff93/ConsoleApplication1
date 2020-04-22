using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ship
    {
        public double price { get; set; }
        public int age { get; set; }
        public string port { get; set; }
        public string name { get; set; }

        public void GetShipInfo()
        {
            Console.WriteLine($"Имя: {name}| |Возраст: {age}| |Порт: {port}| |Цена: {price}|");
        }
    }

    class Boat : Ship
    {
        public string type { get; set; }

        public virtual void GetBoatInfo()
        {
            Console.WriteLine($"Имя: {name}| |Возраст: {age}| |Порт: {port}| |Цена: {price}| |Тип: {type}");
        }
        static void Sayhi()
        {
            Console.WriteLine("Hi");
        }
    }
}