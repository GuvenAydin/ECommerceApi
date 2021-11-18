using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApi.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(100, ErrorMessage = "Must be between 2 and 100 characters", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Must be between 2 and 100 characters", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [StringLength(200, ErrorMessage = "Must be between 5 and 200 characters", MinimumLength = 5)]
        public string Email { get; set; }

        [Phone]
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(50, ErrorMessage = "Must be between 7 and 50 characters", MinimumLength = 7)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public User()
        {

        }
    }
}

