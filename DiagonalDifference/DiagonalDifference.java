import java.util.Scanner;

class DiagonalDifference {
	public static void main(String[] args) {
		Scanner stdin = new Scanner(System.in);
		int sizeOfMatrix = Integer.parseInt(stdin.nextLine());
		int[][] matrix = new int[sizeOfMatrix][sizeOfMatrix];
		String[] tokens;
		int z =0;
		
		while (stdin.hasNextLine()) {	
			
		tokens = stdin.nextLine().split(" ");			
		
		
			for(int j = 0; j < sizeOfMatrix; j++)
			{
				matrix[z][j] = Integer.parseInt(tokens[j]);
				//System.out.println(matrix[i][j]);
			}
		z++;
		}
		
		
		int rtotal = 0;
		int ltotal = 0;
		int total = 0;
		
		int x = matrix.length;
		for (int i = 0; i < sizeOfMatrix; i++)
		{
			rtotal += matrix[i][i];
			ltotal += matrix[x-1][i];
			x--;
		}
		
		//System.out.println(ltotal);
		System.out.println(Math.abs(rtotal-ltotal));
	}
}