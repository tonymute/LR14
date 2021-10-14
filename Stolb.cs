using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR14
{
    public class Stolb : Visualisation
    {
        public void StolbInform(System.Windows.Forms.DataVisualization.Charting.Chart StolbInfo, System.Windows.Forms.DataGridView data)
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
            StolbInfo.Series.Clear();
            int[] a = new int[10];
            for(int i = 0; i < 10; i++)
                for(int j = 0; j < 10; j++)
                    a[Convert.ToInt32(data.Rows[i].Cells[j].Value)]++;
            for (int i = 0; i < 10; i++)
            {
                StolbInfo.Series.Add(i.ToString()).Points.AddXY("", a[i]);
            }
        }
    }
}