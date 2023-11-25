using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Tranning.Validations;

namespace Tranning.Models
{
    public class CategoryModel
    {
        public List<CategoryDetail> CategoryDetailLists { get; set; }
    }

    public class CategoryDetail
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Enter name, please")]
        public string name { get; set; }

        public string? description { get; set; }

        public string? icon { get; set; }

        [Required(ErrorMessage = "Choose Status, please")]
        public string status { get; set; }

        [Required(ErrorMessage = "Choose file, please")]
        [AllowedExtensionFile(new string[] { ".png",".jpg",".jpeg" })]
        [AllowedSizeFile(3*1024*1024)]
        public IFormFile? Photo { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public DateTime? deleted_at { get; set; }
    }
}
