﻿// <auto-generated />
using AplicadorQuestoesArcoIrisV2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AplicadorQuestoesArcoIrisV2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231004122822_AlteracoesPropriedades4")]
    partial class AlteracoesPropriedades4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("AplicadorQuestoesArcoIrisV2.Domain.Entities.Alternativa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AlternativaCorreta")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestaoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("QuestaoId");

                    b.ToTable("Alternativas");
                });

            modelBuilder.Entity("AplicadorQuestoesArcoIrisV2.Domain.Entities.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("AplicadorQuestoesArcoIrisV2.Domain.Entities.Questao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Questao");
                });

            modelBuilder.Entity("AplicadorQuestoesArcoIrisV2.Domain.Entities.RespostaAluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlternativaEscolhidaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PerguntaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AlternativaEscolhidaId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("PerguntaId");

                    b.ToTable("Respostas");
                });

            modelBuilder.Entity("AplicadorQuestoesArcoIrisV2.Domain.Entities.Alternativa", b =>
                {
                    b.HasOne("AplicadorQuestoesArcoIrisV2.Domain.Entities.Questao", "Questao")
                        .WithMany("Alternativas")
                        .HasForeignKey("QuestaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questao");
                });

            modelBuilder.Entity("AplicadorQuestoesArcoIrisV2.Domain.Entities.RespostaAluno", b =>
                {
                    b.HasOne("AplicadorQuestoesArcoIrisV2.Domain.Entities.Alternativa", "AlternativaEscolhida")
                        .WithMany()
                        .HasForeignKey("AlternativaEscolhidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AplicadorQuestoesArcoIrisV2.Domain.Entities.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AplicadorQuestoesArcoIrisV2.Domain.Entities.Questao", "Pergunta")
                        .WithMany()
                        .HasForeignKey("PerguntaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AlternativaEscolhida");

                    b.Navigation("Aluno");

                    b.Navigation("Pergunta");
                });

            modelBuilder.Entity("AplicadorQuestoesArcoIrisV2.Domain.Entities.Questao", b =>
                {
                    b.Navigation("Alternativas");
                });
#pragma warning restore 612, 618
        }
    }
}
