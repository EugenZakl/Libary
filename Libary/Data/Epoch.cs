using System;
using System.Collections.Generic;

namespace Libary.Data;

public partial class Epoch
{
    public int Id { get; set; }

    public string? EpochName { get; set; }

    public virtual ICollection<Publication> Publications { get; set; } = new List<Publication>();
}
