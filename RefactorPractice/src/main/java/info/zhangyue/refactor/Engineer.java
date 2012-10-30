package info.zhangyue.refactor;

/**
 * Created with IntelliJ IDEA.
 * User: nickzhang
 * Date: 10/30/12
 * Time: 11:01 AM
 * To change this template use File | Settings | File Templates.
 */
public class Engineer implements EmployeeType {
    @Override
    public int getPayment(Employee employee) {
        return employee.getMonthlySummary();
    }
}
