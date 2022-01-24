using System;
using System.Collections.Generic;
namespace mis321_PA1_cwray2
{
    public class SongUtil
    {
        public static void PrintAllSongs(List<Song> allSongs)
        {
            foreach (var song in allSongs)
            {
                if(song.Deleted == false)
                {
                    Console.WriteLine(song.ToString());
                }
            }
        }

        public static List<Song> AddSong(List<Song> allSongs)
        {
            allSongs.Add(new Song(){
                ID=Guid.NewGuid(), 
                Title=Console.ReadLine(), 
                DateAdded=DateTime.Now,
                Deleted=false});
            return allSongs;
        }

        public static List<Song> DeleteSong(List<Song> allSongs)
        {
            Guid deleteThis = Guid.Parse(Console.ReadLine());
            foreach (var song in allSongs)
            {
                if (song.ID == deleteThis)
                {
                    song.Deleted = true;
                }
            }
            return allSongs;
        }
    }
}