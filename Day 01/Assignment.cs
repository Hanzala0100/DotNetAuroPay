using System;

class Assignment{

	//powering
	static int power(int num,int pow){
		//powering upto length;
		int temp = 1;
		while(pow!=0){
			temp = temp * num;
			pow--;
		}

		return temp;
	}

	//factorial
	static int Factorial(int num){
		int fact = 1;
		while(num!=1){
			fact *= num;
			num--;
		}

		return fact;
	}


	//Perfect number
	static bool IsPerfectNumber(int num){
		int sum = 0;
		for(int i=1;i<=num/2;i++){
			if(num % i == 0){
				sum += i;
			}
		}

		if(sum == num){
			return true;
		}
		return false;
	}

	

	//Amstrong number
	static void IsArmstrongNumber(int num){
		//find out the lenght of the number;
		int count = 0;
		int temp = num;
		while(temp!=0){
			temp /= 10;
			count++;
		}
		Console.WriteLine("size of the number is: " + count);

		temp = num;
		int sum = 0;
		while(temp!=0){
			int rem = temp % 10;
			sum += power(rem,count);
			temp /= 10;
		}
		if(sum == num){
			Console.WriteLine("is an Armstrong Number");
		}
		else{
			Console.WriteLine("is not an Armstrong Number");
		}
	}

	//Strong number
	static void IsStrongNumber(int num){
		int temp = num;
		int sum = 0;
		while(temp!=0){
			int rem = temp%10;
			sum += Factorial(rem);
			temp /=10;
		}
		if(sum == num){
			Console.WriteLine("is an Strong Number");
		}
		else{
			Console.WriteLine("is not an Strong Number");
		}

	}

	//fibonaci series
	static void fibo(int num){
		int a = 0,b=1;
		Console.Write(a + " " + b + " ");
		int sum = 0;
		while(num-2!=0){
			sum  = a+b;
			Console.Write(sum + " ");
			a = b;
			b = sum;
			num--;
		}
	}

	//Prime number
	static void isPrimeNumber(int num){

		int count = 0;
		for(int i=1;i<num/2;i++){
			if(num%i == 0){
				count++;
			}
		}
		
		if(count == 1){
			Console.WriteLine("the number is prime");
		}
		else{
			Console.WriteLine("the number is not Prime");
		}
	}



	public static void Main(string [] args){
		int Pnum = 496;
		int Anum = 1634;
		int Snum = 145;
		int Primenum = 13;
		int [] arr = {5,4,3,2,1};

		//sorting using single loop
		for(int i=1;i<arr.Length;i++){
			if(arr[i] > arr[i-1]){
				int temp = arr[i];
				arr[i] = arr[i-1];
				arr[i-1] = temp;
				i=0;
			}
		}

		for(int i=0;i<arr.Length;i++){
			Console.Write(arr[i] + " ");
		}

		Console.WriteLine("");

		Console.WriteLine(IsPerfectNumber(Pnum));

		IsArmstrongNumber(Anum);

		IsStrongNumber(Snum);

		isPrimeNumber(Primenum);

		fibo(10);
		
	}
}