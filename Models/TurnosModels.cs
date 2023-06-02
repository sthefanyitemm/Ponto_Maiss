namespace PontoMais.Models;

public class TurnosModels{ //Turnos Listar

  public class Meta
    {
        public int now { get; set; }
        public string? ip { get; set; }
        public int count { get; set; }
    }

    public class Root
    {
        public List<Shift>? shifts { get; set; }
        public Meta? meta { get; set; }
    }

    public class Shift
    {
        public int id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public int shift_type { get; set; }
        public bool advanced { get; set; }
        public bool flexible { get; set; }
        public bool flexible_interval { get; set; }
        public bool auto_interval { get; set; }
        public bool without_holidays { get; set; }
        public object? holiday { get; set; }
    }


}


    public class DadoTrunoErro
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class Enderecamento
    {
        public string? error { get; set; }
        public Meta? meta { get; set; }
    }

//Turno Listar dias
     public class Day
    {
        public int id { get; set; }
        public List<string>? periods { get; set; }
        public string? description { get; set; }
    }

    public class DadosTurno
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class Enderecamentos
    {
        public List<Day>? days { get; set; }
        public Meta? meta { get; set; }
    }