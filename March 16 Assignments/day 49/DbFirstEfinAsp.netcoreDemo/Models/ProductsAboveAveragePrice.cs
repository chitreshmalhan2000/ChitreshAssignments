using System;
using System.Collections.Generic;

namespace DbFirstEfinAsp.netcoreDemo.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
