namespace Hospital.App.Models;

public class Examination
{
    public DateTime Date { get; init; }
    public Doctor Doctor { get; init; }
    public string Commentary { get; init; }
}