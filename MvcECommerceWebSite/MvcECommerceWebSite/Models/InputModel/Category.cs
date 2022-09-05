﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcECommerceWebSite.Models.InputModel
{
    public class Category
    {
        public int Id { get; set; }
        [Required,Display(Name ="Category")]
        public string CategoryName { get; set; }
        [Display(Name ="Description")]
        public string CategoryDescription { get; set; }
        //nev
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}