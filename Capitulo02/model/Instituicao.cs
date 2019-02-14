namespace Capitulo02.model
{
    class Instituicao
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Departamento[] Departamentos { get; } = new Departamento[10];
    }
}
