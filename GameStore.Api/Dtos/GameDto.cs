namespace GameStore.Api.Dtos;

public record GameDto(
    int Id,
    string Name,
    String Genre,
    Decimal Price,
    DateOnly ReleaseDate
);
