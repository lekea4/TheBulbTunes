﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBulbTunes.EFDataService.Entities;

namespace TheBulbTunes.EFDataService.EntityServices
{
    public class UserService
    {
        private readonly TheBulbTunesDBContext _contex = new TheBulbTunesDBContext();

        private List<User> _users;

   

        //Create a User 

        public void Create(string firstName, string lastName, string emailAddress)
        {
            User newUser = new User
            {
                UserID = new Guid(),
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };
            _contex.Users.Add(newUser);
            _contex.SaveChanges(); 
        }

        public List<User> FetchAll()
        {
            return _contex.Users.ToList();
        }

        public List<User> FetchWithFilter(string firstNameFilter = null, string lastNameFilter = null, string emailAddressFilter = null)
        {
           
            _users   = FetchAll();

            if (firstNameFilter != null)
                _users = SearchByFirstName(firstNameFilter, _users);

            if (lastNameFilter != null)
                _users = SearchByLastName(lastNameFilter, _users);

            if (emailAddressFilter != null)
                _users = SearchByEmail(emailAddressFilter, _users);

            return _users;
        }

        // Private Helper Methods 
        private List<User> SearchByFirstName(string searchValue, List<User> users)
        {
            return users.Where(u => u.FirstName.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private List <User> SearchByLastName(string searchValue, List<User> users)
        {
            return users.Where(u => u.LastName.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private List<User> SearchByEmail(string searchValue, List<User> users)
        {
            return users.Where(u => u.EmailAddress.Contains(searchValue, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //Update User
        public void Update (Guid id, User userUpdateInfo)
        {
            //check if the user exists
            User userToUpdate = FetchAll()
                 .Where(u => u.UserID == id)
                 .FirstOrDefault();

            if (userToUpdate == null)
            {
                Console.WriteLine("Invalid Operation! No match was found for the id supplied");
                return;
            }

            //if a user is found, perform the requested update 

            if (userUpdateInfo.FirstName != null) userToUpdate.FirstName = userUpdateInfo.FirstName;
            if (userUpdateInfo.LastName != null) userToUpdate.LastName = userUpdateInfo.LastName;
            if (userUpdateInfo.EmailAddress != null) userToUpdate.EmailAddress = userUpdateInfo.EmailAddress;

            _contex.SaveChanges();
        }




        // Delete User
        public void Delete (Guid id)
        {
            User userToDelete = FetchAll()
                .Where(u => u.UserID == id)
                .FirstOrDefault();

            if (userToDelete == null)
            {
                Console.WriteLine("Invalid operation! No match was found for the id you supplied");
                return;
            }
            _contex.Users.Remove(userToDelete);
            _contex.SaveChanges();
        }

    }
}
