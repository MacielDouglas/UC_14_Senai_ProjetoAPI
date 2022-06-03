using Chapter.WebApi2.Contexts;
using Chapter.WebApi2.Interfaces;
using Chapter.WebApi2.Repositories;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Adicionando o Cors (para o controle da APi)
builder.Services.AddCors( options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = "JwtBearer";
    options.DefaultAuthenticateScheme = "JwtBearer";
}).AddJwtBearer("JwtBearer", options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("chapter-chave-autenticacao")),
        ClockSkew = TimeSpan.FromMinutes(60),
        ValidIssuer = "chapter.webapi",
        ValidAudience = "chapter.webapi"
    };
});

builder.Services.AddScoped<ChapterContext, ChapterContext>();

builder.Services.AddTransient<LivroRepository, LivroRepository>();

// Interface n�o pode ser instanciada,pois a l�gica est� no repositorio. Assim � necessario fazer o link da interface com a IUsuarioRepository, para quando for chamado, saber onde est� a l�gica que ir� executar.
// IUsuarioRepository � a interface, UsuarioRepository � a classe.
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

app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
