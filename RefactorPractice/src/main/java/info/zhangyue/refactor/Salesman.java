package info.zhangyue.refactor;

/**
 * Created with IntelliJ IDEA.
 * User: nickzhang
 * Date: 10/30/12
 * Time: 11:39 AM
 * To change this template use File | Settings | File Templates.
 */
public class Salesman implements EmployeeType {
    @Override
    public int getPayment(Employee employee) {
        return employee.getMonthlySummary() - employee.getCommission();
    }
}
