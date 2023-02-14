using System.Diagnostics;
using System.Collections.Immutable;
namespace ArraysImplimentations
{
    internal class Program
    {
        public static readonly int[] const_array = new int[10];
        static void Main(string[] args)
        {
            var implicit_array = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(implicit_array.GetType());

            var immutable = ImmutableArray.Create<int>(0, 1, 2, 3, 4, 5);

            foreach (var item in immutable)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(immutable.IndexOf(3));

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


            Console.WriteLine($"The difference in terms of bytes between jagged array and two dimensional array is : {(space4 - space3)-(space2 - space1)}");

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

            Stopwatch s = new Stopwatch();
            s.Start();
            foreach (var i in temp)
            {
                sum += i;
            }
            s.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);


            int[] resize_array = new int[] { 1, 2, 3, 4, 5 };
            Array.Resize(ref resize_array, 10);

            dynamic array = GenerateArray(1, 2, 3);

            long space5 = GC.GetTotalMemory(true);
            int[] check = new int[2147483591];
            long space6 = GC.GetTotalMemory(true);

            Console.WriteLine(space6 - space5);

        }

        static void ChangeArray(int[] arr)
        {
            arr[0] = 100;
            arr[1] = 200;
            arr[2] = 300;
        }

        static void ChangeArray(long[] arr)
        {
            arr[0] = 100;
            arr[1] = 200;
            arr[2] = 300;
        }

        static dynamic MultipleReturns(string str)
        {
            if (str.StartsWith("D"))
            {
                return true;
            }
            else
            {
                return 10;
            }
        }

        static dynamic GenerateArray(params int[] dimensions)
        {
            switch (dimensions.Length)
            {
                case 0:
                    throw new Exception("You have to mention atleast of 1 dimension");
                case 1:
                    return new int[dimensions[0]];
                case 2:
                    return new int[dimensions[0], dimensions[1]];
                case 3:
                    return new int[dimensions[0], dimensions[1], dimensions[2]];
                case 4:
                    return new int[dimensions[0], dimensions[1], dimensions[2], dimensions[3]];
                default:
                    throw new Exception("You have to mention atmost of 4 dimensions only");
            }
        }

        static void DisplayArray(int[] array)
        {
            foreach(var i in array)
            {
                Console.WriteLine(i);
            }
        }

        static void DisplayArray(int[,] array)
        {
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}