/* Given a zero-based permutation nums (0-indexed), build an array ans of the same length where ans[i] = nums[nums[i]] for each 0 <= i < nums.length and return it.
A zero-based permutation nums is an array of distinct integers from 0 to nums.length - 1 (inclusive). */

public class Solution {
    int x;
    
    public int[] BuildArray(int[] nums) {
        int[] ans = new int[nums.Length];        
        //nums = [5,0,1,2,3,4];
        
        for(int i=0; i < nums.Length; i++){
            ans[i] = nums[nums[i]];
            }
        
        return ans;
    }
}


