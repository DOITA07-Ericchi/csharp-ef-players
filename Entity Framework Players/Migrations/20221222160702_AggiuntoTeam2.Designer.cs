﻿// <auto-generated />
using Entity_Framework_Players;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkPlayers.Migrations
{
    [DbContext(typeof(PlayersContext))]
    [Migration("20221222160702_AggiuntoTeam2")]
    partial class AggiuntoTeam2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity_Framework_Players.Player", b =>
                {
                    b.Property<int>("playerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("playerId"));

                    b.Property<string>("cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nPartiteGiocate")
                        .HasColumnType("int");

                    b.Property<int>("nPartiteVinte")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("punteggio")
                        .HasColumnType("int");

                    b.Property<int>("teamId")
                        .HasColumnType("int");

                    b.HasKey("playerId");

                    b.HasIndex("playerId")
                        .IsUnique();

                    b.HasIndex("teamId");

                    b.ToTable("player");
                });

            modelBuilder.Entity("Entity_Framework_Players.Team", b =>
                {
                    b.Property<int>("teamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teamId"));

                    b.Property<string>("allenatore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("città")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("colori")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teamId");

                    b.HasIndex("teamId")
                        .IsUnique();

                    b.ToTable("team");
                });

            modelBuilder.Entity("Entity_Framework_Players.Player", b =>
                {
                    b.HasOne("Entity_Framework_Players.Team", "team")
                        .WithMany("giocatori")
                        .HasForeignKey("teamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("team");
                });

            modelBuilder.Entity("Entity_Framework_Players.Team", b =>
                {
                    b.Navigation("giocatori");
                });
#pragma warning restore 612, 618
        }
    }
}
