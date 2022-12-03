using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Agreement   // соглосования
    {
        public int Id { get; set; }
        public int PerformerEmployeeId { get; set; }
        public Employee PerformerEmployee { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public DateTime DateOfSendingAgreement { get; set; } // дата отправления на соглосования
        public DateTime DateAgreementDocument { get; set; }  // дата  соглосования
        public bool AgreementResult { get; set; }
        public string Commment { get; set; }
        public int AgreementEmployeeId { get; set; }
        //[NotMapped]
        public Employee AgreementEmployee { get; set; }




    }
}
