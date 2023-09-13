using System.Text;

namespace Hospital.App.Models;

public class MedicalCard
{
    private readonly string _id;
    public string Id => _id;

    private readonly List<Examination> _examinations;
    public List<Examination> Examinations => _examinations;

    public MedicalCard(string id)
    {
        _id = id;
        _examinations = new List<Examination>();
    }

    public void AddExamination(DateTime date, Doctor doctor, string commentary)
    {
        _examinations.Add(new Examination(date, doctor, commentary));
    }

    public static string CreateId(string firstName, string lastName, string patronymic, DateTime dateOfBirth)
    {
        var idBuilder = new StringBuilder();
        idBuilder.Append($"{lastName[0]}{firstName[0]}{patronymic[0]}");
        idBuilder.Append($"{dateOfBirth.Year}{dateOfBirth.Month}{dateOfBirth.Day}");
        var random = new Random();
        idBuilder.Append(random.Next(1000, 10000));

        return idBuilder.ToString();
    }
}