﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGITALMENU.MODEL
{
    public  class Menu
    {
        [Key]
        public int DishID { get; set; }


        [Required(ErrorMessage ="Please write the dish name")]
        [Display(Name ="Dish Name")]
        public string DishName { get; set; }

        [Required]
        [Display(Name ="Description")]
        [StringLength(500, MinimumLength = 30)]
        public string DishDescription { get; set; }


        [Required(ErrorMessage ="Please add price ")]
        [Display(Name ="Price")]
        public int DishPrice { get; set; }

      
        [Display(Name ="Category")]
        public string DishCategory { get; set; }


        [Required(ErrorMessage = "Please choose the Type")]
        [Display(Name = "Type")]
        public Type DishType { get; set; }


        [Required(ErrorMessage = "Please choose the Quantity")]
        [Display(Name = "Quantity")]
        public Qunatity DishQuantity { get; set; }


        [NotMapped]
        public IFormFile DishPhoto { get; set; }

        public string DishImageUrl { get; set; }

        public DateTime? CreatedOn { get; set; }

        public enum  Type
        {
            Indian = 1,
            Chinese = 2,
            Italian = 3,
            Australian = 4,
            Thai = 5
        }

        public enum Qunatity
        {
            Full,
            Half
           
        }
    }
}
