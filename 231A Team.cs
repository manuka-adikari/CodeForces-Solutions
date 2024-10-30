	public static void solve()
		{
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			for(int i=0;i<n;i++)
			{
				string[] numb = Console.ReadLine().Split(' ');
				int x = int.Parse(numb[0]);
				int y = int.Parse(numb[1]);
				int z = int.Parse(numb[2]);
				a[i] = x+y+z;
			}
			int ans=0;
			for(int i=0;i<n;i++)
			{
				if(a[i]>=2)
				{
					ans++;
				}
			}
			Console.WriteLine(ans);
		}