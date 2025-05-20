using EcoBin_Auth_Service.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureAuthentication(builder.Configuration);
builder.Services.ConfigureAuthorization();
builder.Services.ConfigureSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseCors("CorsPolicy");

app.Run();