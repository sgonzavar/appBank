namespace consoleAppBank
{
    public class Program
    {
        //public Person[] objPersonArray = new Person[3];

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Create user");
            Console.WriteLine("2) Get cash");
            Console.WriteLine("3) Show all data");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CreateUser();
                    return true;
                case "2":
                    return true;
                case "3":
                    return false;
                default:
                    return false;
            }
        }

        private static void CreateUser()
        {   
            string userAge, userName;
            decimal userCash;
            int count = 0;

            Console.Write("what is your name: ");
            userName = Console.ReadLine();
            
            Console.Write("Tell me you age: ");
            userAge = Console.ReadLine();

            Console.Write("Add you cash: ");
            userCash = Convert.ToDecimal(Console.ReadLine());

            AddUser(userCash, userAge, userName);

        }

        public static void AddUser(decimal userCash, string? userAge, string? userName)
        {
            var listPerson = new Person(userName, userAge, userCash);
            //objPersonArray[listPerson];

            Console.Write("some change", listPerson.Age);
            Console.ReadKey();
        }
    }
}