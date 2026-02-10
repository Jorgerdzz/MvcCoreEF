using Microsoft.EntityFrameworkCore;
using MvcCoreEF.Data;
using MvcCoreEF.Models;

namespace MvcCoreEF.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return await consulta.ToListAsync();
        }

        public async Task<Hospital> FindHospitalByIdAsync(int idHospital)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == idHospital
                           select datos;
            //if(consulta.Count() == 0)
            //{
            //    return null;
            //}
            //else
            //{
            //    return await consulta.FirstAsync();
            //}
            return await consulta.FirstOrDefaultAsync();
        }

    }
}
