using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class A
    {
        public void S1()
        {
            Console.WriteLine("A::S1");
            V1();
        }

        protected void V1()
        {
            Console.WriteLine("A::V1");
            S3();
        }

        public void S2()
        {
            Console.WriteLine("A::S2");
            S1();
        }

        private void S3()
        {
            Console.WriteLine("A::S3");
        }
    }
}