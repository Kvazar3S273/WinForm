﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TreeView
{
    /// <summary>
    /// Категорії
    /// </summary>
    [Table("tblBreeds")]
    public class Breed
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Image { get; set; }
        
        [StringLength(255)]
        public string UrlSlug { get; set; }
        
        [ForeignKey("Parent")]
        public int ? ParentId { get; set; }
        public virtual Breed Parent { get; set; }
    }
}
