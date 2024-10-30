        public static void solve()
        {
            int[,] numbers = new int[5, 5];

            for (var i = 0; i < 5; i++)
            {
                var numList = new string[5];
                numList = Console.ReadLine().Split(' ');
                for (var j = 0; j < 5; j++)
                {
                    numbers[i, j] = Convert.ToInt32(numList[j]);
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (numbers[i,j] == 1)
                    {
                        int x = Math.Abs(2 - i);
                        int y = Math.Abs(2 - j);
                        Console.WriteLine(x + y);
                    }
                }
            }
        }	