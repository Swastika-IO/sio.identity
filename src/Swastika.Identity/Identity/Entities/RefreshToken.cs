using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Swastika.Identity.Entities
{
    public class RefreshToken
    {
        [Key]
        public string Id { get; set; }
        public string ClientId { get; set; }
        public DateTime IssuedUtc { get; set; }
        public DateTime ExpiresUtc { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
