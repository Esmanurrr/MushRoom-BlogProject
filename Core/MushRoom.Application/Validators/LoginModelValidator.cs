using FluentValidation;
using MushRoom.API.Models;

namespace MushRoom.API.Validators
{
    public class LoginModelValidator: AbstractValidator<LoginModel>
    {
        public LoginModelValidator()
        {
            RuleFor(s => s.Username)
           .NotEmpty().WithMessage("Username is required.");
           
            RuleFor(s => s.Password)
               .NotEmpty().WithMessage("Password is required.");
        }
    }
}
