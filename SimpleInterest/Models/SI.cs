using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleInterest.Models
{
    public class SimpleInterestModel
    {
        [Required(ErrorMessage = "Principal amount is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Principal amount must be greater than zero.")]
        public decimal? Principal { get; set; }
        [Required(ErrorMessage = "Rate of interest is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Rate of interest must be greater than zero.")]
        public decimal? Amount {  get; set; }   //Here Amount refers to Rate
        [Required(ErrorMessage = "Number of years is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Number of years must be at least 1.")]
        public int? Year { get; set; }
        [Required(ErrorMessage = "Simple interest is required.")]
        public decimal? SimpleInterest { get; set; }
    }
}