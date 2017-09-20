using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        private List<Student> mStudentList;


        public StudentContainer()
        {
            mStudentList = new List<Student>();
        }

       
        public void Add(Student student)
        {
             mStudentList.Add(student);
        }

        public void Remove(Student student)
        {
            for(int i=0; i< mStudentList.Count; i++)
            {
                if (student.Equals(mStudentList[i]))
                {
                    mStudentList.RemoveAt(i);
                    break;
                }
            }
        }
        
       public void Sort()
        {
            if (mStudentList!= null)
            {
                mStudentList.OrderBy(i => i.LastName);
            }
        }
    public List<Student> Fetch()
        {
            this.Sort();
            return mStudentList;
        }
    }
}