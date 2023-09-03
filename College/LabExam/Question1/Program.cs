namespace Question1
{
    class Program
    {
        class User
        {
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string Address { get; set; } = "";

            public User(string firstName, string lastName, string address)
            {
                FirstName = firstName;
                LastName = lastName;
                Address = address;
            }

            public static void ShowUser(User user)
            {
                Console.WriteLine("First Name: " + user.FirstName);
                Console.WriteLine("Last Name: " + user.LastName);
                Console.WriteLine("Address Name: " + user.Address);
            }
        }
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("For User " + i);
                Console.WriteLine("Enter FirstName: ");
                string fname = Console.ReadLine();
                Console.WriteLine("Enter LastName: ");
                string lname = Console.ReadLine();
                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();
                User user = new User(fname, lname, address);
                users.Add(user);
            }


            var userResult = from rUser in users
                             where rUser.Address == "pokhara"
                             orderby rUser.LastName descending
                             select rUser;

            foreach(User user in userResult)
            {
                User.ShowUser(user);
            }
                                    
        }
    }
}