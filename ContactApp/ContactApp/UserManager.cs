using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class UserManager
    {
        List<User> users = new List<User>();

        public UserManager() {
            
            users.Add(new User("101", "Samruddhi", "K", true));
            //Console.WriteLine(users.Count);
            users.Add(new User("102","Kalyani", "R"));
            //Console.WriteLine(users.Count);
        }


        public bool CheckIsAdmin(string userID) {
            foreach (var user in users) {
                if (user.UserID.Equals(userID)) {
                    return user.IsAdmin;
                }
            }
            throw new UserDoesNotExistsException("User does not exist!");
        }

        public User AddAdmin(string fname, string lname) {
            User newAdmin = new User(fname, lname, true);
            users.Add(newAdmin);
            return newAdmin;
        }

        public User AddUser(string fname, string lname)
        {
            User newUser= new User(fname, lname, false);
            users.Add(newUser);
            return newUser;

        }

        public void updateUser(string userID, string fanme, string lname, bool isAdmin) {
            User user=users.FirstOrDefault(o=>o.UserID==userID); //LINQ query
            if (user == null)
                throw new UserDoesNotExistsException("User does not exist");
            else
            {
                user.Fname = fanme;
                user.Lname = lname;
                user.IsAdmin = isAdmin;
            }
            //foreach (var user in users) {
            //    if (user.UserID == userID)
            //    {
            //        user.Fname = fanme;
            //        user.Lname = lname;
            //        user.IsAdmin = isAdmin;
            //    }                
            //}
            //throw new UserDoesNotExistsException("User does not exist");
        }

        public void deleteUser(string userID)
        {
            foreach (var user in users)
            {
                if (user.UserID == userID) { user.IsActive = false; }
            }
        }

        public List<User> ViewAdmins()
        {
            List<User> adminUsers = new List<User>();    
            foreach (var user in users)
            {
                if (user.IsActive)
                {
                    //Console.WriteLine(user.Fname);
                    //Console.WriteLine(user.Lname);
                    adminUsers.Add(user);
                }                
            }
            return adminUsers;
        }
        public List<User> viewUsers()
        {
            List<User> adminUsers = new List<User>();
            foreach (var user in users)
            {
                if (user.IsActive)
                {
                    adminUsers.Add(user);
                }
            }
            var usersList=users.Where(user=>user.IsActive).ToList();
            return adminUsers;
        }

    }
}

