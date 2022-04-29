using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название страницы")]
        [Display(Name = "Название страницы")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание страницы")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание страницы")]
        public override string Text { get; set; }
    }
}
