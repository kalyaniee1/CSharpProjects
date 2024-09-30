using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class User
    {
        //public string _userID;
        //string _password;
        //string _fname, _lname;
        //bool _isAdmin=false;
        //bool _isActive = true;
        List<Contact> contacts = new List<Contact>();   

        //public string UserID { get; set; }
        public string UserID { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public User(string fname,string lname){
            UserID=Convert.ToString(Guid.NewGuid());
            //Console.WriteLine(_UserID);
            Fname = fname;
            Lname = lname;
            IsActive = true;
        }
        public User(string fname,string lname,bool isAdmin):this(fname,lname) {
            //_userID++;
            IsAdmin = isAdmin;         
            
        }
        public User(string ID,string fname, string lname)
        {
            UserID = ID;
            //Console.WriteLine(_UserID);
            Fname = fname;
            Lname = lname;
            IsActive = true;    
        }
        public User(string ID,string fname, string lname, bool isAdmin) : this(ID,fname, lname)
        {
            //_userID++;
            IsAdmin = isAdmin;
        }

    }
}
