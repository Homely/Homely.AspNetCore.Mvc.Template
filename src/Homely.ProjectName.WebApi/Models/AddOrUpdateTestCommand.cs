using FluentValidation;

namespace Homely.ProjectName.WebApi.Models
{
    public class AddOrUpdateTestCommand
    {
        public string Name { get; set; }
    }

    public class AddOrUpdateTestCommandValidator : AbstractValidator<AddOrUpdateTestCommand>
    {
        public AddOrUpdateTestCommandValidator()
        {
            RuleFor(model => model.Name).NotEmpty();
        }
    }
}