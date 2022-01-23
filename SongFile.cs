using System;
using System.IO;
using System.Collections.Generic;

namespace mis321_PA1_cwray2
{
    public class SongFile
    {
        public static List<Song> GetAllSongs()
        {
            List<Song> allSongs = new List<Song>();

            StreamReader inFile = null; //open

            try
            {
                inFile = new StreamReader("songs.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file was not found!", e);
                return allSongs;
            }

            string line = inFile.ReadLine(); //priming read
            while(line != null) //process
            {
                string[] temp = line.Split("#");
                allSongs.Add(new Song(){
                    ID=Guid.Parse(temp[0]), 
                    Title=temp[1], 
                    DateAdded=DateTime.Parse(temp[2]), 
                    Deleted=bool.Parse(temp[3])});
                line = inFile.ReadLine(); // update read
            }

            inFile.Close(); //close

            return allSongs;
        }

        public static void SaveSongs(List<Song> allSongs)
        {
            StreamWriter outFile = new StreamWriter("songs.txt"); //openish

            foreach (var song in allSongs) //process
            {
                if (song != null)
                {
                    outFile.WriteLine(song.ToFile());
                }
            }

            outFile.Close(); //close
        }
    }
}