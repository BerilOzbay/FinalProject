using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAddedMessage = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductListed = "Ürünler Listelendi";
        internal static string UnitPriceInvalid = "Fiyat geçersiz";
        internal static string ProductCountOfCategorError = "Bu kategoride en fazla 10 ürün olabilir";
        internal static string ProductUpdateMessage = "Ürün güncellendi";
        internal static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldı.";
    }

}
