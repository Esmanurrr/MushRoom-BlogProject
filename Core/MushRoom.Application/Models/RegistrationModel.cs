using System.ComponentModel.DataAnnotations;

namespace MushRoom.API.Models
{
    public class RegistrationModel
    {      
        public string Username { get; set; }  
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }     
        public string Password { get; set; }
    }
}

