package info.zhangyue.refactor;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

import static org.hamcrest.CoreMatchers.is;
import static org.junit.Assert.assertThat;
import static org.junit.runners.Parameterized.*;

/**
 * Created with IntelliJ IDEA.
 * User: nickzhang
 * Date: 10/29/12
 * Time: 1:20 PM
 * To change this template use File | Settings | File Templates.
 */
@RunWith(value = Parameterized.class)
public class CalculatorTest {

    private final int addend1;
    private final int addend2;
    private final int expectedResult;

    public CalculatorTest(int addend1, int addend2, int expectedResult) {
        this.addend1 = addend1;
        this.addend2 = addend2;
        this.expectedResult = expectedResult;
    }

    @Parameters
    public static Collection<Object[]> data() {
        Object[][] data = new Object[][] { { 1, 2, 3 }, { -2, -1, -3 }, { 3, 0, 3 } };
        return Arrays.asList(data);
    }

    @Test
    public void shouldAddedTwoNumbersCorrectly(){
        Calculator calculator = new Calculator();
        assertThat(calculator.add(addend1, addend2), is(expectedResult));
    }

}
