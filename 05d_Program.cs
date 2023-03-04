#region Display Object States
Console.WriteLine("\n-----Display Object States-----");
Console.WriteLine($"Object State Name   : {string.Join(", ", Enum.GetNames<ObjectState>())}");
Console.WriteLine($"Object State Value  : {string.Join(", ", Enum.GetValues<ObjectState>().Cast<int>())}");
#endregion

#region Create Simple Object
Console.WriteLine("\n----Create Simple Object----");
SimpleObject so1 = new() { Id = 1 };
Console.WriteLine(so1);

//var nextStates = so1.GetNextStates();
var nextStates = so1.State.GetNextStates();

Console.WriteLine($"Next Stages: {nextStates}");

foreach (var state in Enum.GetValues<ObjectState>())
    if (nextStates.HasFlag(state))
        Console.WriteLine($"{state} - {state:D}");
#endregion

#region State Demo
Console.WriteLine("\n----State Demo----");
ObjectState b = ObjectState.B;
Console.WriteLine($"Next states of B: {b.GetNextStates()}");
#endregion

[Flags]
enum ObjectState
{
    A = 1 << 0,
    B = 1 << 1,
    C = 1 << 2,
    D = 1 << 3,
    E = 1 << 4,
    F = 1 << 5,
    G = 1 << 6 //End Point
}

static class ObjectStateExtension
{
    //Extension Methods
    public static ObjectState GetNextStates(this ObjectState state)
        => state switch
        {
            ObjectState.A => (ObjectState)38,
            ObjectState.B => (ObjectState)48,
            ObjectState.C => (ObjectState)12,
            ObjectState.D => (ObjectState)32,
            ObjectState.E => (ObjectState)32,
            ObjectState.F => (ObjectState)64,
            _ => (ObjectState)64
        };
}

class SimpleObject
{
    public int Id { get; set; }
    public ObjectState State { get; set; } = ObjectState.A;

    public override string ToString() => $"Id: {Id}, State: {State}";

}