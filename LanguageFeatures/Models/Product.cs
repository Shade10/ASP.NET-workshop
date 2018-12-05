﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models {
    public class Product {
        private string name;

        public string Name {
            get { return ProductId + name; }
            set { name = value; }
        }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string category { get; set; }

    }
}