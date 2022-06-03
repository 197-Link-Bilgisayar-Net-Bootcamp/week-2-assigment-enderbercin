using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWorkCrud.API.Data.Entities
{
    [Table("Users")]
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public string Email { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
    }
}
