using EcoBin_Auth_Service.Extensions;
using EcoBin_GateWay_Service.Extension.Helpers;
using EcoBin_GateWay_Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.InjectService();
builder.Services.AddControllers();
builder.Services.ConfigureAuthentication(builder.Configuration);
builder.Services.ConfigureAuthorization();
builder.Services.ConfigureSwaggerGen();
builder.Services.AddTransient<HttpClientHeaderHandler>();
builder.Services.AddHttpClient<HttpClientBase>()
    .AddHttpMessageHandler<HttpClientHeaderHandler>();

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