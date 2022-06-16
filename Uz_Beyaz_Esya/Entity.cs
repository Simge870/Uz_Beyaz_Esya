using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uz_Beyaz_Esya
{
    public class Musteri
    {
        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }
        public class Urun
        {
            public Guid ID { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Renk { get; set; }
            public string Stok { get; set; }
            public string Seri { get; set; }
            public string Garanti { get; set; }
            public string Tarih { get; set; }
            public override string ToString()
            {
                return $"{Marka} {Model}";
            }
        }

        public class Satis
        {
            public Guid ID { get; set; }
            public Guid MusteriID { get; set; }
            public Guid UrunID { get; set; }
            public DateTime Tarih { get; set; }
            public Double Fiyat { get; set; }
        }

        public class Odeme 
        {
            public Guid ID { get; set; }
            public Guid MusteriID { get; set; }
            public DateTime Tarih { get; set; }
            public Double Tutar { get; set; }
            public string Tur { get; set; }
            public string Aciklama { get; set; }
        }
    
}
