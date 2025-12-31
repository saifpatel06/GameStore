using FluentValidation;
using GameStore.Api.Dtos;

namespace GameStore.Api.Validators;

public class CreateGameDtoValidator : AbstractValidator<CreateGameDto>
{
    public CreateGameDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.GenreId)
            .NotEmpty();

        RuleFor(x => x.Price)
            .GreaterThan(0)
            .InclusiveBetween(1, 100);

        RuleFor(x => x.ReleaseDate)
            .NotEqual(default(DateOnly));
    }
    
}
