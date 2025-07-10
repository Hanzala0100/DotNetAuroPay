namespace ArrayLearning
{
    internal class Program
    {

        static void MagicSquare(int[,] arr)
        {
            //to check
            //sum of each row should be equal 
            //sum of each column should be equal
            //sum of each diagonal should be equal
            int checksum = 0;
            int col1Sum = 0, col2Sum = 0, col3Sum = 0, diag1Sum = 0, diag2Sum = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    checksum += arr[i, j];
                }

            }

            Console.WriteLine(checksum);


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int rowSum = 0;

                col1Sum += arr[i, 0];
                col2Sum += arr[i, 1];
                col3Sum += arr[i, 2];

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //Console.WriteLine($"row {i}");
                    rowSum += arr[i, j];

                    //Console.WriteLine($"rowsum: {rowSum} ");

                    if (i == j)
                    {
                        diag1Sum += arr[i, j];
                    }

                    //Console.WriteLine($"diag1sum: {diag1Sum} ");

                }
                diag2Sum += arr[i, arr.GetLength(0) - 1 - i];
                //Console.WriteLine($"diag2sum: {diag2Sum}");

                //Console.WriteLine($"Row {i} sum: {rowSum}");

                if (rowSum != checksum)
                {
                    Console.WriteLine("It is not a Magic Matrix");
                    return;
                }
            }

            if (col1Sum != checksum || col2Sum != checksum || col3Sum != checksum || diag1Sum != checksum || diag2Sum != checksum)
            {
                Console.WriteLine("It is not a Magic Matrix");
                return;

            }

            Console.WriteLine("Magic Matrix");
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 2,7,6 }, { 9,5,1 }, { 4,3,8 } };



            for(int i = 0;i< arr.GetLength(0);i++)
            {
                for(int j = 0; j< arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+ " ");
                }
                Console.WriteLine("");
            }

            //2d array iteration can also be done using the foreach loop;
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = int.MinValue;
                int min = int.MaxValue;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] > max)
                        max = arr[i,j];

                    if(arr[i,j] < min)  
                        min = arr[i,j];
                }
                Console.Write("for row {0} min is {1} and max is {2}",i,min,max);
                Console.WriteLine("");
            }

            MagicSquare(arr);
        }
    }
}
