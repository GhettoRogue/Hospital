using Hospital.App.DAL;
using Hospital.App.Models;

namespace Hospital.App.BLL;

public class Hospital
{
    private readonly IContext _context;

    public Hospital(IContext context)
    {
        _context = context;
        
        _context.ImportDoctors();
        _context.ImportPatients();
    }

    #region Doctors

    public IEnumerable<Doctor> GetAllDoctors() => _context.Doctors;
    public IEnumerable<Doctor> FindDoctorsByName(string name) => _context.Doctors.Where(d => d.FullName.Contains(name));

    #endregion

    #region Patients

    public IEnumerable<Patient> GetAllPatients() => _context.Patients;

    #endregion
    
    
}