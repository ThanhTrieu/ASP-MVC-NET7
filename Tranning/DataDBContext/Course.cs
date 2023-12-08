using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Tranning.DataDBContext
{
    public class Course
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("category_id")]
        public int category_id { get; set; }

        [Column("name", TypeName = "Varchar(50)"), Required]
        public string name { get; set; }

        [Column("description", TypeName ="Varchar(200)"), AllowNull]
        public string? description { get; set; }

        [Column("start_date"), Required]
        public DateTime start_date { get; set; }

        [Column("end_date"), AllowNull]
        public DateTime? end_date { get; set; }

        [Column("vote", TypeName ="Integer"), AllowNull]
        public int? vote { get; set; }

        [Column("avatar", TypeName ="Varchar(200)")]
        public string? avatar { set; get; }

        [Column("status", TypeName ="Varchar(50)"), Required]
        public string status { get; set; }

        [AllowNull]
        public DateTime? created_at { get; set; }
        [AllowNull]
        public DateTime? updated_at { get; set; }
        [AllowNull]
        public DateTime? deleted_at { get; set; }

    }
}
