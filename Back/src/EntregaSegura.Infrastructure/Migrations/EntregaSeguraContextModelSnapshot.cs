﻿// <auto-generated />
using System;
using EntregaSegura.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntregaSegura.Infrastructure.Migrations
{
    [DbContext(typeof(EntregaSeguraContext))]
    partial class EntregaSeguraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Condominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CND_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária do condomínio");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CND_BAIRRO")
                        .HasColumnOrder(12)
                        .HasComment("Bairro do endereço do condomínio");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CND_CEP")
                        .HasColumnOrder(11)
                        .HasComment("CEP do endereço do condomínio");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CND_CNPJ")
                        .HasColumnOrder(6)
                        .HasComment("CNPJ do condomínio");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CND_CIDADE")
                        .HasColumnOrder(13)
                        .HasComment("Cidade do endereço do condomínio");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CND_DATA_ATUALIZACAO")
                        .HasColumnOrder(16)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização do condomínio");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CND_DATA_CRIACAO")
                        .HasColumnOrder(15)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação do condomínio");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("CND_EMAIL")
                        .HasColumnOrder(8)
                        .HasComment("E-mail do condomínio");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(2)")
                        .HasColumnName("CND_ESTADO")
                        .HasColumnOrder(14)
                        .HasComment("Estado do endereço do condomínio");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("CND_LOGRADOURO")
                        .HasColumnOrder(9)
                        .HasComment("Logradouro do endereço do condomínio");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("CND_NOME")
                        .HasColumnOrder(5)
                        .HasComment("Nome do condomínio");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("CND_NUMERO")
                        .HasColumnOrder(10)
                        .HasComment("Número do endereço do condomínio");

                    b.Property<int>("QuantidadeAndares")
                        .HasColumnType("int")
                        .HasColumnName("CND_QTD_ANDARES")
                        .HasColumnOrder(4)
                        .HasComment("Quantidade de andares do condomínio");

                    b.Property<int>("QuantidadeBlocos")
                        .HasColumnType("int")
                        .HasColumnName("CND_QTD_BLOCOS")
                        .HasColumnOrder(3)
                        .HasComment("Quantidade de blocos do condomínio");

                    b.Property<int>("QuantidadeUnidades")
                        .HasColumnType("int")
                        .HasColumnName("CND_QTD_UNIDADES")
                        .HasColumnOrder(2)
                        .HasComment("Quantidade de unidades do condomínio");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CND_TELEFONE")
                        .HasColumnOrder(7)
                        .HasComment("Telefone do condomínio");

                    b.HasKey("Id")
                        .HasName("PK_CONDOMINIOS");

                    b.HasIndex("CNPJ")
                        .IsUnique()
                        .HasDatabaseName("IX_CONDOMINIOS_CNPJ");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("IX_CONDOMINIOS_EMAIL");

                    b.HasIndex("Nome")
                        .IsUnique()
                        .HasDatabaseName("IX_CONDOMINIOS_NOME");

                    b.ToTable("TB_CONDOMINIOS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bairro = "Jardim Paulistano",
                            CEP = "04567010",
                            CNPJ = "17540623000150",
                            Cidade = "São Paulo",
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3604),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3596),
                            Email = "contato@boavista.com.br",
                            Estado = "SP",
                            Logradouro = "Rua das Acácias",
                            Nome = "Condomínio Boa Vista",
                            Numero = "55",
                            QuantidadeAndares = 10,
                            QuantidadeBlocos = 5,
                            QuantidadeUnidades = 4,
                            Telefone = "1140028922"
                        },
                        new
                        {
                            Id = 2,
                            Bairro = "Copacabana",
                            CEP = "22021001",
                            CNPJ = "27004428000169",
                            Cidade = "Rio de Janeiro",
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3612),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3611),
                            Email = "contato@raiodesol.com.br",
                            Estado = "RJ",
                            Logradouro = "Avenida Atlântica",
                            Nome = "Condomínio Raio de Sol",
                            Numero = "700",
                            QuantidadeAndares = 10,
                            QuantidadeBlocos = 5,
                            QuantidadeUnidades = 8,
                            Telefone = "2130033211"
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Entrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ETG_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária da entrega");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("ETG_DATA_ATUALIZACAO")
                        .HasColumnOrder(11)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização da entrega");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("ETG_DATA_CRIACAO")
                        .HasColumnOrder(10)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação da entrega");

                    b.Property<DateTime>("DataRecebimento")
                        .HasColumnType("datetime")
                        .HasColumnName("ETG_DATA_RECEBIMENTO")
                        .HasColumnOrder(5)
                        .HasComment("Data de recebimento da entrega");

                    b.Property<DateTime?>("DataRetirada")
                        .HasColumnType("datetime")
                        .HasColumnName("ETG_DATA_RETIRADA")
                        .HasColumnOrder(6)
                        .HasComment("Data de retirada da entrega");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("ETG_DESCRICAO")
                        .HasColumnOrder(7)
                        .HasComment("Descrição da entrega");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int")
                        .HasColumnName("FUN_ID")
                        .HasColumnOrder(3)
                        .HasComment("Chave estrangeira do funcionário");

                    b.Property<int>("MoradorId")
                        .HasColumnType("int")
                        .HasColumnName("MOR_ID")
                        .HasColumnOrder(4)
                        .HasComment("Chave estrangeira do morador");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("ETG_OBSERVACAO")
                        .HasColumnOrder(8)
                        .HasComment("Observação da entrega");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("ETG_STATUS")
                        .HasColumnOrder(9)
                        .HasComment("Status da entrega");

                    b.Property<int>("TransportadoraId")
                        .HasColumnType("int")
                        .HasColumnName("TRP_ID")
                        .HasColumnOrder(2)
                        .HasComment("Chave estrangeira da transportadora");

                    b.HasKey("Id")
                        .HasName("PK_ENTREGAS");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("MoradorId");

                    b.HasIndex("TransportadoraId");

                    b.ToTable("TB_ENTREGAS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3776),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3776),
                            DataRecebimento = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3777),
                            Descricao = "Entrega Teste 1",
                            FuncionarioId = 1,
                            MoradorId = 1,
                            Observacao = "Observação Teste 1",
                            Status = 1,
                            TransportadoraId = 1
                        },
                        new
                        {
                            Id = 2,
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3779),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3778),
                            DataRecebimento = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3779),
                            Descricao = "Entrega Teste 2",
                            FuncionarioId = 2,
                            MoradorId = 2,
                            Observacao = "Observação Teste 2",
                            Status = 1,
                            TransportadoraId = 2
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FUN_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária do funcionário");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("FUN_CPF")
                        .HasColumnOrder(3)
                        .HasComment("CPF do funcionário");

                    b.Property<int>("Cargo")
                        .HasColumnType("int")
                        .HasColumnName("FUN_CARGO")
                        .HasColumnOrder(6)
                        .HasComment("Cargo do funcionário");

                    b.Property<int>("CondominioId")
                        .HasColumnType("int")
                        .HasColumnName("FUN_CONDOMINIO_ID")
                        .HasColumnOrder(11)
                        .HasComment("Chave estrangeira do condomínio");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime")
                        .HasColumnName("FUN_DATA_ADMISSAO")
                        .HasColumnOrder(7)
                        .HasComment("Data de admissão do funcionário");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FUN_DATA_ATUALIZACAO")
                        .HasColumnOrder(10)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização do funcionário");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FUN_DATA_CRIACAO")
                        .HasColumnOrder(9)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação do funcionário");

                    b.Property<DateTime?>("DataDemissao")
                        .HasColumnType("datetime")
                        .HasColumnName("FUN_DATA_DEMISSAO")
                        .HasColumnOrder(8)
                        .HasComment("Data de demissão do funcionário");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("FUN_EMAIL")
                        .HasColumnOrder(4)
                        .HasComment("Email do funcionário");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("FUN_NOME")
                        .HasColumnOrder(2)
                        .HasComment("Nome do funcionário");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("FUN_TELEFONE")
                        .HasColumnOrder(5)
                        .HasComment("Telefone do funcionário");

                    b.HasKey("Id")
                        .HasName("PK_FUNCIONARIOS");

                    b.HasIndex("CPF")
                        .IsUnique()
                        .HasDatabaseName("IX_FUNCIONARIO_CPF");

                    b.HasIndex("CondominioId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("IX_FUNCIONARIO_EMAIL");

                    b.ToTable("TB_FUNCIONARIOS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "12345678903",
                            Cargo = 3,
                            CondominioId = 1,
                            DataAdmissao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3748),
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3747),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3746),
                            Email = "funcionario1@teste.com",
                            Nome = "Funcionario Teste 1",
                            Telefone = "1234567892"
                        },
                        new
                        {
                            Id = 2,
                            CPF = "12345678904",
                            Cargo = 2,
                            CondominioId = 2,
                            DataAdmissao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3750),
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3750),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3749),
                            Email = "funcionario2@teste.com",
                            Nome = "Funcionario Teste 2",
                            Telefone = "1234567893"
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Morador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MOR_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária do morador");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("MOR_CPF")
                        .HasColumnOrder(3)
                        .HasComment("CPF do morador");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime")
                        .HasColumnName("MOR_DATA_ATUALIZACAO")
                        .HasColumnOrder(10)
                        .HasComment("Data da última atualização do morador");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime")
                        .HasColumnName("MOR_DATA_CRIACAO")
                        .HasColumnOrder(9)
                        .HasComment("Data de criação do morador");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("MOR_EMAIL")
                        .HasColumnOrder(4)
                        .HasComment("Email do morador");

                    b.Property<string>("Foto")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("MOR_FOTO")
                        .HasColumnOrder(7)
                        .HasComment("Foto do morador");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("MOR_NOME")
                        .HasColumnOrder(2)
                        .HasComment("Nome do morador");

                    b.Property<string>("Ramal")
                        .HasColumnType("varchar(5)")
                        .HasColumnName("MOR_RAMAL")
                        .HasColumnOrder(6)
                        .HasComment("Ramal do morador");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("MOR_TELEFONE")
                        .HasColumnOrder(5)
                        .HasComment("Telefone do morador");

                    b.Property<int>("UnidadeId")
                        .HasColumnType("int")
                        .HasColumnName("MOR_UNIDADE_ID")
                        .HasColumnOrder(8)
                        .HasComment("Chave estrangeira da unidade do morador");

                    b.HasKey("Id")
                        .HasName("PK_MORADORES");

                    b.HasIndex("CPF")
                        .IsUnique()
                        .HasDatabaseName("IX_MORADORES_CPF");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("IX_MORADORES_EMAIL");

                    b.HasIndex("UnidadeId")
                        .HasDatabaseName("IX_MORADORES_UNIDADE_ID");

                    b.ToTable("TB_MORADORES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "12345678901",
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3731),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3730),
                            Email = "morador1@teste.com",
                            Foto = "foto1.jpg",
                            Nome = "Morador Teste 1",
                            Ramal = "123",
                            Telefone = "1234567890",
                            UnidadeId = 1
                        },
                        new
                        {
                            Id = 2,
                            CPF = "12345678902",
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3734),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3733),
                            Email = "morador2@teste.com",
                            Foto = "foto2.jpg",
                            Nome = "Morador Teste 2",
                            Ramal = "456",
                            Telefone = "1234567891",
                            UnidadeId = 2
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TRA_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária da transportadora");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(14)")
                        .HasColumnName("TRA_CNPJ")
                        .HasColumnOrder(3)
                        .HasComment("CNPJ da transportadora");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("TRA_DATA_ATUALIZACAO")
                        .HasColumnOrder(7)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização da transportadora");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("TRA_DATA_CRIACAO")
                        .HasColumnOrder(6)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação da transportadora");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("TRA_EMAIL")
                        .HasColumnOrder(5)
                        .HasComment("E-mail da transportadora");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("TRA_NOME")
                        .HasColumnOrder(2)
                        .HasComment("Nome da transportadora");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(11)")
                        .HasColumnName("TRA_TELEFONE")
                        .HasColumnOrder(4)
                        .HasComment("Telefone da transportadora");

                    b.HasKey("Id")
                        .HasName("PK_TRANSPORTADORAS");

                    b.HasIndex("CNPJ")
                        .IsUnique()
                        .HasDatabaseName("IX_TRANSPORTADORAS_CNPJ")
                        .HasFilter("[TRA_CNPJ] IS NOT NULL");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("IX_TRANSPORTADORAS_EMAIL")
                        .HasFilter("[TRA_EMAIL] IS NOT NULL");

                    b.HasIndex("Nome")
                        .IsUnique()
                        .HasDatabaseName("IX_TRANSPORTADORAS_NOME");

                    b.HasIndex("Telefone")
                        .IsUnique()
                        .HasDatabaseName("IX_TRANSPORTADORAS_TELEFONE")
                        .HasFilter("[TRA_TELEFONE] IS NOT NULL");

                    b.ToTable("TB_TRANSPORTADORAS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CNPJ = "12345678912347",
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3763),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3762),
                            Email = "transportadora1@teste.com",
                            Nome = "Transportadora Teste 1",
                            Telefone = "1234567894"
                        },
                        new
                        {
                            Id = 2,
                            CNPJ = "12345678912348",
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3765),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3765),
                            Email = "transportadora2@teste.com",
                            Nome = "Transportadora Teste 2",
                            Telefone = "1234567895"
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UND_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária da unidade");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Andar")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("UND_ANDAR")
                        .HasColumnOrder(4)
                        .HasComment("Andar da unidade");

                    b.Property<string>("Bloco")
                        .HasColumnType("varchar(10)")
                        .HasColumnName("UND_BLOCO")
                        .HasColumnOrder(5)
                        .HasComment("Bloco da unidade");

                    b.Property<int>("CondominioId")
                        .HasColumnType("int")
                        .HasColumnName("CON_ID")
                        .HasColumnOrder(2)
                        .HasComment("Chave estrangeira do condomínio");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("UND_DATA_ATUALIZACAO")
                        .HasColumnOrder(7)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização da unidade");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("UND_DATA_CRIACAO")
                        .HasColumnOrder(6)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação da unidade");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("UND_NUMERO")
                        .HasColumnOrder(3)
                        .HasComment("Número da unidade");

                    b.HasKey("Id")
                        .HasName("PK_UNIDADES");

                    b.HasIndex("CondominioId", "Numero", "Bloco")
                        .HasDatabaseName("IX_UNIDADES_CONDOMINIO_NUMERO_BLOCO");

                    b.ToTable("TB_UNIDADES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Andar = "0",
                            Bloco = "A",
                            CondominioId = 1,
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3713),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3713),
                            Numero = "101"
                        },
                        new
                        {
                            Id = 2,
                            Andar = "0",
                            Bloco = "A",
                            CondominioId = 1,
                            DataAtualizacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3717),
                            DataCriacao = new DateTime(2023, 5, 31, 0, 5, 29, 747, DateTimeKind.Local).AddTicks(3716),
                            Numero = "102"
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Entrega", b =>
                {
                    b.HasOne("EntregaSegura.Domain.Entities.Funcionario", "Funcionario")
                        .WithMany("Entregas")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_FUNCIONARIO_ENTREGA");

                    b.HasOne("EntregaSegura.Domain.Entities.Morador", "Morador")
                        .WithMany("Entregas")
                        .HasForeignKey("MoradorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_MORADORES_ENTREGAS");

                    b.HasOne("EntregaSegura.Domain.Entities.Transportadora", "Transportadora")
                        .WithMany("Entregas")
                        .HasForeignKey("TransportadoraId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_ENTREGA_TRANSPORTADORA");

                    b.Navigation("Funcionario");

                    b.Navigation("Morador");

                    b.Navigation("Transportadora");
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Funcionario", b =>
                {
                    b.HasOne("EntregaSegura.Domain.Entities.Condominio", "Condominio")
                        .WithMany("Funcionarios")
                        .HasForeignKey("CondominioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_FUNCIONARIO_CONDOMINIO");

                    b.Navigation("Condominio");
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Morador", b =>
                {
                    b.HasOne("EntregaSegura.Domain.Entities.Unidade", "Unidade")
                        .WithMany("Moradores")
                        .HasForeignKey("UnidadeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_MORADORES_UNIDADES");

                    b.Navigation("Unidade");
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Unidade", b =>
                {
                    b.HasOne("EntregaSegura.Domain.Entities.Condominio", "Condominio")
                        .WithMany("Unidades")
                        .HasForeignKey("CondominioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_UNIDADES_CONDOMINIOS");

                    b.Navigation("Condominio");
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Condominio", b =>
                {
                    b.Navigation("Funcionarios");

                    b.Navigation("Unidades");
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Funcionario", b =>
                {
                    b.Navigation("Entregas");
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Morador", b =>
                {
                    b.Navigation("Entregas");
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Transportadora", b =>
                {
                    b.Navigation("Entregas");
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Unidade", b =>
                {
                    b.Navigation("Moradores");
                });
#pragma warning restore 612, 618
        }
    }
}
