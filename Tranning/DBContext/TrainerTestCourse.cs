using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Tranning.DBContext
{
    public class TrainerTestCourse
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public TrainerTestCategories TrainerTestCategories { get; set; }  // reference navigation

        [Column("NameCourse", TypeName = "Varchar(50)")]
        public string NameCourse { get; set; }

        [Column("Description", TypeName = "Varchar(100)")]
        public string Description { get; set; }

        [Column("StartDate", TypeName = "DateOnly")]
        public DateOnly StartDate { get; set; }

        [Column("EndDate", TypeName = "DateOnly")]
        public DateOnly EndDate { get; set; }

        [Column("Vote", TypeName = "Integer")]
        public int Vote { get; set; }

        [Column("Avatar", TypeName = "Varchar(100)")]
        public string Avatar { get; set; }

        [Column("Status", TypeName = "Integer")]
        public int Status { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
