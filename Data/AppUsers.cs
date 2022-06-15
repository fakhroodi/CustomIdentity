using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.Data
{
    public class AppUsers :IdentityUser
    {
        public int UserId { get; set; }
        [MaxLength(50)]
        public string? FirstName { get; set; }  
        [MaxLength(50)]
        public string? LastName { get; set; }    
        public byte PostId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(8, MinimumLength =8)]
        public string? ExpireDate { get; set; } 
        [StringLength(1000)]
        public string? AdminComment { get; set; }
        public bool IsEnable { get; set; }
        public bool  LoginSms { get; set; }
        public string? ImageName { get; set; }


    }
}
