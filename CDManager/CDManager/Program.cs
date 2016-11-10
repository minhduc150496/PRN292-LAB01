using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDLibrary;

// bet: milk tea + chicken rice

namespace Lab02_DucBM
{
    class Program
    {
        static void Main(string[] args)
        {
            CDManager cm = new CDManager();
            Menu menu = new Menu();
            menu.Add("Add new CD.");
            menu.Add("Update a CD by ID.");
            menu.Add("Delete a CD by ID.");
            menu.Add("Sort by Album.");
            menu.Add("Sort by Singer.");
            menu.Add("List all CD.");
            menu.Add("Search CD by Album.");
            menu.Add("Search CD by Singer.");
            menu.Add("Search CD by Song.");

            bool stop = false;
            do
            {
                int choice = menu.GetUserChoice();
                Console.WriteLine();
                stop = false;
                switch (choice)
                {
                    case 1:
                        cm.AddNew();
                        break;
                    case 2:
                        cm.Update();
                        break;
                    case 3:
                        cm.Delete();
                        break;
                    case 4:
                        cm.SortByAlbum();
                        break;
                    case 5:
                        cm.SortBySinger();
                        break;
                    case 6:
                        cm.ListAll();
                        break;
                    case 7:
                        cm.SearchByAlbum();
                        break;
                    case 8:
                        cm.SearchBySinger();
                        break;
                    case 9:
                        cm.SearchBySong();
                        break;
                    default:
                        stop = true;
                        break;
                }
                Console.WriteLine();
                if (!stop)
                {
                    Console.WriteLine("Press ANY KEY to continue.");
                    Console.ReadKey(true);
                }
            } while (!stop);
        }
    }
}
