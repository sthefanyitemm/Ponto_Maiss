using System.Text.Json.Serialization;

namespace PontoMais.Models; //classe de banco (model) 
    public class BancoModels{ //Banco de horas -> Listar
        public int now { get; set; }
        public string? ip { get; set; }
        public int count { get; set; }
    }

    public class Root
    {
        public List<TimeBalanceEntry>? time_balance_entries { get; set; }
        public Meta? meta { get; set; }
    }

    public class TimeBalanceEntry
    {
        public int id { get; set; }
        public string? date { get; set; }
        public bool withdraw { get; set; }
        public int amount { get; set; }
        public int employee_id { get; set; }
        public string? observation { get; set; }
        public UpdatedBy? updated_by { get; set; }
    }

    public class UpdatedBy
    {
        public int id { get; set; }
        public string? name { get; set; }
    }

// Detalhar

 public class Meta
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class Rotas
    {
        public TimeBalanceEntry? time_balance_entry { get; set; }
        public Meta? meta { get; set; }
    }

    public class EntradaSaldoTempo
    {
        public int id { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public string? date { get; set; }
        public bool withdraw { get; set; }
        public int amount { get; set; }
        public int signed_amount { get; set; }
        public string? signed_amount_humanized { get; set; }
        public int work_day_id { get; set; }
        public int employee_id { get; set; }
        public UpdatedBy? updated_by { get; set; }
        public object? observation { get; set; }
    }

    public class Atualizacao
    {
        public int id { get; set; }
        public string? name { get; set; }
    }

//Detalhar erro msg

    public class DadoError
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class EndError
    {
        public string? error { get; set; }
        public Meta? meta { get; set; }
    }
       
    
    
