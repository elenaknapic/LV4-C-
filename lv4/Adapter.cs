using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv4
{
    //Z1
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        private object line;

        public Adapter(Analyzer3rdParty analyticsService2)
        {
            this.analyticsService = analyticsService2;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> data = dataset.GetData();
            int rowCount = data.Count;
            int columnCount = data[0].Count;
            double[][] array = new double[rowCount][];
            for (int i = 0; i < rowCount; i++)
            {
                array[i] = new double[columnCount];
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    array[i][j] = data[i][j];
                }
            }
            return array;
        }

    

        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }

    }
}
