using NivEm.Domain.Base;

namespace NivEm.Domain.Entities.Institution
{
    public class Institution : User
    {
        public string Name  { get; set; }
        public string CNPJ { get; set; }
        public virtual List<SchoolClass> Classes { get; set; }
    }
}
