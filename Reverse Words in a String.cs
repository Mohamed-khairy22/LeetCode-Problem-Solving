public class Solution {
    public string ReverseWords(string s) {
    string s2 = "",temp="";

    for (int i =0;i< s.Length; i++)
    {
        if( (s[i] != ' '))
        {
            temp += s[i];
            
        }
        if (temp.Length > 0 && (s[i] == ' ' ||i==s.Length-1))
        {
            if (s2 == "")
                s2 += temp;
            else
                s2 += " " + temp;
            temp = "";
        }
    }
    string[] words =s2.Split(' ') ;
    Array.Reverse(words);
    s2 = "";
    foreach (string word in words)
    {
        
        if(s2=="")
            s2 += word;
        else
            s2 +=" "+ word;
    }
    return s2;
}
}