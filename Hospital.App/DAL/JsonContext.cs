using System.Text.Json;
using Hospital.App.Models;

namespace Hospital.App.DAL;

public class JsonContext : FileContext, IContext
{
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }

    public JsonContext(string pathToDoctors, string pathToPatients) : base(pathToDoctors, pathToPatients)
    { }

    public void ImportDoctors()
    {
        var doctorsJson = File.ReadAllText(PathToDoctors);
        Doctors = JsonSerializer.Deserialize<List<Doctor>>(doctorsJson);
    }
    
    public void ImportPatients()
    {
        var patientsJson = File.ReadAllText(PathToPatients);
        Patients = JsonSerializer.Deserialize<List<Patient>>(patientsJson);
    }

    public void ExportDoctors()
    {
        var doctorsJson = JsonSerializer.Serialize(Doctors);
        File.WriteAllText(PathToDoctors, doctorsJson);
    }
    
    public void ExportPatients()
    {
        var patientsJson = JsonSerializer.Serialize(Patients);
        File.WriteAllText(PathToPatients, patientsJson);
    }
}