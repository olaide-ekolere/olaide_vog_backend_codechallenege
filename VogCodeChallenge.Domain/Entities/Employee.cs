
using System.ComponentModel.DataAnnotations;
using VogCodeChallenge.Domain.Common;
namespace VogCodeChallenge.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
