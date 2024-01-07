using FluentValidation;
using MushRoom.Application.Features.Commands.TagCommands.Add;

namespace MushRoom.API.Validators
{
    public class AddTagCommandRequestValidator:AbstractValidator<AddTagCommandRequest>
    {
        public AddTagCommandRequestValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty().WithMessage("Name is required.");

        }
    }
}
