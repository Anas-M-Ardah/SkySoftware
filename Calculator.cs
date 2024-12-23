namespace ObjectHW1
{
    internal class Calculator
    {
        private decimal x, y;

        public Calculator(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        public Calculator()
        {
            this.x = 0;
            this.y = 0;
        }

        public decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Subtract(decimal x, decimal y) { return x - y; }
        public decimal Multiply(decimal x, decimal y) { return x * y; }

        public decimal Divide(decimal x, decimal y) {

            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return -1;
            }

            return x / y; 
        }

        public void DoCalculations()
        {
            ConsoleColor color = new ConsoleColor();
            color.SetConsoleColor("blue");
            Console.WriteLine($"X+Y = {this.Add(this.x, this.y)}");
            Console.WriteLine($"X-Y = {this.Subtract(this.x, this.y)}");
            Console.WriteLine($"X*Y = {this.Multiply(this.x, this.y)}");
            Console.WriteLine($"X/Y = {this.Divide(this.x, this.y)}");
            color.ResetColor();
        }

        public void setX(decimal x)
        {
            this.x = x;
        }

        public void setY(decimal y)
        {
            this.y = y;
        }

        public decimal getX()
        {
            return this.x;
        }

        public decimal getY()
        {
            return this.y;
        }

        
    }
}
