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

//UI
namespace Excel_Optimizer_2._0
{
    public partial class Excel_Data_Optimizer_Form : Form
    {
        private string file;       
        private Excel.Application Excel = new Excel.Application();
        private Excel.Workbook Workbook;
        private Excel.Worksheet WorkSheet;
        private TextBox[,] textboxes = new TextBox[6, 5];

        private int component = 0;
        private bool isMinimized = false;
        private bool isMaximized = false;

        public Excel_Data_Optimizer_Form()
        {
            InitializeComponent();
        }

        private void Load_Excel_File_Click(object sender, EventArgs e)
        {
            Open_File.Filter = ".xlsx|*.xlsx";

            if (Open_File.ShowDialog() == DialogResult.OK)
            {              
                file = Open_File.FileName;
            }
            
            if(file != null)
            {
                Load_Excel_Worksheet();
            }           
        }

        private void Load_Excel_Worksheet()
        {
            Workbook = Excel.Workbooks.Open(@file);
            WorkSheet = Workbook.Worksheets.Item[1];
            Excel.Visible = true;
        }

        private void Save_Excel_File_Click(object sender, EventArgs e)
        {
            Save_File_As.Filter = ".xlsx|*.xlsx";
            if (Excel.Visible == true)
            {
                try
                {
                    Workbook.Save();
                }
                catch
                {
                    MessageBox.Show("Error Saving File.");
                }
            }
        }

        private void Save_Excel_File_As_Click(object sender, EventArgs e)
        {
            Save_File_As.Filter = ".xlsx|*.xlsx";
            if (Excel.Visible == true)
            {
                if (Save_File_As.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Workbook.SaveAs(Save_File_As.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Error Saving File.");
                    }
                }
            }
        }

        private void Componet_Container_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label_Layout.Controls.Clear();
            Label_Layout.Controls.Add(Row_Label, 0, 0);
            Label_Layout.Controls.Add(Column_Label, 1, 0);
            Label_Layout.Controls.Add(Minimum_Label, 2, 0);
            Label_Layout.Controls.Add(Maximum_Label, 3, 0);
            Label_Layout.Controls.Add(Precision_Label, 4, 0);
            Label_Layout.Controls.Add(Optimal_Label, 5, 0);
            component = Convert.ToInt32(Componet_Container.SelectedItem);

            for (int y = 0; y < component; y++)
            {
                for(int x = 0; x < 6; x++)
                {
                    bool isRead = false;

                    if(x == 5)
                    {
                        isRead = true;
                    }

                    textboxes[x, y] = new TextBox{ Anchor = AnchorStyles.Left, AutoSize = true, ReadOnly = isRead};
                    Label_Layout.Controls.Add(textboxes[x,y], x , y + 1);
                }
            }
        }

        private void Constraint_Container_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Constraint_Container.SelectedItem.ToString() == "Minimize")
            {
                isMinimized = true;
                isMaximized = false;
            }

            if (Constraint_Container.SelectedItem.ToString() == "Maximize")
            {
                isMinimized = false;
                isMaximized = true;
            }
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            if (!Background_Worker.IsBusy)
            {
                Run_Button.Enabled = false;

                foreach (TextBox textbox in textboxes)
                {
                    if (textbox != null)
                    {
                        textbox.Enabled = false;
                    }
                }

                M_Row.Enabled = false;
                M_Column.Enabled = false;
                Componet_Container.Enabled = false;
                Constraint_Container.Enabled = false;
                Load_Excel_File.Enabled = false;
                Save_Excel_File.Enabled = false;
                Save_Excel_File_As.Enabled = false;

                Progress_Bar.Visible = true;
                Status.Text = "Running";
                Background_Worker.RunWorkerAsync();
            }
        }

        private void Do_Background_Work(object sender, DoWorkEventArgs e)
        {
            try
            {
                SetValues();
                Calculate(component - 1);
                Optimize_Values();
            }

            catch
            {
                MessageBox.Show("Input Parameter Error.");
            }
                
        }

        private void Completed_Background_Work(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (TextBox textbox in textboxes)
            {
                if (textbox != null)
                {
                    textbox.Enabled = true;
                }
            }

            M_Row.Enabled = true;
            M_Column.Enabled = true;
            Componet_Container.Enabled = true;
            Constraint_Container.Enabled = true;
            Load_Excel_File.Enabled = true;
            Save_Excel_File.Enabled = true;
            Save_Excel_File_As.Enabled = true;

            Status.Text = "Ready";
            Progress_Bar.Visible = false;
            Progress_Bar.Value = 0;
            Run_Button.Enabled = true;
        }

        private void Background_Work_Progress(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage <= 100 && e.ProgressPercentage >= 0)
            {
                Progress_Bar.Value = e.ProgressPercentage;
            }           
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
