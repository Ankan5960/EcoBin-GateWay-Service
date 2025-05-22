using EcoBin_Auth_Service.Extensions;
using EcoBin_GateWay_Service.Extension.Helpers;
using EcoBin_GateWay_Service.Services;
using EcoBin_GateWay_Service.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.InjectService();
builder.Services.AddControllers();
builder.Services.ConfigureSwaggerGen();
builder.Services.AddTransient<HttpClientHeaderHandler>();
builder.Services.AddHttpClient<IEcoBinAuthService, EcoBinAuthService>()
    .AddHttpMessageHandler<HttpClientHeaderHandler>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.UseCors("CorsPolicy");

app.Run();