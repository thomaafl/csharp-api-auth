using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.wwwapi.Models
{

    public enum Role { User, Admin }
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("username")]
        public string Username { get; set; }
        [Column("passwordhash")]
        public string PasswordHash { get; set; }    

        public Role Role { get; set; }
    }
}
