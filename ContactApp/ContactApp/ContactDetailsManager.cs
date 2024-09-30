using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactApp
{
    internal class ContactDetailsManager
    {
        List<ContactDetails> contactDetails = new List<ContactDetails>();

        public ContactDetails AddDetails(string contactType)
        {
            ContactDetails contactDetail = new ContactDetails(contactType);
            contactDetails.Add(contactDetail);
            return contactDetail;
        }

        public void UpdateContactDetail(int ID, string contactType)
        {
            ContactDetails contactDetail = contactDetails.FirstOrDefault(o => o.ContactTypeID == ID); //LINQ query
            if (contactDetail == null)
                throw new ContactDetailDoesNotExistsException("Contact detail does not exist");
            else
            
                contactDetail.ContactType = contactType;
                
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
            foreach (var contactDetail in contactDetails)
            {
                if (contactDetail.ContactTypeID == contactDetailID) { contactDetail.IsActive = false; }
            }
        }

        public List<ContactDetails> ViewContactDetails()
        {
            List<ContactDetails> contactDetails = new List<ContactDetails>();
            foreach (var contactDetail in contactDetails)
            {
                if (contactDetail.IsActive)
                {
                    //Console.WriteLine(user.Fname);
                    //Console.WriteLine(user.Lname);
                    contactDetails.Add(contactDetail);
                }
            }
            return contactDetails;
        }
    }
}
