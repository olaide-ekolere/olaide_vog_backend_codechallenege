using System.ComponentModel.DataAnnotations;
namespace VogCodeChallenge.Domain.Common
{
    public abstract class BaseEntity
    {
        [Required]
        public int Id { get; set; }
    }
}
