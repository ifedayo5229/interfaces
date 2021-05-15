using System;

namespace interfaces_abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student ife = new Student();
            // ife.printFullName();
            StudentA ife = new StudentA();
            ife.printFullName();
            ife.doSomething();
        }
    }


    // interface IStudent
    // {
    //     void printFullName();
    //     // void doSomething();

    // }

    // public class Student : IStudent
    // {
    //     public void printFullName()
    //     {

    //         Console.WriteLine("my full name is ADEMODI IFEDAYO ");
    //     }
    // }



    public abstract class Student
    {
        public int id; 
        public virtual void doSomething()
        {
            Console.WriteLine("my name");
        }
       public abstract void printFullName();
      
    }
}
