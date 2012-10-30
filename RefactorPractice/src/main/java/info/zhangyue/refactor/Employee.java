package info.zhangyue.refactor;

/**
 * Created with IntelliJ IDEA.
 * User: nickzhang
 * Date: 10/25/12
 * Time: 9:59 AM
 * To change this template use File | Settings | File Templates.
 */
public class Employee {
    private int monthlySummary;
    private int commission;
    private int bonus;
    private EmployeeTypeCode employeeTypeCode;

    public Employee(int monthlySummary, int commission, int bonus, EmployeeTypeCode employeeTypeCode) {
        this.monthlySummary = monthlySummary;
        this.commission = commission;
        this.bonus = bonus;
        this.employeeTypeCode = employeeTypeCode;
    }

    public int payment(){
        switch (getTypeCode()){
            case ENGINEER:
                return monthlySummary;
            case SALESMAN:
                return monthlySummary - commission;
            case MANAGER:
                return monthlySummary + bonus;
            default:
                throw new RuntimeException("Incorrect Employee");
        }
    }

    private EmployeeTypeCode getTypeCode() {
        return employeeTypeCode;
    }
}
