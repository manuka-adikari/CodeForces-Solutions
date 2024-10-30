	public static void solve()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string s;
			for (int i = 0; i < n; i++)
			{
				s = Console.ReadLine();
				if (s.Length > 10)
				{
					Console.WriteLine("{0}{1}{2}", s[0], s.Length - 2, s[s.Length - 1]);
				}
				else
				{
					Console.WriteLine(s);
				}
			}	
		}