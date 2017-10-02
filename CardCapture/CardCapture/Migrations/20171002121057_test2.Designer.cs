﻿// <auto-generated />
using CardCapture.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CardCapture.Migrations
{
    [DbContext(typeof(CardCaptureContext))]
    [Migration("20171002121057_test2")]
    partial class test2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CardCapture.Models.Card", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Atk");

                    b.Property<string>("Card_Type");

                    b.Property<string>("Def");

                    b.Property<string>("Family");

                    b.Property<string>("Level");

                    b.Property<string>("Name");

                    b.Property<string>("Property");

                    b.Property<string>("Text");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("CardCapture.Models.Collection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CardId");

                    b.Property<int?>("NameID");

                    b.HasKey("ID");

                    b.HasIndex("CardId");

                    b.HasIndex("NameID");

                    b.ToTable("Collection");
                });

            modelBuilder.Entity("CardCapture.Models.Collection", b =>
                {
                    b.HasOne("CardCapture.Models.Card", "CardID")
                        .WithMany()
                        .HasForeignKey("CardId");

                    b.HasOne("CardCapture.Models.Card", "Name")
                        .WithMany()
                        .HasForeignKey("NameID");
                });
#pragma warning restore 612, 618
        }
    }
}
