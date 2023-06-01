using System.Text.Json.Serialization;

namespace PontoMais.Models; //classe de banco (model)
    public class BancoModels{
        [JsonPropertyName ("id")]

        public string? Id {get;set;}

        [JsonPropertyName ("date")]

        public string? Date {get;set;}

        [JsonPropertyName ("withdraw")]

        public bool withdraw{get;set;}

        [JsonPropertyName ("amount")]

        public int amount{get;set;}

        [JsonPropertyName ("employed_id")]

        public string? employed_id{get;set;}

        [JsonPropertyName ("observation")]

        public string? observation{get;set;}

       [JsonPropertyName("updated_by")]
        public string? name{get;set;}
        public int id {get;set;}
       
    }  
    
