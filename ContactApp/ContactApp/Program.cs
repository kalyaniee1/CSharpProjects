using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userID;
            
            UserManager userManager = new UserManager();
            Console.WriteLine("Enter User ID:");
            userID = Console.ReadLine();
            

                if (userManager.CheckIsAdmin(userID))
                    showAdminMenu(userManager);
                else
                    showUserMenu();
            
        }
        public static void printUsers(List<User> users)
        {
            foreach (User user in users)
            {

                Console.WriteLine(user.UserID); 
                Console.WriteLine(user.Fname);
                Console.WriteLine(user.Lname);
            }
        }

        public static void showAdminMenu(UserManager userManager) {
            //string fname, lname;
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("Choose your operation:");
                Console.WriteLine("1. Add Admin");
                Console.WriteLine("2. Add user");
                Console.WriteLine("3. Update user");
                Console.WriteLine("4. Delete User");
                //Console.WriteLine("5. View all admins:");
                Console.WriteLine("5. View all users:");
                Console.WriteLine("6. Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter admin first name:");
                        string fname = Console.ReadLine();
                        Console.WriteLine("Enter admin last name:");
                        string lname = Console.ReadLine();
                        User newAdmin= userManager.AddAdmin(fname, lname);
                        if (newAdmin != null)
                        {
                            Console.WriteLine("User entred successfully with user ID: "+newAdmin.UserID);                        
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter user first name:");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter user last name:");
                        lname = Console.ReadLine();
                        User newUser=userManager.AddUser(fname, lname);
                        if (newUser != null)
                        {
                            Console.WriteLine("User entred successfully with user ID: " + newUser.UserID);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter user ID:");
                        string userID = Console.ReadLine();
                        Console.WriteLine("Enter user first name:");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter user last name:");
                        lname = Console.ReadLine();
                        Console.WriteLine("Is he an admin? True/False");
                        bool isAdmin = Convert.ToBoolean(Console.ReadLine());
                        userManager.updateUser(userID, fname, lname, isAdmin);
                        break;
                    case 4:
                        Console.WriteLine("Enter user ID to be deleted:");
                        userID = Console.ReadLine();
                        userManager.deleteUser(userID);
                        break;
                    case 5:
                        printUsers(userManager.viewUsers());
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter valid input");
                        break;
                }
            }

        }

       

        public static void showUserMenu() { }
    }
}
