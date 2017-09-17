using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public static class Res
{
        public static List<String> files = new List<string>();

        public static String getFileName(String file)
        {
            String[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
}
}
