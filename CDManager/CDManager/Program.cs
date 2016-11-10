using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject;

// bet: milk tea + chicken rice

namespace Lab02_DucBM
{
    class Program
    {
        static void Main(string[] args)
        {
            FilesManager manager = new FilesManager();
            Menu menu = new Menu();
            menu.Add("Enter file content.");
            menu.Add("Read file content.");

            bool stop = false;
            do
            {
                int choice = menu.GetUserChoice();
                Console.WriteLine();
                stop = false;
                switch (choice)
                {
                    case 1:
                        manager.EnterFileContent();
                        break;
                    case 2:
                        manager.ReadFileContent();
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
