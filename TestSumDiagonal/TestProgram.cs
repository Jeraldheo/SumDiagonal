using SumDiagonal;

namespace TestSumDiagonal
{
    public class TestProgram
    {
        public static IEnumerable<object[]> TestDataSumDiagonal
            => new[]
            {
                new object[]{62, new int[,] { {17, 9, 36, 21 }, {8, 28, 3, 1 }, {15, 7, 5, 30}, {10, 17, 4, 12 } } },
                new object[]{0, new int[,] { {0, 0, 0, 0 }, {0, 0, 0, 0 }, {0, 0, 0, 0}, {0, 0, 0, 0 } } },
                new object[]{4, new int[,] { {1, 0, 0, 0 }, {0, 1, 0, 0 }, {0, 0, 1, 0}, {0, 0, 0, 1 } } },
                new object[]{10, new int[,] { {1, 0, 0, 0 }, {0, 2, 0, 0 }, {0, 0, 3, 0}, {0, 0, 0, 4 } } },

            };
        [Theory]
        [MemberData(nameof(TestDataSumDiagonal))]
        public void Test_SumDiagonal(int expectedSum, int[,] matrix)
        {
            int sum = Program.SumDiagonal(matrix);
            Assert.Equal(expectedSum, sum);
        }
    }
}