namespace SOLID._2_O;

public class Medicament
{
    private readonly string name;
    private readonly string description;

    public string Name => name;
    public string Description => description;

    public Medicament(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
}