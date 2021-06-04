using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace appTsane.Models{

    [Table("t_cliente")]
    public class Cliente{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int ID { get; set; }


    [Required(ErrorMessage = "Por favor ingrese Nombre")]
    [Display(Name = "Nombre")]
    public string Name { get; set; }
    
    [Display(Name="Email")]
    [Column("email")]
    public string Email { get; set; }

    [DataType(DataType.PhoneNumber)]
    [Display(Name="Telefono")]
    [Column("phone")]
    public string Phone { get; set; }

}

}