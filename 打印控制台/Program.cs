using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 打印控制台
{

    class Program
    {
        [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = false)]
        public static extern void CopyMemory(int dest, int src, uint count);
        static void Main(string[] args)
        {
            string itemName = "由于需要按4个字节长度来分割字符串，而原数据是每两个字节就有一个空格，所以无法直接通过Split方法进行分割。我想到了两种思路：①去掉第1、3、5、7……个空格以及回车、换行和制表字符，然后使用Split分割字符串；②去掉所有空格、回车、换行和制表符，然后通过循环取字符串的子串的方式而达到‘分割’字符串到字符数组的目的。我觉得第二种方法的思路更简单，所以采用的是第二种方法。（int startIndex——开始截取子串的位置，int length——子字符串的长度）";

            SubString(itemName);

            //unsafe
            //{
            //    fixed (char* p = "yuchengren")
            //    {

            //        byte* b = stackalloc byte[20];
            //        CopyMemory((int)b, (int)p, (uint)Encoding.Unicode.GetByteCount(p, 10));

            //        Console.WriteLine(Encoding.Unicode.GetString(b, 20));


            //    }



            //}
           

            

            Console.Read();
        }

       static  List<string> itemNames = new List<string>();
        static int startIndex = 0;
        static int Num = 9;
        static int remainNum =0;
        static void SubString(string itemName )
        {

            remainNum = itemName.Length;
            var sbString = "";
            if (remainNum !=0 && remainNum <9)
            {
               sbString  = itemName.Substring(startIndex, remainNum);
                Num = remainNum-1;
            }
            else
            {
                sbString = itemName.Substring(startIndex, Num);
            }
           
            
            while (remainNum>0 && Encoding.Default.GetByteCount(sbString) <50 && Encoding.Default.GetByteCount(itemName.Substring(startIndex, Num + 1)) <= 50)
            {
               
                Num += 1;
                sbString = itemName.Substring(startIndex, Num);
                remainNum = itemName.Length - Num;


            }
            itemNames.Add(sbString);
            if (remainNum>0)
            {
                
                itemName = itemName.Substring(Num);


                Num = 9;


                while (remainNum > 0)
                {
                    SubString(itemName);
                }

            }
            else
            {
                foreach (var item in itemNames)
                {
                    Console.WriteLine(item);
                }
                return;
            }


            
          

        }
            
    }
}
