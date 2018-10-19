using APIJwt.Model;
using LiteDB;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIJwt.DAO
{
    public class UsersDAO
    {
        private IConfiguration _configuration;

        public UsersDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User Find(string userID)
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var users = db.GetCollection<User>("Users");
                var resultsUsers = users.FindById(userID);
                return resultsUsers;
            }
        }
    }
}
