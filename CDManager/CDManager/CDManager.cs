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
        public CD GetByID(int ID)
        {
            return Data.FirstOrDefault(a => a.ID == ID);
        }
        #endregion

        #region Public Methods
        public void AddNew()
        {
            CD cd = new CD();
            cd.input();
            if (this.GetByID(cd.ID) != null)
            {
                Console.WriteLine("Duplicated ID."); // hoi ki ki
                return;
            }
            Data.Add(cd);
            Console.WriteLine("A new CD has been added.");
        }
        public void Update()
        {
            Console.Write("Enter ID: ");
            int ID = int.Parse(Console.ReadLine());
            CD cd = Data.FirstOrDefault(a => a.ID == ID);
            if (cd==null)
            {
                Console.WriteLine("The CD is not found");
                return;
            }
            cd.input();
            Console.WriteLine("The CD has been updated.");
        }
        public void Delete()
        {
            Console.Write("Enter ID: ");
            int ID = int.Parse(Console.ReadLine());
            CD cd = Data.First(a => a.ID == ID);
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
            this.Data = this.Data.OrderBy(a => a.Album).ToList<CD>();
        }
        public void SortBySinger()
        {
            this.Data = this.Data.OrderBy(a => a.Singer).ToList<CD>();
        }
        public void ListAll()
        {
            foreach (var cd in this.Data)
            {
                Console.WriteLine(cd.ToString());
            }
        }
        public List<CD> SearchByAlbum()
        {
            Console.Write("Enter Album: ");
            var searchValue = Console.ReadLine();
            var result =
                from a in this.Data
                where a.Album.Contains(searchValue)
                select a;
            return result.ToList<CD>();
        }
        public List<CD> SearchBySinger()
        {
            Console.Write("Enter Singer: ");
            var searchValue = Console.ReadLine();
            var result =
                from a in this.Data
                where a.Singer.Contains(searchValue)
                select a;
            return result.ToList<CD>();
        }
        public List<CD> SearchBySong()
        {
            Console.Write("Enter Singer: ");
            var searchValue = Console.ReadLine();
            var result =
                from a in this.Data
                where a.Songs.FirstOrDefault(b => b.Name.Contains(searchValue)) != null
                select a;
            return result.ToList<CD>();
        }
        #endregion
    }
}
