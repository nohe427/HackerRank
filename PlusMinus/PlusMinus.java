import java.util.Scanner;

class PlusMinus {
	public static void main(String[] args) {
		Scanner stdin = new Scanner(System.in);
		int sizeOfArray = Integer.parseInt(stdin.nextLine());
		int[] values = new int[sizeOfArray];
		int numberOfNegatives = 0;
		int numberOfPositive = 0;
		int numberOfZeros = 0;
		String arrayValues = stdin.nextLine();
		String[] tokens = arrayValues.split(" ");
		for(int i =0; i < tokens.length; i++)
		{
			if (Integer.parseInt(tokens[i]) < 0)
			{
				numberOfNegatives++;
			}
			else if (Integer.parseInt(tokens[i]) > 0) {
				numberOfPositive++;
			}
			else {
				numberOfZeros++;
			}
		}
		
		System.out.println(((double)numberOfPositive/(double)sizeOfArray));
		System.out.println(((double)numberOfNegatives/(double)sizeOfArray));
		System.out.println(((double)numberOfZeros/(double)sizeOfArray));
	}
}
