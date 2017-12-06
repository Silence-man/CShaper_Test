using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //t.Ids = arr;//会调用属性的Set方法
            t.Ids[1] = 1;//正常访问数组  调用属性的Get方法  返回对象给t.Ids   
            //跟下标无关 下标赋值是数组自己的功能
            t[2]=6;//索引器访问数组

            for (int i = 0; i < t.Ids.Length; i++)
            {
                Console.WriteLine(t.Ids[i]);
            }
            Console.Read();
        }
    }
    
    class Test
    {
        private int[] ids=new int[5];

        //属性封装的是整个数据对象 不是具体的单独类型
        public int[] Ids
        {
            get
            {
                return ids;
            }

            //set
            //{
            //    ids = value;
            //}
        }

        public int this[int nindex]
        {
            get { return ids[nindex]; }
            set { ids[nindex] = value; }
        }
    }
}
