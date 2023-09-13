using System.Text.Json.Serialization;

namespace Hospital.App.Models;

public abstract class Person
{
    public Guid Id { get; init; }
    
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string? Patronymic { get; init; }
    
    [JsonIgnore]
    public string FullName => $"{LastName} {FirstName} {Patronymic}";
    
    public DateTime DateOfBirth { get; init; }
    
    [JsonIgnore]
    public int Age
    {
        get
        {
            var today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;
            if (DateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }

    public Sex Sex { get; init; }

    protected Person(Guid id, string firstName, string lastName, string? patronymic, DateTime dateOfBirth, Sex sex)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        DateOfBirth = dateOfBirth;
        Sex = sex;
    }
}