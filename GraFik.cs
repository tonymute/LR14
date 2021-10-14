using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace LR14
{
    public class GraFik : Visualisation
    {
        public void GrfInform(System.Windows.Forms.DataVisualization.Charting.Chart GrafInfo, System.Windows.Forms.DataGridView data)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Convert.ToInt32(data.Rows[i].Cells[j].Value) > 9)
                        data.Rows[i].Cells[j].Value = Convert.ToInt32(data.Rows[i].Cells[j].Value) % 10;
                    if (Convert.ToInt32(data.Rows[i].Cells[j].Value) < 0)
                        data.Rows[i].Cells[j].Value = -Convert.ToInt32(data.Rows[i].Cells[j].Value) % 10;
                }
            }
            GrafInfo.Series.Clear();
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    a[Convert.ToInt32(data.Rows[i].Cells[j].Value)]++;
            GrafInfo.Series.Add(new Series("ColumnSeries")
            {
                ChartType = SeriesChartType.Line
            }) ;
            for (int i = 0; i < 10; i++)
                GrafInfo.Series["ColumnSeries"].Points.AddXY(i, a[i]);
            GrafInfo.Series["ColumnSeries"].SetCustomProperty("PointWidth", "4");

        }
    }
}