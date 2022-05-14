using System;

namespace AspNetCore_GitHub_Action_Test_Reporter.Service
{
    public class SampleService
    {


        public bool DoSomthing()
                => true;


        public void ThrowError()
                => throw new Exception();


        public int Add(int a, int b)
                => a + b;

        public int Sub(int a, int b)
                => a - b;
    }
}
