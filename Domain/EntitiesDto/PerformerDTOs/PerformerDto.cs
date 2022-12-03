using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntitiesDto.PerformerDTOs
{
    public  class PerformerDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset DateOrderDocument { get; set; }  //дата поручения
        public DateTimeOffset DateExecution { get; set; }    //срок исполнения
        public string Description { get; set; }   //  коментария
        public DateTimeOffset PerformanceDate { get; set; }  //дата исполнения
        public PerformerType PerformerType { get; set; }
        public int DocumentId { get; set; }
        public int EmployeeId { get; set; }
    }
}
