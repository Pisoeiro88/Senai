﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cadaMedicoApi.Data;

namespace cadaMedicoApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("cadaMedicoApi.Models.CidadeModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estado = "PR",
                            Nome = "Londrina"
                        },
                        new
                        {
                            Id = 2,
                            Estado = "PR",
                            Nome = "Cambé"
                        },
                        new
                        {
                            Id = 3,
                            Estado = "PR",
                            Nome = "Rolandia"
                        },
                        new
                        {
                            Id = 4,
                            Estado = "PR",
                            Nome = "Jataizinho"
                        },
                        new
                        {
                            Id = 5,
                            Estado = "SP",
                            Nome = "São Paulo"
                        },
                        new
                        {
                            Id = 6,
                            Estado = "RJ",
                            Nome = "Rio de Janeiro"
                        });
                });

            modelBuilder.Entity("cadaMedicoApi.Models.EspecialidadeModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "CLINICO GERAL"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "PSIQUIATRA"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "OFTALMOLOGISTA"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "PODÓLOGO"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "OBSTÉTRA"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "UROLOGISTA"
                        });
                });

            modelBuilder.Entity("cadaMedicoApi.Models.MedicoCidade", b =>
                {
                    b.Property<int>("MedicoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CidadeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MedicoId", "CidadeId");

                    b.HasIndex("CidadeId");

                    b.ToTable("MedicoCidade");

                    b.HasData(
                        new
                        {
                            MedicoId = 1,
                            CidadeId = 1
                        },
                        new
                        {
                            MedicoId = 2,
                            CidadeId = 2
                        },
                        new
                        {
                            MedicoId = 3,
                            CidadeId = 3
                        },
                        new
                        {
                            MedicoId = 4,
                            CidadeId = 4
                        },
                        new
                        {
                            MedicoId = 5,
                            CidadeId = 5
                        });
                });

            modelBuilder.Entity("cadaMedicoApi.Models.MedicoEspecilidade", b =>
                {
                    b.Property<int>("MedicoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MedicoId", "EspecialidadeId");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("MedicoEspecilidade");

                    b.HasData(
                        new
                        {
                            MedicoId = 1,
                            EspecialidadeId = 1
                        },
                        new
                        {
                            MedicoId = 2,
                            EspecialidadeId = 2
                        },
                        new
                        {
                            MedicoId = 3,
                            EspecialidadeId = 3
                        },
                        new
                        {
                            MedicoId = 4,
                            EspecialidadeId = 4
                        },
                        new
                        {
                            MedicoId = 5,
                            EspecialidadeId = 5
                        });
                });

            modelBuilder.Entity("cadaMedicoApi.Models.MedicoModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Crm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Medicos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Crm = "23478",
                            Nome = "SEBASTIÃO",
                            Telefone = "19-3241-7893"
                        },
                        new
                        {
                            Id = 2,
                            Crm = "6534",
                            Nome = "PEDRO",
                            Telefone = "43-3467-6578"
                        },
                        new
                        {
                            Id = 3,
                            Crm = "87634",
                            Nome = "MARIANA",
                            Telefone = "11-5614-8794"
                        },
                        new
                        {
                            Id = 4,
                            Crm = "223412",
                            Nome = "LUIZ",
                            Telefone = "43-3256-3456"
                        },
                        new
                        {
                            Id = 5,
                            Crm = "84763",
                            Nome = "JULIA",
                            Telefone = "43-3598-9875"
                        },
                        new
                        {
                            Id = 6,
                            Crm = "87623",
                            Nome = "JORGIM",
                            Telefone = "21-1238-9873"
                        });
                });

            modelBuilder.Entity("cadaMedicoApi.Models.PrivilegioModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Privilegios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "MASTER"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "ADM"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "USER"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "USERMEDICO"
                        });
                });

            modelBuilder.Entity("cadaMedicoApi.Models.UsuarioModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("PrivilegioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "ROBERTO01",
                            Nome = "ROBERTO",
                            PrivilegioId = 2,
                            Senha = "SENHA123"
                        },
                        new
                        {
                            Id = 2,
                            Login = "JOAO01",
                            Nome = "JOÃO",
                            PrivilegioId = 5,
                            Senha = "SENHA123"
                        },
                        new
                        {
                            Id = 3,
                            Login = "ANTONIETA01",
                            Nome = "MARIA ANTONIETA",
                            PrivilegioId = 2,
                            Senha = "SENHA123"
                        },
                        new
                        {
                            Id = 4,
                            Login = "HENRIQUE01",
                            Nome = "HENRIQUE",
                            PrivilegioId = 5,
                            Senha = "SENHA123"
                        },
                        new
                        {
                            Id = 5,
                            Login = "FERNANDO01",
                            Nome = "FERNANDO",
                            PrivilegioId = 6,
                            Senha = "SENHA123"
                        },
                        new
                        {
                            Id = 6,
                            Login = "WALTER01",
                            Nome = "WALTER",
                            PrivilegioId = 4,
                            Senha = "SENHA123"
                        });
                });

            modelBuilder.Entity("cadaMedicoApi.Models.MedicoCidade", b =>
                {
                    b.HasOne("cadaMedicoApi.Models.CidadeModels", "Cidade")
                        .WithMany("MedicoCidade")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cadaMedicoApi.Models.MedicoModels", "Medico")
                        .WithMany("MedicoCidade")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("cadaMedicoApi.Models.MedicoEspecilidade", b =>
                {
                    b.HasOne("cadaMedicoApi.Models.EspecialidadeModels", "Especialidade")
                        .WithMany("MedicoEspecialidade")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cadaMedicoApi.Models.MedicoModels", "Medico")
                        .WithMany("MedicoEspecialidade")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("cadaMedicoApi.Models.CidadeModels", b =>
                {
                    b.Navigation("MedicoCidade");
                });

            modelBuilder.Entity("cadaMedicoApi.Models.EspecialidadeModels", b =>
                {
                    b.Navigation("MedicoEspecialidade");
                });

            modelBuilder.Entity("cadaMedicoApi.Models.MedicoModels", b =>
                {
                    b.Navigation("MedicoCidade");

                    b.Navigation("MedicoEspecialidade");
                });
#pragma warning restore 612, 618
        }
    }
}
