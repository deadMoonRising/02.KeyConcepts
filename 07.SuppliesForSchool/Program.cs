
int countPenPacks = int.Parse(Console.ReadLine());
int countMarkerPacks = int.Parse(Console.ReadLine());
int litersBoardCleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());
double penPackPrice = 5.80;
double markerPackPrice = 7.20;
double boardCleaner = 1.20;

double ttlCostPens = countPenPacks * penPackPrice;
double ttlCostMarkers = countMarkerPacks * markerPackPrice;
double ttlCostBoardCleaner = litersBoardCleaner * boardCleaner;
double allMaterials = ttlCostPens +  ttlCostMarkers +  ttlCostBoardCleaner; ;
//double discount = discountPercentage/100;
double totalAmountNeeded = allMaterials - (allMaterials * discountPercentage / 100);

//Console.WriteLine(discount);
Console.WriteLine(totalAmountNeeded);