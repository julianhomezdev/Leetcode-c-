public class Solution {
    public void MoveZeroes(int[] nums)
    {

        // Two pointers solution
        // Fast and slow pointer
        //[0,1,0,3,12] -> [1,3,12,0,0]

        // Fast recorre todo el array cuando encuentra un numero != 0
        // Lo mueve a la posicion de slow, slow solo se mueve luego de encontrar un numero != 0 
        // por fast, aumenta en 1, luego de recorrer, a partir de donde quedo slow llenamos de 0


        int slow = 0;


        for (int fast = 0; fast <= nums.Length - 1; fast++)
        {
            int value = nums[fast];


            if (value != 0)
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }


        for (int i = slow ; i < nums.Length ; i++)
        {
            nums[i] = 0;
        }

    }
}