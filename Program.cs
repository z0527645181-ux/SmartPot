using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPot
{
    internal class Program

    {
        public delegate void md(string meal, int minuts);
        static void Main(string[] args)
        {
            onDishReady onDishReady1 = new onDishReady();
            chef ch=new chef();
            onDishReady1.OnDishReady += ch.takeOffStove;
            onDishReady1.OnDishReady += (string dish, int minutes) => { Console.WriteLine("!!!!!"); };
            onDishReady1.OnDishReady -= ch.takeOffStove;
            onDishReady1.startCooking("corn marak", 50);
            
        }
    }
}
