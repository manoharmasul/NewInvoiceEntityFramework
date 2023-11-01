using Microsoft.EntityFrameworkCore;
using NewDemoInvoiceApplication.Context;
using NewDemoInvoiceApplication.Repository.Interface;
using NewDemoInvoiceApplication.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyContext"));
});


builder.Services.AddScoped<IInvoiceAsycRepositoryAsync, InvoiceItemAsyncRepository>();
builder.Services.AddScoped<ICommonDropdownAsyncRepository, CommonDropdownAsyncRepository>();
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
