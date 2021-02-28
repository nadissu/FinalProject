using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla on ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün eklenemez";
        public static string CategoryLimitExceded="Limit kuralı aşıldı";
    }
}
