namespace SOLID._2_O.prescription;

public class PrescriptionPrinter
{
    public void PrintPrescription(Prescription prescription, Medicament medicament)
    {
        Console.WriteLine(prescription.CreatePrescription(medicament));
    }
}