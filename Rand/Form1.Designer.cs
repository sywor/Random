namespace Rand
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_gen = new System.Windows.Forms.Button();
			this.txb_out = new System.Windows.Forms.TextBox();
			this.btn_saveLoc = new System.Windows.Forms.Button();
			this.txb_start = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txb_end = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txb_count = new System.Windows.Forms.TextBox();
			this.pb_gen = new System.Windows.Forms.ProgressBar();
			this.label5 = new System.Windows.Forms.Label();
			this.nud_iter = new System.Windows.Forms.NumericUpDown();
			this.bgw = new System.ComponentModel.BackgroundWorker();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.nud_iter)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_gen
			// 
			this.btn_gen.Enabled = false;
			this.btn_gen.Location = new System.Drawing.Point(289, 58);
			this.btn_gen.Name = "btn_gen";
			this.btn_gen.Size = new System.Drawing.Size(75, 23);
			this.btn_gen.TabIndex = 0;
			this.btn_gen.Text = "Generate";
			this.btn_gen.UseVisualStyleBackColor = true;
			this.btn_gen.Click += new System.EventHandler(this.bth_gen_Click);
			// 
			// txb_out
			// 
			this.txb_out.Location = new System.Drawing.Point(15, 87);
			this.txb_out.Multiline = true;
			this.txb_out.Name = "txb_out";
			this.txb_out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txb_out.Size = new System.Drawing.Size(348, 215);
			this.txb_out.TabIndex = 1;
			// 
			// btn_saveLoc
			// 
			this.btn_saveLoc.Location = new System.Drawing.Point(208, 58);
			this.btn_saveLoc.Name = "btn_saveLoc";
			this.btn_saveLoc.Size = new System.Drawing.Size(75, 23);
			this.btn_saveLoc.TabIndex = 2;
			this.btn_saveLoc.Text = "Browse";
			this.btn_saveLoc.UseVisualStyleBackColor = true;
			this.btn_saveLoc.Click += new System.EventHandler(this.btn_saveLoc_Click);
			// 
			// txb_start
			// 
			this.txb_start.Location = new System.Drawing.Point(85, 6);
			this.txb_start.Name = "txb_start";
			this.txb_start.Size = new System.Drawing.Size(100, 20);
			this.txb_start.TabIndex = 3;
			this.txb_start.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Start number:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(191, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "End number:";
			// 
			// txb_end
			// 
			this.txb_end.Location = new System.Drawing.Point(264, 6);
			this.txb_end.Name = "txb_end";
			this.txb_end.Size = new System.Drawing.Size(100, 20);
			this.txb_end.TabIndex = 6;
			this.txb_end.Text = "1000";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Count:";
			// 
			// txb_count
			// 
			this.txb_count.Location = new System.Drawing.Point(85, 32);
			this.txb_count.Name = "txb_count";
			this.txb_count.Size = new System.Drawing.Size(100, 20);
			this.txb_count.TabIndex = 8;
			this.txb_count.Text = "15000";
			// 
			// pb_gen
			// 
			this.pb_gen.Location = new System.Drawing.Point(16, 308);
			this.pb_gen.Name = "pb_gen";
			this.pb_gen.Size = new System.Drawing.Size(348, 23);
			this.pb_gen.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(186, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Num iteration:";
			// 
			// nud_iter
			// 
			this.nud_iter.Location = new System.Drawing.Point(266, 32);
			this.nud_iter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_iter.Name = "nud_iter";
			this.nud_iter.Size = new System.Drawing.Size(98, 20);
			this.nud_iter.TabIndex = 13;
			this.nud_iter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// bgw
			// 
			this.bgw.WorkerReportsProgress = true;
			this.bgw.WorkerSupportsCancellation = true;
			this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
			this.bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
			this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 343);
			this.Controls.Add(this.nud_iter);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pb_gen);
			this.Controls.Add(this.txb_count);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txb_end);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txb_start);
			this.Controls.Add(this.btn_saveLoc);
			this.Controls.Add(this.txb_out);
			this.Controls.Add(this.btn_gen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Random Number Generator";
			((System.ComponentModel.ISupportInitialize)(this.nud_iter)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_gen;
		private System.Windows.Forms.TextBox txb_out;
		private System.Windows.Forms.Button btn_saveLoc;
		private System.Windows.Forms.TextBox txb_start;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txb_end;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txb_count;
		private System.Windows.Forms.ProgressBar pb_gen;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nud_iter;
		private System.ComponentModel.BackgroundWorker bgw;
		private System.Windows.Forms.FolderBrowserDialog fbd;
	}
}

