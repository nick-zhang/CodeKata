package info.zhangyue.refactor;

import org.junit.Test;

import static org.hamcrest.CoreMatchers.is;
import static org.junit.Assert.assertThat;

/**
 * Created with IntelliJ IDEA.
 * User: nickzhang
 * Date: 10/25/12
 * Time: 10:15 AM
 * To change this template use File | Settings | File Templates.
 */
public class EmployeeTest {
    @Test
    public void shouldReturnCorrectPaymentForEngineer(){
        Employee engineer = new Employee(500, 0, 0, new Engineer());
        int payment = engineer.payment();
        assertThat("Payment is not correct.", payment, is(500));
    }

    @Test
    public void shouldReturnCorrectPaymentForSalesman(){
        Employee salesman = new Employee(500, 100, 0, new Salesman());
        int payment = salesman.payment();
        assertThat("Payment is not correct.", payment, is(500-100));
    }

    @Test
    public void shouldReturnCorrectPaymentForManager(){
        Employee manager = new Employee(500, 100, 100, new Manager());
        int payment = manager.payment();
        assertThat("Payment is not correct.", payment, is(500+100));
    }
}
