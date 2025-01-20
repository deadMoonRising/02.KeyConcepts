
double bathWidth = double.Parse(Console.ReadLine());
double bathHeight = double.Parse(Console.ReadLine());
double tilesWidth = double.Parse(Console.ReadLine());
double tilesHeight = double.Parse(Console.ReadLine());

double bathArea = bathWidth * bathHeight;
double surplusAdded = bathArea + (0.1 * bathArea);
double tileArea = tilesWidth * tilesHeight;
double countOfTilesNeeded = surplusAdded / tileArea;

Console.WriteLine(Math.Round(countOfTilesNeeded));
