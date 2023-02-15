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
    }
}
