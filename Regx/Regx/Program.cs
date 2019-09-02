using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Regx
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 关于C#字符串中的\转义问题 与正则表达式\的转义问题
            //string msg="\d";此时c#会认为\是一个转义字符串，但是\d是正则表达式中的转义字符，不是C# 里面的转义字符

            string msg = "\\d";//此时C#会认为\是一个字符串转义字符，打印后的字符串就是"\d"

            Regex.IsMatch("ada",msg);  //meg在正则表达式中为\d表示[0-9]

            Regex.IsMatch(@"\d", "\\\\d");//\\\\d在C#中会转义成\\d，\\d在正则表达式中转义成普通字符\d

            Regex.IsMatch(@"\d",@"\\d");
            #endregion


            //string path = @"F:\RegularExpress\Regx\Regx\Program.cs";

            ////此处因为有“贪婪模式”的存在，所以表达式中的\肯定匹配的是路径中的最后一个\
            //Match match= Regex.Match(path,@".+\\(.+)");
            //Console.WriteLine(match.Groups[1].Value);
            //Console.ReadKey();


            //string data = "June     26   ,   1932   ";

            //Match mm=Regex.Match(data,@"([a-zA-Z]+)\s*([0-9]{2})\s*,\s*([0-9]{4})\s*");
            //for (int i = 0; i < mm.Groups.Count; i++)
            //{
            //    Console.WriteLine(mm.Groups[i].Value);

            //}

            //MatchCollection mc = Regex.Matches(data,@"[a-zA-Z0-9]+");
            //foreach (Match item in mc)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //Console.ReadKey();

            // string email = "jxct@126.com";

            //Match mt= Regex.Match(email, @"([-a-zA-z0-9._]+)@([-a-zA-Z0-9._]+(\.[a-zA-Z]+)+)");
            // for (int i = 0; i < mt.Groups.Count; i++)
            // {
            //     Console.WriteLine(mt.Groups[i]);
            // }
            // Console.ReadKey();

            string url = "192.168.10.5[port=21,type=ftp]"; //或192.168.10.5[port=21]

            Match mm = Regex.Match(url,@"(.+)\[port=([0-9]{2,5})(,type=(.+))?\]");

            Console.WriteLine(mm.Groups[1].Value);
            Console.WriteLine(mm.Groups[2].Value);
            Console.WriteLine(mm.Groups[4].Value);
            Console.ReadKey();


        }
    }
}
