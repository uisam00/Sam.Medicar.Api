using Sam.Medicar.Domain.Entities.Shared;

namespace Sam.Medicar.Domain.Entities
{
    public class Especialidade : Entity
    {
        public string Nome { get; set; }
        public ICollection<Medico> Medicos { get; private set; }
        public Especialidade() {
            Nome = "";
            Medicos = new List<Medico>();
        }
        public Especialidade(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Medicos = new List<Medico>();

        }
    }
}
