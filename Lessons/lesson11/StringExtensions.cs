using System.Linq;
namespace lesson11
{
    public static class StringExtensions
    {
        public static string Capitalize(this string str)
        {
            var temp = str.ToLower().ToArray();
            temp[0] = char.ToUpper(temp[0]);
            return new string(temp);
        }

        public static int ToInt(this string son) => int.Parse(son);
        public static bool TryParse(this string son, out int x) => int.TryParse(son, out x); 
    }
}