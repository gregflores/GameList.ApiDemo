using GameListApi.Data;
using GameListApi.Endpoints;
using GameListApi.EndPoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");

// builder.Services.AddSqlServer<GameStoreContext>(connString);
builder.Services.AddDbContext<GameStoreContext>(options => options.UseSqlServer(connString));

var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndpoints();
await app.MigrateDbAsync();
app.Run();
