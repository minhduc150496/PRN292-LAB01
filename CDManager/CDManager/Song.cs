using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDManager
{
    class Song
    {
        #region Fields
        public string Name;
        #endregion

        #region Override Methods
        public bool Equals(Song other)
        {
            return this.Name == other.Name;
        }
        #endregion

        #region Normal Methods
        public bool Contains(string s)
        {
            return this.Name.Contains(s);
        }
        public void input()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Name: ");
                    this.Name = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        #endregion
    }
}
