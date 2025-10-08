using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace BlazorCRUDWebApp.Models
{
    [Table("people")]
    public class Employee
    {

        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = String.Empty;

        [Column("gender")]
        public string Gender { get; set; } = String.Empty;

        [Column("position")]
        public string Position { get; set; } = String.Empty;

        [Column("birthdate")]
        public int Birthdate { get; set; }

        [Column("salary")]
        public double Salary { get; set; }
    }
}
