using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    interface IManage<T,K>
    {
        void Create(T obj);
        T Read(int id);
        void Update(int id, K val);
        void Delete(int id);
    }
    class Student
    {

        public int ID { get; set; }
        public string StudentName { get; set; }
        public int fakNumber { get; set; }
        public Student(int id, string studn, int fakn)
        {
            this.ID = id;
            this.StudentName = studn;
            this.fakNumber = fakn;
        }
    }
    class StudentManagament : IManage<Student,int>
    {
        static Dictionary<int, Student> studentDict = new Dictionary<int, Student>();
        public void Create (Student t)
        {
            studentDict.Add(t.ID, t);
        }
        public Student Read(int id)
        {
            return studentDict[id];
        }
        public void Update(int id, int fakn)
        {
            studentDict[id].fakNumber = fakn;
        }
        public void Delete(int id)
        {
            studentDict.Remove(id);
        }
    }
}
