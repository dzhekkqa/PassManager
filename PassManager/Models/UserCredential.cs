using System;
using System.Collections.Generic;

namespace PassManager.Models;

public partial class UserCredential
{
    public Guid IdUser { get; set; }

    public string? WebResource { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
