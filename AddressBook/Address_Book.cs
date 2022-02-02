namespace AddressBook
{
    internal class Address_Book
    {
        private string? firstname;
        private string? lastname;
        private string? state;
        private string? city;
        private string? address;
        private string? email;
        private int zipcode;
        private long mobilenumber;

        public Address_Book(string? firstname, string? lastname, string? state, string? city, string? address, string? email, int zipcode, long mobilenumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.state = state;
            this.city = city;
            this.address = address;
            this.email = email;
            this.zipcode = zipcode;
            this.mobilenumber = mobilenumber;
        }
    }
}