using System.ComponentModel.DataAnnotations;

namespace JPBlazor.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}