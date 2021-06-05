using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using appTsane.Models;


namespace appTsane.Models{

    [Table("t_contact")]
    public class Contacto{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int ID { get; set; }


    [Required(ErrorMessage = "Por favor ingrese Nombre")]
    [Display(Name = "Nombre")]
    public string Name { get; set; }
    
    
    public string Email { get; set; }

    
    public string Phone { get; set; }

    
}

}