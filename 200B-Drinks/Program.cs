int n = int.Parse(Console.ReadLine());
int pSum = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Sum();
int maxPer = 100 * n;
decimal res = 100m * (pSum * 1m) / (maxPer * 1m);
Console.WriteLine(res.ToString("n12"));
