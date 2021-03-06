using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class ItemStockModels
    {
        [Key]public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
    public class ItemStockContext : DbContext
    {
        public DbSet<ItemStockModels> StockModel { get; set; }
    }
}