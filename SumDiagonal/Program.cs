namespace SumDiagonal
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 17, 9, 36, 21 }, { 8, 28, 3, 1 }, { 15, 7, 5, 30 }, { 10, 17, 4, 12 } };
            int sum = SumDiagonal(matrix);
            Console.WriteLine($"La suma es: {sum}");
        }

        public static int SumDiagonal(int[,] matrix)
        {
            int sumDiagonal = 0;
            int numRows = matrix.GetLength(0);
            for(int i = 0; i<numRows; i++)
            {
                sumDiagonal+= matrix[i,i];
            }
            return sumDiagonal;
        }
    }
}