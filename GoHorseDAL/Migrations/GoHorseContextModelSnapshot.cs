﻿// <auto-generated />
using System;
using GoHorseDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoHorseDAL.Migrations
{
    [DbContext(typeof(GoHorseContext))]
    partial class GoHorseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoHorseClassLibrary.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientePessoaId")
                        .HasColumnType("int");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raca")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientePessoaId");

                    b.ToTable("Animais");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Cartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientePessoaId")
                        .HasColumnType("int");

                    b.Property<int>("Cv")
                        .HasColumnType("int");

                    b.Property<string>("NCartao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Validade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientePessoaId");

                    b.ToTable("Cartoes");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MotoristaPessoaId")
                        .HasColumnType("int");

                    b.Property<string>("NConta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MotoristaPessoaId");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Endereco");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartaoId")
                        .HasColumnType("int");

                    b.Property<int?>("ContaId")
                        .HasColumnType("int");

                    b.Property<int?>("ViagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartaoId");

                    b.HasIndex("ContaId");

                    b.HasIndex("ViagemId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PessoaId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoFabricacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MotoristaPessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MotoristaPessoaId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Viagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("DataDestino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataOrigem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecoDestinoEnderecoId")
                        .HasColumnType("int");

                    b.Property<int?>("EnderecoOrigemEnderecoId")
                        .HasColumnType("int");

                    b.Property<double>("ValorViagem")
                        .HasColumnType("float");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("EnderecoDestinoEnderecoId");

                    b.HasIndex("EnderecoOrigemEnderecoId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Viagens");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Parada", b =>
                {
                    b.HasBaseType("GoHorseClassLibrary.Endereco");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("NumeroParada")
                        .HasColumnType("int");

                    b.Property<int?>("ViagemId")
                        .HasColumnType("int");

                    b.HasIndex("ViagemId");

                    b.HasDiscriminator().HasValue("Parada");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Cliente", b =>
                {
                    b.HasBaseType("GoHorseClassLibrary.Pessoa");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Motorista", b =>
                {
                    b.HasBaseType("GoHorseClassLibrary.Pessoa");

                    b.Property<string>("CategoriaCnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnName("Motorista_Id")
                        .HasColumnType("int");

                    b.Property<string>("NRegistroCnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidadeCnh")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Motorista");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Animal", b =>
                {
                    b.HasOne("GoHorseClassLibrary.Cliente", "Cliente")
                        .WithMany("Animais")
                        .HasForeignKey("ClientePessoaId");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Cartao", b =>
                {
                    b.HasOne("GoHorseClassLibrary.Cliente", "Cliente")
                        .WithMany("Cartoes")
                        .HasForeignKey("ClientePessoaId");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Conta", b =>
                {
                    b.HasOne("GoHorseClassLibrary.Motorista", "Motorista")
                        .WithMany("Contas")
                        .HasForeignKey("MotoristaPessoaId");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Pagamento", b =>
                {
                    b.HasOne("GoHorseClassLibrary.Cartao", "Cartao")
                        .WithMany()
                        .HasForeignKey("CartaoId");

                    b.HasOne("GoHorseClassLibrary.Conta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaId");

                    b.HasOne("GoHorseClassLibrary.Viagem", "Viagem")
                        .WithMany()
                        .HasForeignKey("ViagemId");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Pessoa", b =>
                {
                    b.HasOne("GoHorseClassLibrary.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Telefone", b =>
                {
                    b.HasOne("GoHorseClassLibrary.Pessoa", "Pessoa")
                        .WithMany("Telefones")
                        .HasForeignKey("PessoaId");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Veiculo", b =>
                {
                    b.HasOne("GoHorseClassLibrary.Motorista", "Motorista")
                        .WithMany("Veiculos")
                        .HasForeignKey("MotoristaPessoaId");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Viagem", b =>
                {
                    b.HasOne("GoHorseClassLibrary.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId");

                    b.HasOne("GoHorseClassLibrary.Endereco", "EnderecoDestino")
                        .WithMany()
                        .HasForeignKey("EnderecoDestinoEnderecoId");

                    b.HasOne("GoHorseClassLibrary.Endereco", "EnderecoOrigem")
                        .WithMany()
                        .HasForeignKey("EnderecoOrigemEnderecoId");

                    b.HasOne("GoHorseClassLibrary.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");
                });

            modelBuilder.Entity("GoHorseClassLibrary.Parada", b =>
                {
                    b.HasOne("GoHorseClassLibrary.Viagem", null)
                        .WithMany("Paradas")
                        .HasForeignKey("ViagemId");
                });
#pragma warning restore 612, 618
        }
    }
}
