using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
    public class Diamond : Treasure
    {
        public Diamond(string Description, int score) : base(Description, score) { }
        public override void Display()
        {
            Console.WriteLine("Diamond" + this.Description + " is displayed"); 
        }
    }
}
