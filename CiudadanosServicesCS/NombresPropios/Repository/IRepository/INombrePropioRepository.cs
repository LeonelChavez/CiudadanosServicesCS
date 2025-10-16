using CiudadanosServicesCS.NombresPropios.Models;

namespace CiudadanosServicesCS.NombresPropios.Repository.IRepository;

public interface INombrePropioRepository
{
    ICollection<NombrePropioEntity> GetAll();
    NombrePropioEntity GetById(int id);
    bool NombrePropioExists(int id);
    bool NombrePropioExists(string NombrePropio);

    bool Create(NombrePropioEntity entity);
    bool Update(NombrePropioEntity entity);
    bool Delete(NombrePropioEntity entity);

    bool Save();
}
