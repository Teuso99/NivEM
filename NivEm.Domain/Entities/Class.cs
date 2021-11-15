using NivEm.Domain.Base;

namespace NivEm.Domain.Entities
{
    public class Class : User
    {
        public string Name { get; set; }
        public virtual List<Student> Students { get; set; }
        //Instrutor List?
        
        public long InstitutionId { get; set; }
        public Institution Institution { get; set; }
    }
}
