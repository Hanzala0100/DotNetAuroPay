using System;

class Palindrome{
	public static void Main(string [] args){
		int number = 121;
		int rev = 0;
		int temp =  number;
		while(temp != 0){
			
			rev = (rev * 10) + (temp % 10);
			temp = temp/10;
			
			
		}

		if(rev == number){
			Console.WriteLine("the number is a Palindrome");
		}
		else{
			Console.WriteLine("the number is not a Palindrome");
		}
	}
}