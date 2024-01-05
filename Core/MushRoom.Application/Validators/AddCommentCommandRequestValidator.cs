using FluentValidation;
using MushRoom.Application.Features.Commands.CommentCommands.Add;

namespace MushRoom.API.Validators
{
    public class AddCommentCommandRequestValidator:AbstractValidator<AddCommentCommandRequest>
    {
        public AddCommentCommandRequestValidator()
        {
            RuleFor(s => s.Content)
                .NotEmpty().WithMessage("Content is required.");
            RuleFor(s => s.AppUserId)
                .NotEmpty().WithMessage("AppUserId is required.");
            RuleFor(s => s.BlogPostId)
                .NotEmpty().WithMessage("BlogPostId is required.");

        }
    }
}
