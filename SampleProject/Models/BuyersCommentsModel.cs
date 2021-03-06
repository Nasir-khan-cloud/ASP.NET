using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class BuyersCommentsModel
    {
        [ Key]public int BuyersID { get; set; }

        public string BuyersName { get; set; }
        public string StarRating { get; set; }
        public string CommentsTitle { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
    }
   
}