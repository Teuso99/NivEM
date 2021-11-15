using NivEm.Domain.Base;

namespace NivEm.Domain.Entities
{
    public class Instructor : User
    {
        public NaturalPerson NaturalPerson { get; set; }

        public long ClassId { get; set; }
        public Class Class { get; set; }
    }
}
