namespace Curso.ComercioElectronico.Domain;
public interface IAutorRepository :  IRepository<Autor> {


    Task<bool> ExisteNombre(string nombre);

    Task<bool> ExisteNombre(string nombre, int idExcluir);


}