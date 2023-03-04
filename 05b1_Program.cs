using System.Text;
using System.Text.Json;

Employee e1 = new()
{
    Id = 1,
    Name = "Nhung",
    Gender = Gender.Les,
    Birthdate = new DateTime(2000, 05, 27),
    Salary = 10_000m,
    //Skills = new string[] { "Singing", "Dancing", "Coding", "Writing" }
};
Console.WriteLine(e1);

string data = JsonSerializer.Serialize(e1, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText("data.json", data, Encoding.UTF8);

enum Gender
{
    Unknown = 0,
    Male = 1,
    Female = 2,
    Gay = 3,
    Les = 4
}

class Employee
{
    #region Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public DateTime Birthdate { get; set; }
    public decimal Salary { get; set; }
    public string[] Skills { get; set; }
    #endregion

    #region Methods
    public override string ToString()
        => new StringBuilder()
        .AppendLine($"Id		: {Id}")
        .AppendLine($"Name		: {Name}")
        .AppendLine($"Gender		: {Gender}")
        .AppendLine($"Birthdate	: {Birthdate:yyyy-MM-dd}")
        .AppendLine($"Salary		: {Salary:c}")
        .AppendLine($"Skills		: {string.Join(", ", Skills ?? Array.Empty<string>())}")
        .ToString();
    #endregion
}