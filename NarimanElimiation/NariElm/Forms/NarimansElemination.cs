using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NariElm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (check3())
            {

                double[] array = new double[12];
                int i = 0, k = 0;
                foreach (Control texbox in groupBox1.Controls)
                {
                    if (texbox is TextBox)
                    {
                        array[i] = System.Convert.ToDouble(texbox.Text);
                        i++;
                    }
                }
                double[,] myarray = new double[3, 4];

                for (int h = 0; h < 3; h++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        myarray[h, j] = array[k];
                        k++;
                    }

                }
                mehvargiri(myarray);
                GElimination(myarray);
                print(myarray);
                button1.Visible = false;
                button1.Enabled = false;
                reset3.Enabled = true;
                reset3.Visible = true;
                solve3.Visible = true;
                solve3.Enabled = true;

            }
            else
                MessageBox.Show("Warning! Plz make sure the boxes ain't filled by non-numbers!");
        }
        public bool check3()                                                      //  update 2 {
        {
            foreach (Control box in groupBox1.Controls)                                     
            {

                if (box is TextBox)
                {
                    double outputvalue = 0;
                    bool isNumber = false;
                    isNumber = double.TryParse(box.Text, out outputvalue);
                    if (!isNumber)
                    {
                        return false;
                    }
                }
            

        }
        return true;
        }                                                                              //update 2 }
        public void print(double[,] myarray)
        {
            double[] array = new double[12];
            int k = 0, i = 0;
            for (int h = 0; h < 3; h++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[k] = myarray[h, j];
                    k++;
                }

            }

            foreach (Control texbox in groupBox1.Controls)
            {
                if (texbox is TextBox)
                {
                    texbox.Text = System.Convert.ToString(array[i]);
                    i++;
                }
            }
        }
        public void mehvargiri(double[,] myarray)
        {
            for (int h = 0; h < 3; h++)
            {
                for (int j = h + 1; j < 3; j++)
                {
                    if (myarray[h, h] < myarray[h, j])
                    {
                        for (int m = 0; m < 4; m++)
                        {
                            double me = myarray[h, m];
                            myarray[h, m] = myarray[j, m];
                            myarray[j, m] = me;
                        }
                    }
                }
            }
        }
        public void GElimination(double[,] myarray)
        {
            for (int q = 0; q < 2; q++)
                for (int p = q + 1; p < 3; p++)
                {
                    if (myarray[q, q] != 0)
                    {
                        double t = myarray[p, q] / myarray[q, q];
                        for (int j = 0; j <= 3; j++)
                            myarray[p, j] = myarray[p, j] - t * myarray[q, j];
                    }
                }
        }
        private void doit5_Click(object sender, EventArgs e)
        {
            if (check5())
            {
                double[] array = new double[30];
                int i = 0, k = 0;
                foreach (Control texbox in groupBox2.Controls)
                {

                    if (texbox is TextBox)
                    {
                        array[i] = System.Convert.ToDouble(texbox.Text);
                        i++;
                    }
                }
                double[,] myarray = new double[5, 6];

                for (int h = 0; h < 5; h++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        myarray[h, j] = array[k];
                        k++;
                    }

                }
                mehvargiri2(myarray);
                GElimination2(myarray);
                print2(myarray);
                doit5.Visible = false;
                doit5.Enabled = false;
                Reset5.Visible = true;
                Reset5.Enabled = true;
                solve5.Visible = true;
                solve5.Enabled = true;

            }
            else
                MessageBox.Show("Warning! Plz make sure the boxes ain't filled by non-numbers");
        }
        public bool check5()                                          // update 2  {
        {
            foreach (Control box in groupBox2.Controls)
            {

                if (box is TextBox)
                {
                    double outputvalue = 0;
                    bool isNumber = false;
                    isNumber = double.TryParse(box.Text, out outputvalue);
                    if (!isNumber)
                    {
                        return false;
                    }
                }


            }
            return true;
        }                                                              //update 2  }
        public void print2(double[,] myarray)
        {
            double[] array = new double[30];
            int k = 0, i = 0;
            for (int h = 0; h < 5; h++)
            {
                for (int j = 0; j < 6; j++)
                {
                    array[k] = myarray[h, j];
                    k++;
                }

            }

            foreach (Control texbox in groupBox2.Controls)
            {
                if (texbox is TextBox)
                {
                    texbox.Text = System.Convert.ToString(array[i]);
                    i++;
                }
            }
        }
        public void mehvargiri2(double[,] myarray)
        {
            for (int h = 0; h < 5; h++)
            {
                for (int j = h + 1; j < 5; j++)
                {
                    if (myarray[h, h] < myarray[h, j])
                    {
                        for (int m = 0; m < 6; m++)
                        {
                            double temp = myarray[h, m];
                            myarray[h, m] = myarray[j, m];
                            myarray[j, m] = temp;
                        }
                    }
                }
            }
        }
        public void GElimination2(double[,] myarray)
        {
            for (int q = 0; q < 4; q++)
                for (int p = q + 1; p < 5; p++)
                {
                    if (myarray[q, q] != 0)
                    {
                        double t = myarray[p, q] / myarray[q, q];
                        for (int j = 0; j <= 5; j++)
                            myarray[p, j] = myarray[p, j] - t * myarray[q, j];
                    }
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.mandra.ir");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (matrix3.Checked)
            {
                groupBox2.Enabled = false;
                groupBox2.Visible = false;
                groupBox1.Visible = true;
                groupBox1.Enabled = true;
                note.Text = "Plz fill the Matrix";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void matrix5_CheckedChanged(object sender, EventArgs e)
        {
            if (matrix5.Checked)
            {
                groupBox1.Visible = false;
                groupBox1.Enabled = false;
                groupBox2.Visible = true;
                groupBox2.Enabled = true;
                note.Text = "Plz fill the Matrix";
            }
        }

        private void reset3_Click(object sender, EventArgs e)
        {
            foreach (Control block in groupBox1.Controls)
            {
                if (block is TextBox)
                {
                    block.Text = "";
                }

            }
            button1.Visible = true;
            button1.Enabled = true;
            reset3.Enabled = false;
            reset3.Visible = false;
            solve3.Visible = false;
            solve3.Enabled = false;
            solutions.Visible = false;
            solutions.Enabled = false;
            infinite.Visible = false;                      //update 2 {
            infinite.Enabled = false;
            j1.Visible = false;
            j2.Visible = false;
            j3.Visible = false;
            j4.Visible = false;
            j5.Visible = false;
            j1.Enabled = false;
            j2.Enabled = false;
            j3.Enabled = false;
            j4.Enabled = false;
            j5.Enabled = false;
            nosol.Enabled = false;
            nosol.Visible = false;                           //update 2 }

        }

        private void Reset5_Click(object sender, EventArgs e)
        {
            foreach (Control block in groupBox2.Controls)
            {
                if (block is TextBox)
                {
                    block.Text = "";
                }
                doit5.Visible = true;
                doit5.Enabled = true;
                Reset5.Enabled = false;
                Reset5.Visible = false;
                solve5.Visible = false;
                solve5.Enabled = false;
                solutions.Visible = false;
                solutions.Enabled = false;
                infinite.Visible = false; //update 2 {
                infinite.Enabled = false;
                j1.Visible = false;
                j2.Visible = false;
                j3.Visible = false;
                j4.Visible = false;
                j5.Visible = false;
                j1.Enabled = false;
                j2.Enabled = false;
                j3.Enabled = false;
                j4.Enabled = false;
                j5.Enabled = false;
                nosol.Enabled = false;
                nosol.Visible = false;    //update 2 }
            }
        }


        private void solve3_Click(object sender, EventArgs e)         //    update 1 {
        {
            double[] array = new double[12];
            int i = 0, k = 0;
            foreach (Control texbox in groupBox1.Controls)
            {
                if (texbox is TextBox)
                {
                    array[i] = System.Convert.ToDouble(texbox.Text);
                    i++;
                }
            }
            double[,] myarray = new double[3, 4];

            for (int h = 0; h < 3; h++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myarray[h, j] = array[k];
                    k++;
                }

            }
                                                                
            double[] sarray = new double[3];
            if (myarray[2, 2] != 0)
            {
                sarray[2] = myarray[2, 3] / myarray[2, 2];
                if (myarray[1, 1] != 0)
                {
                    sarray[1] = (myarray[1, 3] - (sarray[2] * myarray[1, 2])) / myarray[1, 1];
                    if (myarray[0, 0] != 0)
                    {
                        sarray[0] = (myarray[0, 3] - (sarray[2] * myarray[0, 2]) - (sarray[1] * myarray[0, 1])) / myarray[0, 0];
                        j1.Text = "X1 = "+System.Convert.ToString(sarray[0]);
                        j2.Text = "X2 = "+System.Convert.ToString(sarray[1]);
                        j3.Text = "X3 = "+System.Convert.ToString(sarray[2]);
                        j1.Visible = true;
                        j2.Visible = true;
                        j3.Visible = true;

                    }
                    else
                    {
                        if((myarray[0,3]-(myarray[0,2]*sarray[2]))/myarray[0,1]==sarray[1])
                        {
                            infinite.Visible = true;
                            j2.Text = "X2 = "+System.Convert.ToString(sarray[1]);
                            j3.Text = "X3 = "+System.Convert.ToString(sarray[2]);
                            j2.Visible = true;
                            j3.Visible = true;
                        }
                        else
                        nosol.Visible = true;
                    }
                }
                else
                {
                    if (myarray[1, 3] / myarray[1, 2] == sarray[2])
                    {
                        infinite.Visible = true;
                        j3.Text = "X3 = " + System.Convert.ToString(sarray[2]);
                        j3.Visible = true;
                    }


                    else
                    {
                        nosol.Visible = true;

                    }
                }
            }
            else
            {
                if (myarray[2, 3] == 0)
                    infinite.Visible=true;
                else
                    nosol.Visible=true;
            }
            solve3.Visible = false;
            solve3.Enabled = false;
            solutions.Visible = true;
            solutions.Enabled = true;
        }                                                               //update 1  }

        private void solve5_Click(object sender, EventArgs e)           //update 1.5   {
        {
            double[] array = new double[30];
            int i = 0, k = 0;
            foreach (Control texbox in groupBox2.Controls)
            {
                if (texbox is TextBox)
                {
                    array[i] = System.Convert.ToDouble(texbox.Text);
                    i++;
                }
            }
            double[,] myarray = new double[5, 6];

            for (int h = 0; h < 5; h++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myarray[h, j] = array[k];
                    k++;
                }

            }
                                                                 
            double[] sarray = new double[5];
            if (myarray[4, 4] != 0)
            {
                sarray[4] = myarray[4, 5] / myarray[4, 4];
                if (myarray[3, 3] != 0)
                {
                    sarray[3] = (myarray[3, 5] - (sarray[4] * myarray[3, 4])) / myarray[3, 3];
                    if (myarray[2, 2] != 0)
                    {
                        sarray[2] = (myarray[2, 5] - (sarray[4] * myarray[2, 4]) - (sarray[3] * myarray[2, 3])) / myarray[2, 2];
                        if (myarray[1,1]!=0)
                        {
                            sarray[1] = (myarray[1, 5] - (sarray[4] * myarray[1, 4]) - (sarray[3] * myarray[1, 3]) - (sarray[2] * myarray[1, 2]))/myarray[1,1];
                            if (myarray[0,0]!=0)
                            {
                                sarray[0] = (myarray[0, 5] - (sarray[4] * myarray[0, 4]) - (sarray[3] * myarray[0, 3]) - (sarray[2] * myarray[0, 2]) - (sarray[1] * myarray[0, 1]))/myarray[0,0];
                                j1.Text = "X1 = " + System.Convert.ToString(sarray[0]);
                                j2.Text = "X2 = " + System.Convert.ToString(sarray[1]);
                                j3.Text = "X3 = " + System.Convert.ToString(sarray[2]);
                                j4.Text = "X4 = " + System.Convert.ToString(sarray[3]);
                                j5.Text = "X5 = " + System.Convert.ToString(sarray[4]);
                                j1.Visible = true;
                                j2.Visible = true;
                                j3.Visible = true;
                                j4.Visible = true;
                                j5.Visible = true;
                            }
                            else
                            {
                                if ((myarray[0, 5] - (myarray[0, 2] * sarray[2])-(myarray[0,3]*sarray[3])-(myarray[0,4]*sarray[4]))/ myarray[0, 1] == sarray[1])
                                {
                                    infinite.Visible = true;
                                    j2.Text = "X2 = " + System.Convert.ToString(sarray[1]);
                                    j3.Text = "X3 = " + System.Convert.ToString(sarray[2]);
                                    j4.Text = "X4 = " + System.Convert.ToString(sarray[3]);
                                    j5.Text = "X5 = " + System.Convert.ToString(sarray[4]);
                                    j2.Visible = true;
                                    j3.Visible = true;
                                    j4.Visible = true;
                                    j5.Visible = true;
                                }
                                else
                                {
                                    nosol.Visible = true;
                                }
                            }

                        }
                        else
                        {
                            if((myarray[1,5]-(myarray[1,3]*sarray[3])-(myarray[1,4]*sarray[5])/myarray[1,2])==sarray[2])
                            {
                                infinite.Visible = true;
                                j3.Text = "X3 = " + System.Convert.ToString(sarray[2]);
                                j4.Text = "X4 = " + System.Convert.ToString(sarray[3]);
                                j5.Text = "X5 = " + System.Convert.ToString(sarray[4]);
                                j3.Visible = true;
                                j4.Visible = true;
                                j5.Visible = true;
                            }
                            else
                            {
                                nosol.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        if ((myarray[2, 5] - (myarray[2, 4] * sarray[4])) / myarray[2, 3] == sarray[3])
                        {
                            infinite.Visible = true;
                            j4.Text = "X4 = " + System.Convert.ToString(sarray[3]);
                            j5.Text = "X5 = " + System.Convert.ToString(sarray[4]);
                            j4.Visible = true;
                            j5.Visible = true;
                        }
                        else
                            nosol.Visible = true;
                    }
                }
                else
                {
                    if (myarray[3, 5] / myarray[3, 4] == sarray[4])
                    {
                        infinite.Visible = true;
                        j5.Text = "X5 = " + System.Convert.ToString(sarray[4]);
                        j5.Visible = true;
                    }


                    else
                    {
                        nosol.Visible = true;

                    }
                }
            }
            else
            {
                if (myarray[4, 5] == 0)
                    infinite.Visible = true;
                else
                    nosol.Visible = true;
            }
            solve5.Visible = false;
            solve5.Enabled = false;
            solutions.Visible = true;
            solutions.Enabled = true;
        }                                                                            //update 1.5 }
    }
}
