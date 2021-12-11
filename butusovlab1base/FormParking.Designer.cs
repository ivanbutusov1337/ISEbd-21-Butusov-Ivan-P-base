
namespace butusovlab1base
{
	partial class FormParking
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
			this.pictureBoxTrains = new System.Windows.Forms.PictureBox();
			this.buttonAddTrain = new System.Windows.Forms.Button();
			this.buttonAddHornedTrain = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonTakeCar = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrains)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxTrains
			// 
			this.pictureBoxTrains.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxTrains.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxTrains.Name = "pictureBoxTrains";
			this.pictureBoxTrains.Size = new System.Drawing.Size(631, 450);
			this.pictureBoxTrains.TabIndex = 0;
			this.pictureBoxTrains.TabStop = false;
			// 
			// buttonAddTrain
			// 
			this.buttonAddTrain.Location = new System.Drawing.Point(637, 12);
			this.buttonAddTrain.Name = "buttonAddTrain";
			this.buttonAddTrain.Size = new System.Drawing.Size(151, 40);
			this.buttonAddTrain.TabIndex = 1;
			this.buttonAddTrain.Text = "Припарковать поезд";
			this.buttonAddTrain.UseVisualStyleBackColor = true;
			this.buttonAddTrain.Click += new System.EventHandler(this.buttonAddTrain_Click);
			// 
			// buttonAddHornedTrain
			// 
			this.buttonAddHornedTrain.Location = new System.Drawing.Point(637, 59);
			this.buttonAddHornedTrain.Name = "buttonAddHornedTrain";
			this.buttonAddHornedTrain.Size = new System.Drawing.Size(151, 40);
			this.buttonAddHornedTrain.TabIndex = 2;
			this.buttonAddHornedTrain.Text = "Припарковать крутой поезд";
			this.buttonAddHornedTrain.UseVisualStyleBackColor = true;
			this.buttonAddHornedTrain.Click += new System.EventHandler(this.buttonAddHornedTrain_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonTakeCar);
			this.groupBox1.Controls.Add(this.maskedTextBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(637, 105);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(151, 100);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Забрать машину";
			// 
			// buttonTakeCar
			// 
			this.buttonTakeCar.Location = new System.Drawing.Point(6, 62);
			this.buttonTakeCar.Name = "buttonTakeCar";
			this.buttonTakeCar.Size = new System.Drawing.Size(139, 23);
			this.buttonTakeCar.TabIndex = 2;
			this.buttonTakeCar.Text = "Забрать";
			this.buttonTakeCar.UseVisualStyleBackColor = true;
			this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(6, 36);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(139, 20);
			this.maskedTextBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Место";
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonAddHornedTrain);
			this.Controls.Add(this.buttonAddTrain);
			this.Controls.Add(this.pictureBoxTrains);
			this.Name = "FormParking";
			this.Text = "Парковка";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrains)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxTrains;
		private System.Windows.Forms.Button buttonAddTrain;
		private System.Windows.Forms.Button buttonAddHornedTrain;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonTakeCar;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label1;
	}
}