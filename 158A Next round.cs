        public static void solve()
        {
            string inputValues = Console.ReadLine();
            string[] valueArray = Regex.Split(inputValues, @"\D+");
            int n = int.Parse(valueArray[0]);
            int k = int.Parse(valueArray[1]);

            string inputScores = Console.ReadLine();
            string[] scoreArray = Regex.Split(inputScores, @"\D+");

            int passed = 0;
            
            for (int i=0; i<n; i++)
            {
                if (int.Parse(scoreArray[i]) >= int.Parse(scoreArray[k-1]) && int.Parse(scoreArray[i]) != 0)
                {
                    passed++;
                }
            }
            
            Console.WriteLine(passed);
        }