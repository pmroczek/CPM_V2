namespace CPM.Controls
{
	partial class AddNode
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNodeName = new System.Windows.Forms.Label();
			this.lblNodeId = new System.Windows.Forms.Label();
			this.lblNodeTime = new System.Windows.Forms.Label();
			this.tbDuration = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbNodeName = new System.Windows.Forms.TextBox();
			this.cbxNeighbors = new System.Windows.Forms.CheckedListBox();
			this.lblNearby = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNodeName
			// 
			this.lblNodeName.AutoSize = true;
			this.lblNodeName.Location = new System.Drawing.Point(16, 26);
			this.lblNodeName.Name = "lblNodeName";
			this.lblNodeName.Size = new System.Drawing.Size(36, 13);
			this.lblNodeName.TabIndex = 0;
			this.lblNodeName.Text = "Node:";
			// 
			// lblNodeId
			// 
			this.lblNodeId.AutoSize = true;
			this.lblNodeId.Location = new System.Drawing.Point(59, 26);
			this.lblNodeId.Name = "lblNodeId";
			this.lblNodeId.Size = new System.Drawing.Size(0, 13);
			this.lblNodeId.TabIndex = 1;
			// 
			// lblNodeTime
			// 
			this.lblNodeTime.AutoSize = true;
			this.lblNodeTime.Location = new System.Drawing.Point(16, 50);
			this.lblNodeTime.Name = "lblNodeTime";
			this.lblNodeTime.Size = new System.Drawing.Size(33, 13);
			this.lblNodeTime.TabIndex = 2;
			this.lblNodeTime.Text = "Time:";
			// 
			// tbDuration
			// 
			this.tbDuration.Location = new System.Drawing.Point(98, 47);
			this.tbDuration.Name = "tbDuration";
			this.tbDuration.Size = new System.Drawing.Size(75, 20);
			this.tbDuration.TabIndex = 3;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(16, 279);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(98, 279);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// tbNodeName
			// 
			this.tbNodeName.Location = new System.Drawing.Point(98, 23);
			this.tbNodeName.Name = "tbNodeName";
			this.tbNodeName.Size = new System.Drawing.Size(75, 20);
			this.tbNodeName.TabIndex = 6;
			// 
			// cbxNeighbors
			// 
			this.cbxNeighbors.FormattingEnabled = true;
			this.cbxNeighbors.Location = new System.Drawing.Point(98, 74);
			this.cbxNeighbors.Name = "cbxNeighbors";
			this.cbxNeighbors.Size = new System.Drawing.Size(75, 184);
			this.cbxNeighbors.TabIndex = 7;
			// 
			// lblNearby
			// 
			this.lblNearby.AutoEllipsis = true;
			this.lblNearby.AutoSize = true;
			this.lblNearby.Location = new System.Drawing.Point(13, 74);
			this.lblNearby.Name = "lblNearby";
			this.lblNearby.Size = new System.Drawing.Size(58, 13);
			this.lblNearby.TabIndex = 8;
			this.lblNearby.Text = "Neighbors:";
			// 
			// AddNode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblNearby);
			this.Controls.Add(this.cbxNeighbors);
			this.Controls.Add(this.tbNodeName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.tbDuration);
			this.Controls.Add(this.lblNodeTime);
			this.Controls.Add(this.lblNodeId);
			this.Controls.Add(this.lblNodeName);
			this.Name = "AddNode";
			this.Size = new System.Drawing.Size(200, 314);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNodeName;
		private System.Windows.Forms.Label lblNodeId;
		private System.Windows.Forms.Label lblNodeTime;
		private System.Windows.Forms.TextBox tbDuration;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbNodeName;
		private System.Windows.Forms.CheckedListBox cbxNeighbors;
		private System.Windows.Forms.Label lblNearby;
	}
}
