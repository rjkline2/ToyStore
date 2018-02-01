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

            //foreach (string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            //Console.WriteLine(toyList[0]);

            //The properties and methods that we will use the most are 
            //.Count()
            //.Insert()
            //.Add()
            //.Remove()

            //Console.WriteLine(toyList.Count);
            //toyList.Remove("Barbie");
            //Console.WriteLine(toyList.Count);


            //Insert allows us to put a new element in the list
            //AND
            //Specifiy which index we want for that element

            toyList.Insert(0, "kite");
            toyList.Insert(2, "baby doll");
            toyList.Insert(1, "plastic dinosaur");

            //foreach (string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            // Another method that we will use i s the .Contains()
            //It returns a bool value

            if (toyList.Contains("plastic dinosaur"))
            {
                Console.WriteLine("Daniel would never buy the dino. ");
            }
            else
            {
                Console.WriteLine("Daniel might buy any of these toys.");
            }



            List<bool> shelfStatus = new List<bool>() { true, false, true, true, false };
            for (int i = 0; i < shelfStatus.Count; i++)
            {
                if (shelfStatus[i] == true)
                {
                    Console.WriteLine("There are toys on this shelf.");
                }
                else if (shelfStatus[i] == false)
                {
                    Console.WriteLine("You broke the code.");
                }

                //coudl use a for each loop

                //create a list, add five stuffed animals to your list
                // Print each stuffed animal in your list.


            }

            List<string> stuffedAnimals = new List<string>() { "Ragedy Andy", "Teddy", "Farmy", "Brownie Bear", "Velvateen Rabbit" };


            foreach (string stuffed in stuffedAnimals)
            {
                Console.WriteLine(stuffed);
            }




            List<string> employeeNames = new List<string>();

        }
    }
}
