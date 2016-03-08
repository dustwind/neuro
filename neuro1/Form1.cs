using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace neuro1
{
    public partial class Form1 : Form
    {
        List<double[]> learn;
        List<double[]> check;
        double[] start;
        Web web;

        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            chart_errorDynamic.Series[0].Points.Clear();
            chart_sick.Series[0].Points.Clear();
            chart_sick.Series[1].Points.Clear();            

            parseLearnTxt();
            this.web = new Web();
            this.web = web.createWeb(7, Decimal.ToInt32(nudNeuro.Value), Decimal.ToInt32(nudLayer.Value), rnd);
            List<double> error_list = web.getErrorList();
            lbl_done.Text = this.web.learnWeb(learn,rnd,Decimal.ToDouble(nudAge.Value))+"  " + error_list.Count.ToString();
            plot();
        }

        private void button_diagnos_Click(object sender, EventArgs e)
        {
            double[] param = new double[7];
            if (cbMorning.Checked) param[0] = 1; else param[0] = -1;
            if (cbSustav.Checked) param[1] = 1; else param[1] = -1;
            if (cbKist.Checked) param[2] = 1; else param[2] = -1;
            if (cbSimmetria.Checked) param[3] = 1; else param[3] = -1;
            if (cbUzli.Checked) param[4] = 1; else param[4] = -1;
            if (cbFactor.Checked) param[5] = 1; else param[5] = -1;
            if (cbXray.Checked) param[6] = 1; else param[6] = -1;

            double bbb = this.web.testWeb(param);
            lbl_diagnos.Text = bbb.ToString();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            parseCheckTxt();
            double fff = this.web.testWeb(check[1]);
            MessageBox.Show("Вы больны с вероятностью " +fff.ToString());

        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            nudLayer.Value = 2;
            nudNeuro.Value = 5;
            nudAge.Value = 100;

        }

        private void parseLearnTxt()
        {
            learn=new List<double[]>();
            var l = File.ReadAllLines("learn.txt");
            foreach (string s in l)
            {
                string w;
                w = Regex.Replace(s,@"[|]","",RegexOptions.Compiled);
                double[] param = new double[8];
                for (int i = 0; i < 8; i++)
                {
                    if (w[i].ToString() != "0")
                        param[i] = Convert.ToDouble(w[i].ToString());
                    else
                        param[i] = -1;
                }
                learn.Add(param);
            }
        }

        private void parseCheckTxt()
        {
            check=new List<double[]>();
            var l = File.ReadAllLines("check.txt");
            foreach (string s in l)
            {
                string w;
                w = Regex.Replace(s, @"[|]", "", RegexOptions.Compiled);
                double[] param = new double[8];
                for (int i = 0; i < 8; i++)
                {
                    param[i] = Convert.ToDouble(w[i].ToString());
                }
                check.Add(param);
            }
        }

        static void SaveToXML(Web Network)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = new FileStream("network", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fStream, Network);
            }
        }
        static Web OpenXml()
        {
            FileStream fs = new FileStream("network", FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Web Temp = (Web)bf.Deserialize(fs);
            return Temp;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveToXML(this.web);
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            chart_errorDynamic.Series[0].Points.Clear();
            chart_sick.Series[0].Points.Clear();
            chart_sick.Series[1].Points.Clear();
            this.web=OpenXml();
            parseLearnTxt();
            plot();
        }

        private void plot()
        {
            List<double> error_list = web.getErrorList();
            lbl_done.Text = "done " + error_list.Count.ToString();

            chart_errorDynamic.ChartAreas[0].AxisY.Minimum = 0;
            chart_errorDynamic.ChartAreas[0].AxisX.Minimum = 0;
            for (int i = 0; i < error_list.Count; i++)
            {
                chart_errorDynamic.Series[0].Points.AddXY(i, error_list[i]);
            }

            List<double[]> val = web.getFinalValues();
            chart_sick.ChartAreas[0].AxisY.Minimum = 0;
            for (int i = 0; i < error_list.Count; i++)
            {
                for (int j = 0; j < val[i].Count(); j++)
                {
                    if (learn[j][7] == -1) chart_sick.Series[0].Points.AddXY(val[i][j], i + rnd.NextDouble() / 5.0 - 0.1);
                    else chart_sick.Series[1].Points.AddXY(val[i][j], i + rnd.NextDouble() / 5.0 - 0.1);
                }
            }
        }
    }
}
