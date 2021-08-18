using System;
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

    }
}
