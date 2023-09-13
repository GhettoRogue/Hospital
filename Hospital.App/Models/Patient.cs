using System.Text.Json.Serialization;

namespace Hospital.App.Models;

public class Patient : Person
{
    public string MedicalPolicyNumber { get; init; }
    public MedicalCard MedicalCard { get; init; }

    public Patient(string firstName, string lastName, string? patronymic, DateTime dateOfBirth, Sex sex, string medicalPolicyNumber) : base(Guid.NewGuid(), firstName, lastName, patronymic, dateOfBirth, sex)
    {
        MedicalPolicyNumber = medicalPolicyNumber;
        MedicalCard = new MedicalCard(Models.MedicalCard.CreateId(firstName: FirstName,
            lastName: LastName,
            patronymic: Patronymic ?? "0",
            dateOfBirth: DateOfBirth));
    }

    [JsonConstructor]
    public Patient(Guid id, string firstName, string lastName, string? patronymic, DateTime dateOfBirth, Sex sex, string medicalPolicyNumber, MedicalCard medicalCard) : base(id, firstName, lastName, patronymic, dateOfBirth, sex)
    {
        MedicalPolicyNumber = medicalPolicyNumber;
        MedicalCard = medicalCard;
    }
    
    
}