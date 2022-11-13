using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Car //: CarBase
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public Guid ID { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Make { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}