
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VogCodeChallenge.Domain.Common;
namespace VogCodeChallenge.Domain.Entities
{
    public class Department : BaseEntity
    {
        [Required, StringLength(150, MinimumLength = 4,
                                ErrorMessage = "Name cannot be longer than 150 characters")]
        public string Name { get; set; }

        [Required, StringLength(150, MinimumLength = 4,
                                ErrorMessage = "Address cannot be longer than 150 characters")]
        public string Address { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
