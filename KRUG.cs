using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace LR14
{
    public class KRUG : Visualisation
    {
        public void KrugInfo(System.Windows.Forms.DataVisualization.Charting.Chart KrugInf, System.Windows.Forms.DataGridView data)
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
            KrugInf.Series.Clear();
            int[] a = new int[10];
            string[] b = new string[10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    a[Convert.ToInt32(data.Rows[i].Cells[j].Value)]++;
                b[i] = i.ToString();
            }
                KrugInf.Series.Add(new Series("ColumnSeries")
                {
                    ChartType = SeriesChartType.Pie
                });
                KrugInf.Series["ColumnSeries"].Points.DataBindXY(b, a);
        }
    }
}