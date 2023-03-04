// chung ta lam 2 cach
// cach 1: tao dieu kien bat ky danh cho serial va code
// cach 2: tao dieu kien mac dinh danh cho serial cua 1 loai the cao

using System.Text;
using System.Text.Json;

Card c1 = new()
{
    Id = 012332321,
    SerialViettel = "10003213216587", //sai
    CodeViettel = "012345678964523",
    Name = ProviderName.Viettel,
    Price = 100_000m,
    ExpiryDate = new DateTime(2020, 05, 27),
    Description = new string[] { "abc", "xyz", "bcn", "mnb" }
};
Console.WriteLine(c1);

string data = JsonSerializer.Serialize(c1, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText("data.json", data, Encoding.UTF8);
Console.ReadLine();

enum ProviderName
{
    Unknow = 0,
    Viettel = 1,
    Mobifone = 2,
    Vinaphone = 3,
    Vietnammobile = 4
}

class Card
{
    #region Fields
    private string serialViettel;
    private string codeViettel;
    #endregion

    #region Properties
    public int Id { get; set; }
    public string SerialViettel 
    {
        get => serialViettel;
        set
        {
            if(value is null)
                throw new ArgumentNullException("Serial Number's must be required");
            if (value is { Length: not 14 })
                throw new InvalidDataException("Serial Number's length must be 14 digits");

            serialViettel = value;
        }
    }
    public string CodeViettel 
    {
        get => codeViettel;
        set
        {
            if (value is null)
                throw new ArgumentNullException("Code Number's must be required");
            if (value is { Length: not 15 })
                throw new InvalidDataException("Code Number's length must be 15 digits");

            codeViettel = value;
        }
    }
    public ProviderName Name { get; set; }
    public decimal Price { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string[] Description { get; set; }
    #endregion

    #region Methods
    public override string ToString()
        => new StringBuilder()
        .AppendLine($"Id card     : #{Id}")
        .AppendLine($"Serial      : {serialViettel}")
        .AppendLine($"Code        : {codeViettel}")
        .AppendLine($"Name        : {Name}")
        .AppendLine($"Price       : {Price:c}")
        .AppendLine($"Expiry date : {ExpiryDate:yyyy-MM-dd}")
        .AppendLine($"Description : {string.Join(", ", Description ?? Array.Empty<string>())}")
        .ToString();
    #endregion
}

