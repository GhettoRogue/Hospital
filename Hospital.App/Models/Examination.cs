namespace Hospital.App.Models;

public class Examination
{
    public DateTime Date { get; init; }
    public Doctor Doctor { get; init; }
    public string Commentary { get; init; }

    public Examination(DateTime date, Doctor doctor, string commentary)
    {
        Date = date;
        Doctor = doctor;
        Commentary = commentary;
    }
}