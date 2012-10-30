package info.zhangyue.refactor;

/**
 * Created with IntelliJ IDEA.
 * User: nickzhang
 * Date: 10/30/12
 * Time: 11:51 AM
 * To change this template use File | Settings | File Templates.
 */
public class Manager implements EmployeeType {
    @Override
    public int getPayment(Employee employee) {
        return employee.getMonthlySummary() + employee.getBonus();
    }
}
