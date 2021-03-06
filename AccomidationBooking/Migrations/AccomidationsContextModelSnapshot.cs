// <auto-generated />
using System;
using AccomidationBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccomidationBooking.Migrations
{
    [DbContext(typeof(AccomidationsContext))]
    partial class AccomidationsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AccomidationBooking.Models.Accomidation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Accomidations");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("AccomidationsId")
                        .HasColumnType("int")
                        .HasColumnName("Accomidations_Id");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<int>("HotelTypeId")
                        .HasColumnType("int")
                        .HasColumnName("HotelType_Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AccomidationsId");

                    b.HasIndex("HotelTypeId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("AccomidationBooking.Models.HotelType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("HotelType");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("BookedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CheckinDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CheckoutDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Guest")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int")
                        .HasColumnName("Hotel_Id");

                    b.Property<int>("NoofPeople")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("Room_Id");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Availablepeople")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int")
                        .HasColumnName("Hotel_Id");

                    b.Property<bool>("IsAc")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShared")
                        .HasColumnType("bit")
                        .HasColumnName("isShared");

                    b.Property<int>("Maxnoofpeople")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("RoomStatusId")
                        .HasColumnType("int")
                        .HasColumnName("RoomStatus_Id");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int")
                        .HasColumnName("RoomType_Id");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomStatusId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("AccomidationBooking.Models.RoomStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("RoomStatus");
                });

            modelBuilder.Entity("AccomidationBooking.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("RoomType");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Hotel", b =>
                {
                    b.HasOne("AccomidationBooking.Models.Accomidation", "Accomidations")
                        .WithMany("Hotels")
                        .HasForeignKey("AccomidationsId")
                        .HasConstraintName("FK_Hotels_Accomidations_Id")
                        .IsRequired();

                    b.HasOne("AccomidationBooking.Models.HotelType", "HotelType")
                        .WithMany("Hotels")
                        .HasForeignKey("HotelTypeId")
                        .HasConstraintName("FK_Hotels_HotelType_Id")
                        .IsRequired();

                    b.Navigation("Accomidations");

                    b.Navigation("HotelType");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Reservation", b =>
                {
                    b.HasOne("AccomidationBooking.Models.Hotel", "Hotel")
                        .WithMany("Reservations")
                        .HasForeignKey("HotelId")
                        .HasConstraintName("FK_Reservation_Hotel_Id")
                        .IsRequired();

                    b.HasOne("AccomidationBooking.Models.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_Reservation_Room_Id")
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Room", b =>
                {
                    b.HasOne("AccomidationBooking.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .HasConstraintName("FK_Rooms_Hotel_Id")
                        .IsRequired();

                    b.HasOne("AccomidationBooking.Models.RoomStatus", "RoomStatus")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomStatusId")
                        .HasConstraintName("FK_Rooms_RoomStatus_Id")
                        .IsRequired();

                    b.HasOne("AccomidationBooking.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .HasConstraintName("FK_Rooms_RoomType_Id")
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("RoomStatus");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Accomidation", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Hotel", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("AccomidationBooking.Models.HotelType", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("AccomidationBooking.Models.Room", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("AccomidationBooking.Models.RoomStatus", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("AccomidationBooking.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
