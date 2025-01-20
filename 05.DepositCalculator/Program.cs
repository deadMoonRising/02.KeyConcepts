
double depositedAmount = double.Parse(Console.ReadLine());
int depositTermMonths = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());


double totalInterest = depositedAmount * annualInterestRate / 100;
double interestPerMonth = totalInterest / 12;
double totalAmountReceived = depositedAmount + depositTermMonths * interestPerMonth;

Console.WriteLine(totalAmountReceived);