using System;
using System.Collections.Generic;

namespace TeamOak.EF.Model;

public partial class UserBookPreference
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual User? User { get; set; }
}
