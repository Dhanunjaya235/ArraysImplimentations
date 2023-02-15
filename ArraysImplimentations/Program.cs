using System.Diagnostics;
using System.Collections.Immutable;
namespace ArraysImplimentations
{
    internal class Program
    {
        public static readonly int[] const_array = new int[10];
        static void Main(string[] args)
        {
            DisplayArray("Dhanunjay");
            int[][] type_check = new int[10][];
            type_check[0] = new int[10];
            short[][] short_check = new short[10][];
            DisplayArray(type_check);
            DisplayArray(short_check);

            var implicit_array = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(implicit_array.GetType());
            DisplayArray(implicit_array);

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


            Console.WriteLine($"The difference in terms of bytes between jagged array and two dimensional array is : {(space4 - space3) - (space2 - space1)}");

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

            dynamic array = GenerateArray(1, 2, 3);

            long space5 = GC.GetTotalMemory(true);
            short[] check = new short[2147483591];
            long space6 = GC.GetTotalMemory(true);

            Console.WriteLine(space6 - space5);

            long space7 = GC.GetTotalMemory(true);
            int[] check_int = new int[2147483591];
            long space8 = GC.GetTotalMemory(true);

            Console.WriteLine(space8 - space7);

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


        static void DisplayArray(dynamic array)
        {
            var arr = array as Array;
            if (arr != null)
            {
                if (array.Length > 0 && (array[0] == null || array[0] is Array))
                {
                    Console.WriteLine("The Array passed as the argument is an Jagged Array");
                    Console.WriteLine("Displaying The Elements in the Jagged Array ");

                    foreach (var ar in array)
                    {
                        if (ar != null)
                        {
                            foreach (var item in ar)
                            {
                                Console.Write(item + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Displaying the elements the given {array.Rank} - Dimensional array");
                    foreach (var item in array)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("The passed argument is an neither an Array nor a Jagged Array");
            }
        }
    }
}