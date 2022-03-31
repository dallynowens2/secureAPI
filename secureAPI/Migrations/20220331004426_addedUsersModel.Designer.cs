﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using secureAPI.Data;

namespace secureAPI.Migrations
{
    [DbContext(typeof(WireGuardContext))]
    [Migration("20220331004426_addedUsersModel")]
    partial class addedUsersModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("secureAPI.Models.UserInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("password")
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<byte[]>("salt")
                        .HasColumnType("bytea")
                        .HasColumnName("salt");

                    b.Property<string>("userName")
                        .HasColumnType("text")
                        .HasColumnName("user_name");

                    b.HasKey("id")
                        .HasName("pk_user_info");

                    b.ToTable("user_info");
                });

            modelBuilder.Entity("secureAPI.Models.UserModelInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("icecream")
                        .HasColumnType("text")
                        .HasColumnName("icecream");

                    b.Property<string>("nickname")
                        .HasColumnType("text")
                        .HasColumnName("nickname");

                    b.Property<string>("topping")
                        .HasColumnType("text")
                        .HasColumnName("topping");

                    b.Property<string>("userName")
                        .HasColumnType("text")
                        .HasColumnName("user_name");

                    b.Property<string>("visit")
                        .HasColumnType("text")
                        .HasColumnName("visit");

                    b.HasKey("id")
                        .HasName("pk_user_model_info");

                    b.ToTable("user_model_info");
                });

            modelBuilder.Entity("secureAPI.WireGuardInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("allowedIpRange")
                        .HasColumnType("text")
                        .HasColumnName("allowed_ip_range");

                    b.Property<string>("clientName")
                        .HasColumnType("text")
                        .HasColumnName("client_name");

                    b.Property<string>("clientPrivateKey")
                        .HasColumnType("text")
                        .HasColumnName("client_private_key");

                    b.Property<string>("clientPublicKey")
                        .HasColumnType("text")
                        .HasColumnName("client_public_key");

                    b.Property<string>("dateAdded")
                        .HasColumnType("text")
                        .HasColumnName("date_added");

                    b.Property<string>("ipAddress")
                        .HasColumnType("text")
                        .HasColumnName("ip_address");

                    b.HasKey("id")
                        .HasName("pk_wire_guard_info");

                    b.ToTable("wire_guard_info");
                });
#pragma warning restore 612, 618
        }
    }
}
