﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name invalid.";
        public static string ProductsListed="Product listed";
        public static string MaintenanceTime= "The system is in maintenance";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isim sistemde mevcut";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı.";
    }
}
