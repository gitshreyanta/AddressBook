using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook1
    {
        public void AddressUC1()
        {

            Console.Write("Enter the First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter the Address : ");
            string address = Console.ReadLine();
            Console.Write("Enter the City : ");
            string city = Console.ReadLine();
            Console.Write("Enter the State : ");
            string state = Console.ReadLine();
            Console.Write("Enter the Zip : ");
            int pincode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the phoneNum : ");
            double phoneNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the email-id : ");
            string email = Console.ReadLine();

            Console.WriteLine(" FullName: {0} {1} \n Address: {2} {3} {4} {5}  \n PhoneNumber: {6} \n Email-Id: {7} ", firstName, lastName, address, city, state, pincode, phoneNumber, email);

            //Console.WriteLine(firstName + lastName + address + city + state + pincode + phoneNumber + email);
        }

    }
}
