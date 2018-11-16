﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Shopping.Models
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Please Enter Product Name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Description")]
        public string ProductDesc { get; set; }

        [Required(ErrorMessage = "Please Enter Unit Price")]
        [Display(Name = "Unit Price")]
        public string ProductUnitPrice { get; set; }


        [Required(ErrorMessage = "Please Enter Unit")]
        [Display(Name = "Unit")]
        public string ProductUnit { get; set; }

        [Required(ErrorMessage = "Please Enter Category Name")]
        [Display(Name = "Category")]
        public string CategoryId { get; set; }
    }
}