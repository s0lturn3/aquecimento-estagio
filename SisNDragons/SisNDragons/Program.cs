using SisNDragons.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Esta linha permite que o meu Controller use a mesma inst�ncia da minha classe de Services sempre, sem recriar uma nova a cada requisi��o
builder.Services.AddSingleton<BestiarioServices>();
builder.Services.AddSingleton<PersonagemServices>();

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
