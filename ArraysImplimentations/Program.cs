using System.Collections.Immutable;
using System.Diagnostics;
namespace ArraysImplimentations
{
    internal class Program
    {
        public static readonly int[] const_array = new int[10];
        static void Main(string[] args)
        {
            ArrayGenerations genration = new ArrayGenerations();

            GenerateImmutableArrays immutableArrays = new GenerateImmutableArrays();


            Console.WriteLine(typeof(double));
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(long));
            Console.WriteLine(typeof(short));
            Console.WriteLine(typeof(char));
            Console.WriteLine(typeof(float));
            Console.WriteLine(typeof(decimal));

            var gen = genration.GenerateArray(typeof(int), 3);

            for (int i = 0; i < gen.Length; i++)
            {
                Console.Write($"Enter the number to store in the array at index position {i} : ");
                gen[i] = Convert.ToInt32(Console.ReadLine());
            }
            var dhanu = genration.GenerateArray(typeof(int), 10);
            Console.WriteLine(dhanu.GetType());
            foreach (var i in dhanu)
            {
                Console.WriteLine(i);
            }

            var dhanu2 = immutableArrays.GenerateImmutableArray(typeof(int), 10, 20, 30, 40, 50);
            Console.WriteLine(dhanu2.GetType());
            foreach (var i in dhanu2)
            {
                Console.WriteLine(i);
            }

            var dhanu3 = immutableArrays.GenerateImmutableArray(typeof(string), "Dhanu", "Madhu", "Mani", "Vamsi", "Brahmaiya");
            Console.WriteLine(dhanu3.GetType());
            foreach (var i in dhanu3)
            {
                Console.WriteLine(i);
            }

            int[] w = new int[] { 2 };
            int[,] x = new int[,] { { 1, 2 } };
            int[,,] y = new int[,,] { { { 1, 2 }, { 3, 4 } } };
            int[,,,] z = new int[,,,] { { { { 1, 2 }, { 3, 4 } }, { { 1, 2 }, { 3, 4 } } } };
            Console.WriteLine($"The bytes needed for the 1-dimensional array is :  {Buffer.ByteLength(w)}  and the number of elements in the " +
                $"array are :  {w.Length}");
            Console.WriteLine($"The bytes needed for the 2-dimensional array is :  {Buffer.ByteLength(x)}  and the number of elements in the " +
                $"array are :  {x.Length}");
            Console.WriteLine($"The bytes needed for the 3-dimensional array is :  {Buffer.ByteLength(y)}  and the number of elements in the " +
                $"array are :  {y.Length}");
            Console.WriteLine($"The bytes needed for the 4-dimensional array is :  {Buffer.ByteLength(z)}  and the number of elements in the " +
                $"array are :  {z.Length}");

            int[,] array_2d = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (int i in array_2d)
            {
                Console.WriteLine(i);
            }

            int[,,] array_3d = new int[2, 3, 2] {
                { { 1, 2 }, { 3, 4 }, { 5, 6 } },
                { { 1, 2 }, { 3, 4 }, { 5, 6 } }
            };

            int[,,,] array_4d = new int[2, 2, 2, 2]
            {
                {
                    {
                        {1,2 },
                        {3,4 }
                    },
                    {
                        {1,2 },
                        {3,4 }
                    }
                },
                {
                    {
                        {1,2 },
                        {3,4 }
                    },
                    {
                        {1,2 },
                        {3,4 }
                    }
                }
            };


            Console.WriteLine($"The length of the 2-Dimensional Array is : {array_2d.Length}");

            Console.WriteLine($"The length of the 3-Dimensional Array is : {array_3d.Length}");

            Console.WriteLine($"The length of the 4 Dimensional Array is : {array_4d.Length}");


            int[][] jagged = new int[][]
            {
                new int[]{ 1, 2, 3, 4, 5 },
                new int[] { 6,7,8}
            };

            int[,] arr_2d = new int[,] { { 2, 3, 4 }, { 5, 6, 7 } };

            int[][] jagged_array = new int[2][] { new int[] { }, new int[] { } };

            int[,] array_2dim = new int[2, 2];
            long spcace = GC.GetTotalMemory(false);
            Console.WriteLine(spcace);

            long space1 = GC.GetTotalMemory(false);

            int[][] jag = new int[10000][];

            for (int i = 0; i < jag.GetLength(0); i++)
            {
                jag[i] = new int[10000];
            }

            long space2 = GC.GetTotalMemory(false);

            Console.WriteLine($"Total space in bytes : {space2 - space1}");


            long space3 = GC.GetTotalMemory(false);

            int[,] temp = new int[10000, 10000];

            long space4 = GC.GetTotalMemory(false);

            Console.WriteLine($"Total space in bytes : {space4 - space3}");


            Console.WriteLine($"The difference in terms of bytes between jagged array and two dimensional array " +
                $"is : {(space4 - space3) - (space2 - space1)}");

            int sum = 0;
            Stopwatch s2 = new Stopwatch();
            s2.Start();
            foreach (var i in jag)
            {
                foreach (var j in i)
                {
                    sum += j;
                }
            }
            s2.Stop();
            Console.WriteLine(s2.ElapsedMilliseconds);
            Console.WriteLine($"The sum of the elements in the jagged array is :  {sum}");
            Stopwatch s = new Stopwatch();
            s.Start();
            foreach (var i in temp)
            {
                sum += i;
            }
            s.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine($"The sum of the elements in the two dimensional array is :  {sum}");

            int[] resize_array = new int[] { 1, 2, 3, 4, 5 };
            Array.Resize(ref resize_array, 10);

            dynamic array = genration.GenerateArray(typeof(int), 1, 2, 3);

            long space5 = GC.GetTotalMemory(true);
            short[] check = new short[2147483591];
            long space6 = GC.GetTotalMemory(true);

            Console.WriteLine(space6 - space5);

            long space7 = GC.GetTotalMemory(true);
            int[] check_int = new int[2147483591];
            long space8 = GC.GetTotalMemory(true);

            Console.WriteLine(space8 - space7);

        }

    }
}