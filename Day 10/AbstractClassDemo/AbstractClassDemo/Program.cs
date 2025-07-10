namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            // throws an error

            Pig pig = new Pig();
            pig.animalSound();
            pig.Sleep();
        }
    }
}
