
#region Enum members
Console.WriteLine("\n-----Enum members-----");

string[] names = Enum.GetNames(typeof(Month));
Console.WriteLine($"Member's names: {string.Join(", ", names)}");
int[] values = (int[])Enum.GetValues(typeof(Month));
Console.WriteLine($"Member's values: {string.Join(", ", values)}");
#endregion

#region Enum Comparison Operators
Console.WriteLine("\n-----Enum Comparison Operators-----");
Console.WriteLine(Month.January < Month.February);
Console.WriteLine(Month.January <= Month.February);
Console.WriteLine(Month.January >= Month.February);
Console.WriteLine(Month.January == Month.February);
Console.WriteLine(Month.January != Month.February);
Console.WriteLine(Month.January.ToString() == "January");
Console.WriteLine(Month.January == (Month)1);
Console.WriteLine((int)Month.January == 1);
#endregion

#region Declare enum variables
Console.WriteLine("\n-----Declare enum variables-----");
Month month = Month.January;
Console.WriteLine(month);
#endregion

#region Enum Conversion
Console.WriteLine("\n-----Enum Conversion-----");
Month january = (Month)Enum.Parse(typeof(Month), "January");
Console.WriteLine(january);

Month february = Enum.Parse<Month>("February");
Console.WriteLine(february);

Month march = (Month)3;
Console.WriteLine(march);
#endregion

enum Month
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    Octorber,
    November,
    December
}