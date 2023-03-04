
Hobbie person1 = Hobbie.Cooking | Hobbie.Driving; //0000_0001 | 0000_0010 = 0000_0011
Console.WriteLine($"Person 1's hobbies: {(int)person1} - {person1}");
Console.WriteLine($"Can cook          : {(person1 & Hobbie.Cooking) == Hobbie.Cooking}");
Console.WriteLine($"Can drive         : {(person1 & Hobbie.Driving) == Hobbie.Driving}");
Console.WriteLine($"Can go hiking     : {(person1 & Hobbie.Hiking) == Hobbie.Cooking}");
Console.WriteLine($"Can cook and drive: {(person1 & (Hobbie.Cooking | Hobbie.Driving)) == (Hobbie.Cooking | Hobbie.Driving)}");

[Flags]
enum Hobbie
{
    Cooking = 1,            //0000_0001
    Driving = 2,            //0000_0010
    Hiking = 4,             //0000_0100
    Listening_to_music = 8, //0000_1000
    Reading_books = 16,     //0001_0000
    Shopping = 32,          //0010_0000
    Traveling = 64,         //0100_0000
    Walking = 128,          //1000_0000
}