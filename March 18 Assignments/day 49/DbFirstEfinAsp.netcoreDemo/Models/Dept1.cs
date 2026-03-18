using System;
using System.Collections.Generic;

namespace DbFirstEfinAsp.netcoreDemo.Models;

public partial class Dept1
{
    public int Deptno { get; set; }

    public string? Dname { get; set; }

    public string? Loc { get; set; }

    public virtual ICollection<Empl> Empls { get; set; } = new List<Empl>();
}
