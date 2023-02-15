using System.Collections.Immutable;

namespace ArraysImplimentations
{
    internal class GenerateImmutableArrays
    {
        public dynamic GenerateImmutableArray(Type t, params dynamic[] values)
        {
            dynamic temp;
            switch (t.ToString())
            {
                case "System.Char":
                    temp = new char[values.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = (char)values[i];
                    }
                    return GenerateImmutableCharArray(temp);

                case "System.String":
                    temp = new string[values.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = (string)values[i];
                    }
                    return GenerateImmutableStringArray(temp);


                case "System.Int16":
                    temp = new short[values.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = (long)values[i];
                    }
                    return GenerateImmutableShortArray(temp);


                case "System.Int32":
                    temp = new int[values.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = (int)values[i];
                    }
                    return GenerateImmutableIntegerArray(temp);


                case "System.Int64":
                    temp = new long[values.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = (long)values[i];
                    }
                    return GenerateImmutableLongArray(temp);


                case "System.Single":
                    temp = new float[values.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = (double)values[i];
                    }
                    return GenerateImmutableFloatArray(temp);


                case "System.Double":
                    temp = new double[values.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = (double)values[i];
                    }
                    return GenerateImmutableDoubleArray(temp);


                case "System.Decimal":
                    temp = new decimal[values.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = (decimal)values[i];
                    }
                    return GenerateImmutableDecimalArray(temp);

            }

            return null;
        }


        dynamic GenerateImmutableCharArray(params char[] values)
        {
            var temp = ImmutableArray.Create<char>(values);
            return temp;
        }

        dynamic GenerateImmutableStringArray(params string[] values)
        {
            var temp = ImmutableArray.Create<string>(values);
            return temp;
        }

        dynamic GenerateImmutableShortArray(params short[] values)
        {
            var temp = ImmutableArray.Create<short>(values);
            return temp;
        }

        dynamic GenerateImmutableIntegerArray(params int[] values)
        {
            var temp = ImmutableArray.Create<int>(values);
            return temp;
        }

        dynamic GenerateImmutableLongArray(params long[] values)
        {
            var temp = ImmutableArray.Create<long>(values);
            return temp;
        }

        dynamic GenerateImmutableFloatArray(params float[] values)
        {
            var temp = ImmutableArray.Create<float>(values);
            return temp;

        }
        dynamic GenerateImmutableDoubleArray(params double[] values)
        {
            var temp = ImmutableArray.Create<double>(values);
            return temp;
        }

        dynamic GenerateImmutableDecimalArray(params decimal[] values)
        {
            var temp = ImmutableArray.Create<decimal>(values);
            return temp;
        }



    }
}
