using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDManager
{
    class CD
    {
        #region Fields
        public int ID;
        public string Album;
        public string Singer;
        public long Duration;
        public List<Song> Songs;
        public CDGenre Genre;
        #endregion

        public CD()
        {
            
        }

        #region Override Methods
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Normal Methods
        public void input()
        {
            inputID();
            inputAlbum();
            inputSinger();
            inputDuration();
            inputSong();
            inputGenre();
        }
        public void inputID()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter ID: ");
                    this.ID = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void inputAlbum()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Album: ");
                    this.Album = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void inputSinger()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Singer: ");
                    this.Singer = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void inputDuration()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Duration: ");
                    this.Duration = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void inputSong()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter number of songs: ");
                    int n = int.Parse(Console.ReadLine());
                    this.Songs = new List<Song>();
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Enter the song No.{0}", i+1);
                        Song song = new Song();
                        song.input();
                        this.Songs.Add(song);
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void inputGenre()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Genre: ");
                    if (Enum.TryParse<CDGenre>(Console.ReadLine(), out this.Genre))
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("Invalid.");
                    }
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

public enum CDGenre
{
    Rock, Rap, Country, Blue, Jazz, Dance
}