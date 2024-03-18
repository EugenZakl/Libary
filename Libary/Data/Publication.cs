using System;
using System.Collections.Generic;

namespace Libary.Data;

public partial class Publication
{
    public int Id { get; set; }

    public int GenreId { get; set; }

    public int EpochId { get; set; }

    public string? BookName { get; set; }

    public string? Annotation { get; set; }

    public int? PageCout { get; set; }

    public int? Price { get; set; }

    public int? Year { get; set; }

    public virtual Epoch Epoch { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

    public virtual ICollection<LibaryCheck> LibaryChecks { get; set; } = new List<LibaryCheck>();

    public virtual ICollection<PublicationAutor> PublicationAutors { get; set; } = new List<PublicationAutor>();
}
