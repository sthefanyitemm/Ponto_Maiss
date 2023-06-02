using System.Text.Json.Serialization;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class City //Cidades -> Listar
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? state { get; set; }
    }

    public class Meta
    {
        public int now { get; set; }
        public string? ip { get; set; }
    }

    public class Root
    {
        public List<City>? cities { get; set; }
        public Meta? meta { get; set; }
    }
