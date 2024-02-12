namespace SOLID._2_O.prescription;

public class DetailPrescription: Prescription
{
    public string CreatePrescription(Medicament medicament)
    {
        return $"Detailed prescription for {medicament.Name}: {medicament.Description}";
    }
}