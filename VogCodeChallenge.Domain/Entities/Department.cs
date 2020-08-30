
using System.Collections.Generic;
using VogCodeChallenge.Domain.Common;
namespace VogCodeChallenge.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
