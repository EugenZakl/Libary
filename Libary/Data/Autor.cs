﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Libary.Data;

public partial class Autor : Entity
{
    public int Id { get; set; }

    public int RegionId { get; set; }

    [Required(ErrorMessage = "Хоча б одне поле не повинне бути порожнім")]
    [RegularExpression(@"^[^\d]+$", ErrorMessage = "Поле не може містити числа")]
    public string? AutorName { get; set; }
    [RegularExpression(@"^[^\d]+$", ErrorMessage = "Поле не може містити числа")]
    public string? Pseudonym { get; set; }
    [RegularExpression(@"^[^\d]+$", ErrorMessage = "Поле не може містити числа")]
    public virtual PublicationAutor? PublicationAutor { get; set; }

    public virtual Region? Region { get; set; }
}
