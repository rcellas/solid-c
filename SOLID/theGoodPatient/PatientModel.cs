namespace SOLID.theGoodPatient;

public class PatientModel
{
    // privado y solo de lectura
    private readonly string name;
    private readonly int age;
    private readonly string illness;

    public string Name => name;
    public int Age => age;
    public string Illness => illness;

    public PatientModel(string name, int age, string illness)
    {
        this.name = name;
        this.age = age;
        this.illness = illness;
    }

    public string GetDetail()
    {
        return $"{name}, {age}, suffering from {illness}";
    }

}