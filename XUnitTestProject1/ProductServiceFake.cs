using System;
using System.Collections.Generic;
using System.Text;
using webAPI.Domain.Models;

namespace XUnitTestProject1
{
    class ProductServiceFake
    {
        private readonly List<Product> _products;

        public ProductServiceFake()
        {
            _products = new List<Product>()
            {
                new Product() { Id = 34,
                    Name = "Hair Specialist Argan Yağlı Şampuan 350 ml",  Price ="50,00" ,new_Price="29,99" ,Context="İçeriğindeki yüksek E vitamini sayesinde ARGAN YAĞI saçınıza eski gücünü kazandırır. Saçlarınızı besleyip hacim verir. Saçlarınıza ekstra dolgunluk vererek ritüeliniz haline gelir. Her zaman arzuladığın dolgun saçlara Hair Specialist Argan Şampuan ile kavuşabilirsin. ",Images="https://tr.huncalife.com/Assets/Images/Products/27691_3.png" ,CategoryId=102 ,Category={Id=102,Name="Şampuan"} },
                 new Product() { Id = 35,
                    Name = "Hair Specialist Argan Yağlı Şampuan 350 ml",  Price ="50,00" ,new_Price="29,99" ,Context="Zeytinyağı ekstraktı içeren formülü ile saçların doğal parlaklığına kavuşmasını hedefler. Saçlarınızı yumuşatmaya ve güçlenmesine yardımcı olur. Saçı diş etkenlere karşı korumaya yardımcı olur. ",Images="https://tr.huncalife.com/Assets/Images/Products/27620_3.png" ,CategoryId=102,Category={Id=102,Name="Şampuan"}},
                new Product() { Id = 36,
                    Name = "Huncalife Nature Isırgan Otlu Şampuan 500 ml",  Price ="50,00" ,new_Price="29,99" ,Context="Bitki kompleksi içerikli formülü sayesinde saçlarınızın daha sağlıklı ve güçlü olmasına yardımcı olur. Saçlarınızı ağırlaştırmadan derinlemesine temizlenmesini destekler. Saçlarınızın daha parlak ve bakımlı görünüme kavuşmasını amaçlar. Yağlı saç tiplerinin kullanımı için uygundur. ",Images="https://tr.huncalife.com/Assets/Images/Products/27673_3.png" ,CategoryId=102,Category={Id=102,Name="Şampuan"}}
            };
        }

        public IEnumerable<Product> GetAllItems()
        {
            return _products;
        }

        //public Product Add(Product newItem)
        //{
        //    newItem.Id = new int();
        //    _products.Add(newItem);
        //    return newItem;
        //}

        //public Product GetById(int id)
        //{
        //    return _products.Where(a => a.Id == id)
        //        .FirstOrDefault();
        //}

        //public void Remove(int id)
        //{
        //    var existing = _products.First(a => a.Id == id);
        //    _products.Remove(existing);
        //}
    }
}
