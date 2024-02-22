using System;
using System.Collections.Generic;

namespace TeamOak.EF.Model;

public partial class User
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? UserDetailsId { get; set; }

    public virtual ICollection<History> Histories { get; } = new List<History>();

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();

    public virtual ICollection<UserBookPreference> UserBookPreferences { get; } = new List<UserBookPreference>();

    public virtual UserDetail? UserDetails { get; set; }

    public virtual ICollection<Wishlist> Wishlists { get; } = new List<Wishlist>();
}
