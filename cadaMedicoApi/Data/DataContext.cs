using System.Collections.Generic;
using cadaMedicoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace cadaMedicoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<MedicoModels> Medicos{get; set;}
        public DbSet<CidadeModels> Cidades{get; set;}
        public DbSet<EspecialidadeModels> Especialidades{get; set;}
        public DbSet<UsuarioModels> Usuarios {get; set;}
        public DbSet<PrivilegioModels> Privilegios {get; set;}

        protected override void OnModelCreating(ModelBuilder builder){
            
            builder.Entity<MedicoModels>()
                .HasData(new List<MedicoModels>(){
                    new MedicoModels(1, "SEBASTIÃO"	, "23478"	,"19-3241-7893"	),
                    new MedicoModels(2, "PEDRO"		, "6534"	,"43-3467-6578"	),
                    new MedicoModels(3, "MARIANA"	, "87634"	,"11-5614-8794"	),
                    new MedicoModels(4, "LUIZ"		, "223412"  ,"43-3256-3456"	),
                    new MedicoModels(5, "JULIA"		, "84763"	,"43-3598-9875"	),
                    new MedicoModels(6, "JORGIM"	, "87623"	,"21-1238-9873"	)
            });

            builder.Entity<CidadeModels>()
                .HasData(new List<CidadeModels>(){
                    new CidadeModels(1, "Londrina",     "PR"),
                    new CidadeModels(2, "Cambé",        "PR"),
                    new CidadeModels(3, "Rolandia",     "PR"),
                    new CidadeModels(4, "Jataizinho",   "PR"),
                    new CidadeModels(5, "São Paulo",    "SP"),
                    new CidadeModels(6, "Rio de Janeiro","RJ"),
            });

            builder.Entity<EspecialidadeModels>()
                .HasData(new List<EspecialidadeModels>(){
                    new EspecialidadeModels(1,"CLINICO GERAL"),
                    new EspecialidadeModels(2,"PSIQUIATRA"),
                    new EspecialidadeModels(3,"OFTALMOLOGISTA"),
                    new EspecialidadeModels(4,"PODÓLOGO"),
                    new EspecialidadeModels(5,"OBSTÉTRA"),
                    new EspecialidadeModels(6,"UROLOGISTA")
            });

            builder.Entity<UsuarioModels>()
                .HasData(new List<UsuarioModels>(){
                    new UsuarioModels(1, "ROBERTO"			  ,"ROBERTO01"	, "SENHA123",2),
                    new UsuarioModels(2, "JOÃO"				  ,"JOAO01"	    ,"SENHA123"	,5),
                    new UsuarioModels(3, "MARIA ANTONIETA"	  ,"ANTONIETA01","SENHA123"	,2),
                    new UsuarioModels(4, "HENRIQUE"			  ,"HENRIQUE01" ,"SENHA123"	,5),
                    new UsuarioModels(5, "FERNANDO"			  ,"FERNANDO01" ,"SENHA123"	,6),
                    new UsuarioModels(6, "WALTER"			  ,"WALTER01"	, "SENHA123",4)
            });


            builder.Entity<PrivilegioModels>()
                .HasData(new List<PrivilegioModels>(){
                    new PrivilegioModels(1,"MASTER"),
                    new PrivilegioModels(2,"ADM"),
                    new PrivilegioModels(3,"USER"),
                    new PrivilegioModels(4,"USERMEDICO")
            });

            builder.Entity<MedicoCidade>().HasKey(MC => new {MC.MedicoId, MC.CidadeId});

            builder.Entity<MedicoCidade>().HasData(new List<MedicoCidade>(){
                new MedicoCidade() {MedicoId = 1, CidadeId = 1},
                new MedicoCidade() {MedicoId = 2, CidadeId = 2},
                new MedicoCidade() {MedicoId = 3, CidadeId = 3},
                new MedicoCidade() {MedicoId = 4, CidadeId = 4},
                new MedicoCidade() {MedicoId = 5, CidadeId = 5},
            });

            builder.Entity<MedicoEspecilidade>().HasKey(MC => new {MC.MedicoId, MC.EspecialidadeId});

            builder.Entity<MedicoEspecilidade>().HasData(new List<MedicoEspecilidade>(){
                new MedicoEspecilidade() {MedicoId = 1, EspecialidadeId = 1},
                new MedicoEspecilidade() {MedicoId = 2, EspecialidadeId = 2},
                new MedicoEspecilidade() {MedicoId = 3, EspecialidadeId = 3},
                new MedicoEspecilidade() {MedicoId = 4, EspecialidadeId = 4},
                new MedicoEspecilidade() {MedicoId = 5, EspecialidadeId = 5},
            });
        }
    }
}
    
