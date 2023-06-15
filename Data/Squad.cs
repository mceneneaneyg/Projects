using System;
using System.Collections.Generic;

namespace schoolManagementApp.mvc.Data;

public partial class Squad
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Code { get; set; }

    public int? Rank { get; set; }
}
