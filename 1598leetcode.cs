public class Solution {
    public int MinOperations(string[] logs) {
        int deep = 0;
        foreach (string log in logs){
            if (log == "../"){
                if (deep > 0)
                    --deep;
            } else if (log == "./"){
                
            } else{
                ++deep;
            }

        }
        
        return deep;
    }
}