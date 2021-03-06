using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SampleProject.Models
{
    public class ItemCommentsViewModel
    {   
        public ItemModel item { get; set; }
        public List<BuyersCommentsModel> comments { get; set; }
    }
   
}