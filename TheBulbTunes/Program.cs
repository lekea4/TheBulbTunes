using System;
using System.Collections.Generic;
using TheBulbTunes.EFDataService.Entities;
using TheBulbTunes.EFDataService.EntityServices;

namespace TheBulbTunes
{
    class Program
    {
        static void Main(string[] args)
        {





            #region Consuming the User Service 

            UserService userService = new UserService();


            #region Consuming the Delete method 

            Guid UserToDelete1 = new Guid("56624948-0ed9-4681-dffc-08d96306324f");
            Guid UserToDelete2 = new Guid("bd5bc9cc-9632-4fb3-dffd-08d96306324f");
            Guid UserToDelete3 = new Guid("76ffa97d-da37-42ca-dffe-08d96306324f");
            Guid UserToDelete4 = new Guid("e9f3f60f-9ef8-44e9-dfff-08d96306324f");
            Guid UserToDelete5 = new Guid("f5550c15-1913-4083-e000-08d96306324f");
            Guid UserToDelete6 = new Guid("cbfdc792-9729-44bb-3d85-08d963063ef5");
            Guid UserToDelete7 = new Guid("7f8adee0-6e9a-4143-3d86-08d963063ef5");
            Guid UserToDelete8 = new Guid("d2c1f050-65cc-44d0-3d88-08d963063ef5");
            Guid UserToDelete9 = new Guid("dd2b4b3f-6a56-476b-3d87-08d963063ef5");
            Guid UserToDelete0 = new Guid("b348348d-fc13-438f-3d89-08d963063ef5");



            userService.Delete(UserToDelete0);
            userService.Delete(UserToDelete1);
            userService.Delete(UserToDelete2);
            userService.Delete(UserToDelete3);
            userService.Delete(UserToDelete4);
            userService.Delete(UserToDelete5);
            userService.Delete(UserToDelete6);
            userService.Delete(UserToDelete7);
            userService.Delete(UserToDelete8);
            userService.Delete(UserToDelete9);

            List<User> availableUsers = userService.FetchAll();

            Console.WriteLine("First Name \t\tLast Name \t\tEmail");

            foreach (User user in availableUsers)
            {
                Console.WriteLine("\n\n");
                Console.Write($"{user.FirstName}\t{user.LastName}\t{user.EmailAddress}");
            }


            #endregion


            #region Consuming the Create Method
            //userService.Create("Temiloluwa", "Tegbe", "temiloluwau.tegbe@thebulb.africa");
            //userService.Create("Adeleke", "Ayinde", "adeleke.ayinde@thebulb.africa");
            //userService.Create("Ndudim","Hope", "hope.ndudim@thebulb.africa");
            //userService.Create("Bayowa", "Odometa", "bayowa.odometa@thebulb.africa");
            //userService.Create("Nkechi", "Okeke", "nkechi.okeke@gmail.com");
            /*
                        List<User> availableUsers = userService.FetchAll();

                        Console.WriteLine("First Name \t\tLast Name \t\tEmail");

                        foreach (User user in availableUsers)
                        {
                            Console.WriteLine("\n\n");
                            Console.Write($"{user.FirstName}\t{user.LastName}\t{user.EmailAddress}");
                        } */

            #endregion

            #region Consuming the Fetch with Filter Method 

            //List<User> filteredUser1 = userService.FetchWithFilter("Tem","te","te");
            //List<User> filteredUser2 = userService.FetchWithFilter("odo","odo","odo");
            //List<User> filteredUser1 = userService.FetchWithFilter("", "", "");
            //st<User> filteredUser1 = userService.FetchWithFilter("", "", "");

            /*
            List<User> availableUsers = userService.FetchAll();

            Console.WriteLine("First Name \t\tLast Name \t\tEmail");

            foreach (User user in availableUsers)
            {
                Console.WriteLine("\n\n");
                Console.Write($"{user.FirstName}\t{user.LastName}\t{user.EmailAddress}");
            }
            */
            #endregion








            #endregion








            #region Consuming the Song Services 
            SongService songService = new SongService();

            

            #region  Using the Update and Delete Method 


            //Fetch all songs before Update  
/*
            List<Song> availableSongs = songService.FetchAll();

            Console.WriteLine("\n\n CURRENTLY AVAILABLE SONGS: \n");
            Console.Write("Title \t\tArtist\t\tAlbum");

            foreach (Song song in availableSongs)
            {
                Console.WriteLine();
                Console.Write($"{song.Title}\t\t{song.Artist}\t\t{song.Album}");
            }

            //Set the ID of song to be updated 
            Guid idOfSongToUpdate1 = new Guid("c31daf82-a39d-43dc-e206-08d9623b4f6d");
            Guid idOfSongToUpdate2 = new Guid("143c13a6-eb54-4cbb-e209-08d9623b4f6d");

            Song songToUpdate = new Song()
            {
                Genre = "Afro-Pop"
            };

            Song songToUpdate2 = new Song()
            {
                Genre = "Rap/Hip-Hop",
                ReleasedDate = new DateTime(2013, 3, 31)

            };


            //Invoking the Update method 
            songService.Update(idOfSongToUpdate1, songToUpdate);
            songService.Update(idOfSongToUpdate2, songToUpdate2);

            //Fetch all songs after  Update  

            availableSongs = songService.FetchAll();

            Console.WriteLine("\n\n CURRENTLY AVAILABLE SONGS: \n");
            Console.Write("Title \t\tArtist\t\tAlbum");

            foreach (Song song in availableSongs)
            {
                Console.WriteLine();
                Console.Write($"{song.Title}\t\t{song.Artist}\t\t{song.Album}");
            }


            */

            //Using the Delete method


            //Set ID of song to delete 
            /*
            Guid songToDelete1 = new Guid("0d414e2a-77e4-4caf-aae2-08d962485061");
            Guid songToDelete2 = new Guid("b0ae362f-bced-4797-aae3-08d962485061");
            Guid songToDelete3 = new Guid("60288c52-5981-4100-aae4-08d962485061");
            Guid songToDelete4 = new Guid("63b4de79-239d-4687-aae5-08d962485061");
            Guid songToDelete5 = new Guid("7125438c-456c-46d1-aae6-08d962485061");

            */
            // Guid songToDelete6 = new Guid("");


            //songService.Delete(songToDelete1);
            //songService.Delete(songToDelete2);
            //songService.Delete(songToDelete3);
            //songService.Delete(songToDelete4);
            //songService.Delete(songToDelete5);



            #endregion

            #region Using the Fetch with Filter Method 

            //List<Song> filteredSong1 = songService.FetchWithFilter("over", null, null, null);
            //List<Song> filteredSong2 = songService.FetchWithFilter("Ess", "kid", "r", "lagos");

            //Console.WriteLine("\n\nFILTERED SONGS FOR JANE\n");
            //Console.Write("Title\t\tArtist\t\tAlbum");
            //foreach (Song song in filteredSong1)
            //{
            //    Console.WriteLine();
            //    Console.Write($"{song.Title}\t{song.Artist}\t{song.Album}");
            //}

            //Console.WriteLine("\n\nFILTERED SONGS FOR HOPE\n");
            //Console.Write("Title\t\tArtist\t\tAlbum");
            //foreach (Song song in filteredSong2)
            //{
            //    Console.WriteLine();
            //    Console.Write($"{song.Title}\t{song.Artist}\t{song.Album}");
            //}
            //Console.WriteLine("\n\n\n");

            #endregion

            #region Create a number of songs with the Create Method and fetching the list with the fetch all method 

            //songService.Create("All Over", "Tiwa Savage","Sugarcane","","Afro-pop, Romantic",new DateTime(2017, 5, 22));
            //songService.Create("Nobody's Business","Rihanna","Unapologetic","Chris Brown","R&B",new DateTime(2012,1,1));
            //songService.Create("Get Down On It","Kool & The Gang","Something Special","", "Funk",new DateTime(1981,11,1));
            //songService.Create("The Monster","Eminem","Marshal Mathers","Rihanna","Rap/R&B",new DateTime(2013,1,1));
            //songService.Create("Essence","Wizkid","Made In Lagos","Tems","R&B",new DateTime(2020,10,30));
            ////songService.Create("", "", "", "", "", new DateTime());

            ////Fetch all Songs
            //List<Song> availableSongs = songService.FetchAll();
            //Console.WriteLine("Title \t\tArtist\t\tAlbum");

            //foreach (Song song in availableSongs)
            //{
            //    Console.WriteLine();
            //    Console.Write($"{song.Title}\t\t{song.Artist}\t\t{song.Album}");
            //}

            #endregion

            #endregion
        }
    }
}
