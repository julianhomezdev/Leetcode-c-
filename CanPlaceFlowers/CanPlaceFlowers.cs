public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0)
            {
                int left  = (i == 0) ? 0 : flowerbed[i - 1];
                int right = (i == flowerbed.Length - 1) ? 0 : flowerbed[i + 1];

                if (left == 0 && right == 0)
                {
                    flowerbed[i] = 1; // planto aquí
                    count++;
                    if (count >= n) return true; // ya cumplí
                }
            }
        }

        return count >= n;
    }
}
