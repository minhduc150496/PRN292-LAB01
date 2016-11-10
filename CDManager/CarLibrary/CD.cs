using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDLibrary
{
    public class CD
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
        public static int x;

        #region Override Methods
        public override string ToString()
        {
            string s = "";
            s += "ID\t\t: " + ID + "\n";
            s += "Album\t\t: " + Album + "\n";
            s += "Singer\t\t: " + Singer + "\n";
            s += "Duration\t: " + Duration + "\n";
            s += "Songs\t\t: " + string.Join(", ", Songs) + "\n";
            s += "Genre\t\t: " + Genre + "\n";
            return s;
        }
        #endregion

        #region Normal Methods
        public void update()
        {
            inputAlbum();
            inputSinger();
            inputDuration();
            inputSong();
            inputGenre();
        }
        public void input(List<CD> data)
        {
            inputID(data);
            inputAlbum();
            inputSinger();
            inputDuration();
            inputSong();
            inputGenre();
        }
        public void inputID(List<CD> data)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter ID: ");
                    this.ID = int.Parse(Console.ReadLine());
                    if (data.FirstOrDefault(a => a.ID == this.ID) != null)
                    {
                        Console.WriteLine("Duplicated ID.");
                        continue;
                    }
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
                    if (this.Duration <= 0)
                    {
                        Console.WriteLine("Invalid");
                        continue;
                    }
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
                        Console.WriteLine("Enter the song No.{0}", i + 1);
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
                    Console.Write("Enter Genre (");
                    var genres = Enum.GetValues(typeof(CDGenre)).Cast<CDGenre>(); // Cast la gi vay???
                    Console.Write(string.Join(", ", genres));
                    Console.Write("): ");
                    var sGenre = Console.ReadLine();
                    try
                    {
                        int.Parse(sGenre);
                        Console.WriteLine("Invalid");
                        continue;
                    }
                    catch (Exception) {}
                    if (Enum.TryParse<CDGenre>(sGenre, out this.Genre))
                    {
                        break;
                    }
                    else
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