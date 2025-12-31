namespace GameStore.Api.Dtos;

public record GameSummaryDto(
    int Id,
    string Name,
    String Genre,
    Decimal Price,
    DateOnly ReleaseDate
);
