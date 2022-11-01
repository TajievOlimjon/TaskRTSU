using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Agreement    // соглосования
    {
        public int Id { get; set; }
        public int AgreementEmployeeId { get; set; }
        [NotMapped]
        public Employee AgreementEmployee { get; set; }
        public int PerformerEmployeeId { get; set; }
        public Employee PerformerEmployee { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        //public int DepartmentId { get; set; }
        //public Department Department { get; set; }
        public DateTime DateOtprovkaNaSoglosovaniya { get; set; } // дата отправления на соглосования
        public DateTime DateSoglosovaniya { get; set; }
        public bool AgreementResult { get; set; }
        public string Description { get; set; }
    }
}
