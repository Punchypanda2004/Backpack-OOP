using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Backpack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Backpack pack1 = new Backpack("blue", "small");
            Backpack pack2 = new Backpack("red", "medium");
            Backpack pack3 = new Backpack("green", "large");
            pack2.openBag();
            pack2.putin("lunch");
            pack2.putin("jacket");
            pack2.closeBag();
            pack2.openBag();
            pack2.takeout("jacket");
            pack2.closeBag();
        }
    }

    public class Backpack
    {
        private string colour;
        private string size;
        private bool open;
        List<string> items = new List<string>();
        public Backpack(string packColour, string packSize)
        {
            colour = packColour;
            size = packSize;
            open = false;
        }
  
        public void openBag()
        {
            open = true;
            Console.WriteLine("You have opened the backpack");
        }

        public void closeBag()
        {
            open = false;
            Console.WriteLine("You have closed the backpack");
            //REMOVE THIS!
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void putin(string item)
        {
            if (open == true)
            {
                items.Add(item);
                Console.WriteLine("You have added " + item + " to you backpack");
            }
            else
            {
                Console.WriteLine("ERR. Could not insert item into bag.");
            }   
        }

        public void takeout(string item)
        {
            if (open == true)
            {
                var index = 0;
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i] == item)
                    {
                        index = i;
                    }
                }
                items.RemoveAt(index);
                Console.WriteLine("You have remove " + item + " from your backpack");
            }
            else
            {
                Console.WriteLine("ERR. Could not remove item from bag.");
            }  
        }
    }
}
