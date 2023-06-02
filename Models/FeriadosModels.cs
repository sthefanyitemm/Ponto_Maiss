namespace PontoMais.Models;
 public class FeriadoModel //Feriados -> Listar
    {
        public int id { get; set; }
        public string? name { get; set; }
        public bool @fixed { get; set; }
        public string? date { get; set; }
        public object? business_unit { get; set; }
    }

    public class Cord
    {
        public int now { get; set; }
        public string? ip { get; set; }
        public int count { get; set; }
    }

    public class Rota
    {
        public List<FeriadoModel>? holidays { get; set; }
        public Meta? meta { get; set; }
    }

//Detalhar sucess

   public class Holiday
    {
        public int id { get; set; }
        public string? name { get; set; }
        public bool @fixed { get; set; }
        public string? date { get; set; }
        public object? business_unit { get; set; }
    }

    public class Dado
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class Endereco
    {
        public Holiday? holiday { get; set; }
        public Meta? meta { get; set; }
    }

//Detalhar erro msg

    public class DadoErro
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class EndErro
    {
        public string? error { get; set; }
        public Meta? meta { get; set; }
    }


