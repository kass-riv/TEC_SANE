using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appTsane.Models{


[Table("t_proforma")]
    public class Proforma
    {

[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}


      public String UserID {get; set;}

        public Producto Producto {get; set;}

        public int Quantity{get; set;}

        public Decimal Price { get; set; }



    }











}