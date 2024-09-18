public class Solution {
    public string MergeAlternately(string word1, string word2) {

        if (word1 == null) return word2;
        if (word2 == null) return word1;

        string result = "";
        if (word1.Length >= word2.Length)
        {
            for (int i = 0; i < word1.Length; i++)
            {
                result = result + word1[i];
                if (word2.Length > i)
                    result = result + word2[i];
            }
        }
        else 
        {
            for (int i = 0; i < word2.Length; i++)
            {
                if (word1.Length > i)
                    result = result + word1[i];
                result = result + word2[i];
            }
        }

        return result;
    }
}