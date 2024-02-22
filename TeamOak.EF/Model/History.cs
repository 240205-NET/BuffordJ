using System;
using System.Collections.Generic;

namespace TeamOak.EF.Model;

public partial class History
{
    public int Id { get; set; }

    public int? Bookid { get; set; }

    public int? UserId { get; set; }

    public string? Description { get; set; }

    public virtual Book? Book { get; set; }

    public virtual User? User { get; set; }
}
