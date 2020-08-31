
using System.ComponentModel.DataAnnotations;
using VogCodeChallenge.Domain.Common;
namespace VogCodeChallenge.Domain.Entities
{
    public class Employee : BaseEntity
    {
        [Required, StringLength(50, MinimumLength = 4,
                                ErrorMessage = "First Name cannot be longer than 50 characters")]
        public string FirstName { get; set; }
        [Required, StringLength(50, MinimumLength = 4,
                                ErrorMessage = "Last Name cannot be longer than 50 characters")]
        public string LastName { get; set; }
        [Required, StringLength(100, MinimumLength = 4,
                                ErrorMessage = "Job Title cannot be longer than 100 characters")]
        public string JobTitle { get; set; }
        [Required, StringLength(150, MinimumLength = 4,
                                ErrorMessage = "Address cannot be longer than 150 characters")]
        public string Address { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
