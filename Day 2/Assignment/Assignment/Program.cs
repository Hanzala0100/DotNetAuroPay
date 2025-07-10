class Assignment
{

    static void SquareANumber(ref int num)
    {
        num *= num;
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b; 
        b = temp;
    }

    static void GetData(out int a, out string b)
    {
        a = 100;
        b = "Hanzala";

    static void ModifyData(in int id,out string name,out int age)
    {
        // id = 123; //this id can never be modified.
        name = "Ram";
        age = 18;
    }

    public static void Main(string[] args)
    {
        //exploring ref parameters
        // if we want to read or modify any variable we can use ref parameters.

        //lets take an example where we take a number from the user and it should be squared by default.
        int.TryParse(Console.ReadLine(),out int number );
        SquareANumber(ref number);

        Console.WriteLine(number);

        int prevNum = 10,currNum = 20;
        Swap(ref prevNum, ref currNum);
        Console.WriteLine(prevNum + " " + currNum);


        //exploring out Parameters 
        // when a method wants to return multiple variables we can use out parameters.
        // these parameters do not need to be initialized or can be initialized in the method call itself.

        GetData(out int rollno, out string name);

        Console.WriteLine("rollno: {0} name: {1}" , rollno, name);

        //exploring in Parameters
        // these parameters cant be modified. These are only Read-only parameters.
        // a good example of its use could be when i want to make a variable immutable in a function


        int age = 21;

        ModifyData(in rollno, out name, out age);

        Console.WriteLine("rollno: {0} name: {1} age: {2}", rollno, name , age);

        // implicit converison

        char val = 'a';
        Console.WriteLine(val);
        int num = val;
        Console.WriteLine(num);
        long num2 = num;
        Console.WriteLine(num2);
        float num3 = num2;
        Console.WriteLine(num3);
        double num4 = num3;
        Console.WriteLine(num4);

        //Explicit converison
        double num5 = 98.1;
        Console.WriteLine(num5);
        int num6 = (int)(num5);
        Console.WriteLine(num6);
        char val1 = Convert.ToChar(num6);
        Console.WriteLine(val1);


    }
}
