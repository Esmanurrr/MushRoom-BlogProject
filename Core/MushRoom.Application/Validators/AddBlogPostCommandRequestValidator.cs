using FluentValidation;
using MushRoom.Application.Features.Commands.BlogPostCommands.Add;

namespace MushRoom.API.Validators
{
    public class AddBlogPostCommandRequestValidator:AbstractValidator<AddBlogPostCommandRequest>
    {
        public AddBlogPostCommandRequestValidator()
        {
            RuleFor(s => s.Title)
                .NotEmpty().WithMessage("Title is required.");

            RuleFor(s => s.Content)
                .NotEmpty().WithMessage("Content is required.");

        }
    }
}
