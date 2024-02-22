using System;
using System.Collections.Generic;

namespace TeamOak.EF.Model;

public partial class UserDetail
{
    public int Id { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public int? Zip { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
