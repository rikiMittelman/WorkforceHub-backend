using workforceHub_backend.Core.Repositories;
using workforceHub_backend.Data.Repositories;
using workforceHub_backend.Data;
using workforceHub_backend.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<EmployeeRoleService>();
builder.Services.AddScoped<RoleService>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeRoleRepository, EmployeeRoleRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();

builder.Services.AddDbContext<DataContext>();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactClientPolicy",
        builder =>
        {
            builder.WithOrigins("http://localhost:5173")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.UseCors("ReactClientPolicy");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();