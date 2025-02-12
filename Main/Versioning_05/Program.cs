﻿using System;

namespace Versioning_05
{
    class BaseClass
    {
        public void BaseClassMethod() // Шаблонный метод
        {
            SomeMetod1();
            SomeMetod2();
        }

        public virtual void SomeMetod1() { Console.WriteLine("1"); }
        public virtual void SomeMetod2() { Console.WriteLine("2"); }
    }

    class DerivedClass : BaseClass
    {
        public new void SomeMetod1() { Console.WriteLine("3"); }
        public override void SomeMetod2() { Console.WriteLine("4"); }
    }

    class Program
    {
        static void Main()
        {
            BaseClass instance = new DerivedClass();

            instance.SomeMetod1();  // 1
            instance.SomeMetod2();  // 4

            instance.BaseClassMethod(); // 14

            // Delay
            Console.ReadKey();
        }
    }
}