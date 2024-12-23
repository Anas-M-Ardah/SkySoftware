namespace ObjectHW1
{
    internal class ConsoleColor
    {
        public ConsoleColor() { }

        public void SetConsoleColor(string color)
        {

            if (color.ToLower() == "green")
            {
                Console.ForegroundColor = System.ConsoleColor.Green;
            } else if (color.ToLower() == "red")
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
            } else if (color.ToLower() == "blue")
            {
                Console.ForegroundColor = System.ConsoleColor.Blue;
            } else
            {
                Console.WriteLine($"{color} is not available");
            }
        }

        public void ResetColor()
        {
            Console.ForegroundColor = System.ConsoleColor.White;
        }
    }
}
