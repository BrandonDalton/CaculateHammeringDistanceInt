public class Solution {
    public int HammingDistance(int x, int y) {
        //One has to be One
        int check = x ^ y; 
        int setBits = 0; 
  
    while (check > 0)  
    { 
        setBits += check & 1; 
        check >>= 1; 
    } 
  
    return setBits; 
    }
}
