using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDManager
{
    class CDManager
    {
        #region Fields
        List<CD> Data = new List<CD>();
        #endregion

        #region Override Methods
        #endregion

        #region Private Methods
        //public CD GetByID(int ID)
        //{
        //    return Data.FirstOrDefault(a => a.ID == ID);
        //}
        #endregion

        #region Public Methods
        public void AddNew()
        {
            CD cd = new CD();
            cd.input(this.Data);
            Data.Add(cd);
            Console.WriteLine("A new CD has been added.");
        }
        public void Update()
        {
            // Check if empty
            if (this.Data.Count() == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            // Input
            Console.Write("Enter ID: ");
            int ID = int.Parse(Console.ReadLine());
            // Get CD by ID
            CD cd = Data.FirstOrDefault(a => a.ID == ID);
            // Process
            if (cd == null)
            {
                Console.WriteLine("The CD is not found");
                return;
            }
            cd.update();
            Console.WriteLine("The CD has been updated.");
        }
        public void Delete()
        {
            // Check if empty
            if (this.Data.Count() == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            // Input
            Console.Write("Enter ID: ");
            int ID = int.Parse(Console.ReadLine());
            CD cd = Data.FirstOrDefault(a => a.ID == ID);
            if (cd == null)
            {
                Console.WriteLine("The CD is not found");
                return;
            }
            this.Data.Remove(cd);
            Console.WriteLine("The CD has been deleted.");
        }
        public void SortByAlbum()
        {
            // Check if empty
            if (this.Data.Count() == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            int asc = 1;
            while (true)
            {
                try
                {
                    // Input
                    Console.WriteLine("Do you want to sort by Album in: 1-Ascending order. 2- Descending order.");
                    asc = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid");
                }
            }

            this.Data = this.Data.OrderBy(a => a.Album).ToList<CD>();
            if (asc != 1)
            {
                this.Data.Reverse();
            }

            Console.WriteLine("The list has been sorted.");
        }
        public void SortBySinger()
        {
            // Check if empty
            if (this.Data.Count() == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            int asc = 1;
            while (true)
            {
                try
                {
                    // Input
                    Console.WriteLine("Do you want to sort by Singer in: 1-Ascending order. 2- Descending order.");
                    asc = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid");
                }
            }

            this.Data = this.Data.OrderBy(a => a.Singer).ToList<CD>();
            if (asc != 1)
            {
                this.Data.Reverse();
            }

            Console.WriteLine("The list has been sorted.");
        }
        public void ListAll()
        {
            // Check if empty
            if (this.Data.Count() == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            foreach (var cd in this.Data)
            {
                Console.WriteLine(cd.ToString());
            }
        }
        public void SearchByAlbum()
        {
            // Check if empty
            if (this.Data.Count() == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            // Input
            Console.Write("Enter Album: ");
            var searchValue = Console.ReadLine();
            var result =
                from a in this.Data
                where a.Album.Contains(searchValue)
                select a;
            if (result.Count() == 0)
            {
                Console.WriteLine("No results.");
            }
            else
            {
                Console.WriteLine("Search results:");
                foreach (var item in result.ToList())
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public void SearchBySinger()
        {
            // Check if empty
            if (this.Data.Count() == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            // Input
            Console.Write("Enter Singer: ");
            var searchValue = Console.ReadLine();
            var result =
                from a in this.Data
                where a.Singer.Contains(searchValue)
                select a;
            if (result.Count() == 0)
            {
                Console.WriteLine("No results.");
            }
            else
            {
                Console.WriteLine("Search results:");
                foreach (var item in result.ToList())
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public void SearchBySong()
        {
            // Check if empty
            if (this.Data.Count() == 0)
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            // Input
            Console.Write("Enter Singer: ");
            var searchValue = Console.ReadLine();
            var result =
                from a in this.Data
                where a.Songs.FirstOrDefault(b => b.Name.Contains(searchValue)) != null
                select a;
            if (result.Count() == 0)
            {
                Console.WriteLine("No results.");
            }
            else
            {
                Console.WriteLine("Search results:");
                foreach (var item in result.ToList())
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        #endregion
    }
}
