using SOLID.theGoodPatient;

namespace SOLID._0_S;

public class RoomAssignmets
{
    private readonly PatientModel _patientModel;
    private readonly Room _room;

    public RoomAssignmets(PatientModel patientModel, Room room)
    {
        this._patientModel = patientModel;
        this._room = room;
    }

    public void AssignRoom()
    {
        Console.WriteLine($"Assigning room {_room.RoomNumber} to patient {_patientModel.Name}");
    }
}