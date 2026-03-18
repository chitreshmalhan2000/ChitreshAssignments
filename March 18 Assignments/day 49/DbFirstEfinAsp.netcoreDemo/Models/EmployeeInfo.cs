using System;
using System.Collections.Generic;

namespace DbFirstEfinAsp.netcoreDemo.Models;

public partial class EmployeeInfo
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public int? Salary { get; set; }

    public DateTime? StartDate { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }
}
