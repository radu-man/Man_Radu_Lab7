using System;
using System.ComponentModel.DataAnnotations.Schema;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Man_Radu_Lab7.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey(nameof(ShopList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }
    }
}

