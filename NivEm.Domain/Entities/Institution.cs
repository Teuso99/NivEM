using NivEm.Domain.Base;

namespace NivEm.Domain.Entities
{
    public class Institution : User
    {
        public string Name  { get; set; }
        public string CNPJ { get; set; }
        public List<Class> Classes { get; set; }
    }
}
