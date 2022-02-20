using NivEm.Domain.Base;

namespace NivEm.Domain.Entities.Student
{
    public class Student : User
    {
        public NaturalPerson NaturalPerson { get; set; }
        
        public long ClassId { get; set; }
        public SchoolClass.SchoolClass Class { get; set; }
        //Gameficacao
        //Relatorios List
    }
}
