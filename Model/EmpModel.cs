using DemoApp.Employee;

namespace DemoApp.Model;

public class EmpModel
{
    public List<Emp> FetchEmployees()
    {
        using var emp = new EmployeeDbContext();
        return emp.Employees.ToList();
    }

    public void AcceptEmplyee(
    int EmpId,
    string EmpName,
    string EmpJob,
    int? EmpMgr,
    DateOnly EmpHiredate,
    decimal? EmpSal,
    decimal? EmpComm,
    int? EmpDeptId)
{
    using var emp = new EmployeeDbContext();

    var employee = emp.Employees.Find(EmpId);

    if(employee == null)
    {
        employee = new Emp { Id = EmpId };
        emp.Employees.Add(employee);
    }

    employee.ENAME = EmpName;
    employee.JOB = EmpJob;
    employee.MGR = EmpMgr;
    employee.HIREDATE = EmpHiredate;
    employee.SAL = EmpSal;
    employee.COMM = EmpComm;
    employee.DEPTID = EmpDeptId;

    emp.SaveChanges();
}
}