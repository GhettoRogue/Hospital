using Hospital.App.Models;

namespace Hospital.App.DAL;

public interface IContext
{
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }

    public void ImportDoctors();
    public void ImportPatients();
    public void ExportDoctors();
    public void ExportPatients();
}