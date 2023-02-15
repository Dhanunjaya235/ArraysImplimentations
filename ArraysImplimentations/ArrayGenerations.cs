namespace ArraysImplimentations
{
    internal class ArrayGenerations
    {
        public dynamic GenerateArray(Type t, params int[] dimensions)
        {
            switch (t.ToString())
            {
                case "System.String":
                    return GenerateStringArray(dimensions);
                case "System.Int32":
                    return GenerateIntegerArray(dimensions);
                case "System.Double":
                    return GenerateDoubleArray(dimensions);
                case "System.Int16":
                    return GenerateShortArray(dimensions);
                case "System.Int64":
                    return GenerateLongArray(dimensions);
                case "System.Char":
                    return GenerateCharArray(dimensions);
                case "System.Decimal":
                    return GenerateDecimalArray(dimensions);
                case "System.Single":
                    return GenerateFloatArray(dimensions);

            }

            return null;
        }



        dynamic GenerateCharArray(params int[] dimensions)
        {
            switch (dimensions.Length)
            {
                case 0:
                    throw new Exception("You have to mention atleast of 1 dimension");
                case 1:
                    return new char[dimensions[0]];
                case 2:
                    return new char[dimensions[0], dimensions[1]];
                case 3:
                    return new char[dimensions[0], dimensions[1], dimensions[2]];
                case 4:
                    return new char[dimensions[0], dimensions[1], dimensions[2], dimensions[3]];
                default:
                    throw new Exception("You have to mention atmost of 4 dimensions only");
            }
        }

        dynamic GenerateStringArray(params int[] dimensions)
        {
            switch (dimensions.Length)
            {
                case 0:
                    throw new Exception("You have to mention atleast of 1 dimension");
                case 1:
                    return new string[dimensions[0]];
                case 2:
                    return new string[dimensions[0], dimensions[1]];
                case 3:
                    return new string[dimensions[0], dimensions[1], dimensions[2]];
                case 4:
                    return new string[dimensions[0], dimensions[1], dimensions[2], dimensions[3]];
                default:
                    throw new Exception("You have to mention atmost of 4 dimensions only");
            }
        }

        dynamic GenerateShortArray(params int[] dimensions)
        {
            switch (dimensions.Length)
            {
                case 0:
                    throw new Exception("You have to mention atleast of 1 dimension");
                case 1:
                    return new short[dimensions[0]];
                case 2:
                    return new short[dimensions[0], dimensions[1]];
                case 3:
                    return new short[dimensions[0], dimensions[1], dimensions[2]];
                case 4:
                    return new short[dimensions[0], dimensions[1], dimensions[2], dimensions[3]];
                default:
                    throw new Exception("You have to mention atmost of 4 dimensions only");
            }
        }

        dynamic GenerateIntegerArray(params int[] dimensions)
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

        dynamic GenerateLongArray(params int[] dimensions)
        {
            switch (dimensions.Length)
            {
                case 0:
                    throw new Exception("You have to mention atleast of 1 dimension");
                case 1:
                    return new long[dimensions[0]];
                case 2:
                    return new long[dimensions[0], dimensions[1]];
                case 3:
                    return new long[dimensions[0], dimensions[1], dimensions[2]];
                case 4:
                    return new long[dimensions[0], dimensions[1], dimensions[2], dimensions[3]];
                default:
                    throw new Exception("You have to mention atmost of 4 dimensions only");
            }
        }

        dynamic GenerateFloatArray(params int[] dimensions)
        {
            switch (dimensions.Length)
            {
                case 0:
                    throw new Exception("You have to mention atleast of 1 dimension");
                case 1:
                    return new float[dimensions[0]];
                case 2:
                    return new float[dimensions[0], dimensions[1]];
                case 3:
                    return new float[dimensions[0], dimensions[1], dimensions[2]];
                case 4:
                    return new float[dimensions[0], dimensions[1], dimensions[2], dimensions[3]];
                default:
                    throw new Exception("You have to mention atmost of 4 dimensions only");
            }
        }

        dynamic GenerateDoubleArray(params int[] dimensions)
        {
            switch (dimensions.Length)
            {
                case 0:
                    throw new Exception("You have to mention atleast of 1 dimension");
                case 1:
                    return new double[dimensions[0]];
                case 2:
                    return new double[dimensions[0], dimensions[1]];
                case 3:
                    return new double[dimensions[0], dimensions[1], dimensions[2]];
                case 4:
                    return new double[dimensions[0], dimensions[1], dimensions[2], dimensions[3]];
                default:
                    throw new Exception("You have to mention atmost of 4 dimensions only");
            }
        }

        dynamic GenerateDecimalArray(params int[] dimensions)
        {
            switch (dimensions.Length)
            {
                case 0:
                    throw new Exception("You have to mention atleast of 1 dimension");
                case 1:
                    return new decimal[dimensions[0]];
                case 2:
                    return new decimal[dimensions[0], dimensions[1]];
                case 3:
                    return new decimal[dimensions[0], dimensions[1], dimensions[2]];
                case 4:
                    return new decimal[dimensions[0], dimensions[1], dimensions[2], dimensions[3]];
                default:
                    throw new Exception("You have to mention atmost of 4 dimensions only");
            }
        }

        void Display()
        {
            Console.WriteLine("Array Generations Class Display Method");
        }
    }
}
