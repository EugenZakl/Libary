using System;
using System.Collections.Generic;

namespace Libary.Data;

public partial class Region
{
    public int Id { get; set; }

    public string? RegionName { get; set; }

    public virtual ICollection<Autor> Autors { get; set; } = new List<Autor>();
}
