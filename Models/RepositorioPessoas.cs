namespace projetoProva.Models
{

    public static class RepositorioPessoas
    {
        private static List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa {
                Id = 1,
                Nome = "Matheus Nunes",
                DataDeNascimento = DateTime.Parse("02/12/2002"),
                Email = "matheusnunes808@gmail.com",
                Telefone = "+55 (11) 98989-8989"
            },

            new Pessoa {
                Id = 2,
                Nome = "Antônio Oliveira",
                DataDeNascimento = DateTime.Parse("08/04/1987"),
                Email = "antoniooliveira777@gmail.com",
                Telefone = "+55 (11) 94444-3322"
            }
        };
        public static IEnumerable<Pessoa> Pessoas => pessoas;

        public static int AdicionarPessoa(Pessoa pessoa)
        {
            pessoa.Id = pessoas.Max(n => n.Id) + 1;
            pessoas.Add(pessoa);
            
            return pessoa.Id;
        }

        public static void RemoverPessoa(int Id)
        {
            var pessoa = pessoas.FirstOrDefault(n => n.Id == Id);

            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
            }
        }
    }
}