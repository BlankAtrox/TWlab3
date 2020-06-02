using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eUseControl.Domain.Entities.User
{
     public class News
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int Id { get; set; }

          [Required]
          public string Data { get; set; }

          [Required]
          public string Noutati { get; set; }

          [Required]
          public string Foto { get; set; }
     }
}