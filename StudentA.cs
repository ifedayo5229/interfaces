using System;


namespace interfaces_abstraction
{
    public class StudentA : Student
    {
    
        public override void printFullName()
        {
            Console.WriteLine("Ademodi ife");
        }

        public override void doSomething()
        {
           Console.WriteLine("my name");
        }
    }
}