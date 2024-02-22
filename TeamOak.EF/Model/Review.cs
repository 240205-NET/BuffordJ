using System;
using System.Collections.Generic;

namespace TeamOak.EF.Model;

public partial class Review
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public int? BookId { get; set; }

    public virtual Book? Book { get; set; }

    public virtual User? User { get; set; }
}
