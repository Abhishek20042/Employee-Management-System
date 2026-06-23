using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Employee;
[Table("DEPT")]
public class Dept
{
    [Column("DEPTNO")]
    public int Id { get; set; }
    public string DNAME { get; set; }

    public string LOC { get; set; }

     public ICollection<Emp> Employees { get; set; } = [];

}