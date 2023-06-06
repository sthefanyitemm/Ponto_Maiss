using System.Text.Json.Serialization;

namespace PontoMais.interfaces;

    
    public class IEnderecoInterface{ //classe de endereçamento
    private const string UriString = "http://localhost:2751/";
    static HttpClient client = new HttpClient();
      static async Task RunAsync()
{
    // Update port # in the following line.
    client.BaseAddress = new Uri(UriString);
    client.DefaultRequestHeaders.Accept.Clear();
  //  client.DefaultRequestHeaders.Accept.Add(
       // new MediaTypeWithQualityHeaderValue("application/json")); 

    }
}