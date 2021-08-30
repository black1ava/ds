using System;

namespace Program {
	public class Program {
		public static void Main(string[] args){
			int[] arr1 = {1, 3, 2, 5, 4, 7, 6};

			foreach(int item in arr1){
				Console.Write("{0} ", item);
			}
			Console.WriteLine("");




			int n;
			int[] arr2;
			Console.Write("Size of array2: ");
			n = int.Parse(Console.ReadLine());

			arr2 = new int[n];
			Console.WriteLine("Size if array2: {0}", arr2.Length);




			int m;
			int[] arr3;
			Console.Write("Size of array3: ");
			m = int.Parse(Console.ReadLine());

			arr3 = new int[m];

			for(int i = 0; i < m; i++){
				Console.Write("Item {0}: ", i);
				arr3[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine(largest(arr3));
		}

		public static int bigger(int a, int b){
			return a > b ? a : b;
		}

		public static int largest(int[] arr){
			int biggest = 0;

			foreach(int item in arr){
				biggest = bigger(biggest, item); 
			}

			return biggest;
		}
	}
}