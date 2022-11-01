using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum DocumentType
    {
        [Display(Name = "Организационные")]
        Organizational,
        [Display(Name = "Информационные")]
        Informational,
        [Display(Name = "Бухгалтерские")]
        Accounting,
        [Display(Name = "Коммерческие")]
        Commercial,
        [Display(Name = "Распорядительные")]
        Managerial
    }
}
