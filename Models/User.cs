using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prueba_tecnica.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("Id")]
        [Required(ErrorMessage = "This field required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("FirstName")]
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "This field required")]
        [StringLength(50, ErrorMessage = "Firstname length can't be more than 50.")]
        public string FirstName { get; set; }

        [Column("LastName")]
        [Display(Name = "LastName")]
        [Required(ErrorMessage = "This field required")]
        [StringLength(50, ErrorMessage = "Lastname length can't be more than 50.")]
        public string LastName { get; set; }


        [Column("Direction")]
        [Display(Name = "Direction")]
        [Required(ErrorMessage = "This field required")]
        [StringLength(50, ErrorMessage = "Lastname length can't be more than 50.")]
        public string Direction { get; set; }

        [Column("Sexo")]
        [Required(ErrorMessage = "This field required")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Column("DocumentNumber")]
        [Display(Name = "DocumentNumber")]
        [Required(ErrorMessage = "This field required")]
        [StringLength(8, ErrorMessage = "Lastname length can't be more than 50.")]
        public int DocumentNumber { get; set; }

        [Column("Email")]
        [Required(ErrorMessage = "This field required")]
        [Display(Name = "Email")]

        public string Email { get; set; }


        [Column("FechaNacimiento")]
        [Required(ErrorMessage = "This field required")]
        [Display(Name = "FechaNacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [ForeignKey("FkProvince")]
        [Required(ErrorMessage = "This field required")]
        [Display(Name = "Province")]
        public Province province { get; set; }


    }
}
