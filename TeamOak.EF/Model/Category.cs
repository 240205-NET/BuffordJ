using System;
using System.Collections.Generic;

namespace TeamOak.EF.Model;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();

    public virtual ICollection<UserBookPreference> UserBookPreferences { get; } = new List<UserBookPreference>();
}
