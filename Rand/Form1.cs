using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Rand
{
	struct bar
	{
		public double mean { get; private set; }
		public double deviation { get; private set; }

		public bar(double _mean, double _deviation) : this()
		{
			mean = _mean;
			deviation = _deviation;
		}
	}


	public partial class Form1 : Form
	{
		DateTime prev;
		int a = 0;

		public Form1()
		{
			InitializeComponent();
		}		

		private void bth_gen_Click(object sender, EventArgs e)
		{
			prev = DateTime.Now;
			txb_out.Clear();
			txb_out.AppendText("Rand number generation started at: " + prev.ToLongTimeString() + "\n");

			int start = Convert.ToInt32(txb_start.Text);
			int end = Convert.ToInt32(txb_end.Text);
			int count = Convert.ToInt32(txb_count.Text);
			int iterCount = Convert.ToInt32(nud_iter.Value);

			pb_gen.Maximum = count * iterCount;

			object[] args = new object[] { start, end, count, iterCount, fbd.SelectedPath };

			bgw.RunWorkerAsync(args);
		}

		private void btn_saveLoc_Click(object sender, EventArgs e)
		{
			DialogResult res = fbd.ShowDialog();

			if (res == DialogResult.OK)
			{
				btn_gen.Enabled = true;
			}
		}

		private bar calcBar(int[] _i)
		{
			double mean = (double)_i.Sum() / (double)_i.Length;
			double[] tmp = new double[_i.Length];

			for (int i = 0; i < _i.Length; i++)
			{
				tmp[i] = (_i[i] - mean) * (_i[i] - mean);
			}			

			return new bar(mean, Math.Sqrt(tmp.Sum() / tmp.Length));
		}

		private string convertToStr(double _d)
		{
			string tmp = _d.ToString();
			return tmp.Replace(',', '.');
		}

		private void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			object[] args = (object[])e.Argument;

			int start = (int)args[0];
			int end = (int)args[1];
			int count = (int)args[2];
			int iterCount = (int)args[3];

			string fileName = (string)args[4];

			int[][] stat = new int[100][];
			double[,] data = new double[iterCount, count];

			for (int i = 0; i < 100; i++)
			{
				stat[i] = new int[iterCount];
			}

			Random rand = new Random();

			for (int a = 0; a < iterCount; a++)
			{
				for (int i = 0; i < count; i++)
				{
					double d = start + rand.NextDouble() * (end - start);
					stat[(int)(d / 10)][a]++;
					data[a, i] = d;
					bgw.ReportProgress(1);
				}

				bgw.ReportProgress(0, "Iteration " + a + " is complete \n");
			}

			bar[] res = new bar[100];
			bgw.ReportProgress(0, "Calculating bar graph values \n");
			for (int i = 0; i < 100; i++)
			{
				res[i] = calcBar(stat[i]);
			}

			StreamWriter writer = new StreamWriter(fileName + "\\stat.txt", false, Encoding.ASCII);

			bgw.ReportProgress(0, "Writing to statistics file \n");
			for (int i = 0; i < res.Length; i++)
			{
				writer.Write(i + "\t" + convertToStr(res[i].mean) + "\t" + convertToStr(res[i].deviation) + "\n");
			}

			writer.Flush();
			writer.Close();

			writer = new StreamWriter(fileName + "\\data.txt", false, Encoding.ASCII);
			StringBuilder sb = new StringBuilder();

			bgw.ReportProgress(0, "Writing to data file \n");
			for (int i = 0; i < count; i++ )
			{
				for (int j = 0; j < iterCount; j++ )
				{
					sb.Append(data[j, i] + "\t");
				}
				writer.Write(sb.ToString() + "\n");
				sb.Clear();
			}

			writer.Flush();
			writer.Close();
		}

		private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			txb_out.AppendText("Rand number generation finished at: " + DateTime.Now.ToLongTimeString() + "\n");
			txb_out.AppendText("it took: " + (DateTime.Now - prev).ToString());
		}

		private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (e.ProgressPercentage == 1)
			{
				pb_gen.Increment(1);
			}
			else
			{
				txb_out.AppendText(e.UserState.ToString());
			}
		}
	}
}
