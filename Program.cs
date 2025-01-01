namespace Simple_Library_Management_System
{

    class Program
    {
        public static void Main(string[] args)
        {
            ProgramInterface();
            bool exit = false;

            List<LibraryItem> list = new List<LibraryItem>();
            list.Add(new Book("\"Harry Potter\" by J.K Rowling", 1990, "Fantasy", 309));
            list.Add(new Magazine("National Geographic", "NatGeo", 120, 2023));
            list.Add(new DVD("Inception", "Christopher Nolan", 148));

            while (!exit)
            {
                Print("\nEnter your choice: ", ConsoleColor.Blue);
                string input = Console.ReadLine().Trim();

                switch (input)
                {
                    case "1":
                        AddItem(list);
                        break;
                    case "2":
                        PrintList(list);
                        break;
                    case "3":
                        BorrowItem(list);
                        break;
                    case "4":
                        exit = true;
                        PrintLine("\nThank you!", ConsoleColor.DarkRed);
                        break;
                }
            }
        }

        public static void BorrowItem(List<LibraryItem> list)
        {
            if (list.Count == 0)
            {
                PrintLine("No items available to borrow.", ConsoleColor.Yellow);
                return;
            }

            PrintList(list);
            Print("\nPlease enter the item's ID: ", ConsoleColor.Blue);

            try
            {
                string input = Console.ReadLine().Trim();

                // Validate input is a number
                int id = int.Parse(input);

                // Check if ID is within list range
                if (id < 1 || id > list.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                LibraryItem selectedItem = list[id - 1];
                PrintLine($"\nSelected Item: {selectedItem}", ConsoleColor.Green);
                Print("Enter Ok to confirm your order: ", ConsoleColor.Blue);
                string confirm = Console.ReadLine().Trim();

                if(confirm.ToLower() != "ok")
                {
                    PrintLine("Operation cancelled", ConsoleColor.Red);
                    return;
                }

                list.RemoveAt(id-1);
                PrintLine("Item borrowed successfully!", ConsoleColor.Green);
            }
            catch (FormatException)
            {
                PrintLine("Invalid input. Please enter a numeric ID.", ConsoleColor.Red);
            }
            catch (ArgumentOutOfRangeException)
            {
                PrintLine($"Invalid ID. Please enter a number between 1 and {list.Count}.", ConsoleColor.Red);
            }
        }

        public static void AddItem(List<LibraryItem> list)
        {
            PrintLine("\nPress 1 to add a Book", ConsoleColor.Magenta);
            PrintLine("Press 2 to add a DVD", ConsoleColor.DarkCyan);
            PrintLine("Press 3 to add a Magazine", ConsoleColor.DarkGreen);
            PrintLine("Press 4 to Cancel\n", ConsoleColor.Red);

            string input = Console.ReadLine().Trim();

            try
            {
                switch (input)
                {
                    case "1":
                        AddBook(list);
                        break;
                    case "2":
                        AddDVD(list);
                        break;
                    case "3":
                        AddMagazine(list);
                        break;
                    case "4":
                        return;
                    default:
                        PrintLine("Invalid choice. Please try again.", ConsoleColor.Red);
                        break;
                }
            }
            catch (Exception ex)
            {
                PrintLine($"Error: {ex.Message}", ConsoleColor.Red);
            }
        }

        private static void AddBook(List<LibraryItem> list)
        {
            try
            {
                Print("Enter book name: ", ConsoleColor.Blue);
                string name = Console.ReadLine();

                Print("Enter book Year of Publication: ", ConsoleColor.Blue);
                int yearOfPublication = int.Parse(Console.ReadLine());

                Print("Enter book genre: ", ConsoleColor.Blue);
                string genre = Console.ReadLine();

                Print("Enter book number of pages: ", ConsoleColor.Blue);
                int numberOfPages = int.Parse(Console.ReadLine());

                list.Add(new Book(name, yearOfPublication, genre, numberOfPages));
                PrintLine("Book added successfully!", ConsoleColor.Green);
            }
            catch (FormatException)
            {
                PrintLine("Invalid input. Please enter valid numbers.", ConsoleColor.Red);
            }
        }

        private static void AddDVD(List<LibraryItem> list)
        {
            try
            {
                Print("Enter DVD name: ", ConsoleColor.Blue);
                string name = Console.ReadLine();

                Print("Enter DVD director: ", ConsoleColor.Blue);
                string director = Console.ReadLine();

                Print("Enter DVD duration (minutes): ", ConsoleColor.Blue);
                int duration = int.Parse(Console.ReadLine());

                list.Add(new DVD(name, director, duration));
                PrintLine("DVD added successfully!", ConsoleColor.Green);
            }
            catch (FormatException)
            {
                PrintLine("Invalid input. Please enter valid numbers.", ConsoleColor.Red);
            }
        }

        private static void AddMagazine(List<LibraryItem> list)
        {
            try
            {
                Print("Enter magazine name: ", ConsoleColor.Blue);
                string name = Console.ReadLine();

                Print("Enter magazine publisher: ", ConsoleColor.Blue);
                string publisher = Console.ReadLine();

                Print("Enter issue number: ", ConsoleColor.Blue);
                int issueNumber = int.Parse(Console.ReadLine());

                Print("Enter issue year: ", ConsoleColor.Blue);
                int issueYear = int.Parse(Console.ReadLine());

                list.Add(new Magazine(name, publisher, issueNumber, issueYear));
                PrintLine("Magazine added successfully!", ConsoleColor.Green);
            }
            catch (FormatException)
            {
                PrintLine("Invalid input. Please enter valid numbers.", ConsoleColor.Red);
            }
        }

        public static void PrintList(List<LibraryItem> list)
        {
            PrintLine("\n--- Library Items ---\n", ConsoleColor.Green);
            for (int i = 0; i < list.Count; i++)
            {
                Print($"{i + 1}. ", ConsoleColor.Yellow);
                list[i].Print();
            }
        }

        public static void ProgramInterface()
        {
            PrintLine("Welcome to the Library Management System!\n", ConsoleColor.Cyan);

            PrintMenuOption("1", "Add Library Item");
            PrintMenuOption("2", "View all Items");
            PrintMenuOption("3", "Borrow an Item");
            PrintMenuOption("4", "Exit");
        }

        private static void PrintMenuOption(string number, string description)
        {
            Print(number, ConsoleColor.Yellow);
            PrintLine($". {description}", ConsoleColor.Cyan);
        }

        public static void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void PrintLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}