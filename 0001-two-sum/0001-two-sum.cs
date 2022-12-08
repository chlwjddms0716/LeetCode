public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] answer = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target && i != j)
                {
                    answer[0] = i;
                    answer[1] = j;
                    return answer;
                }
            }
        }

        return answer;
    }
}