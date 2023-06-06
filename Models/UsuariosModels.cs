using System.Text.Json.Serialization;

namespace PontoMais.Models;

public class UsuariosModels{ //Grupo de acesso-> Listar
    public class Group
    {
        public int id { get; set; }
        public string? name { get; set; }
    }

    public class Meta
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class Root
    {
        public List<Group>? groups { get; set; }
        public Meta? meta { get; set; }
    }


}


//Unidades DetalharSucesso

    public class UnidadesDetalhar
    {
        public int id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? corporate_name { get; set; }
        public bool is_employer { get; set; }
        public PersonType? person_type { get; set; }
    }

    public class DadosDetalhar
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class TipoPessoa
    {
        public int id { get; set; }
        public string? name { get; set; }
    }

    public class EnderecamentoEmpre
    {
        public BusinessUnit? business_unit { get; set; }
        public Meta? meta { get; set; }
    }

    //Detalhamento erro msg

        public class Dadoerrousers
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class EndeUsers
    {
        public string? error { get; set; }
        public Meta? meta { get; set; }
    }

