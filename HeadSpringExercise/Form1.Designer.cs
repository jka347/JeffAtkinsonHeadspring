namespace HeadSpringExercise
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
			this.fizzBuzzButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fizzBuzzButton
			// 
			this.fizzBuzzButton.Location = new System.Drawing.Point(12, 12);
			this.fizzBuzzButton.Name = "fizzBuzzButton";
			this.fizzBuzzButton.Size = new System.Drawing.Size(205, 42);
			this.fizzBuzzButton.TabIndex = 0;
			this.fizzBuzzButton.Text = "FizzBuzz To Output Window!";
			this.fizzBuzzButton.UseVisualStyleBackColor = true;
			this.fizzBuzzButton.Click += new System.EventHandler(this.fizzBuzzButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(231, 63);
			this.Controls.Add(this.fizzBuzzButton);
			this.Name = "Form1";
			this.Text = "FizzBuzz";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button fizzBuzzButton;
	}
}

