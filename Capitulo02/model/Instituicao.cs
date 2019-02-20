﻿namespace ProjetoIES.model
{
    public class Instituicao
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        private Departamento[] Departamentos { get; } = new Departamento[10];

        private int quantidadeDepartamentos = 0;

        public void RegistrarDepartamento(string nome)
        {
            AddDepartamento(new Departamento() { Nome = nome });
        }

        public void RegistrarDepartamento(Departamento d)
        {
            AddDepartamento(d);
        }

        private void AddDepartamento (Departamento d)
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
