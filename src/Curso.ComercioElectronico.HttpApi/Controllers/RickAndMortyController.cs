using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Web;




namespace Curso.ComercioElectronico.HttpApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RickAndMorty : ControllerBase
{
    [HttpGet]
    public async IEnumerable<RickAndMorty> Rick()
    {
        var client = new HttpClient();
        var json = await client.GetStringAsync("https://rickandmortyapi.com/api/character");
        var lista = JsonConvert.DeserializeObject<List<RickAndMorty>>(json);
        
        return lista;
    }
        
}
