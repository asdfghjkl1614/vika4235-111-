//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tugashova4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HospitalEntities : DbContext
    {
        private static HospitalEntities _context;
        public HospitalEntities()
            : base("name=HospitalEntities")
        {
        }


        public static HospitalEntities GetContext()
        {
            if (_context == null)
                _context = new HospitalEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<Sick> Sick { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ward> Ward { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
    }
}
