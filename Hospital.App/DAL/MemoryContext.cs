using Hospital.App.Models;

namespace Hospital.App.DAL;

public class MemoryContext : IContext
{
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }
    
    public void ImportDoctors()
    {
        Doctors = new List<Doctor>()
        {
            new("A", "AA", "B", DateTime.Today, Sex.Female, "total"),
            new("B", "BB", "C", DateTime.Today, Sex.Female, "total")
        };
    }

    public void ImportPatients()
    {
        Patients = new List<Patient>()
        {
            new("B", "BB", "C", DateTime.Today, Sex.Female, "empty"),
            new("A", "AA", "B", DateTime.Today, Sex.Female, "empty")
        };
    }

    public void ExportDoctors()
    {
        throw new NotImplementedException();
    }

    public void ExportPatients()
    {
        throw new NotImplementedException();
    }
}