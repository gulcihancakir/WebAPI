﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webAPI.Persistance.Contexts;

namespace webAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webAPI.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 102,
                            Name = "Şampuan"
                        },
                        new
                        {
                            Id = 103,
                            Name = "Saç Kremi"
                        },
                        new
                        {
                            Id = 104,
                            Name = "2'si 1 Arada Ürün"
                        },
                        new
                        {
                            Id = 105,
                            Name = "Şekillendirici"
                        },
                        new
                        {
                            Id = 106,
                            Name = "Maske"
                        },
                        new
                        {
                            Id = 107,
                            Name = "Serum"
                        },
                        new
                        {
                            Id = 108,
                            Name = "Durulanmayan Bakım Ürünleri"
                        },
                        new
                        {
                            Id = 109,
                            Name = "Saç Maskarası"
                        });
                });

            modelBuilder.Entity("webAPI.Domain.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("webAPI.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Context")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasMaxLength(50);

                    b.Property<int>("StockCount")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<double>("new_Price")
                        .HasColumnType("float")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 102,
                            Context = "İçeriğindeki yüksek E vitamini sayesinde ARGAN YAĞI saçınıza eski gücünü kazandırır. Saçlarınızı besleyip hacim verir. Saçlarınıza ekstra dolgunluk vererek ritüeliniz haline gelir. Her zaman arzuladığın dolgun saçlara Hair Specialist Argan Şampuan ile kavuşabilirsin. ",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27691_3.png",
                            Name = "Hair Specialist Argan Yağlı Şampuan 350 ml",
                            Price = 50.0,
                            StockCount = 20,
                            new_Price = 27.989999999999998
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 102,
                            Context = "Zeytinyağı ekstraktı içeren formülü ile saçların doğal parlaklığına kavuşmasını hedefler. Saçlarınızı yumuşatmaya ve güçlenmesine yardımcı olur. Saçı diş etkenlere karşı korumaya yardımcı olur. ",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27620_3.png",
                            Name = "HL Nature Zeytinyağlı Şampuan 500ml",
                            Price = 50.0,
                            StockCount = 20,
                            new_Price = 22.989999999999998
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 102,
                            Context = "Bitki kompleksi içerikli formülü sayesinde saçlarınızın daha sağlıklı ve güçlü olmasına yardımcı olur. Saçlarınızı ağırlaştırmadan derinlemesine temizlenmesini destekler. Saçlarınızın daha parlak ve bakımlı görünüme kavuşmasını amaçlar. Yağlı saç tiplerinin kullanımı için uygundur. ",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27673_3.png",
                            Name = "Huncalife Nature Isırgan Otlu Şampuan 500 ml",
                            Price = 50.0,
                            StockCount = 20,
                            new_Price = 28.989999999999998
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 102,
                            Context = "Sarımsak ektraktı içeren formülü ile saçlarınızın hacimli, parlak ve güçlü görünümüne yardımcı olur. Kurumuş -Yıpranmış saçlarınızın sağlıklı ışıldamasını destek verir. ",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27580_3.png",
                            Name = "Huncalife Nature Sarımsaklı Şampuan 500 ml",
                            Price = 50.0,
                            StockCount = 20,
                            new_Price = 29.989999999999998
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 102,
                            Context = "Ardıç özü içeren formülü sayesinde saçınızı yıpratmadan, kurutmadan temizlemeyi destekler. YAĞLI SAÇLAR İÇİN ",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27518_3.png",
                            Name = "Nature Ardıç Şampuan 400 ml",
                            Price = 60.0,
                            StockCount = 20,
                            new_Price = 32.990000000000002
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 102,
                            Context = "Ferahlatıcı etkisi ile benzersiz bir deneyime hazır mısın?At kestanesi saç ve vücut şampuanı stres ve yorgunluktan kurtularak derinlemesine temizlik ve ferahlık hissetmenizi sağlar. At kestanesi özü ile daha güçlü ve bakımlı saçlara sahip olmanızı destekler. At kestanesi saçlarınızın daha ipeksi ve daha parlak olmasını yardımcı olacaktır. ",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27527_3.png",
                            Name = "Nature At Kestanesi Saç ve Vücut Şampuanı 350 ml",
                            Price = 45.0,
                            StockCount = 20,
                            new_Price = 21.989999999999998
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 102,
                            Context = "Aynısefa özü içeren bu saç ve vücut şampuanı, kuru saçlar için idealdir. Saçınızın daha nemli, pürüzsüz ve bakımlı görünmesine yardımcı olur. Saçlar için haftada 1-2 defa (önerilen 3 gün ara ile) Aynısefa saç maskesinin de uygulanması nemin korunması için destek sağlayacaktır. ",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27530_3.png",
                            Name = "Nature Aynısefa Saç ve Vücut Şampuanı 350 ml",
                            Price = 45.0,
                            StockCount = 20,
                            new_Price = 29.989999999999998
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 102,
                            Context = "Biberiye özü içeren özel formülü sayesinde ferahlatıcı etkisi ile saçlarınızda serinlik ve rahatlama hissi bırakır. Aynı zamanda saçınızı beslemeye, güçlendirmeye ve dayanıklı bir hale getirmeye yardımcı olur. NORMAL SAÇLAR İÇİN ",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27516_3.png",
                            Name = "Nature Çamur Şampuan 400 ml",
                            Price = 60.0,
                            StockCount = 20,
                            new_Price = 32.990000000000002
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 102,
                            Context = "Çay Ağacı saç ve vücut şampuanı ile saçlarınızı ve bedeninizi dinç tutmaya hazır olun. Saçlarınızı derinlemesine temizlemeye yardımcı olur. Kalıcı temizlik ve ferahlık hissi yaratarak, saçlarınızın kolay taranmasını ve şekillendirilmesine yardımcı olur. Yağlı saçlar için kullanıma uygundur. ",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27525_3.png",
                            Name = "Nature Çay Ağacı Saç ve Vücut Şampuanı 350 ml ",
                            Price = 45.0,
                            StockCount = 20,
                            new_Price = 23.989999999999998
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 102,
                            Context = "Keratin Şampuan kuru, mat ve cansız saçlarınızın,daha parlak,canlı görünümünü destekler. Saç tellerin daha pürüzsüz ve bakımlı olmasını destekler. Islak saça parmak uçlarıyla masaj yaparak köpürtün, iyice durulayın. Etkili sonuç almak için düzenli kullanılması ve durulama sonrası Nature Keratin saç maskesi kullanımı tavsiye edilir.",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27528_3.png",
                            Name = "Nature Keratin Complex Şampuan 350 ml",
                            Price = 50.0,
                            StockCount = 20,
                            new_Price = 27.989999999999998
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 102,
                            Context = "Yeni Nature siyah sarımsak şampuanı saçların hacimli, güçlü görünmesine destek olurken daha parlak ve pürüzsüz saçlara kavuşmanızı amaçlar.",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27529_3.png",
                            Name = "Nature Siyah Sarımsaklı Şampuan 350 ml",
                            Price = 50.0,
                            StockCount = 20,
                            new_Price = 34.990000000000002
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 102,
                            Context = "Kaynağı Fransa’daki volkandan elde edilen mineralli su içeriği ile saçlarınızın güçlenmesine yardımcı olur. Daha dolgun ve sağlıklı saçlara kavuşmanızı destekler. KURU ve YIPRANMIŞ SAÇLAR İÇİN",
                            Images = "https://tr.huncalife.com/Assets/Images/Products/27517_3.png",
                            Name = "Nature Volkan Şampuan 400 ml",
                            Price = 60.0,
                            StockCount = 20,
                            new_Price = 32.990000000000002
                        });
                });

            modelBuilder.Entity("webAPI.Domain.Models.Sepet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasMaxLength(50);

                    b.Property<double>("new_Price")
                        .HasColumnType("float")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Sepet");
                });

            modelBuilder.Entity("webAPI.Domain.Models.Signup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Signup");
                });

            modelBuilder.Entity("webAPI.Domain.Models.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasMaxLength(50);

                    b.Property<double>("new_Price")
                        .HasColumnType("float")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Siparis");
                });

            modelBuilder.Entity("webAPI.Domain.Models.Product", b =>
                {
                    b.HasOne("webAPI.Domain.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
