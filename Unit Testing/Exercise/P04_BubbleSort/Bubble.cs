namespace P04_BubbleSort
{
    public static class Bubble
    {
        public static int[] Sort(int[] numbers)
        {
            bool isSwaped = true;

            while (isSwaped)
            {
                isSwaped = false;

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        int currentNumber = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = currentNumber;
                        isSwaped = true;
                    }
                }
            }

            return numbers;
        }
    }
}