using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class ContactManager
    {
        List<Contact> contacts = new List<Contact>();

        public Contact AddDetails(string firstName, string lastName)
        {
            Contact contact = new Contact(firstName,lastName);
            contacts.Add(contact);
            return contact;
        }

        public void UpdateContactDetail(int ID, string firstName, string lastName)
        {
            Contact contact = contacts.FirstOrDefault(o => Contact.ContactID == ID); //LINQ query
            if (contact == null)
                throw new ContactDetailDoesNotExistsException("Contact detail does not exist");
            else

            {
                contact.FirstName = firstName;
                contact.LastName = lastName;
            }
            //foreach (var contactDetail in contactDetails)
            //{
            //    if (contactDetail.ContactTypeID == ID)
            //    {
            //        contactDetail.ContactType = contactType;
            //    }
            //}
        }

        public void DeleteContactDetail(int contactDetailID)
        {
            foreach (var contact in contacts)
            {
                if (Contact.ContactID == contactDetailID) { contact.IsActive = false; }
            }
        }

        public List<Contact> ViewContact()
        {
            List<Contact> contacts = new List<Contact>();
            foreach (var contact in contacts)
            {
                if (contact.IsActive)
                {
                    //Console.WriteLine(user.Fname);
                    //Console.WriteLine(user.Lname);
                    contacts.Add(contact);
                }
            }
            return contacts;
        }
    }
}

