using System.Collections.Generic;
using System;

namespace mis321_PA1_cwray2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> allSongs = SongFile.GetAllSongs();
            Menu(allSongs);
        }

        static void Menu(List<Song> allSongs)
        {
            int menuChoice = GetMenuChoice();
            while(menuChoice != 4)
            {
                while(menuChoice != 1 && menuChoice != 2 && menuChoice != 3)
                {
                    Console.WriteLine("Invalid Selection");
                    menuChoice = GetMenuChoice();
                }

                if(menuChoice == 1)
                {
                    SortAndReverse(allSongs);
                    SongUtil.PrintAllSongs(allSongs);
                    HoldYourHorses();
                }
                else if(menuChoice == 2)
                {
                    SortAndReverse(allSongs);
                    SongUtil.PrintAllSongs(allSongs);
                    SongUtil.AddSong(allSongs);
                    SongFile.SaveSongs(allSongs);
                    HoldYourHorses();
                }
                else if(menuChoice == 3)
                {
                    SortAndReverse(allSongs);
                    SongUtil.PrintAllSongs(allSongs);
                    SongUtil.DeleteSong(allSongs);
                    SongFile.SaveSongs(allSongs);
                    HoldYourHorses();
                }
                menuChoice = GetMenuChoice();
            }
        }

        static void SortAndReverse(List<Song> allSongs)
        {
            allSongs.Sort();
            allSongs.Reverse();
        }

        static int GetMenuChoice()  //method to get the users choice for the menu
        {
            //Console.Clear();
            Console.WriteLine("Welcome to  Big Al's Playlist! \n1)Show All Songs \n2)Add a Song \n3)Delete a Song \n4)Exit");
            return int.Parse(Console.ReadLine());
        }

        static void HoldYourHorses()  //method to prevent the program from immediately looping back to the menu
        {
            Console.WriteLine("Press any key to continue to the menu: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
