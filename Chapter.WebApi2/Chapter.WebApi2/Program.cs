using Chapter.WebApi2.Contexts;
using Chapter.WebApi2.Interfaces;
using Chapter.WebApi2.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<ChapterContext, ChapterContext>();

builder.Services.AddTransient<LivroRepository, LivroRepository>();

// Interface não pode ser instanciada,pois a lógica está no repositorio. Assim é necessario fazer o link da interface com a IUsuarioRepository, para quando for chamado, saber onde está a lógica que irá executar.
// IUsuarioRepository é a interface, UsuarioRepository é a classe.
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();

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
