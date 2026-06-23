using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Employee;

[Table("EMP")]
public class Emp
{
    [Column("EMPNO")]
    public int Id { get; set; }

    public string ENAME { get; set; }

    public string  JOB { get; set; }

    public int? MGR { get; set; }

    public DateOnly HIREDATE { get; set; }

    public decimal? SAL { get; set; }

    public decimal? COMM { get; set; }

    [Column("DEPTNO")]
    public int? DEPTID { get; set; }

    
}