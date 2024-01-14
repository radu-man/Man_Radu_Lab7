﻿using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Man_Radu_Lab7.Models
{
	public class Shop
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ShopName { get; set; }
        public string Adress { get; set; }
        public string ShopDetails
        {
            get
            {
                return ShopName + "" + Adress;}
            }

        [OneToMany]
        public List<ShopList> ShopLists { get; set; }

    }
}

