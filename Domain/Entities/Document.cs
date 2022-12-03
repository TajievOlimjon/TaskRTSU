
using Domain.Enums;

namespace Domain.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }   // тема документа
        public string Description { get; set; }
        public int NomberDocument { get; set; }
        public DateTime DateCreated { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Correspondent { get; set; }
        public int NumberCorrespondent { get; set; }   //1
        public string PerformerPhoneNumber { get; set; }  //1







    }
}
