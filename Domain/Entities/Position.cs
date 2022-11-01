
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public  class Position
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Ввведите дольжность"),
            MaxLength(50,ErrorMessage ="Число символов должен быть минимум 50 ")]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual  List<Employee> Employees { get; set; }
        public virtual  List<Performer> Performers { get; set; }

    }
}
