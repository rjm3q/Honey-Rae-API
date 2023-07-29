using HoneyRaesAPI.Models;
List<Customer> customers = new List<Customer> { };
List<Employee> employees = new List<Employee> { };
List<ServiceTicket> serviceTickets = new List<ServiceTicket> { }; = new List<HoneyRaesAPI.Models.ServiceTicket> { };

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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


app.MapGet("/servicetickets", () =>
{
    return serviceTickets;
});

app.MapGet("/servicetickets/{id}", (int id) =>
{
    return serviceTickets.FirstOrDefault(st => st.Id == id);
});

app.Run();