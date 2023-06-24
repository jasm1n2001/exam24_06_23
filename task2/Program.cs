 int k = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

  for(int i = n; i <= k; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            System.Console.WriteLine($"{i} * {j} = {i*j}");
        }
    System.Console.WriteLine();
    }


