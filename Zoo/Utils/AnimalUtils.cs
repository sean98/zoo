using System.Collections.Generic;
using System.Linq;

namespace Zoo.Utils
{
    public static class AnimalUtils
    {
        public static IEnumerable<string> GetAnimalsNamesFromFile(string filePath)
        {
            return System.IO.File
                .ReadLines(filePath)
                .SelectMany(s => s.Split(' '))
                .Where(s => !string.IsNullOrWhiteSpace(s));
        }
    }
}