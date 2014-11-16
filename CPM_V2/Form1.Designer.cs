namespace CPM
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
			this.btnShowTimes = new System.Windows.Forms.PictureBox();
			this.btAddNode = new System.Windows.Forms.Button();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnShowTimeScale = new System.Windows.Forms.Button();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnTestGraph = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.btnShowTimes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnShowTimes
			// 
			this.btnShowTimes.Location = new System.Drawing.Point(353, 12);
			this.btnShowTimes.Name = "btnShowTimes";
			this.btnShowTimes.Size = new System.Drawing.Size(700, 517);
			this.btnShowTimes.TabIndex = 1;
			this.btnShowTimes.TabStop = false;
			// 
			// btAddNode
			// 
			this.btAddNode.Location = new System.Drawing.Point(12, 12);
			this.btAddNode.Name = "btAddNode";
			this.btAddNode.Size = new System.Drawing.Size(75, 23);
			this.btAddNode.TabIndex = 2;
			this.btAddNode.Text = "Add node";
			this.btAddNode.UseVisualStyleBackColor = true;
			this.btAddNode.Click += new System.EventHandler(this.btAddNode_Click);
			// 
			// btnShow
			// 
			this.btnShow.Enabled = false;
			this.btnShow.Location = new System.Drawing.Point(93, 12);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 4;
			this.btnShow.Text = "Show graph";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// btnShowTimeScale
			// 
			this.btnShowTimeScale.Enabled = false;
			this.btnShowTimeScale.Location = new System.Drawing.Point(255, 12);
			this.btnShowTimeScale.Name = "btnShowTimeScale";
			this.btnShowTimeScale.Size = new System.Drawing.Size(92, 23);
			this.btnShowTimeScale.TabIndex = 5;
			this.btnShowTimeScale.Text = "Show time scale";
			this.btnShowTimeScale.UseVisualStyleBackColor = true;
			this.btnShowTimeScale.Click += new System.EventHandler(this.btnShowTimeScale_Click);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Enabled = false;
			this.btnCalculate.Location = new System.Drawing.Point(174, 12);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 6;
			this.btnCalculate.Text = "Calcutate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnTestGraph
			// 
			this.btnTestGraph.Location = new System.Drawing.Point(12, 41);
			this.btnTestGraph.Name = "btnTestGraph";
			this.btnTestGraph.Size = new System.Drawing.Size(156, 23);
			this.btnTestGraph.TabIndex = 7;
			this.btnTestGraph.Text = "Prepare test graph";
			this.btnTestGraph.UseVisualStyleBackColor = true;
			this.btnTestGraph.Click += new System.EventHandler(this.btnTestGraph_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 575);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1041, 120);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1065, 707);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnTestGraph);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.btnShowTimeScale);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.btAddNode);
			this.Controls.Add(this.btnShowTimes);
			this.Name = "Form1";
			this.Text = "CPM";
			((System.ComponentModel.ISupportInitialize)(this.btnShowTimes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.PictureBox btnShowTimes;
		public System.Windows.Forms.Button btAddNode;
		public System.Windows.Forms.Button btnShow;
		public System.Windows.Forms.Button btnShowTimeScale;
		public System.Windows.Forms.Button btnCalculate;
		public System.Windows.Forms.Button btnTestGraph;
		public System.Windows.Forms.PictureBox pictureBox1;
	}
}

