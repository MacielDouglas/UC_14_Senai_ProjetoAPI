namespace ExoApi.Models
{
    public class Projeto
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public Byte StatusProjeto  { get; set; }

        public DateTime DataInicio { get; set; }

        public string? Tecnologias { get; set; }

        public string? Area { get; set; }

    }
}

