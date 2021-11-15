using NivEm.Domain.Base;

namespace NivEm.Domain.Entities
{
    public class Student : User
    {
        public NaturalPerson NaturalPerson { get; set; }
        
        public long ClassId { get; set; }
        public Class Class { get; set; }
        //Gameficacao
        //Relatorios List
    }
}
