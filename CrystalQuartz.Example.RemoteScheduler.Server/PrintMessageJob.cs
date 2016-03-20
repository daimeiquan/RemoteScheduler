namespace CrystalQuartz.Example.RemoteScheduler.Server
{
    using System;
    using Quartz;

    public class PrintMessageJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            for(int i = 0; i < 1000; i++) { 
            Console.WriteLine("Hello!");
            }
        }
    }
}