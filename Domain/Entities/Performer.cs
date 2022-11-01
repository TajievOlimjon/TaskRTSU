using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Performer  //исполнитель
    {
        public int Id { get; set; }
        public string PerformerFirstName { get; set; }
        public string PerformerLastName { get; set; }
        public string PerformerPotronymic { get; set; }
        public string PerformerEmail { get; set; }
        public string PerformerPhoneNumber { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public string Title { get; set; }
        public DateTime DateOrderDocument { get; set; }  //дата поручения
        public DateTime DateExecution { get; set; }    //срок исполнения
        public string Description { get; set; }
        public DateTime PerformanceDate { get; set; }  //дата исполнения
        public int CorrespondentId { get; set; }
        public Employee? Correspondent { get; set; }
        public int NumberCorrespondent { get; set; }
        public int PositionId { get; set; }
        public Position?  Position { get; set; }

    }
}

