using Hospital.App.DAL;

namespace Hospital.App;

public static class Program
{
    public static void Main()
    {
        var pathDoctors = "doctors.json";
        var pathPatients = "patients.json";

        var hospital = new BLL.Hospital(new MemoryContext());
        
        var doctors = hospital.GetAllDoctors();
        HospitalView.ShowDoctors(doctors);
        Console.WriteLine();


        var patients = hospital.GetAllPatients();
        HospitalView.ShowPatients(patients);
        Console.WriteLine();

        var name = ConsoleHelper.Input("Введите имя для поиска: ");
        var docs = hospital.FindDoctorsByName(name);
        HospitalView.ShowDoctors(docs);
    }
}

