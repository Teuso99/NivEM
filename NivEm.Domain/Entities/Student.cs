using NivEm.Domain.Base;

namespace NivEm.Domain.Entities
{
    public class Student : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        
        public long ClassId { get; set; }
        public Class Class { get; set; }
        //Gameficacao
        //Relatorios List

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetAge ()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }
}
