using System;
using SOLID._0_S;
using SOLID._2_O;
using SOLID._2_O.prescription;
using SOLID._3_l;
using SOLID._4_i;
using SOLID._5_d;
//using SOLID._5_d;
using SOLID.theGoodPatient;

class Program
{
    static void Main(string[] args)
    {
        //ejemplo de S
        IPatient patientModel = new PatientModel("Javier Prades", 25, "Flu");
        Room room = new Room(404);
        RoomAssignmets roomAssignmets = new RoomAssignmets(patientModel, room);
        
        roomAssignmets.AssignRoom();
        
        //ejemplo de o
        Medicament medicament = new Medicament("Ibuprofeno", "Anti-inflamatorio");
        SimplePrescription simplePrescription = new SimplePrescription();
        DetailPrescription detailPrescription = new DetailPrescription();
        PrescriptionPrinter printer = new PrescriptionPrinter();
        
        printer.PrintPrescription(simplePrescription,medicament);
        printer.PrintPrescription(detailPrescription,medicament);
        
        //ejemplo de l
        Surgeon heartSurgeon = new HeartSurgeon();
        Surgeon neuroSurgeon = new NeuroSurgeon();

        PerformSurgery(heartSurgeon);
        PerformSurgery(neuroSurgeon);
        
        //ejemplo de i
        Oral aspirine = new Aspirine();
        Injectable insulin = new Insulin();

        AdministerOral(aspirine);
        AdministerInjectable(insulin);
        
        //ejemplo de d
        Admissions admissions = new Admissions(patientModel);
        //if (admissions == null) throw new ArgumentNullException(nameof(admissions));

        admissions.AdmitPatient();
    }
    
    static void PerformSurgery(Surgeon surgeon)
    {
        surgeon.PerformSurgery();
    }

    static void AdministerOral(Oral med)
    {
        med.AdministerOral();
    }

    static void AdministerInjectable(Injectable med)
    {
        med.AdministerInjection();
    }
}

