﻿namespace Shop.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class DeliverViewModel
    {
        public int Id { get; set; }

        [Display(Name ="Delivery date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/mm/dd hh:mm tt", ApplyFormatInEditMode = true)]
        public DateTime DeliveryDate { get; set; }
    }
}
