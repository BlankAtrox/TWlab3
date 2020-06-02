using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace eUseControl.Web.Models
{
     public class UserNews
     {
          [DataType(DataType.Date)]
          [DisplayFormat(DataFormatString = "{0:dd}", ApplyFormatInEditMode = true)]
          public string Data { get; set; }
          public string Noutati { get; set; }
          [DisplayName("Upload File")]
          public string Foto { get; set; }

          public HttpPostedFileBase ImageFile { get; set; }
     }
}