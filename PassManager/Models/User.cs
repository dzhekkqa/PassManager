using System;
using System.Collections.Generic;

namespace PassManager.Models;

public partial class User
{
    public Guid Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? IsAdmin { get; set; }

    public string? Salt { get; set; }
}
