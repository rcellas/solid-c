using SOLID.theGoodPatient;

namespace SOLID._5_d;

public class Admissions
{
    private readonly IPatient _patient;

    public Admissions(IPatient patient)
    {
        this._patient = patient;
    }

    public void AdmitPatient()
    {
        Console.WriteLine($"Admitting patient: {_patient.GetDetails()}");
    }
}