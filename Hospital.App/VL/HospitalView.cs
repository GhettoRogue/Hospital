using Hospital.App.Models;

namespace Hospital.App;

public static class HospitalView
{
    public static void ShowDoctor(Doctor doctor)
    {
        ConsoleHelper.PrintInfo($"{doctor.Id}: {doctor.FullName}, {doctor.Age}, {doctor.Sex}, {doctor.Specialization}");
    }
    
    public static void ShowDoctors(IEnumerable<Doctor> doctors)
    {
        foreach (var doctor in doctors)
        {
            ShowDoctor(doctor);
        }
    }

    public static void ShowExamination(Examination examination)
    {
        ConsoleHelper.PrintInfo($"{examination.Date} : {examination.Doctor.FullName} - {examination.Commentary}");
    }
    
    public static void ShowMedicalCard(MedicalCard medicalCard)
    {
        ConsoleHelper.PrintInfo($"{medicalCard.Id}");
        foreach (var examination in medicalCard.Examinations)
        {
            Console.Write("\t");
            ShowExamination(examination);
        }
    }
    
    public static void ShowPatient(Patient patient)
    {
        ConsoleHelper.PrintInfo($"{patient.Id}: {patient.FullName}, {patient.Age}, {patient.Sex} - {patient.MedicalPolicyNumber}");
        ShowMedicalCard(patient.MedicalCard);
    }

    public static void ShowPatients(IEnumerable<Patient> patients)
    {
        foreach (var patient in patients)
        {
            ShowPatient(patient);
        }
    }
}