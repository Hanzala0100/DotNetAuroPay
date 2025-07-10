namespace InterfacesDemo
{
    internal class Program
    {
        public static void AskUser()
        {
            Console.WriteLine("Do you want Rectangle or circle");
            string choice = Console.ReadLine();

            if(choice == "circle")
            {
                Circle circle = new Circle();
                circle.CalculateArea();
                circle.DisplaySides();
                circle.SetColor("Yellow");
            }
            else
            {
                Rectangle rectangle = new Rectangle();
                rectangle.CalculateArea();
                rectangle.DisplaySides();
                rectangle.SetColor("red");
            }
        }
        static void Main(string[] args)
        {
            AskUser();
        }
    }
}
