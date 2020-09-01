using System;
using System.ComponentModel.DataAnnotations;
namespace VogCodeChallenge.API.Domain.Common
{
    public abstract class BaseEntity
    {
        [Required]
        public int Id { get; set; }
    }
}
