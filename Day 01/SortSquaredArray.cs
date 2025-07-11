using System;

class SortSquaredArray{
	public static void Main(string [] args){
		// no need to use the extra array
		int [] arr = {-2,4,3,9,7};
		int [] arr1 = new int[arr.Length];
		for(int i=0;i<arr.Length;i++){
			
			arr1[i] = arr[i] *arr[i];
			
			Console.WriteLine(arr1[i]);
		}

		for(int i=0;i<arr1.Length;i++){
			for(int j=i+1;j<arr1.Length;j++){
				if(arr1[i] >= arr1[j]){
					int temp = arr1[i];
					arr1[i] = arr1[j];
					arr1[j] = temp;
				}
			}
		}

		Console.WriteLine("sorted array");
		for(int i=0;i<arr1.Length;i++){			
			Console.WriteLine(arr1[i]);
		}

		
	}
}