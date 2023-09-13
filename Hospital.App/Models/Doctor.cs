namespace Hospital.App.Models;

public class Doctor : Person
{
    public string Specialization { get; init; }

    public Doctor(string firstName, string lastName, string? patronymic, DateTime dateOfBirth, Sex sex, string specialization) : base(Guid.NewGuid(), firstName, lastName, patronymic, dateOfBirth, sex)
    {
        Specialization = specialization;
    }

    public Doctor(Guid id, string firstName, string lastName, string? patronymic, DateTime dateOfBirth, Sex sex, string specialization) : base(id, firstName, lastName, patronymic, dateOfBirth, sex)
    {
        Specialization = specialization;
    }
}