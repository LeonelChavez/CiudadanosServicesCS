using System;
using CiudadanosServicesCS.NombresPropios.Data;
using CiudadanosServicesCS.NombresPropios.Models;
using CiudadanosServicesCS.NombresPropios.Repository.IRepository;

namespace CiudadanosServicesCS.NombresPropios.Repository;

public class NombrePropioRepository : INombrePropioRepository
{
    private readonly ApplicationDbContext _db;

    public NombrePropioRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public bool Create(NombrePropioEntity entity)
    {
        entity.FechaCreacion = DateTime.Now;
        _db.NombresPropios.Add(entity);
        return Save();
    }

    public bool Delete(NombrePropioEntity entity)
    {
        _db.NombresPropios.Remove(entity);
        return Save();
    }

    public ICollection<NombrePropioEntity> GetAll()
    {
        return _db.NombresPropios.ToList();
    }

    public NombrePropioEntity GetById(int id)
    {
        return _db.NombresPropios.FirstOrDefault(np => np.Id == id) ?? throw new InvalidOperationException($"Nombre propio no encontrado con el ID {id} no existe.");
    }

    public bool NombrePropioExists(int id)
    {
        return _db.NombresPropios.Any(np => np.Id == id);
    }

    public bool NombrePropioExists(string NombrePropio)
    {
        return _db.NombresPropios.Any(np => np.NombrePropio.ToLower().Trim() == NombrePropio.ToLower().Trim());
    }

    public bool Save()
    {
        return _db.SaveChanges() >= 0 ? true : false;
    }

    public bool Update(NombrePropioEntity entity)
    {
        entity.FechaCreacion = DateTime.Now;
        _db.NombresPropios.Update(entity);
        return Save();
    }
}
