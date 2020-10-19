using Microsoft.EntityFrameworkCore;
using SwatPortal.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SwatPortal.Data;

namespace SwatPortal.Service
{
    public class ContactoService
    {
        private readonly ApplicationDbContext _dbContext;
        public ContactoService(ApplicationDbContext dbContext)
        {
            _dbContext= dbContext;
        }

        public async Task<bool> DeleteContacto(int Id_Contacto)
        {
            var patient = await _dbContext.Contacto.FindAsync(Id_Contacto);

            _dbContext.Contacto.Remove(patient);

            return await _dbContext.SaveChangesAsync() > 0;

        }

        public async Task<List<Contacto>> GetAllContactos()
        {
            return await _dbContext.Contacto.AsNoTracking().ToListAsync();
        }

        public async Task<Contacto> GetContactoDetails(int Id_Contacto)
        {
            return await _dbContext.Contacto.FindAsync(Id_Contacto);
        }

        public async Task<bool> InsertContacto(Contacto Contacto)
        {
            _dbContext.Contacto.Add(Contacto);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveContacto(Contacto contacto)
        {
            if (contacto.IdContacto != 0)
                return await UpdateContacto(contacto);
            else
                return await InsertContacto(contacto);
        }

        public async Task<bool> UpdateContacto(Contacto Contacto)
        {
            _dbContext.Entry(Contacto).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() > 0;
        }


    }
}
