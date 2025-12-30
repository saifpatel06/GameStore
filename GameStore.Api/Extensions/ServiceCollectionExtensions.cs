using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using GameStore.Api.Validators;

namespace GameStore.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<CreateGameDtoValidator>();
        return services;
    }
}
