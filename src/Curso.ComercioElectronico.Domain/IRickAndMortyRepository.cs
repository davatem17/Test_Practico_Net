namespace Curso.ComercioElectronico.Domain;
public interface IRickAndMortyRepository :  IRepository<RickAndMorty> {


    Task<bool> ExisteNombre(string nombre);

    Task<bool> ExisteNombre(string nombre, int idExcluir);


}