using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toyArray = { "action figure", "Doll", "Rocket" };

            List<string> toyList = new List<string>() { "action figure", "stuffed animal", "Rocket" };

            toyList.Add("Barbie");
            toyList.Add("remote control car");
            toyList.Add("Yo-yo");

            foreach (string toy in toyList)
            {
                Console.WriteLine(toy);
            }

            Console.WriteLine(toyList[0]);

            //The properties and methods that we will use the most are 
            //.Count()
            //.Insert()
            //.Add()
            //.Remove()

            Console.WriteLine(toyList.Count);
            toyList.Remove("Barbie");
            Console.WriteLine(toyList.Count);
















            List<string> employeeNames = new List<string>();

        }
    }
}
