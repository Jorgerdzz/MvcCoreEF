using Microsoft.EntityFrameworkCore;
using MvcCoreEF.Models;

namespace MvcCoreEF.Data
{
    public class HospitalContext: DbContext
    {
        //EL CONSTRUCTOR RECIBIRA LAS OPCIONES PARA ESTE CONTEXTO
        //La clase que recibe es DbContextOptions<Context>
        //ESTAS options DEBEMOS ENVIARLAS A LA CLASE BASE/SUPER DEL DbContext
        public HospitalContext(DbContextOptions<HospitalContext> options):base(options)
        {

        }

        //DEBEMOS TENER UNA COLECCION POR CADA MODEL
        //DICHA COLECCION DEBER SER DE TIPO DbSet<T>
        public DbSet<Hospital> Hospitales { get; set; }
        
    }
}
