using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SingletonClass
    {
        static SingletonClass _singletonInstance;
        protected SingletonClass() {
            Console.WriteLine("Constructor executed");
        }

        public static SingletonClass makeInstance() { 
            if(_singletonInstance==null)
                _singletonInstance = new SingletonClass();
            return _singletonInstance;
        }
       
    }
}
