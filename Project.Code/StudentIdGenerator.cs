using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator _instance;
        private int mIdCounter;

        protected StudentIdGenerator()
        {
            this.mIdCounter = 0;
        }

        public static StudentIdGenerator getInstance()
        {
         
            if (_instance == null)
            {
                _instance = new StudentIdGenerator();
            }

            return _instance;
        }
    
        public int generateID()
        {
            return this.mIdCounter++;
        }
}
}
