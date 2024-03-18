using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Libary.Data;

public partial class Autor
{
    public int Id { get; set; }
    
    public int RegionId { get; set; }
    [Required(ErrorMessage = "Хоча б одне поле не повинне бути порожнім")]
    public string? AutorName { get; set; }

    public string? Pseudonym { get; set; }

    public virtual PublicationAutor? PublicationAutor { get; set; }

    public virtual Region? Region { get; set; }
}
