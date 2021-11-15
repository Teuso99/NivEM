namespace NivEm.Domain.Base
{
    public class NaturalPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }
}
