namespace ClubInterface
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Location { get; set; }

        public string Role { get; set; }

        public string Duties { get; set; }

        //Methods
        public string Fullname();
        public string Memberinfo();
    }
    class Program
    {
        class MyClub : IClub
        {

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Location { get; set; }
            public string Role { get; set; }
            public string Duties { get; set;}

            public MyClub() 
            { 
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Location = string.Empty;
                Role = string.Empty;
                Duties = string.Empty;
            }



            public MyClub(int id, string firstName, string lastName, string location, string role, string duties)
            {
               Id = id;
               FirstName = firstName;
               LastName = lastName;
               Location = location;
               Role = role;
               Duties = duties;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public string Memberinfo()
            {
                return Role + " at " + Location + " Chapter and responsible for " + Duties;
            }
        }
        static void Main(string[] args)
        {
            //MyClub object created using parameterized constructor
            MyClub fred = new MyClub(10,"Fred", "Flinstone", "Florida", "Vice President", "Golf Tournament Fundraiser");
            

            Console.WriteLine(fred.Fullname());
            Console.WriteLine(fred.Memberinfo());

            //MyClub object created using the default constructor
            //values are assigned using properties
            MyClub wilma = new MyClub();
            wilma.Id = 20;
            wilma.FirstName = "Wilma";
            wilma.LastName = "Flinstone";
            wilma.Location = "Alabama";
            wilma.Role = "President";
            wilma.Duties = "Overseeing Fred's Fundraiser";
            
            Console.WriteLine( wilma.Fullname());
            Console.WriteLine( wilma.Memberinfo());

        }
    }
}