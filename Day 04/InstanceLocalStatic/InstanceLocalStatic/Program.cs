namespace InstanceLocalStatic
{
    internal class Program
    {
        // static variables and constructor are loaded 1st.
        // the values of these are initialized by the CLR for int its 0 and for string its null.
        int instanceVar;
        static int staticVar;
        int a = 10;
        static int b = 20;

        static Program()
        {
            b = 200;
        }

        public Program()
        {
            a = 30;
            b = 50;
        }
        static void Main(string[] args)
        {
            // the local variables needs to be initialzed.
            int localVar=10;

            Console.WriteLine(localVar);
            Console.WriteLine(Program.staticVar);//static variables should be accessed using the class name.

            Program pg = new Program();
            Console.WriteLine(pg.instanceVar);//an objet is needed to access instance variable.

            pg.a = 500;

            Console.WriteLine(pg.a);
            Console.WriteLine(Program.b);

            Program pg1 = new Program();

            Console.WriteLine(pg1.a);
            Console.WriteLine(b);


        }
    }
}
