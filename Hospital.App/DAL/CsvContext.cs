using System.Globalization;
using CsvHelper;
using Hospital.App.Models;

namespace Hospital.App.DAL;

public class CsvContext : FileContext, IContext
{
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }
    
    public CsvContext(string pathToDoctors, string pathToPatients) : base(pathToDoctors, pathToPatients)
    {
    }
    
    public void ImportDoctors()
    {
        var reader = new StreamReader(PathToDoctors);
        var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        Doctors = csv.GetRecords<Doctor>().ToList();
    }

    public void ImportPatients()
    {
        throw new NotImplementedException();
    }

    public void ExportDoctors()
    {
        var writer = new StreamWriter(PathToDoctors);
        var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(Doctors);
    }

    public void ExportPatients()
    {
        throw new NotImplementedException();
    }
}