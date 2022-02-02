﻿// See https://aka.ms/new-console-template for more information
using AddressBook;
using System.Collections;

namespace AddressBook
{
    class Program
    {
        //Method to perform all operation on contacts
        public static void AddressBook(Address1 cont)
        {
            bool flag = true;
            int choice;
            //Menu to display for the user
            while (flag)
            {

                Console.WriteLine("\n1. Display All Contacts\n2. Add New Contact\n3. Edit Contact\n4. Delete Contact\n5. Exit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    cont.view();
                }
                else if (choice == 2)
                {
                    cont.AddDetails();
                }
                else if (choice == 3)
                {
                    cont.EditContact();
                }
                else if (choice == 4)
                {
                    cont.DeleteContact();
                }
                else if (choice == 5)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }


            }
        }
        public static void Main(string[] args)
        {
            AddressDetails addressDetails = new AddressDetails();

            bool flag = true;
            int choice;
            while (flag)
            {
                Console.WriteLine("\n1. create New Address Book \n2. Use Existing Address Book \n3. Exit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Address_Book contact = new Address1();
                    Console.WriteLine("\nEnter New Address Book Name: ");
                    string addressBookName = Console.ReadLine();
                    addressDetails.AddNewAddressBook(addressBookName, contact);
                    Console.WriteLine("created " + addressBookName + "\tusing Address Book " + addressBookName);
                    AddressBook(contact);

                }
                else if (choice == 2)
                {
                    Console.Write("\nEnter Address Book Name: ");
                    string addressBookName = Console.ReadLine();
                    Address_Book contact = addressDetails.GetAddressBook(addressBookName);
                    if (contact != null)
                    {
                        Console.WriteLine("using Address Book " + addressBookName);
                        AddressBook(contact);
                    }
                    else
                    {
                        Console.WriteLine("There is no book with name " + addressBookName);
                    }

                }
                else if (choice == 3)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        private static void AddressBook(Address_Book contact)
        {
            throw new NotImplementedException();
        }
    }
}

