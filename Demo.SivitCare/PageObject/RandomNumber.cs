using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SivitCare.PageObject
{
    public static class RandomNumber
    {
        private static Random rnd = new Random();
        public static int GetRandom()
        {
            return rnd.Next(1, 100);
        }
    }
}
