        static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
        
        public static void solve()
        {
            string input = Console.ReadLine();
            string s = SortString(input);

            int count = 1;
            char elem = s[0];
            
            for(int i = 0; i < s.Length; i++){
                if(s[i] != elem){
                    elem = s[i];
                    count++;
                }
            }
            
            if(count % 2 == 0){
                Console.WriteLine("CHAT WITH HER!");
            }
            else{
                Console.WriteLine("IGNORE HIM!");
            }
        }