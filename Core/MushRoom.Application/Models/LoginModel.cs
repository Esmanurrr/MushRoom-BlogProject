using System.ComponentModel.DataAnnotations;

namespace MushRoom.API.Models
{
    public class LoginModel
    {        
        public string Username { get; set; }      
        public string Password { get; set; }
    }
}