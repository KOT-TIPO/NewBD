﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yagnov.Model;

namespace Yagnov.Services
{
    public class AuthService 
    {
        private List<User> _users;

        public AuthService()
        {
            _users = new List<User>
            {
                new User("Login","Pass"),
                new User("kto", "vov"),
                new User("KKT", "best")
            };

        }

        public bool CheckData(string login, string pass)
        {
            var user = _users.FirstOrDefault(u => u.Login == login && u.Pass == pass);

            if (user != null && user.Pass == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
