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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CND_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária do condomínio");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CND_BAIRRO")
                        .HasColumnOrder(13)
                        .HasComment("Bairro do endereço do condomínio");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CND_CEP")
                        .HasColumnOrder(12)
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
                        .HasColumnOrder(14)
                        .HasComment("Cidade do endereço do condomínio");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CND_COMPLEMENTO")
                        .HasColumnOrder(11)
                        .HasComment("Complemento do endereço do condomínio");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CND_DATA_ATUALIZACAO")
                        .HasColumnOrder(18)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização do condomínio");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CND_DATA_CRIACAO")
                        .HasColumnOrder(17)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação do condomínio");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime")
                        .HasColumnName("CND_DATA_EXCLUSAO")
                        .HasColumnOrder(19)
                        .HasComment("Data da exclusão do condomínio");

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
                        .HasColumnOrder(15)
                        .HasComment("Estado do endereço do condomínio");

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("CND_EXCLUIDO")
                        .HasColumnOrder(16)
                        .HasComment("Flag de exclusão do condomínio");

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
                            Id = new Guid("f26355b2-c097-4582-8a4a-4a9ecbfc7f09"),
                            Bairro = "Bairro Exemplo",
                            CEP = "11111111",
                            CNPJ = "11111111111111",
                            Cidade = "Cidade Exemplo",
                            Complemento = "Bloco A",
                            DataAtualizacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5397),
                            DataCriacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5386),
                            Email = "contato@condominioexemplo.com.br",
                            Estado = "SP",
                            Excluido = false,
                            Logradouro = "Rua Exemplo",
                            Nome = "Condomínio Exemplo",
                            Numero = "100",
                            QuantidadeAndares = 0,
                            QuantidadeBlocos = 0,
                            QuantidadeUnidades = 0,
                            Telefone = "11999999999"
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Entrega", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ETG_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária da entrega");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("ETG_DATA_ATUALIZACAO")
                        .HasColumnOrder(12)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização da entrega");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("ETG_DATA_CRIACAO")
                        .HasColumnOrder(11)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação da entrega");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime")
                        .HasColumnName("ETG_DATA_EXCLUSAO")
                        .HasColumnOrder(13)
                        .HasComment("Data da exclusão da entrega");

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

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("ETG_EXCLUIDO")
                        .HasColumnOrder(10)
                        .HasComment("Flag de exclusão da entrega");

                    b.Property<Guid>("FuncionarioId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FUN_ID")
                        .HasColumnOrder(3)
                        .HasComment("Chave estrangeira do funcionário");

                    b.Property<Guid>("MoradorId")
                        .HasColumnType("uniqueidentifier")
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

                    b.Property<Guid>("TransportadoraId")
                        .HasColumnType("uniqueidentifier")
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
                            Id = new Guid("8a6b4827-15d3-4d9c-a567-a14a6a0c8ce7"),
                            DataAtualizacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5542),
                            DataCriacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5542),
                            DataRecebimento = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5544),
                            Descricao = "Descrição da entrega",
                            Excluido = false,
                            FuncionarioId = new Guid("f1e28b7e-674f-41dd-868c-c245e35de929"),
                            MoradorId = new Guid("7b3b9132-0eae-4ba1-8519-347d92873868"),
                            Observacao = "Observação da entrega",
                            Status = 1,
                            TransportadoraId = new Guid("5cc12493-0012-43aa-aac0-76cbc18bedb3")
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FUN_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária do funcionário");

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

                    b.Property<Guid>("CondominioId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FUN_CONDOMINIO_ID")
                        .HasColumnOrder(13)
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
                        .HasColumnOrder(11)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização do funcionário");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("FUN_DATA_CRIACAO")
                        .HasColumnOrder(10)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação do funcionário");

                    b.Property<DateTime?>("DataDemissao")
                        .HasColumnType("datetime")
                        .HasColumnName("FUN_DATA_DEMISSAO")
                        .HasColumnOrder(8)
                        .HasComment("Data de demissão do funcionário");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime")
                        .HasColumnName("FUN_DATA_EXCLUSAO")
                        .HasColumnOrder(12)
                        .HasComment("Data da exclusão do funcionário");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("FUN_EMAIL")
                        .HasColumnOrder(4)
                        .HasComment("Email do funcionário");

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("FUN_EXCLUIDO")
                        .HasColumnOrder(9)
                        .HasComment("Indica se o funcionário foi excluído");

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
                            Id = new Guid("f1e28b7e-674f-41dd-868c-c245e35de929"),
                            CPF = "98765432109",
                            Cargo = 2,
                            CondominioId = new Guid("f26355b2-c097-4582-8a4a-4a9ecbfc7f09"),
                            DataAdmissao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5514),
                            DataAtualizacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5513),
                            DataCriacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5513),
                            Email = "funcionario@email.com",
                            Excluido = false,
                            Nome = "Funcionario Exemplo",
                            Telefone = "11999999999"
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Morador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("MOR_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária do morador");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("MOR_CPF")
                        .HasColumnOrder(3)
                        .HasComment("CPF do morador");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime")
                        .HasColumnName("MOR_DATA_ATUALIZACAO")
                        .HasColumnOrder(11)
                        .HasComment("Data da última atualização do morador");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime")
                        .HasColumnName("MOR_DATA_CRIACAO")
                        .HasColumnOrder(10)
                        .HasComment("Data de criação do morador");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime")
                        .HasColumnName("MOR_DATA_EXCLUSAO")
                        .HasColumnOrder(12)
                        .HasComment("Data da exclusão do morador");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("MOR_EMAIL")
                        .HasColumnOrder(4)
                        .HasComment("Email do morador");

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("MOR_EXCLUIDO")
                        .HasColumnOrder(9)
                        .HasComment("Indica se o morador foi excluído");

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

                    b.Property<Guid>("UnidadeId")
                        .HasColumnType("uniqueidentifier")
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
                            Id = new Guid("7b3b9132-0eae-4ba1-8519-347d92873868"),
                            CPF = "12345678901",
                            DataAtualizacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5497),
                            DataCriacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5496),
                            Email = "morador@email.com",
                            Excluido = false,
                            Nome = "Morador Exemplo",
                            Ramal = "210",
                            Telefone = "11999999999",
                            UnidadeId = new Guid("68165d63-fa38-4d27-858f-ac006b1ada92")
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Transportadora", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TRA_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária da transportadora");

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(14)")
                        .HasColumnName("TRA_CNPJ")
                        .HasColumnOrder(3)
                        .HasComment("CNPJ da transportadora");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("TRA_DATA_ATUALIZACAO")
                        .HasColumnOrder(8)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização da transportadora");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("TRA_DATA_CRIACAO")
                        .HasColumnOrder(7)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação da transportadora");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime")
                        .HasColumnName("TRA_DATA_EXCLUSAO")
                        .HasColumnOrder(9)
                        .HasComment("Data da exclusão da transportadora");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("TRA_EMAIL")
                        .HasColumnOrder(5)
                        .HasComment("E-mail da transportadora");

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("TRA_EXCLUIDO")
                        .HasColumnOrder(6)
                        .HasComment("Flag de exclusão da transportadora");

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
                            Id = new Guid("5cc12493-0012-43aa-aac0-76cbc18bedb3"),
                            CNPJ = "22222222222222",
                            DataAtualizacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5528),
                            DataCriacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5527),
                            Email = "contato@transportadoraexemplo.com.br",
                            Excluido = false,
                            Nome = "Transportadora Exemplo",
                            Telefone = "11988888888"
                        });
                });

            modelBuilder.Entity("EntregaSegura.Domain.Entities.Unidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UND_ID")
                        .HasColumnOrder(1)
                        .HasComment("Chave primária da unidade");

                    b.Property<string>("Bloco")
                        .HasColumnType("varchar(10)")
                        .HasColumnName("UND_BLOCO")
                        .HasColumnOrder(4)
                        .HasComment("Bloco da unidade");

                    b.Property<Guid>("CondominioId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CON_ID")
                        .HasColumnOrder(2)
                        .HasComment("Chave estrangeira do condomínio");

                    b.Property<DateTime>("DataAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("UND_DATA_ATUALIZACAO")
                        .HasColumnOrder(10)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data da última atualização da unidade");

                    b.Property<DateTime>("DataCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("UND_DATA_CRIACAO")
                        .HasColumnOrder(9)
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Data de criação da unidade");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime")
                        .HasColumnName("UND_DATA_EXCLUSAO")
                        .HasColumnOrder(11)
                        .HasComment("Data da exclusão da unidade");

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("UND_EXCLUIDO")
                        .HasColumnOrder(8)
                        .HasComment("Indica se a unidade foi excluída");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("UND_NUMERO")
                        .HasColumnOrder(3)
                        .HasComment("Número da unidade");

                    b.HasKey("Id")
                        .HasName("PK_UNIDADES");

                    b.HasIndex("CondominioId", "Numero", "Bloco")
                        .IsUnique()
                        .HasDatabaseName("IX_UNIDADES_CONDOMINIO_NUMERO_BLOCO")
                        .HasFilter("[UND_BLOCO] IS NOT NULL");

                    b.ToTable("TB_UNIDADES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("68165d63-fa38-4d27-858f-ac006b1ada92"),
                            Bloco = "A",
                            CondominioId = new Guid("f26355b2-c097-4582-8a4a-4a9ecbfc7f09"),
                            DataAtualizacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5484),
                            DataCriacao = new DateTime(2023, 5, 16, 21, 14, 24, 80, DateTimeKind.Local).AddTicks(5483),
                            Excluido = false,
                            Numero = "101"
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
