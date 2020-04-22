using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship creiser = new Ship();
            creiser.name = "Крейсер Аврора";
            creiser.price = 750000000;
            creiser.age = 120;
            creiser.port = " Порт Ораниенбаума";

            creiser.GetShipInfo();

            Boat boat = new Boat();
            boat.type = "Парусник";
            boat.name = "Яхта Святого Вячеслава";
            boat.port = "Берега амазонки";
            boat.price = 100000;
            boat.age = 1;


            boat.GetBoatInfo();



        }
    }
}
