public class Solution {
    public string ReverseVowels(string s) {
    List<char> chars = new List<char>();
    
    string vowels = "aeiouAEIOU",result="";
    foreach (var item in s)
    {
        if(vowels.Contains(item))
            chars.Add(item);
    }
    for (int i = 0; i< s.Length; i++) 
    {
        if (vowels.Contains(s[i]))
        {
            result += chars.LastOrDefault();
            chars.RemoveAt(chars.Count-1);
        }
        else
            result += s[i];
    }
    return result;
}
}