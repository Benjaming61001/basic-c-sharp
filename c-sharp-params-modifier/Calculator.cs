namespace c_sharp_params_modifier;

class Calculator
{
	public static int Add(params int[] numbers)
	{
		int sum = 0;
		foreach (int number in numbers)
		{
			sum += number;
		}
		return sum;
	}

	public static int Subtract(params int[] numbers)
	{
		if (numbers.Length == 0)
		{
			throw new ArgumentException("At least one number is required.");
		}

		int result = numbers[0];
		for (int i = 1; i < numbers.Length; i++)
		{
			result -= numbers[i];
		}
		return result;
	}

	public static int Multiply(params int[] numbers)
	{
		if (numbers.Length == 0)
		{
			throw new ArgumentException("At least one number is required.");
		}

		int result = 1;
		foreach (int number in numbers)
		{
			result *= number;
		}
		return result;
	}

	public static double Divide(params int[] numbers)
	{
		if (numbers.Length == 0)
		{
			throw new ArgumentException("At least one number is required.");
		}

		double result = numbers[0];
		for (int i = 1; i < numbers.Length; i++)
		{
			if (numbers[i] == 0)
			{
				throw new DivideByZeroException("Cannot divide by zero.");
			}
			result /= numbers[i];
		}
		return result;
	}
}
