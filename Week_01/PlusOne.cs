using System;
/*66.加一
 * 除 9 之外的数字加一；
   数字 9+1则为零。继续向上一位数加一
 
	 */
public class Class1
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i] += 1;
                return digits;
            }
        }
        digits = new int[digits.Length + 1];
        digits[0] = 1;
        return digits;
    }
}
