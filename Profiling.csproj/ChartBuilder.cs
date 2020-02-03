using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//using ZedGraph;

namespace Profiling
{
    class ChartBuilder : IChartBuilder
    {
        public Control Build(List<ExperimentResult> result)
        {
            Chart chart = new Chart();

            for (int i = 0; i < result.Count; i++)
            {
                chart.Series[1].Points.AddXY(i, result[i].StructResult);
                chart.Series[0].Points.AddXY(i, result[i].ClassResult);
            }

            return chart;
        }
    }
}