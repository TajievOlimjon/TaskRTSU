using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntitiesDto
{
    public class DocumentDto
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public int NomberDocument { get; set; }
        public DateTime DateCreated { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Correspondent { get; set; }
        public int NumberCorrespondent { get; set; } 
        public string PerformerPhoneNumber { get; set; }
    }
}
