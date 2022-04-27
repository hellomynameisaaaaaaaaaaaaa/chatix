namespace chatix
{
    public class Tools
    {
        public static bool IsClean (string x)
        {
            string[] x_s = x.Split(' ');
            for (int i = 0; i < x_s.Length; i++)
                if (Array.IndexOf(new string[] 
                { 
                    "fuck", "shit", "bitch", "motherfucker", "fucker" 
                }, x_s[i]) >= 0) return false; else continue;
            return true;
        }
    }
}
