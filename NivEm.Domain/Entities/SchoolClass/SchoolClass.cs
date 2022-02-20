using NivEm.Domain.Base;

namespace NivEm.Domain.Entities.SchoolClass
{
    public class SchoolClass : User
    {
        public string Name { get; set; }

        public virtual List<Student.Student> Students { get; set; }
        public long InstitutionId { get; set; }
        public Institution.Institution Institution { get; set; }
    }
}
