using System;
using System.Collections.Generic;

namespace schoolManagementApp.mvc.Data;

public partial class Commander
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;
}
