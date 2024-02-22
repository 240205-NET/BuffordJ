using System;
using System.Collections.Generic;

namespace TeamOak.EF.Model;

public partial class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Isbn { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<History> Histories { get; } = new List<History>();

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    public virtual ICollection<Wishlist> Wishlists { get; } = new List<Wishlist>();
}
