using GameStore.Api.Dtos;
using GameStore.Api.Endpoints;
using GameStore.Api.Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation();

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
