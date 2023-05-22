﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "product added";
        public static string ProductNameInvalid = "product name is invalid";
        public static string MaintenanceTime= "system in maintenance";
        public static string ProductsListed="products listed";
        public static string ProductCountOfCategoryError= "a category can contain up to 10 products";
        public static string ProductNameAlreadyExists= "there is already another product with this name";
        public static string CategoryLimitExceded = "no new products are added because the category limit has been exceeded.";
    }
}
