public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }
        char[] s_arr = s.ToCharArray();
        char[] t_arr = t.ToCharArray();
        Array.Sort(s_arr);
        Array.Sort(t_arr);
        bool areEqual = s_arr.SequenceEqual(t_arr);
        return areEqual;
    }
}
