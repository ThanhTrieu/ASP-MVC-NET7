using System.ComponentModel.DataAnnotations;
using Tranning.Validations;

namespace Tranning.Models
{
    public class CourseModel
    {
        public List<CourseDetail> CourseDetailLists { get; set; }
    }

    public class CourseDetail
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Enter Category, please")]
        public int category_id { get; set; }

        [Required(ErrorMessage = "Enter name, please")]
        public string name { get; set; }

        public string? description { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime start_date { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? end_date {  get; set; }

        public int? vote {  get; set; }

        public string avatar { get; set; }

        [Required(ErrorMessage = "Choose Status, please")]
        public string status { get; set; }

        [Required(ErrorMessage = "Choose file, please")]
        [AllowedExtensionFile(new string[] { ".png", ".jpg", ".jpeg" })]
        [AllowedSizeFile(3 * 1024 * 1024)]
        public IFormFile? Photo { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public DateTime? deleted_at { get; set; }
    }
}
