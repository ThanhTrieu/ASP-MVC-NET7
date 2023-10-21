using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tranning.DBContext
{
    public class TrainerTestRoles
    {
        [Key]
        public int Id { get; set; }

        [Column("NameRole", TypeName = "Varchar(50)")]
        public string NameRole { get; set; }

        [Column("Description", TypeName = "Varchar(100)")]
        public string Description { get; set; }

        [Column("Status", TypeName = "Integer")]
        public int Status { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
