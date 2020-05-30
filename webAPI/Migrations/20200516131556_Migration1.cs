using Microsoft.EntityFrameworkCore.Migrations;

namespace webAPI.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "new_Price",
                table: "Products",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Context", "Images", "Name", "Price", "new_Price" },
                values: new object[,]
                {
                    { 1, 102, "İçeriğindeki yüksek E vitamini sayesinde ARGAN YAĞI saçınıza eski gücünü kazandırır. Saçlarınızı besleyip hacim verir. Saçlarınıza ekstra dolgunluk vererek ritüeliniz haline gelir. Her zaman arzuladığın dolgun saçlara Hair Specialist Argan Şampuan ile kavuşabilirsin. ", "https://tr.huncalife.com/Assets/Images/Products/27691_3.png", "Hair Specialist Argan Yağlı Şampuan 350 ml", 50.0, 27.989999999999998 },
                    { 2, 102, "Zeytinyağı ekstraktı içeren formülü ile saçların doğal parlaklığına kavuşmasını hedefler. Saçlarınızı yumuşatmaya ve güçlenmesine yardımcı olur. Saçı diş etkenlere karşı korumaya yardımcı olur. ", "https://tr.huncalife.com/Assets/Images/Products/27620_3.png", "HL Nature Zeytinyağlı Şampuan 500ml", 50.0, 22.989999999999998 },
                    { 3, 102, "Bitki kompleksi içerikli formülü sayesinde saçlarınızın daha sağlıklı ve güçlü olmasına yardımcı olur. Saçlarınızı ağırlaştırmadan derinlemesine temizlenmesini destekler. Saçlarınızın daha parlak ve bakımlı görünüme kavuşmasını amaçlar. Yağlı saç tiplerinin kullanımı için uygundur. ", "https://tr.huncalife.com/Assets/Images/Products/27673_3.png", "Huncalife Nature Isırgan Otlu Şampuan 500 ml", 50.0, 28.989999999999998 },
                    { 4, 102, "Sarımsak ektraktı içeren formülü ile saçlarınızın hacimli, parlak ve güçlü görünümüne yardımcı olur. Kurumuş -Yıpranmış saçlarınızın sağlıklı ışıldamasını destek verir. ", "https://tr.huncalife.com/Assets/Images/Products/27580_3.png", "Huncalife Nature Sarımsaklı Şampuan 500 ml", 50.0, 29.989999999999998 },
                    { 5, 102, "Ardıç özü içeren formülü sayesinde saçınızı yıpratmadan, kurutmadan temizlemeyi destekler. YAĞLI SAÇLAR İÇİN ", "https://tr.huncalife.com/Assets/Images/Products/27518_3.png", "Nature Ardıç Şampuan 400 ml", 60.0, 32.990000000000002 },
                    { 6, 102, "Ferahlatıcı etkisi ile benzersiz bir deneyime hazır mısın?At kestanesi saç ve vücut şampuanı stres ve yorgunluktan kurtularak derinlemesine temizlik ve ferahlık hissetmenizi sağlar. At kestanesi özü ile daha güçlü ve bakımlı saçlara sahip olmanızı destekler. At kestanesi saçlarınızın daha ipeksi ve daha parlak olmasını yardımcı olacaktır. ", "https://tr.huncalife.com/Assets/Images/Products/27527_3.png", "Nature At Kestanesi Saç ve Vücut Şampuanı 350 ml", 45.0, 21.989999999999998 },
                    { 7, 102, "Aynısefa özü içeren bu saç ve vücut şampuanı, kuru saçlar için idealdir. Saçınızın daha nemli, pürüzsüz ve bakımlı görünmesine yardımcı olur. Saçlar için haftada 1-2 defa (önerilen 3 gün ara ile) Aynısefa saç maskesinin de uygulanması nemin korunması için destek sağlayacaktır. ", "https://tr.huncalife.com/Assets/Images/Products/27530_3.png", "Nature Aynısefa Saç ve Vücut Şampuanı 350 ml", 45.0, 29.989999999999998 },
                    { 8, 102, "Biberiye özü içeren özel formülü sayesinde ferahlatıcı etkisi ile saçlarınızda serinlik ve rahatlama hissi bırakır. Aynı zamanda saçınızı beslemeye, güçlendirmeye ve dayanıklı bir hale getirmeye yardımcı olur. NORMAL SAÇLAR İÇİN ", "https://tr.huncalife.com/Assets/Images/Products/27516_3.png", "Nature Çamur Şampuan 400 ml", 60.0, 32.990000000000002 },
                    { 9, 102, "Çay Ağacı saç ve vücut şampuanı ile saçlarınızı ve bedeninizi dinç tutmaya hazır olun. Saçlarınızı derinlemesine temizlemeye yardımcı olur. Kalıcı temizlik ve ferahlık hissi yaratarak, saçlarınızın kolay taranmasını ve şekillendirilmesine yardımcı olur. Yağlı saçlar için kullanıma uygundur. ", "https://tr.huncalife.com/Assets/Images/Products/27525_3.png", "Nature Çay Ağacı Saç ve Vücut Şampuanı 350 ml ", 45.0, 23.989999999999998 },
                    { 10, 102, "Keratin Şampuan kuru, mat ve cansız saçlarınızın,daha parlak,canlı görünümünü destekler. Saç tellerin daha pürüzsüz ve bakımlı olmasını destekler. Islak saça parmak uçlarıyla masaj yaparak köpürtün, iyice durulayın. Etkili sonuç almak için düzenli kullanılması ve durulama sonrası Nature Keratin saç maskesi kullanımı tavsiye edilir.", "https://tr.huncalife.com/Assets/Images/Products/27528_3.png", "Nature Keratin Complex Şampuan 350 ml", 50.0, 27.989999999999998 },
                    { 11, 102, "Yeni Nature siyah sarımsak şampuanı saçların hacimli, güçlü görünmesine destek olurken daha parlak ve pürüzsüz saçlara kavuşmanızı amaçlar.", "https://tr.huncalife.com/Assets/Images/Products/27529_3.png", "Nature Siyah Sarımsaklı Şampuan 350 ml", 50.0, 34.990000000000002 },
                    { 12, 102, "Kaynağı Fransa’daki volkandan elde edilen mineralli su içeriği ile saçlarınızın güçlenmesine yardımcı olur. Daha dolgun ve sağlıklı saçlara kavuşmanızı destekler. KURU ve YIPRANMIŞ SAÇLAR İÇİN", "https://tr.huncalife.com/Assets/Images/Products/27517_3.png", "Nature Volkan Şampuan 400 ml", 60.0, 32.990000000000002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<string>(
                name: "new_Price",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(double),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(double),
                oldMaxLength: 50);
        }
    }
}
