using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appTsane.Models{

// carrito 

[Table("t_order")]
    public class Pedido
    {

[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        public String UserID {get; set;}


        public Decimal Total { get; set; }






    }







}