namespace ArraysImplimentations
{
    internal class ArrayMethods
    {
        public void DisplayArray(dynamic array)
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

        public int[,] CopyAnArrayIntoATwoDimensionalArray(int[] array_1d, int[,] array_2d)
        {
            if(array_1d==null || array_2d == null)
            {
                throw new ArgumentNullException("one of the given array is null");
            }
            if(array_1d.Length==array_2d.Length)
            {
                int index = 0;
                for(int i = 0; i <= array_2d.GetUpperBound(0); i++)
                {
                    for(int j = 0; j <= array_2d.GetUpperBound(1); j++)
                    {
                        array_2d[i, j] = array_1d[index++];
                        
                    }
                }
            }
            else
            {
                string message = array_2d.Length < array_1d.Length ? "The number of elements in the one dimensional array is greater than " +
                    "the length of the two dimensional array inserting values upto the two dimensional array length" : "" +
                    "The length of two dimensional array is greater than the length of the one dimensional array so assigning 0's to the remaining " +
                    "elements in the two dimensional array";
                Console.WriteLine(message);
                int index = 0;
                for (int i = 0; i <= array_2d.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= array_2d.GetUpperBound(1); j++)
                    {
                       array_2d[i,j]= index<array_1d.Length? array_1d[index++]: 0;
                    }
                }
            }
            return array_2d;
        }

        public int[] TwoDimensionalArrayToArray(int[,] array_2d)
        {
            int[] array_1d=new int[array_2d.Length];
            if (array_2d != null)
            {
                int index = 0;
                for(int i = 0; i < array_2d.GetLength(0); i++)
                {
                    for(int j = 0; j < array_2d.GetLength(1); j++)
                    {
                        array_1d[index++] = array_2d[i,j];
                    }
                }
            }
            else
            {
                Console.WriteLine("The Given Two Dimesional Array is null");
            }

            return array_1d;
        }
    }
}
