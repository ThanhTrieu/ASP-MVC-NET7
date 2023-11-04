using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Tranning.Models
{
    public class CategoryModel
    {
        public List<CategoryDetail> CategoryDetailLists { get; set; }
    }

    public class CategoryDetail
    {
        public int id { get; set; }

        public string name { get; set; }

        public string? description { get; set; }

        public string? icon { get; set; }

        public int status { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }

        public DateTime? deleted_at { get; set; }
    }
}
