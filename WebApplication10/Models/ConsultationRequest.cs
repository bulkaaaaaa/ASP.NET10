using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class ConsultationRequest
    {
        [DisplayName("Ім'я та прізвище:")]
        [Required(ErrorMessage = "Поле Ім'я та прізвище є обов'язковим!")]
        public string FullName { get; set; }

        [DisplayName("Електронна пошта:")]
        [Required(ErrorMessage = "Поле Електронної пошти є обов'язковим!")]
        [EmailAddress(ErrorMessage = "Некоректний формат Email!")]
        public string Email { get; set; }

        [DisplayName("Дата консультації:")]
        [Required(ErrorMessage = "Поле Дати консультації є обов'язковим!")]
        [FutureDate(ErrorMessage = "Дата консультації повинна бути у майбутньому!")]
        [NotOnWeekend(ErrorMessage = "Консультація не може попадати на вихідні дні!")]
        [NotOnSpecificDay(DayOfWeek.Monday)]
        public DateTime ConsultationDate { get; set; }

        [DisplayName("Продукт, за яким Ви хочете отримати консультацію:")]
        [Required(ErrorMessage = "Поле Продукт є обов'язковим!")]
        public string Product { get; set; }
        public bool IsRegistered { get; set; }
    }
}
