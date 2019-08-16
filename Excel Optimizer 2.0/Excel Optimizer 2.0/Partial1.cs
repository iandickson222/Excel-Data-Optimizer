using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


// Math
namespace Excel_Optimizer_2._0
{
    public partial class Excel_Data_Optimizer_Form
    {
        double lowest_value = 0;
        double highest_value = 0;

        private void SetValues()
        {
            lowest_value = double.MaxValue;
            highest_value = double.MinValue;
        }

        private void Calculate(int y)
        {
            int row = Convert.ToInt32(textboxes[0, y].Text);
            string column = textboxes[1, y].Text;
            double minimum = Convert.ToDouble(textboxes[2, y].Text);
            double maximum = Convert.ToDouble(textboxes[3, y].Text);
            double precision = Convert.ToDouble(textboxes[4, y].Text);

            for (double i = minimum; i <= maximum; i += precision)
            {
                WorkSheet.Cells[row, column].Value2 = i;

                if(y == component - 1)
                {
                    int progress_value = (int)Math.Floor(100.0 * Math.Abs(i - minimum) / (maximum - minimum));

                    Background_Worker.ReportProgress(progress_value);
                }

                if (y > 0)
                {
                    Calculate(y - 1);
                }

                if (isMinimized)
                {
                    Minimize();
                }

                if (isMaximized)
                {
                    Maximize();
                }
            }

        }

        private void Minimize()
        {
            int row = Convert.ToInt32(M_Row.Text);
            string column = M_Column.Text;

            if(WorkSheet.Cells[row, column].Value2 < lowest_value)
            {
                for (int y = 0; y <= component - 1; y++)
                {
                    int cell_row = Convert.ToInt32(textboxes[0, y].Text);
                    string cell_column = textboxes[1, y].Text;

                    textboxes[5,y].Invoke((MethodInvoker)delegate {
                        textboxes[5, y].Text = WorkSheet.Cells[cell_row, cell_column].Value2.ToString();
                    });
                }

                lowest_value = WorkSheet.Cells[row, column].Value2;
            }
            
        }

        private void Maximize()
        {
            int row = Convert.ToInt32(M_Row.Text);
            string column = M_Column.Text;

            if (WorkSheet.Cells[row, column].Value2 > highest_value)
            {
                for (int y = 0; y <= component - 1; y++)
                {
                    int cell_row = Convert.ToInt32(textboxes[0, y].Text);
                    string cell_column = textboxes[1, y].Text;

                    textboxes[5, y].Invoke((MethodInvoker)delegate {
                        textboxes[5, y].Text = WorkSheet.Cells[cell_row, cell_column].Value2.ToString();
                    });
                }

                highest_value = WorkSheet.Cells[row, column].Value2;
            }
        }

        private void Optimize_Values()
        {
            for (int y = 0; y <= component - 1; y++)
            {
                int cell_row = Convert.ToInt32(textboxes[0, y].Text);
                string cell_column = textboxes[1, y].Text;

                WorkSheet.Cells[cell_row, cell_column].Value2 = Convert.ToDouble(textboxes[5, y].Text);
            }
        }

    }
}
