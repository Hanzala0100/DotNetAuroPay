using System;

class Demo {
	public static void Main(string [] args){
		Console.WriteLine("Hello user provide a number");
		int number = Convert.ToInt32(Console.ReadLine());

		for(int i =0;i<=number;i++){
			Console.WriteLine(i);
		}
		
		int n = 0;
		while(n != number+1){
			Console.WriteLine(n);
			n++;
		}
		n = 0;
		do{
			Console.WriteLine(n);
			n++;
		} while(n != number+1);

	}
}