namespace Capitulo02.model
{
    public class Instituicao
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        private Departamento[] Departamentos { get; } = new Departamento[10];

        private int quantidadeDepartamentos = 0;

        public void RegistrarDepartamento(Departamento d)
        {
            if (quantidadeDepartamentos < 10)
                Departamentos[quantidadeDepartamentos++] = d;
        }

        public int ObterQuantidadeDeparetamentos()
        {
            return quantidadeDepartamentos;
        }

        public Departamento DepartamentoPorIndice(int indice)
        {
            return Departamentos[indice];
        }
    }
}
