public class Solution {
    public string ReverseWords(string s){

    string s2 = "";
   
    string[] words =s.Split(' ') ;
    Array.Reverse(words);
    s2 = "";
    foreach (string word in words)
    {
        if(word.Contains(' ')||word=="")
            continue;
        if(s2=="")
            s2 += word;
        else
            s2 +=" "+ word;
    }
    return s2;
}
}