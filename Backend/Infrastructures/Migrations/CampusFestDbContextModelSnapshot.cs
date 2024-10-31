﻿// <auto-generated />
using System;
using Backend.Infrastructures.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Infrastructures.Migrations
{
    [DbContext(typeof(CampusFestDbContext))]
    partial class CampusFestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccountRole", b =>
                {
                    b.Property<Guid>("AccountsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.HasKey("AccountsId", "RolesId");

                    b.HasIndex("RolesId");

                    b.ToTable("AccountRole");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CampusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampusId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Campus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Campuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "",
                            Description = "Chính thức thành lập ngày 8/9/2006 theo Quyết định của Thủ tướng Chính phủ, Trường Đại học FPT trở thành trường đại học đầu tiên của Việt Nam do một doanh nghiệp đứng ra thành lập với 100% vốn đầu tư từ Tập đoàn FPT.\r\n\r\nSự khác biệt của Trường Đại học FPT so với các trường đại học khác là đào tạo theo hình thức liên kết chặt chẽ với các doanh nghiệp, gắn đào tạo với thực tiễn, với nghiên cứu – triển khai và các công nghệ hiện đại nhất. Triết lý và phương pháp giáo dục hiện đại; Đào tạo con người toàn diện, hài hòa; Chương trình luôn được cập nhật và tuân thủ các chuẩn công nghệ quốc tế; Đặc biệt chú trọng kỹ năng ngoại ngữ; Tăng cường đào tạo quy trình tổ chức sản xuất, kỹ năng làm việc theo nhóm và các kỹ năng cá nhân khác là những điểm sẽ đảm bảo cho sinh viên tốt nghiệp có những cơ hội việc làm tốt nhất sau khi ra trường.",
                            Email = "",
                            Name = "FPT University",
                            Phone = ""
                        },
                        new
                        {
                            Id = 2,
                            Address = "",
                            Description = "Trường Đại học Bách khoa - ĐHQG-HCM  là một trường thành viên của hệ thống Đại học Quốc gia TP. Hồ Chí Minh. Tiền thân của Trường là Trung tâm Quốc gia Kỹ thuật được thành lập vào năm 1957. Hiện nay, Trường ĐH Bách Khoa là trung tâm đào tạo, nghiên cứu khoa học và chuyển giao công nghệ lớn nhất các tỉnh phía Nam và là trường đại học kỹ thuật quan trọng của cả nước.",
                            Email = "",
                            Name = "Đại học Bách Khoa Thành phố Hồ Chí Minh",
                            Phone = ""
                        },
                        new
                        {
                            Id = 3,
                            Address = "",
                            Description = "Trường ĐH Nguyễn Tất Thành là “trường đại học đổi mới sáng tạo” đáp ứng nhu cầu giáo dục đại học đại chúng thông qua việc tạo lập một môi trường học tập tích cực và trải nghiệm thực tiễn cho mọi sinh viên trang bị cho người học năng lực tự học tinh thần sáng tạo khởi nghiệp có trách nhiệm với cộng đồng hội nhập với khu vực và toàn cầu.\r\n\r\nTriết lý giáo dục của Nhà trường: \r\n\r\nTHỰC HỌC – THỰC HÀNH – THỰC DANH – THỰC NGHIỆP ",
                            Email = "",
                            Name = "Đại học Nguyễn Tất Thành",
                            Phone = ""
                        });
                });

            modelBuilder.Entity("Backend.Cores.Entities.Club", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CampusId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampusId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Backend.Cores.Entities.ClubEventStaff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClubId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("ClubId");

                    b.ToTable("ClubEventStaffs");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosterURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<Guid>("club")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("club");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Backend.Cores.Entities.EventRegistration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckinTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OTP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistrationStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("EventId");

                    b.ToTable("EventRegistrations");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "SystemAdmin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ClubEventOrganizer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "ClubEventStaff"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Visitor"
                        });
                });

            modelBuilder.Entity("Backend.Cores.Entities.Token", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ValidAccount")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ValidAccount");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("AccountRole", b =>
                {
                    b.HasOne("Backend.Cores.Entities.Account", null)
                        .WithMany()
                        .HasForeignKey("AccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Cores.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.Cores.Entities.Account", b =>
                {
                    b.HasOne("Backend.Cores.Entities.Campus", null)
                        .WithMany("Accounts")
                        .HasForeignKey("CampusId");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Club", b =>
                {
                    b.HasOne("Backend.Cores.Entities.Campus", "Campus")
                        .WithMany("Clubs")
                        .HasForeignKey("CampusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Cores.Entities.Account", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campus");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Backend.Cores.Entities.ClubEventStaff", b =>
                {
                    b.HasOne("Backend.Cores.Entities.Account", "Account")
                        .WithOne("ClubStaff")
                        .HasForeignKey("Backend.Cores.Entities.ClubEventStaff", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Cores.Entities.Club", "Club")
                        .WithMany("Staffs")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Club");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Event", b =>
                {
                    b.HasOne("Backend.Cores.Entities.Account", null)
                        .WithMany("EventStaff")
                        .HasForeignKey("AccountId");

                    b.HasOne("Backend.Cores.Entities.Club", "Club")
                        .WithMany("Events")
                        .HasForeignKey("club")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("Backend.Cores.Entities.EventRegistration", b =>
                {
                    b.HasOne("Backend.Cores.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Cores.Entities.Event", "Event")
                        .WithMany("EventRegistrations")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Token", b =>
                {
                    b.HasOne("Backend.Cores.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("ValidAccount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Account", b =>
                {
                    b.Navigation("ClubStaff")
                        .IsRequired();

                    b.Navigation("EventStaff");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Campus", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Clubs");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Club", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("Backend.Cores.Entities.Event", b =>
                {
                    b.Navigation("EventRegistrations");
                });
#pragma warning restore 612, 618
        }
    }
}
