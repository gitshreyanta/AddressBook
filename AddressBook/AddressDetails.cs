using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressDetails
    {
        public char y;
        public char n;
        //Dictonary to add address book to dictionary    
        Dictionary<string, Address1> addressBookDict = new Dictionary<string, Address1>();
        public void AddNewAddressBook(string addressName, Address1 addressBook)
        {
            addressBookDict.Add(addressName, addressBook);
        }
        //Method to fetch single address book if it matches user input
        public Address1 GetAddressBook(string name)
        {
            foreach (var item in addressBookDict)
            {
                if (item.Key == name)
                    return item.Value;
            }
            return null;
        }

        internal void AddNewAddressBook(string? addressBookName, Address_Book contact)
        {
            throw new NotImplementedException();
        }
    }
}