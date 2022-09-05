
        int Max(int arg1, int arg2, int arg3)
        {
            int result = arg1;
            if (arg2 > result) result = arg2;
            if (arg3 > result) result = arg3;
            return result;
        }

        int a = 1;
        int b = 2;
        int c = 6;
        int max1 = Max(a, b, c);
        Console.WriteLine(max1);