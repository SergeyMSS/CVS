using System.Collections.Generic;

namespace yield
{
    public static class ExpSmoothingTask
    {
        public static IEnumerable<DataPoint> SmoothExponentialy(this IEnumerable<DataPoint> data, double alpha)
        {
            double prev = 0;
            foreach (var e in data)
            {
                if (e.X == 1)
                {
                    prev = e.OriginalY;
                    yield return e;
                }
                else
                {
                    var curr = e.OriginalY;
                    e.OriginalY = prev + alpha * (curr - prev);
                    prev = curr;
                    yield return e;
                }
            }
        }
    }
}