using Microsoft.EntityFrameworkCore;
using SwatPortal.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SwatPortal.Data;

namespace SwatPortal.Service
{
    public class CiudadesService
    {
        private readonly ApplicationDbContext _dbContext;

        public CiudadesService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       

        public async Task<List<Ciudades>> GetCiudadess()
        {
            return await _dbContext.Ciudades.ToListAsync();
        }
        public async Task<bool> CreateCiudades(Ciudades Ciudades)
        {
            _dbContext.Add(Ciudades);
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }

        }
        public async Task<Ciudades> SingleCiudades(int IdCiudades)
        {
            return await _dbContext.Ciudades.FindAsync(IdCiudades);
        }
        public async Task<bool> EditCiudades(int IdCiudades, Ciudades Ciudades)
        {
            if (IdCiudades != Ciudades.IdCiudad)
            {
                return false;
            }

            _dbContext.Entry(Ciudades).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteCiudades(int IdCiudades)
        {
            var patient = await _dbContext.Ciudades.FindAsync(IdCiudades);
            if (patient == null)
            {
                return false;
            }

            _dbContext.Ciudades.Remove(patient);
            await _dbContext.SaveChangesAsync();
            return true;
        }

      }
}
