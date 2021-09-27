public class ModuloFirst
{
    public static int[] moduloFirst(int[] numbers)
    {
        int n = numbers[0];
        // Modulos each number in the array by the first element.
        for (int i = 0; i < numbers.Length; i++) numbers[i] = numbers[i] % n;
        return numbers;
    }
}
