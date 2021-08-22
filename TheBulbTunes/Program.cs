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
            #region  consuming the Favorite services 

            FavouriteService favouriteService = new FavouriteService();

            #region Invoking the create favourite method
            //set id of the song to be favourited 

            Guid idOfFavouriteSong1 = new Guid("2782df5d-4652-444d-e208-08d9623b4f6d"); //get down on it 
            Guid idOfFavouriteSong2 = new Guid("2782df5d-4652-444d-e208-08d9623b4f6d"); // The Monster
            Guid idOfFavouriteSong3 = new Guid("60ce4d35-50aa-4e37-e20a-08d9623b4f6d"); //essence by wizkid

            //set id of user who wants to favorite a song 

            Guid idOfUser1 = new Guid("49125dda-c415-4435-8122-08d9628d7045");
            Guid idOfUser2 = new Guid("7a75639f-a950-4e1b-8125-08d9628d7045");
            Guid idOfUser3 = new Guid("5566ae35-7e39-4259-8124-08d9628d7045");

            //invoking the create method 

            favouriteService.Create(idOfFavouriteSong1, idOfUser1);
            favouriteService.Create(idOfFavouriteSong2, idOfUser2);
            favouriteService.Create(idOfFavouriteSong3, idOfUser3);

            //fetch the favourtie list 
            List<Favourite> availableFavourite = favouriteService.FetchAll();

            Console.WriteLine("\n\n Currently Available Favourite: \n");
            Console.Write("Title\t\t Artist\t\t\t Favourite By");

            foreach (Favourite favourite in availableFavourite)
            {
                Console.WriteLine();
                Console.Write($"{favourite.SelectedSong.Title}\t {favourite.SelectedSong.Artist}\t {favourite.AddedBy.FirstName}");

            }



            #endregion





            #endregion



            #region Consuming the User Service 

            UserService userService = new UserService();

            #region Consuming the Update Method 

            //fetch all user data before update 
            List<User> availableUser = userService.FetchAll();
            Console.WriteLine("First Name \t\tLast Name \t\tEmail");

            foreach (User user in availableUser)
            {
                Console.WriteLine("\n\n");
                Console.Write($"{user.FirstName}\t{user.LastName}\t{user.EmailAddress}");
            }

            //set the Id of user to update 

            Guid idUserToUpdate = new Guid("42810d2d-1edc-4b7a-8123-08d9628d7045");

            //set the information to be updated

            User userToUpdate = new User()
            {
                EmailAddress = "lekea4@gmail.com"
            };

            //invoking the update method 
            userService.Update(idUserToUpdate, userToUpdate);


            //fetch all users after update 

            availableUser = userService.FetchAll();

            Console.WriteLine("\n\n CURRENTLY AVAILABLE USERS: \n");
            foreach (User user in availableUser)
            {
                Console.WriteLine("\n\n");
                Console.Write($"{user.FirstName}\t{user.LastName}\t{user.EmailAddress}");
            }



            #endregion


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
            

            /*
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

            */
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








        }
    }
}
