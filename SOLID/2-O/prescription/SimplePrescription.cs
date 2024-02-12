namespace SOLID._2_O.prescription;

// Aquí le decimos que SimplePrescription esta hererando de Prescripcion
public class SimplePrescription:Prescription
{
    public string CreatePrescription(Medicament medicament)
    {
        return $"Prescription for {medicament.Name}: {medicament.Description}";
    }
}