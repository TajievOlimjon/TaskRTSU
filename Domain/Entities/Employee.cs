using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public  class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Введите имя сотрудника"),
            MaxLength(75,ErrorMessage = "Число символов должен быть минимум 50 ")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите фамилию сотрудника"),
          MaxLength(75, ErrorMessage = "Число символов должен быть минимум 50 ")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите отчество сотрудника"),
          MaxLength(75, ErrorMessage = "Число символов должен быть минимум 50 ")]
        [Display(Name = "Отчество")]
        public string Middle { get; set; }

        [Required(ErrorMessage = "Введите возраст сотрудника"),
          Range(18 ,65 ,ErrorMessage = "Возраст дольжен быть в диапазоне от 18 до 65 ")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Введите имя сотрудника"),
          EmailAddress(ErrorMessage ="Email не корректна ?")]
        [Display(Name = "Электронная почта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите номер телефона"),
          MaxLength(13, ErrorMessage = "Число символов должен быть минимум 13 ")]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Дата рождения")]
        public DateTimeOffset BitrthDate { get; set; }
        [Display(Name = "Пол")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Введите фото сотрудника")]
        [Display(Name = "Фото")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Введите адрес сотрудника")]
        [Display(Name = "Адрес ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Введите код отдела ")]
        [Display(Name = "Отдел в котором работает этот сотрудник ")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        [Required(ErrorMessage = "Введите дольжност")]
        [Display(Name = "Должность сотрудника")]
        public string Position { get; set; }
    }
}
