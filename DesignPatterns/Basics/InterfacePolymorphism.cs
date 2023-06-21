using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Basics
{
    public interface IPetFood
    {
        int Energy { get; }
    }
    public class Kibble : IPetFood
    {
        public int Energy => 7;
    }
    public class Fish : IPetFood
    {
        int IPetFood.Energy => 8;
    }

}
