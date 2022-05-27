namespace TP1
{
    class Exercise1
    {
        private static void Exercise11()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\tExercise 1.1");
            Console.WriteLine(
                "------------------------------------------------------------------------------------------------------------------------------------------------------------");
            const int max = 11;
            for (int x = 1; x < max; x++)
            {
                for (int y = 1; y < max; y++)
                {
                    int value = x * y;
                    Console.Write("{0} * {1} = {2}\t", y, x, value);
                }
                Console.WriteLine("\t");
            }
        }

        private static void Exercise12()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\tExercise 1.2");
            Console.WriteLine(
                "------------------------------------------------------------------------------------------------------------------------------------------------------------");
            const int max = 11;
            for (int x = 1; x < max; x++)
            {
                for (int y = 1; y < max; y++)
                {
                    int value = x * y;
                    if (value % 2 == 1)
                    {
                        Console.Write("{0} * {1} = {2}\t", y, x, value);
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Exercise13()
        {
            Console.WriteLine("Please write a number and press enter :");
            int n = Convert.ToInt32(Console.ReadLine());   
            Console.Write("\n");
            for(int j=1;j<=10;j++)
            {
                Console.Write("{0} X {1} = {2} \n",n,j,n*j);
            }
        }
        
        private static void Prime()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\tExercise 2.1");
            Console.WriteLine(
                "------------------------------------------------------------------------------------------------------------------------------------------------------------");
            bool isPrime = true;
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
 
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
 
                }
                if (isPrime)
                {
                    Console.Write("\t" +i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }

        private static void Exercise22()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\tExercise 2.2");
            Console.WriteLine(
                "------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Please write a number and press enter :");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Fibonacci("+n+")= 0");
            }

            if (n == 1)
            {
                Console.WriteLine("Fibonacci("+n+")= 1");
            }
            int u = 0;
            int v = 1;
            for (int i = 2; i <= n; i++)
            {
                int w = u + v;
                u = v;
                v = w;
            }
            Console.WriteLine("Fibonacci("+n+")="+v);
        }

        private static void Exercise23()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\tExercise 2.3");
            Console.WriteLine(
                "------------------------------------------------------------------------------------------------------------------------------------------------------------");
            int fact = 1;
            Console.WriteLine("Please write a number and press enter :");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++){      
                fact=fact*i;      
            }      
            Console.Write("Factorial of " +n+"! is = "+fact);    
        }
        
        // If you tried to calculate 420.000! the result is equal to 0
        // A recursive function is a function being called again by itself 

        private static void Exercise3()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\tExercise 3");
            Console.WriteLine(
                "------------------------------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = -2; i <= 2; i++)
            {
                int num = 10;
                int denum = Convert.ToInt32(Math.Pow(i, 2) - 4);
                try
                {
                    int result = num / denum;
                    Console.WriteLine("F(x) = 10/(x²-4) with x = " + i + " is equal to : " + result);
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("You divided by 0");
                }
            }
        }

        private static void Exercise4()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\tExercise 4");
            Console.WriteLine(
                "------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Please write the length of the rectangle :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write the width of the rectangle :");
            int m = Convert.ToInt32(Console.ReadLine());
            int compteurligne = 0;
            int compteurcolonne = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 | i == n-1)
                {
                    Console.Write("0");
                    for (int j = 2; j < n; j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("0 \n");
                }
                else
                {
                    if (i < m - 1)
                    {
                        Console.Write("|");
                        for (int k = 2; k < n; k++)
                        {
                            if (compteurligne % 3 == 0)
                            {
                                Console.Write("*");
                                if (compteurcolonne == 3)
                                {
                                    compteurcolonne = 0;
                                }
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            compteurligne++;
                        }
                        Console.Write("| \n");
                        compteurcolonne++;
                        compteurligne = 1 + compteurligne;
                    }
                }
            }
        }

        // A (1,5) rectangle is equal to : 00
        
        // A (4,1) rectangle is equal to :
        // 0--0 
        // 0--0 
        
        // A (5,7) rectangle is equal to :
        // 0---0 
        // |   | 
        // |   | 
        // |   | 
        // 0---0 
        
        // A (3,3) rectangle is equal to :
        // 0-0 
        // | | 
        // 0-0 

        private static void Exercise5()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\tExercise 5");
            Console.WriteLine(
                "------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Please write the size of the tree :");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 3 | n >= 20)
            {
                Console.WriteLine("Please write the size of the tree :");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Do you want some decorations on your tree ? (Y/N) :");
            string deco = Console.ReadLine();

            Random rnd = new Random();

            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2; k++)
                {
                    if (deco == "N")
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (rnd.Next(1, 10) < 3)
                        {
                            Console.Write("i");
                        }
                        else
                        {
                            if (rnd.Next(1, 10) < 2)
                            {
                                Console.Write("o");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            for (int k = 1; k < (n-1); k++)
            {
                Console.Write(" ");
            }
            Console.Write("| |");
        }

        static void Main()
        {
            // Exercise11();
            // Exercise12();
            // Exercise13();
            // Prime();
            // Exercise22();
            // Exercise23();
            // Exercise3();
            // Exercise4();
            Exercise5();
        }
    }
}