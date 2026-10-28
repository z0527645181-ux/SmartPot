using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmartPot.Program;

namespace SmartPot
{
    internal class onDishReady
    {
        public event md OnDishReady;

        public void startCooking(string dish, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {

            }
            OnDishReady?.Invoke(dish, minutes);

        }
    }
}
