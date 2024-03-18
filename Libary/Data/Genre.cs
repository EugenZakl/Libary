using System;
using System.Collections.Generic;

namespace Libary.Data;

public partial class Genre
{
    public int Id { get; set; }

    public string? GenreName { get; set; }

    public virtual ICollection<Publication> Publications { get; set; } = new List<Publication>();
}
