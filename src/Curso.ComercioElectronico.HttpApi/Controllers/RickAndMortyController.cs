using System.Net;
using Microsoft.AspNetCore.Mvc;



namespace Curso.ComercioElectronico.HttpApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RickAndMorty : ControllerBase
{
    var client = new RestClient("https://rickandmortyapi.com/api/character");
    client.Timeout = -1;
    var request = new RestRequest(Method.GET);
    IRestResponse response = Client.Execute(request);

    public object Client { get => client; set => client = value; }

    Console.WriteLine(response.Content);
}
