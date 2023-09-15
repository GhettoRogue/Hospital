using System.Text.Json;
using Hospital.App.Models;

namespace Hospital.App.DAL;

public class JsonContext : IContext
{
    private readonly string _pathToDoctors;
    private readonly string _pathToPatients;
    
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }

    public JsonContext(string pathToDoctors, string pathToPatients)
    {
        _pathToDoctors = pathToDoctors;
        _pathToPatients = pathToPatients;
    }

    public void ImportDoctors()
    {
        var doctorsJson = File.ReadAllText(_pathToDoctors);
        Doctors = JsonSerializer.Deserialize<List<Doctor>>(doctorsJson);
    }
    
    public void ImportPatients()
    {
        var patientsJson = File.ReadAllText(_pathToPatients);
        Patients = JsonSerializer.Deserialize<List<Patient>>(patientsJson);
    }

    public void ExportDoctors()
    {
        var doctorsJson = JsonSerializer.Serialize(Doctors);
        File.WriteAllText(_pathToDoctors, doctorsJson);
    }
    
    public void ExportPatients()
    {
        var patientsJson = JsonSerializer.Serialize(Patients);
        File.WriteAllText(_pathToPatients, patientsJson);
    }
}