using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoticeWithoutShit.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [RegularExpression(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$", ErrorMessage = "Некорректно введен email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [Display(Name = "Год рождения")]
        public int Year { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required (ErrorMessage ="Поле обязательно к заполнению")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 3 до 20 символов")]
        [RegularExpression(@"\b[A-ZА-Яa-zа-я]\w*\b", ErrorMessage = "Допустимы только буквы")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Длина фамилии должна быть от 3 до 20 символов")]
        [RegularExpression(@"\b[A-ZА-Яa-zа-я]\w*\b", ErrorMessage = "Допустимы только буквы")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

   
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Длина телефона должна быть от 3 до 20 символов")]
        [RegularExpression(@"(\s*)?(\+)?([- _():=+]?\d[- _():=+]?){10,14}(\s*)?", ErrorMessage = "Некорректно введен номер телефона")]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
