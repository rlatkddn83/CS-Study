﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._10
{
    interface IRunnable
    {
        public void Run();
    }

    interface IFlyable
    {
        public void Fly();
    }

    class FlyingCar : IRunnable,IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Car Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Car Fly!");
        }
    }
    internal class _10_07
    {
        static void Main7(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            IFlyable flyable = car as IFlyable;

            runnable.Run();
            flyable.Fly();
        }
    }
}
