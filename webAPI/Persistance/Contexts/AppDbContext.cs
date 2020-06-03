using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace webAPI.Persistance.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sepet> Sepet { get; set; } 
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<Signup> Signup { get; set; }
        public DbSet<Login> Login { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
           (
               new Category { Id = 102, Name = "Şampuan" }, // Id set manually due to in-memory provider
               new Category { Id = 103, Name = "Saç Kremi" },
               new Category { Id = 104, Name = "2'si 1 Arada Ürün" },
               new Category { Id = 105, Name = "Şekillendirici" },
               new Category { Id = 106, Name = "Maske" },
               new Category { Id = 107, Name = "Serum" },
               new Category { Id = 108, Name = "Durulanmayan Bakım Ürünleri" },
               new Category { Id = 109, Name = "Saç Maskarası" }
               );



            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Product>().Property(p => p.Context).IsRequired().HasMaxLength(500);
            builder.Entity<Product>().Property(p => p.Price).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.new_Price).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Images).IsRequired().HasMaxLength(100);
            builder.Entity<Product>().Property(p => p.StockCount).IsRequired().HasMaxLength(50);

            builder.Entity<Product>().HasData
          (
            new Product { Id=1 ,Name= "Hair Specialist Argan Yağlı Şampuan 350 ml", Context= "İçeriğindeki yüksek E vitamini sayesinde ARGAN YAĞI saçınıza eski gücünü kazandırır. Saçlarınızı besleyip hacim verir. Saçlarınıza ekstra dolgunluk vererek ritüeliniz haline gelir. Her zaman arzuladığın dolgun saçlara Hair Specialist Argan Şampuan ile kavuşabilirsin. ", Price= 50.00, new_Price= 27.99 ,Images = "https://tr.huncalife.com/Assets/Images/Products/27691_3.png",StockCount = 20, CategoryId =102},
            new Product { Id=2 ,Name= "HL Nature Zeytinyağlı Şampuan 500ml", Context= "Zeytinyağı ekstraktı içeren formülü ile saçların doğal parlaklığına kavuşmasını hedefler. Saçlarınızı yumuşatmaya ve güçlenmesine yardımcı olur. Saçı diş etkenlere karşı korumaya yardımcı olur. ", Price= 50.00, new_Price= 22.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27620_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=3 ,Name= "Huncalife Nature Isırgan Otlu Şampuan 500 ml", Context= "Bitki kompleksi içerikli formülü sayesinde saçlarınızın daha sağlıklı ve güçlü olmasına yardımcı olur. Saçlarınızı ağırlaştırmadan derinlemesine temizlenmesini destekler. Saçlarınızın daha parlak ve bakımlı görünüme kavuşmasını amaçlar. Yağlı saç tiplerinin kullanımı için uygundur. ", Price= 50.00, new_Price= 28.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27673_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=4 ,Name= "Huncalife Nature Sarımsaklı Şampuan 500 ml", Context= "Sarımsak ektraktı içeren formülü ile saçlarınızın hacimli, parlak ve güçlü görünümüne yardımcı olur. Kurumuş -Yıpranmış saçlarınızın sağlıklı ışıldamasını destek verir. ", Price= 50.00, new_Price= 29.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27580_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=5 ,Name= "Nature Ardıç Şampuan 400 ml", Context= "Ardıç özü içeren formülü sayesinde saçınızı yıpratmadan, kurutmadan temizlemeyi destekler. YAĞLI SAÇLAR İÇİN ", Price= 60.00, new_Price= 32.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27518_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=6 ,Name= "Nature At Kestanesi Saç ve Vücut Şampuanı 350 ml", Context= "Ferahlatıcı etkisi ile benzersiz bir deneyime hazır mısın?At kestanesi saç ve vücut şampuanı stres ve yorgunluktan kurtularak derinlemesine temizlik ve ferahlık hissetmenizi sağlar. At kestanesi özü ile daha güçlü ve bakımlı saçlara sahip olmanızı destekler. At kestanesi saçlarınızın daha ipeksi ve daha parlak olmasını yardımcı olacaktır. ", Price= 45.00, new_Price= 21.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27527_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=7 ,Name= "Nature Aynısefa Saç ve Vücut Şampuanı 350 ml", Context= "Aynısefa özü içeren bu saç ve vücut şampuanı, kuru saçlar için idealdir. Saçınızın daha nemli, pürüzsüz ve bakımlı görünmesine yardımcı olur. Saçlar için haftada 1-2 defa (önerilen 3 gün ara ile) Aynısefa saç maskesinin de uygulanması nemin korunması için destek sağlayacaktır. ", Price= 45.00, new_Price= 29.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27530_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=8 ,Name= "Nature Çamur Şampuan 400 ml", Context= "Biberiye özü içeren özel formülü sayesinde ferahlatıcı etkisi ile saçlarınızda serinlik ve rahatlama hissi bırakır. Aynı zamanda saçınızı beslemeye, güçlendirmeye ve dayanıklı bir hale getirmeye yardımcı olur. NORMAL SAÇLAR İÇİN ", Price= 60.00, new_Price= 32.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27516_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=9 ,Name= "Nature Çay Ağacı Saç ve Vücut Şampuanı 350 ml ", Context= "Çay Ağacı saç ve vücut şampuanı ile saçlarınızı ve bedeninizi dinç tutmaya hazır olun. Saçlarınızı derinlemesine temizlemeye yardımcı olur. Kalıcı temizlik ve ferahlık hissi yaratarak, saçlarınızın kolay taranmasını ve şekillendirilmesine yardımcı olur. Yağlı saçlar için kullanıma uygundur. ", Price= 45.00, new_Price= 23.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27525_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=10 ,Name= "Nature Keratin Complex Şampuan 350 ml", Context= "Keratin Şampuan kuru, mat ve cansız saçlarınızın,daha parlak,canlı görünümünü destekler. Saç tellerin daha pürüzsüz ve bakımlı olmasını destekler. Islak saça parmak uçlarıyla masaj yaparak köpürtün, iyice durulayın. Etkili sonuç almak için düzenli kullanılması ve durulama sonrası Nature Keratin saç maskesi kullanımı tavsiye edilir.", Price= 50.00, new_Price= 27.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27528_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=11 ,Name= "Nature Siyah Sarımsaklı Şampuan 350 ml", Context= "Yeni Nature siyah sarımsak şampuanı saçların hacimli, güçlü görünmesine destek olurken daha parlak ve pürüzsüz saçlara kavuşmanızı amaçlar.", Price= 50.00, new_Price= 34.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27529_3.png", StockCount = 20, CategoryId =102 },
            new Product { Id=12 ,Name= "Nature Volkan Şampuan 400 ml", Context = "Kaynağı Fransa’daki volkandan elde edilen mineralli su içeriği ile saçlarınızın güçlenmesine yardımcı olur. Daha dolgun ve sağlıklı saçlara kavuşmanızı destekler. KURU ve YIPRANMIŞ SAÇLAR İÇİN", Price = 60.00, new_Price= 32.99, Images= "https://tr.huncalife.com/Assets/Images/Products/27517_3.png", StockCount = 20, CategoryId =102 }

          );



            builder.Entity<Sepet>().ToTable("Sepet");
            builder.Entity<Sepet>().HasKey(p => p.Id);
            builder.Entity<Sepet>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Sepet>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Sepet>().Property(p => p.Price).IsRequired().HasMaxLength(50);
            builder.Entity<Sepet>().Property(p => p.new_Price).IsRequired().HasMaxLength(50);
            builder.Entity<Sepet>().Property(p => p.Count).IsRequired().HasMaxLength(50);
            builder.Entity<Sepet>().Property(p => p.Images).IsRequired().HasMaxLength(100);


            builder.Entity<Siparis>().ToTable("Siparis");
            builder.Entity<Siparis>().HasKey(p => p.Id);
            builder.Entity<Siparis>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Siparis>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Siparis>().Property(p => p.Price).IsRequired().HasMaxLength(50);
            builder.Entity<Siparis>().Property(p => p.new_Price).IsRequired().HasMaxLength(50);
            builder.Entity<Siparis>().Property(p => p.Count).IsRequired().HasMaxLength(50);
            builder.Entity<Siparis>().Property(p => p.Images).IsRequired().HasMaxLength(100);

            builder.Entity<Signup>().ToTable("Signup");
            builder.Entity<Signup>().HasKey(p => p.Id);
            builder.Entity<Signup>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Signup>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Signup>().Property(p => p.Surname).IsRequired().HasMaxLength(100);
            builder.Entity<Signup>().Property(p => p.Phone_Number).IsRequired().HasMaxLength(11);
            builder.Entity<Signup>().Property(p => p.Adress).IsRequired().HasMaxLength(400);
            builder.Entity<Signup>().Property(p => p.Email).IsRequired().HasMaxLength(400);

            builder.Entity<Login>().ToTable("Login");
            builder.Entity<Login>().HasKey(p => p.Id);
            builder.Entity<Login>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Login>().Property(p => p.Email).IsRequired().HasMaxLength(100);
            builder.Entity<Login>().Property(p => p.Parola).IsRequired().HasMaxLength(100);








        }

    }
}
