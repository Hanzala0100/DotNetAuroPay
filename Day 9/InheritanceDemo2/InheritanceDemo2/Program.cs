namespace InheritanceDemo2
{
    internal class Program
    {

        static void printArray(Animal[] animals)
        {
            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
                animal.EatsFood();
            }
        }
        static void DisplayMenu()
        {
            int count = 0;
            Animal[] animals = new Animal[4];

            while(count < 4)
            {
                Console.WriteLine("What do u want?");
                Console.Write("1. Dog 2. cat: ");
                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("Enter Color: ");
                                string color = Console.ReadLine();
                                Console.Write("Enter Breed: ");
                                string breed = Console.ReadLine();
                                Dog dog = new Dog(color, breed);
                                animals[count++] = dog;
                            }
                            break;
                        case 2:
                            {
                                Console.Write("Enter Color: ");
                                string color = Console.ReadLine();
                                Console.Write("Enter Breed: ");
                                string breed = Console.ReadLine();
                                Cat cat = new Cat(color, breed);
                                animals[count++] = cat;
                            }
                            break;
                        default: Console.WriteLine("invalid input!");
                            break;
                    }


                }
            }

            printArray(animals);
        }
        static void Main(string[] args)
        {
            Animal animal = new Animal("xyz", "abc");
            animal.EatsFood();

            Dog dog = new Dog("Black", "Labrodor");
            dog.EatsFood();
            Console.WriteLine(dog.ToString());
            

            Cat cat = new Cat("white", "Persian");
            cat.EatsFood();

            Animal animal1 = new Dog("white", "BullDog");
            animal1.EatsFood();
            Console.WriteLine(animal1.ToString());

            Animal animal2 = new Cat("white", "bhoka");
            animal2.EatsFood();
            Console.WriteLine(animal2.ToString());

            DisplayMenu();



        }
    }
}
