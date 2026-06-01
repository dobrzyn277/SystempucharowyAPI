
using Microsoft.EntityFrameworkCore;
using SystempucharowyAPI.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=tournament.db"));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();