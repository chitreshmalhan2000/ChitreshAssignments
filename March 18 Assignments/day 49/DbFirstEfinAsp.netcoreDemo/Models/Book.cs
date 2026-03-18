using System;
using System.Collections.Generic;

namespace DbFirstEfinAsp.netcoreDemo.Models;

public partial class Book
{
    public string TitleId { get; set; } = null!;

    public int? Pages { get; set; }

    public int? QtySold { get; set; }
}
