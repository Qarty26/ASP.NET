﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3_DB.Models.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
/*        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]*/

        public Guid Id { get; set; }
        public DateTime? DateTime { get; set; } 
        public DateTime? LastModified { get; set; }
    }
}
