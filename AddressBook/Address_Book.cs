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

        internal string? GetFirstName()
        {
            throw new NotImplementedException();
        }

        internal void SetFirstName(string? firstname)
        {
            throw new NotImplementedException();
        }

        internal void SetLastName(string? lastname)
        {
            throw new NotImplementedException();
        }

        internal void SetState(string? state)
        {
            throw new NotImplementedException();
        }

        internal void SetCity(string? city)
        {
            throw new NotImplementedException();
        }

        internal void SetAddress(string? address)
        {
            throw new NotImplementedException();
        }

        internal void SetZipCode(int zipcode)
        {
            throw new NotImplementedException();
        }

        internal void SetEmail(string? email)
        {
            throw new NotImplementedException();
        }

        internal void SetMobileNumber(long mobilenumber)
        {
            throw new NotImplementedException();
        }

        internal void SetZipcode(int zipcode)
        {
            throw new NotImplementedException();
        }

        internal void Setmobilenumber(long mobilenumber)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Address_Book(Address1 v)
        {
            throw new NotImplementedException();
        }
    }
}