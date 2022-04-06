using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    public class ToDo
    {
        public string Describe { get; set; }
        public double Time { get; set; }
        public override string ToString()
        {
            return $"{Describe,-50} {Time,-10}";
        }
    }
}
