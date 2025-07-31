using Microsoft.Data.SqlClient;
using WebAPI_ECOMMERCE.Helpers;

var builder = WebApplication.CreateBuilder(args);

var resultConn = DataBaseHelper.ObterConnectionString();

if (!resultConn.Sucesso)
{
    Console.WriteLine(resultConn.Mensagem);
    return;
}
var connectionString = resultConn.Dados;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
