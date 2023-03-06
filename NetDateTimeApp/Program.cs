namespace NetDateTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new();

            Console.WriteLine($"{DateTime.MinValue} {DateTime.MaxValue}");

            dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            dateTime = DateTime.Today;
            Console.WriteLine(dateTime);

            dateTime = new(2012, 5, 23);
            DateTime dateNow = DateTime.Today;
            Console.WriteLine(dateTime.DayOfWeek);

            Console.WriteLine(dateTime.Add(new(24, 0, 0)));
            Console.WriteLine(dateTime.AddDays(-10));
            Console.WriteLine(dateTime.AddMonths(15));
            Console.WriteLine(dateTime.AddYears(6));
            Console.WriteLine(dateTime.AddHours(-48));
            Console.WriteLine(dateTime.AddMinutes(60));

            Console.WriteLine(dateNow.Subtract(dateTime).TotalDays);

            Console.WriteLine(dateNow.ToLocalTime());
            Console.WriteLine(dateNow.ToUniversalTime());
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToLongTimeString());
            Console.WriteLine(dateTime.ToShortTimeString());
            Console.WriteLine();



            Console.WriteLine($"D: {dateTime:D}");
            Console.WriteLine($"d: {dateTime:d}");
            Console.WriteLine($"F: {dateTime:F}");
            Console.WriteLine($"f: {dateTime:f}");
            Console.WriteLine($"G: {dateTime:G}");
            Console.WriteLine($"g: {dateTime:g}");
            Console.WriteLine($"M: {dateTime:M}");
            Console.WriteLine($"m: {dateTime:m}");
            Console.WriteLine($"R: {dateTime:R}");
            Console.WriteLine($"s: {dateTime:s}");
            Console.WriteLine($"T: {dateTime:T}");
            Console.WriteLine($"t: {dateTime:t}");
            Console.WriteLine($"Y: {dateTime:Y}");
            Console.WriteLine($"y: {dateTime:y}");

            Console.WriteLine();

            Console.WriteLine(dateNow.ToString("dd.MM.yyyy"));


        }
    }
}