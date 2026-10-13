namespace Library
{
    public class Member
    {
        // Private backing fields
        private int memberId;
        private string name;
        private string address;
        private int phone;

        // Public properties
        public int MemberId
        {
            get { return memberId; }
            private set
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater than zero.");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                // Ensure name is not blank and does not contain any numbers
                if (!string.IsNullOrWhiteSpace(value) && !value.Any(char.IsDigit))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers.");
                }
            }
        }

        public string Address
        {
            get { return address; }

            set
            {
                // Address may contain numbers (street numbers). Only ensure it's not blank.
                if (!string.IsNullOrWhiteSpace(value))
                {
                    address = value;
                }
                else
                {
                    Console.WriteLine("Error: Member address cannot be blank.");
                }
            }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Constructor using standard C# casing conventions
        public Member(int memberId, string memberName, string memberAddress, int memberPhone)
        {
            this.MemberId = memberId;
            this.Name = memberName;
            this.Address = memberAddress;
            this.Phone = memberPhone;
        }

        // Method to display information about a member
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone no: {Phone}");
            Console.WriteLine();
        }
    }
}
