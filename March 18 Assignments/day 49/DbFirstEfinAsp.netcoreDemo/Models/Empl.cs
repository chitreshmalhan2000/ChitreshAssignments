using System;
using System.Collections.Generic;

namespace DbFirstEfinAsp.netcoreDemo.Models;

public partial class Empl
{
    public int Empno { get; set; }

    public string? Ename { get; set; }

    public string? Job { get; set; }

    public int? Mgr { get; set; }

    public DateOnly? Hiredate { get; set; }

    public int? Sal { get; set; }

    public int? Comm { get; set; }

    public int? Deptno { get; set; }

    public virtual Dept1? DeptnoNavigation { get; set; }
}
