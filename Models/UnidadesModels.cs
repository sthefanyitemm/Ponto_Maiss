namespace PontoMais.Models;

public class UnidadesModels{

   public class BusinessUnit
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
        public List<BusinessUnit>? business_units { get; set; }
        public Meta? meta { get; set; }
    }


}

//Detalhar exemplo de sucesso

  public class BusinessUnit
    {
        public int id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? corporate_name { get; set; }
        public bool is_employer { get; set; }
        public PersonType? person_type { get; set; }
    }

    public class DadosUnidades
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class PersonType
    {
        public int id { get; set; }
        public string? name { get; set; }
    }

    public class EnderecamentoUnidade
    {
        public BusinessUnit? business_unit { get; set; }
        public Meta? meta { get; set; }
    }
