using Sam.Medicar.Domain.Entities.Shared;

namespace Sam.Medicar.Domain.Entities;

public class Medico : Entity
{
    public string Nome { get; set; }
    public string Crm { get; set; }
    public string Email { get; set; }
    public int IdEspecialidade { get; set; }
    public Especialidade Especialidade { get; set; }

    public ICollection<Agenda> Agendas { get; private set; }
    
    public Medico(int id, string nome, string crm, string email, int idEspecialidade)
    {
        Id = id;
        Nome = nome;
        Crm = crm;
        Email = email;
        IdEspecialidade = idEspecialidade;
    }
}
