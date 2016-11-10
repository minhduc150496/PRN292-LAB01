using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Menu
    {
        public List<string> Choices = new List<string>();
        public Menu()
        {
        }
        public void Add(string item)
        {
            Choices.Add(item);
        }
        public int GetUserChoice()
        {
            Console.WriteLine("CD MANAGER v1.0 - by DucBM");
            for (int i = 0; i < Choices.Count(); i++)
            {
                Console.WriteLine("\t" + (i+1) + "- " + Choices.ElementAt(i));
            }
            Console.WriteLine("\tOthers- Quit.");
            Console.Write("Enter your choice: ");
            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                choice = 0;
            }
            return choice;
        }
    }
}
