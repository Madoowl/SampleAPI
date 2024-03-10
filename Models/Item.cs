﻿using System.ComponentModel.DataAnnotations.Schema;

namespace API_DOTNET.Models
{
    [Table("items")] 
    public class Item
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}
