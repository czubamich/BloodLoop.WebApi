﻿// <auto-generated />
using System;
using BloodLoop.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BloodLoop.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BloodLoop.Domain.Accounts.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BloodLoop.Domain.Accounts.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BloodLoop.Domain.BloodBanks.BloodBank", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Label")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("BloodBanks");
                });

            modelBuilder.Entity("BloodLoop.Domain.BloodBanks.BloodLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BloodBankId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Measurement")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BloodBankId");

                    b.HasIndex("CreatedAt");

                    b.ToTable("BloodLevels");
                });

            modelBuilder.Entity("BloodLoop.Domain.DonationHelpers.DonationConverter", b =>
                {
                    b.Property<string>("DonationFromLabel")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DonationToLabel")
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Ratio")
                        .HasColumnType("float");

                    b.HasKey("DonationFromLabel", "DonationToLabel");

                    b.HasIndex("DonationToLabel");

                    b.ToTable("DonationConverters");

                    b.HasData(
                        new
                        {
                            DonationFromLabel = "whole",
                            DonationToLabel = "whole",
                            Ratio = 1.0
                        },
                        new
                        {
                            DonationFromLabel = "plasma",
                            DonationToLabel = "whole",
                            Ratio = 0.33333333333333331
                        },
                        new
                        {
                            DonationFromLabel = "platelets",
                            DonationToLabel = "whole",
                            Ratio = 1.0
                        },
                        new
                        {
                            DonationFromLabel = "redcells",
                            DonationToLabel = "whole",
                            Ratio = 1.6666666666666667
                        },
                        new
                        {
                            DonationFromLabel = "disqualified",
                            DonationToLabel = "whole",
                            Ratio = 0.0
                        });
                });

            modelBuilder.Entity("BloodLoop.Domain.DonationHelpers.DonationInterval", b =>
                {
                    b.Property<string>("DonationFromLabel")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DonationToLabel")
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Interval")
                        .HasColumnType("float");

                    b.HasKey("DonationFromLabel", "DonationToLabel");

                    b.HasIndex("DonationToLabel");

                    b.ToTable("DonationIntervals");

                    b.HasData(
                        new
                        {
                            DonationFromLabel = "whole",
                            DonationToLabel = "whole",
                            Interval = 56.0
                        },
                        new
                        {
                            DonationFromLabel = "whole",
                            DonationToLabel = "plasma",
                            Interval = 14.0
                        },
                        new
                        {
                            DonationFromLabel = "whole",
                            DonationToLabel = "platelets",
                            Interval = 28.0
                        },
                        new
                        {
                            DonationFromLabel = "whole",
                            DonationToLabel = "redcells",
                            Interval = 56.0
                        },
                        new
                        {
                            DonationFromLabel = "plasma",
                            DonationToLabel = "whole",
                            Interval = 14.0
                        },
                        new
                        {
                            DonationFromLabel = "plasma",
                            DonationToLabel = "plasma",
                            Interval = 14.0
                        },
                        new
                        {
                            DonationFromLabel = "plasma",
                            DonationToLabel = "platelets",
                            Interval = 28.0
                        },
                        new
                        {
                            DonationFromLabel = "plasma",
                            DonationToLabel = "redcells",
                            Interval = 28.0
                        },
                        new
                        {
                            DonationFromLabel = "platelets",
                            DonationToLabel = "whole",
                            Interval = 28.0
                        },
                        new
                        {
                            DonationFromLabel = "platelets",
                            DonationToLabel = "plasma",
                            Interval = 28.0
                        },
                        new
                        {
                            DonationFromLabel = "platelets",
                            DonationToLabel = "platelets",
                            Interval = 28.0
                        },
                        new
                        {
                            DonationFromLabel = "platelets",
                            DonationToLabel = "redcells",
                            Interval = 28.0
                        },
                        new
                        {
                            DonationFromLabel = "redcells",
                            DonationToLabel = "whole",
                            Interval = 56.0
                        },
                        new
                        {
                            DonationFromLabel = "redcells",
                            DonationToLabel = "plasma",
                            Interval = 28.0
                        },
                        new
                        {
                            DonationFromLabel = "redcells",
                            DonationToLabel = "platelets",
                            Interval = 28.0
                        },
                        new
                        {
                            DonationFromLabel = "redcells",
                            DonationToLabel = "redcells",
                            Interval = 56.0
                        });
                });

            modelBuilder.Entity("BloodLoop.Domain.Donations.Donation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DonationTypeLabel")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("DonorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SourceBankId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DonationTypeLabel");

                    b.HasIndex("DonorId");

                    b.HasIndex("SourceBankId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("BloodLoop.Domain.Donations.DonationType", b =>
                {
                    b.Property<string>("Label")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DefaultName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DefaultVolume")
                        .HasColumnType("int");

                    b.HasKey("Label");

                    b.ToTable("DonationTypes");

                    b.HasData(
                        new
                        {
                            Label = "whole",
                            DefaultName = "Whole Blood",
                            DefaultVolume = 450
                        },
                        new
                        {
                            Label = "plasma",
                            DefaultName = "Plasma",
                            DefaultVolume = 600
                        },
                        new
                        {
                            Label = "platelets",
                            DefaultName = "Platelets",
                            DefaultVolume = 500
                        },
                        new
                        {
                            Label = "redcells",
                            DefaultName = "Red Cells",
                            DefaultVolume = 500
                        },
                        new
                        {
                            Label = "disqualified",
                            DefaultName = "Disqualified",
                            DefaultVolume = 0
                        });
                });

            modelBuilder.Entity("BloodLoop.Domain.Donors.Donor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique()
                        .HasFilter("[AccountId] IS NOT NULL");

                    b.ToTable("Donors");
                });

            modelBuilder.Entity("BloodLoop.Domain.Staff.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BloodBankId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique()
                        .HasFilter("[AccountId] IS NOT NULL");

                    b.HasIndex("BloodBankId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("BloodLoop.Infrastructure.Identities.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BloodLoop.Domain.BloodBanks.BloodLevel", b =>
                {
                    b.HasOne("BloodLoop.Domain.BloodBanks.BloodBank", null)
                        .WithMany("BloodLevels")
                        .HasForeignKey("BloodBankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BloodLoop.Domain.DonationHelpers.DonationConverter", b =>
                {
                    b.HasOne("BloodLoop.Domain.Donations.DonationType", "DonationFrom")
                        .WithMany()
                        .HasForeignKey("DonationFromLabel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodLoop.Domain.Donations.DonationType", "DonationTo")
                        .WithMany()
                        .HasForeignKey("DonationToLabel")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DonationFrom");

                    b.Navigation("DonationTo");
                });

            modelBuilder.Entity("BloodLoop.Domain.DonationHelpers.DonationInterval", b =>
                {
                    b.HasOne("BloodLoop.Domain.Donations.DonationType", "DonationFrom")
                        .WithMany()
                        .HasForeignKey("DonationFromLabel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodLoop.Domain.Donations.DonationType", "DonationTo")
                        .WithMany()
                        .HasForeignKey("DonationToLabel")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DonationFrom");

                    b.Navigation("DonationTo");
                });

            modelBuilder.Entity("BloodLoop.Domain.Donations.Donation", b =>
                {
                    b.HasOne("BloodLoop.Domain.Donations.DonationType", "DonationType")
                        .WithMany()
                        .HasForeignKey("DonationTypeLabel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodLoop.Domain.Donors.Donor", null)
                        .WithMany("Donations")
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodLoop.Domain.BloodBanks.BloodBank", null)
                        .WithMany()
                        .HasForeignKey("SourceBankId");

                    b.Navigation("DonationType");
                });

            modelBuilder.Entity("BloodLoop.Domain.Donors.Donor", b =>
                {
                    b.HasOne("BloodLoop.Domain.Accounts.Account", "Account")
                        .WithOne()
                        .HasForeignKey("BloodLoop.Domain.Donors.Donor", "AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BloodLoop.Domain.Staff.Staff", b =>
                {
                    b.HasOne("BloodLoop.Domain.Accounts.Account", "Account")
                        .WithOne()
                        .HasForeignKey("BloodLoop.Domain.Staff.Staff", "AccountId");

                    b.HasOne("BloodLoop.Domain.BloodBanks.BloodBank", "BloodBank")
                        .WithMany()
                        .HasForeignKey("BloodBankId");

                    b.Navigation("Account");

                    b.Navigation("BloodBank");
                });

            modelBuilder.Entity("BloodLoop.Infrastructure.Identities.RefreshToken", b =>
                {
                    b.HasOne("BloodLoop.Domain.Accounts.Account", null)
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.HasOne("BloodLoop.Domain.Accounts.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.HasOne("BloodLoop.Domain.Accounts.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.HasOne("BloodLoop.Domain.Accounts.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.HasOne("BloodLoop.Domain.Accounts.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodLoop.Domain.Accounts.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<BloodLoop.Domain.Accounts.AccountId>", b =>
                {
                    b.HasOne("BloodLoop.Domain.Accounts.Account", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BloodLoop.Domain.BloodBanks.BloodBank", b =>
                {
                    b.Navigation("BloodLevels");
                });

            modelBuilder.Entity("BloodLoop.Domain.Donors.Donor", b =>
                {
                    b.Navigation("Donations");
                });
#pragma warning restore 612, 618
        }
    }
}
