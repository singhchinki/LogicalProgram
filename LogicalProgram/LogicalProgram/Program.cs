// See https://aka.ms/new-console-template for more information
Console.WriteLine("1.Fibonicseries\n2.PerfectNumber\n3.PrimeNumber\n4.ReverseNumber\n5.CouponNumber\n6.Stopwatch");
Console.WriteLine("Enter your Choice");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        LogicalProgram.Fibonicseries fibonicseries = new LogicalProgram.Fibonicseries();
        fibonicseries.fibonic();
        break;
    case 2:
        LogicalProgram.PerfectNumber perfectNumber = new LogicalProgram.PerfectNumber();
        perfectNumber.perfect();
        break;
    case 3:
        LogicalProgram.PrimeNumber primeNumber = new LogicalProgram.PrimeNumber();  
        primeNumber.primeNum();
        break;
    case 4:
        LogicalProgram.ReverseNumber reverseNumber = new LogicalProgram.ReverseNumber();
        reverseNumber.reverse();
        break;
    case 5:
        LogicalProgram.CouponNumber couponNumber = new LogicalProgram.CouponNumber();
        couponNumber.coupon();
        break;
    case 6:
        LogicalProgram.Stopwatch stopwatch = new LogicalProgram.Stopwatch();
        stopwatch.StopWatch();
        break;
       
        default:
        Console.WriteLine("Enter valid option");
        break;

}
