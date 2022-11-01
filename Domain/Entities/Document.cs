using Domain.Enums;

namespace Domain.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NomberDocument { get; set; }
        public DateTime DateCreated { get; set; }
        public DocumentType DocumentType { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public virtual List<Agreement> Agreements { get; set; }
        //public Guid CorrespondentId { get; set; }
        //public Employee?  Correspondent { get; set; }
        //public DateTimeOffset Data { get; set; }
        //public int NumberCorrespondent { get; set; }
        //public string PerformerPhoneNumber { get; set; }




    }
}
