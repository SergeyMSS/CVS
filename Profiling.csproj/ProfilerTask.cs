using System.Collections.Generic;
using System.Diagnostics;

namespace Profiling
{
    public class ProfilerTask : IProfiler
    {
        public List<ExperimentResult> Measure(IRunner runner, int repetitionsCount)
        {
            List<ExperimentResult> results = new List<ExperimentResult>();
            Stopwatch watch;

            foreach (int count in Constants.FieldCounts)
            {
                runner.Call(false, count, 1);
                watch = new Stopwatch();
                watch.Start();
                runner.Call(false, count, repetitionsCount); watch.Stop();
                double timeStruct = (double)watch.ElapsedMilliseconds / repetitionsCount;

                runner.Call(true, count, 1);
                watch = new Stopwatch();
                watch.Start();
                runner.Call(true, count, repetitionsCount);
                watch.Stop();
                double timeClass = (double)watch.ElapsedMilliseconds / repetitionsCount;

                results.Add(new ExperimentResult(count, timeClass, timeStruct));
            }

            return results;
        }
    }
}