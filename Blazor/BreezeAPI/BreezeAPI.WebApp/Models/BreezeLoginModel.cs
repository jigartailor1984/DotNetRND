using System.ComponentModel.DataAnnotations;

namespace BreezeAPI.WebApp.Models
{
    public class BreezeLoginModel
    {
        [Required]
        public string AppKey {  get; set; }
        
        [Required]
        public string SecretKey {  get; set; }
    }
}
