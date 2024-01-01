using GetContractDetails;
using GetContractDetails.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<ContractDetail>();
app.MapGet("/", () => "YOU DO NOT KNOW HOW THIS WORK CONTACT THE DEV TEAM.");

app.Run();
