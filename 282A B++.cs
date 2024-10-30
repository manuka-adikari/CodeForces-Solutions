		public static void solve()
		{
			int x = 0;
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine();
			for (int i=0; i<n; i++)
			{
				string input = Console.ReadLine();
				if (input.Contains("+"))
				{
					x++;
				}
				else if (input.Contains("-"))
				{
					x--;
				}
				else{
					continue;
				}
			}
			