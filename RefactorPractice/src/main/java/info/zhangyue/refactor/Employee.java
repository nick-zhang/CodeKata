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
    private EmployeeType employeeType;

    public Employee(int monthlySummary, int commission, int bonus, EmployeeType employeeType) {
        this.monthlySummary = monthlySummary;
        this.commission = commission;
        this.bonus = bonus;
        this.employeeType = employeeType;
    }

    public int payment(){
        switch (getType()){
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

    private EmployeeType getType() {
        return employeeType;
    }
}
