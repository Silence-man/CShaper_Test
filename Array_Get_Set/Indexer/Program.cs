using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Jeff Wong";
            Console.WriteLine(student.Name);
            Console.Read();

            //Student student = new Student();
            //int num = student.ListStudents.Count;
            //Console.WriteLine("All the students:\nLeft-Attributes Right-Indexer\n");
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write(student.ListStudents[i].Name); //通过属性，取所有学生名
            //    Console.Write("-----------"); 
            //    Console.WriteLine(student[i].Name); //通过索引器，取所有学生名
            //}
        }
    }
    public class Student
    {
        private string name;
        /// <summary>
        /// 定义学生的姓名属性
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Student()
        { }
        public Student(string str)
        {
            this.Name = str;
        }
        //public Student()
        //{
        //    this.listStudents.Add(new Student("jeff wong"));
        //    this.listStudents.Add(new Student("jeffery zhao"));
        //    this.listStudents.Add(new Student("terry lee"));
        //    this.listStudents.Add(new Student("dudu"));
        //}
        private List<Student> listStudents = new List<Student>();
        public List<Student> ListStudents
        {
            get
            {
                return listStudents;
            }

            set
            {
                listStudents = value;
            }
        }


        /// <summary>
        /// 构建索引器
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Student this[int i]
        {
            get { return listStudents[i]; }
            set { listStudents[i] = value; }
        }

    }
}
