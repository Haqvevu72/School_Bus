using Context.Contexts;
using Context.Repositories.Abstract;
using Entity.Abstract;
using Entity.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Repositories.Concrete;

public class Repository<T> : IBaseRepository<T> where T : BaseEntity, new()
{
    
    private readonly SchoolBusDB schoolBusDB;

    private readonly DbSet<T> DB_Set;

    public Repository()
    {
        schoolBusDB = new SchoolBusDB();
        DB_Set = schoolBusDB.Set<T>();
    }

    public void Add(T entity)
    {
        DB_Set.Add(entity);
    }

    public T GetById(int id)
    {
        return DB_Set.FirstOrDefault(t => t.Id == id);
    }

    public void AddRange(List<T> entities)
    {
        DB_Set.AddRange(entities);
    }

    public void Delete(T entity)
    {
        DB_Set.Remove(entity);
    }

    public List<T> GetAll()
    {
        return DB_Set.ToList();
    }

    public void SaveChanges()
    {
        schoolBusDB.SaveChanges();
    }

    public void Update(T entity)
    {
        DB_Set.Update(entity);
    }

    public List<int> GetStudentId()
    { 
        return schoolBusDB.Students.Select(t => t.Id).ToList();
    }
    public List<int> GetParentId()
    {
        return schoolBusDB.Parents.Select(t => t.Id).ToList();
    }
    public List<int> GetClassId()
    {
        return schoolBusDB.Classes.Select(t => t.Id).ToList();
    }
    public List<int> GetRideId()
    {
        return schoolBusDB.Rides.Select(t => t.Id).ToList();
    }
    public List<int> GetDriverId()
    {
        return schoolBusDB.Drivers.Select(t => t.Id).ToList();
    }
    public List<int> GetCarId()
    {
        return schoolBusDB.Cars.Select(t => t.Id).ToList();
    }






    public ObservableCollection<RideDTO> Rides()
    {
        ObservableCollection<RideDTO> rideDTO = new ObservableCollection<RideDTO>(schoolBusDB.Rides.Select(r => new RideDTO() { Id = r.Id, BusId = r.BusId , StartPoint=r.StartPoint , EndPoint=r.EndPoint,Passengers = r.Passengers}));
        return rideDTO;
    }

    public ObservableCollection<ClassDTO> Classes() 
    {
        ObservableCollection<ClassDTO> classDTO = new ObservableCollection<ClassDTO>(schoolBusDB.Classes.Select(c => new ClassDTO() { Id = c.Id, Name = c.Name }));
        return classDTO;
    }

    public List<StudentDTO> Students()
    {
        List<StudentDTO> studentDTO = new List<StudentDTO>(schoolBusDB.Students.Select(s => new StudentDTO() { Id = s.Id, Firstname = s.FirstName , Lastname = s.LastName , BusId = s.BusId , ClassId = s.ClassId , ParentId = s.ParentId }));
        return studentDTO;
    }

    public List<ParentDTO> Parents()
    {
        List<ParentDTO> parentDTO = new List<ParentDTO>(schoolBusDB.Parents.Select(p => new ParentDTO() { Id = p.Id, Firstname = p.FirstName, Lastname = p.LastName, Phone = p.Phone , Address=p.Address }));
        return parentDTO;
    }

    public List<DriverDTO> Drivers()
    {
        List<DriverDTO> driverDTO = new List<DriverDTO>(schoolBusDB.Drivers.Select(d => new DriverDTO() { Id = d.Id, Firstname = d.FirstName, Lastname = d.LastName, Phone = d.Phone, Address = d.Address }));
        return driverDTO;
    }

    public List<CarDTO> Cars()
    {
        List<CarDTO> carDTO = new List<CarDTO>(schoolBusDB.Cars.Select(c => new CarDTO() { Id = c.Id , Capacity = c.Capacity , Number = c.Number , DriverId = c.DriverId}));
        return carDTO;
    }
}
