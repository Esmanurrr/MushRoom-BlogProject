using FluentValidation;
using MushRoom.API.Models;

namespace MushRoom.API.Validators
{
    public class RegistrationModelValidator:AbstractValidator<RegistrationModel>
    {
        public RegistrationModelValidator()
        {
            RuleFor(s => s.Username)
                .NotEmpty().WithMessage("Username is required.");
            
            RuleFor(s => s.FirstName)
                .NotEmpty().WithMessage("First name is required.");
            
            RuleFor(s => s.SurName)
                .NotEmpty().WithMessage("Surname is required.");
            
            RuleFor(s => s.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email is not valid.");
            
            RuleFor(s => s.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");
            
        }
    }
}
