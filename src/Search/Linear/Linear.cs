namespace Search.Linear;
public static class Linear
{
    public static bool Exists(this int[] array, int itemValue)
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] == itemValue) return true;

        return false;
    }
}