using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bank_application
{
    internal class SerializerClass
    {
        
        public void Serializer(Account account) {
            FileStream fileStream = new FileStream("Accounts.dat",FileMode.Append,FileAccess.Write); 
            BinaryFormatter binaryforammatter = new BinaryFormatter();
            binaryforammatter.Serialize(fileStream, account);
            fileStream.Close();
            Console.WriteLine("Serialization completed!");
        }

        public Account[] DeSerializer()
        {
            //Account accounts;
                FileStream fileStream = new FileStream("Accounts.dat", FileMode.OpenOrCreate, FileAccess.Read);
                //if (fileStream.Length > 0)
                Account[] accounts = null;
                int i = 0;
           try{
                while (fileStream.Position < fileStream.Length)
                {
                    BinaryFormatter binaryforammatter = new BinaryFormatter();
                    accounts[i] = (Account)binaryforammatter.Deserialize(fileStream);
                    i++;
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception!!!!!!!"+ e);
            }
            return accounts;

            // else
            //{
            //    Console.WriteLine("Serialised file is empty");
            //    return null;
            //}

            //fileStream.Close();

            //return accounts;

            //Console.WriteLine("Serialization completed!");
        }
    }
}
