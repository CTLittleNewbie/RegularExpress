using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpress
{  
        //正则表达式

        //特殊字符(元字符)
        /*
         * 
        . 除了\n以外的任意单个字符  
        eg:a.b  a和b之间有且仅有一个字符，空格符合\t符合条件
        符合：aab、axb、a3b a.b
        不符合：a和b之间有换行符
        a
        b

        [] 字符组：表示在字符组中罗列出来的字符任意取单个字符，必须取字符

        eg:a[xyz]b
        axb、ayb、azb 

        eg: a[a-z]b
        符合：aab/awb/acb
        不符合：aAb/aZb     
        eg:a[a-zABXYZ]b
        符合：aAb/aZb/abb

        eg:a[a-zA-Z0-9] a[a-z王坤]

        eg:a[-a-bA]  -出现在[]最前面不表示一个范围，仅代表字符-

        eg:a[.]b .出现在字符组中表示一个普通字符，并不是元字符  相当于a\.b


        | 表示或  或的优先级最低

        ()  表示改变优先级 或提取组

        eg:a(x|y)b   表示a和b之间要么是x要么是y
        eg:z|food  表示匹配z或者匹配food


        * 表示限制前面的表达式出现0次或多次

        eg:a.*b
        符合: ab axb axxb axxxxxxxxb

        + 表示一次或多次，至少出现一次

        eg:a.+b
        符合：axb axxb axxxxb
        不符合：ab

        ?表示字符可出现0次或一次

        eg: a.?b

        符合：ab axb
        不符合：axxb

        {n} 限定出现次数、表示字符必须出现n次

        eg:[0-9]{5}

        符合：12345

        {n,}表示最少出现n次
        eg:[0-9]{4,}

        符合：16743964

        {n,m} 表示出现的范围在n-m之间最少n次最多m次
        eg:[0-9]{3,5}
        符合：1354

        ^(shift+6) 表示字符串的开始  ,如果在[]字符组中表示非
        eg:^hl  表示字符串必须匹配以h开头的字符并紧跟l
        符合：hlsfsdgf
        不符合：aasdfhl

        eg:a[^xyz]b  表示a和b之间不能是xyz任意一个字符

        符合：aab  不符合：ab axy

        $ 表示字符串的结尾

        eg:oo$ 表示必须以oo结尾
        符合：sfgoo sdfgsoo  不符合：sfsot

        一些表达式的简写：
        [0-9]+   表示出现的数字至少为一个   
        简写：[\d]+   \d表示0到9的数字   \D表示出了0-9以外的所有字符

        \w  等于[a-zA-Z0-9_] 表示能组成单词的所有字符，包括中文字符  

        \W 表示除了\w表示的所有字符

        \s表示所有不可见字符   空白符 空格 \n换行符 \t \r

        \S 表示除了\s以为的所有字符

        [\w\W] 、[\s\S]、 [\d\D]  表示任意单个字符

       */

        class Program
        {
            static void Main(string[] args)
            {
            // System.Text.RegularExpressions.Regex.IsMatch();  用来判断给定的字符串是否匹配某个正则表达式(只要有一部分匹配就返回true)
            //System.Text.RegularExpressions.Regex.Match();  用户从给定的字符串中按照正则表达式的要求提取一个匹配的字符串
            //System.Text.RegularExpressions.Regex.Matches();  用来从给定的字符串中按照正则表达式的要求提取所有的匹配的字符串
            //System.Text.RegularExpressions.Regex.Replace();  替换所有正则表达式匹配的字符串为另外一个字符串

            //while (true)
            //{

            //    Console.WriteLine("请输入一个字符串");
            //    string str = Console.ReadLine();

            //    验证给定的字符串是否为一个合法的邮政编码

            //        注意要想完全匹配必须在开头加 ^ 在结尾加$,否则就是部分匹配
            //        bool b = System.Text.RegularExpressions.Regex.IsMatch(str, "^[0-9]{6}$");
            //    Console.WriteLine("给定的字符串是一个合法的邮政编码吗？" + b);

            //}

            //while (true)
            //{
            //Console.WriteLine("请输入一个10到25之间的的数字包含10和25");
            //string num = Console.ReadLine();

            //bool b = System.Text.RegularExpressions.Regex.IsMatch(num, "^(1[0-9]|2[0-5])$");

            //Console.WriteLine("请输入11位手机号");

            //string num = Console.ReadLine();

            //bool b = System.Text.RegularExpressions.Regex.IsMatch(num, @"^\d[0-9]{11}$");

            //Console.WriteLine(b);

            //Console.WriteLine("请输入：");
            //string str = Console.ReadLine();
            //bool b = System.Text.RegularExpressions.Regex.IsMatch(str,"z|food");  //不完全匹配只要含有z或者food都符合条件
            //Console.WriteLine(b);


            //Console.WriteLine("请输入：");
            //string str1= Console.ReadLine();
            //bool b = System.Text.RegularExpressions.Regex.IsMatch(str1, "(z|f)ood");  //不完全匹配只要含有z或者food都符合条件
            //Console.WriteLine(b);

            //Console.WriteLine("请输入：");
            //string str2 = Console.ReadLine();
            //bool b = System.Text.RegularExpressions.Regex.IsMatch(str2, "^z|food$");  //以z开头的或者以food结尾的都是true,|运算符优先级最低
            //Console.WriteLine(b);


            //Console.WriteLine("请输入：");
            //string str2 = Console.ReadLine();
            //bool b = System.Text.RegularExpressions.Regex.IsMatch(str2, "^(z|food)$");  //完全匹配z或者food  ()改变优先级，先算()中的
            //Console.WriteLine(b);

            //Console.WriteLine("请输入一个省份证号：");  //长度是15位或18位，18位的最后一位可能是X,15为全是数字，开头都不能为0
            //string str2 = Console.ReadLine();
            //bool b = System.Text.RegularExpressions.Regex.IsMatch(str2, @"^([1-9]\d{14}|[1-9]\d{16}[0-9xX])$");  //要么是15位要么是18位

            //bool b1 = System.Text.RegularExpressions.Regex.IsMatch(str2, @"^[1-9]\d{14}|[1-9]\d{16}[0-9xX]$");  //以15开头的或者以18结尾的都是true,|运算符优先级最低

            //bool b2 = System.Text.RegularExpressions.Regex.IsMatch(str2, @"^[1-9]\d{14}([0-9]{2}[0-9Xx])?$");  //前面15位相同，后面三位可能出现0次或1次

            //bool b3 = System.Text.RegularExpressions.Regex.IsMatch(str2, @"^[1-9](\d{14}|\d{16}[0-9Xx])$");  //前面15位相同，后面三位可能出现0次或1次

            //Console.WriteLine(b);

            //Console.WriteLine("请输入一个邮箱："); //用户名 @ 域名  zxh  @  itcasr.cn   123 @ vip.qq.com  aaa@ sina.com.cn
            //string email = Console.ReadLine();

            //bool b = System.Text.RegularExpressions.Regex.IsMatch(email, @"^[-0-9a-zA-Z_\.]+@[0-9a-zA-Z]+(\.[0-9A-Za-z]){1,2}$");  

            //Console.WriteLine(b);

            /*
            010-8888888  010-88888888 010xxxxxxx
            0335-8888888 0335-88888888(区号-电话号码) 0335xxxxxxx
            10086 10010 95599  (五位)
            13673625846（11位）

         */
            //Console.WriteLine("请输入一个全国电话号码：");

            //string num = Console.ReadLine();
            ////- [-] [\-]
            //bool b = System.Text.RegularExpressions.Regex.IsMatch(num,@"^(\d{3,4}-?\d{7,8}|\d{5})$");

            //Console.WriteLine(b);


            ////ip地址 192.168.54.77  333.333.333.333 1.2.222.3 192.169.0.31

            //Console.WriteLine("请输入一个全国电话号码：");

            //string ip = Console.ReadLine();
            //bool b = System.Text.RegularExpressions.Regex.IsMatch(ip, @"^[0-9]{1,3}(\.[0-9]{1,3}){3}$");

            //Console.WriteLine(b);

            //判断是否是合法日期

            //Console.WriteLine("请输入一个日期：");
            //string str = Console.ReadLine();

            //bool b = System.Text.RegularExpressions.Regex.IsMatch(str,@"^[0-9]{4}-(0[1-9]|1[0-2])-[0-9]{2}$");


            //判断是否为合法url地址
            // http https ftp file thunder ed2k ://  www.test.com.a.htm?id=3&name=aaa  127.0.0.1/1.text

            //Console.WriteLine("输入一个地址：");
            //string url = Console.ReadLine();

            //bool b = System.Text.RegularExpressions.Regex.IsMatch(url,@"^[a-zA-Z0-9]+://.+$");
            //}

            //正则表达式默认使用的是Unicode码，包含所有的字母数字符号，unicode占两个字符

            //string msg = "asdfadsf456SGSSGFSG__你好吗１２５６３";

            //bool b = System.Text.RegularExpressions.Regex.IsMatch(msg, @"^\w+$"); //匹配所有的字字母数字下划线和中文包括半角和全角

            //bool b1 = System.Text.RegularExpressions.Regex.IsMatch(msg, @"^\w+$", System.Text.RegularExpressions.RegexOptions.ECMAScript);//只匹配ASSII码数字字母下划线

            //Console.WriteLine(b + " " + b1);
            //Console.ReadKey();



            //string str = "大家好啊，hello，2010年10月10日是一个好日子，嗯，9494，吼，886";

            ////Match只能提取一个符合匹配条件的字符串
            //System.Text.RegularExpressions.Match match=System.Text.RegularExpressions.Regex.Match(str,"[0-9]+");
            //Console.WriteLine(match.Value);

            //System.Text.RegularExpressions.MatchCollection collo=System.Text.RegularExpressions.Regex.Matches(str,"[0-9]+");

            //foreach (System.Text.RegularExpressions.Match item in collo)
            //{
            //    Console.WriteLine(item.Value);
            //}


            //提取所有邮箱地址
            string email = "sgfs@qq.com jkjlsf 你好 wsf@vip.com.cn 5121s2dfg jxct@126.com *())999 sgfs#163.com sdfa@163.com sdfgs@qq.com";

            System.Text.RegularExpressions.MatchCollection collo = System.Text.RegularExpressions.Regex.Matches(email, @"[-a-zA-Z_0-9.]+@[-a-zA-Z0-9_]+(\.[A-Za-z]+)+");

            //如果想要对已经【匹配的字符串进行分组提取，就用到了“提取组”功能
            //通过()进行组的提取
            //在正则表达式中只要出现了()就表示进行了分组，()既有改变优先级的作用又有提取组的功能
            System.Text.RegularExpressions.MatchCollection collo1 = System.Text.RegularExpressions.Regex.Matches(email, @"([-a-zA-Z_0-9.]+)@([-a-zA-Z0-9_]+(\.[A-Za-z]+)+)");


            foreach (System.Text.RegularExpressions.Match item in collo)
            {
                Console.WriteLine(item.Value);
            }
            foreach (System.Text.RegularExpressions.Match item in collo1)
            {

                //item.Value表示本次提取到的字符串
                //item.Groups集合中的存储的就是所有的分组信息
                //item.Groupa[0].Value与item.Value等价，表示本次提取到的完成的字符串，item.Groups[1]表示第一组的字符串
                Console.WriteLine("第0组"+item.Groups[0]);
                Console.WriteLine("第1组" + item.Groups[1]);
                Console.WriteLine("第2组" + item.Groups[2]);
                Console.WriteLine("第3组" + item.Groups[3]);
            }

            Console.WriteLine("ok");
            Console.WriteLine(collo.Count);
            Console.ReadKey();

        }
    }    
}
