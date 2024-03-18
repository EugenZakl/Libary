using System;
using System.Collections.Generic;

namespace Libary.Data;

public partial class PublicationAutor
{
    public int Id { get; set; }

    public int PublicationId { get; set; }

    public virtual Autor IdNavigation { get; set; } = null!;

    public virtual Publication Publication { get; set; } = null!;
}
