namespace PontoMais.Models;

public class DocumentosModels{ //Listar

 public int id { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public string? number { get; set; }
        public DocumentType? document_type { get; set; }
        public string? issuing_agency { get; set; }
        public string? expedition_date { get; set; }
        public string? expiration_date { get; set; }
        public string? first_expedition_date { get; set; }
        public State? state { get; set; }
        public DriverLicenseCategory? driver_license_category { get; set; }
        public object? serial_number { get; set; }
        public string? observation { get; set; }
    }

    public class DocumentType
    {
        public int id { get; set; }
        public string? name { get; set; }
    }

    public class DriverLicenseCategory
    {
        public int id { get; set; }
        public string? name { get; set; }
    }

    public class Dados
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class Document
    {
        public List<Document>? documents { get; set; }
        public Meta? meta { get; set; }
    }

    public class State
    {
        public string? id { get; set; }
        public string? name { get; set; }
    }


