namespace RLC_Circuit
{
    partial class Form_Power_Parameters
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Amplitude = new System.Windows.Forms.TextBox();
            this.textBox_Frequency = new System.Windows.Forms.TextBox();
            this.textBox_Phase = new System.Windows.Forms.TextBox();
            this.label_Amplitude = new System.Windows.Forms.Label();
            this.label_Frequency = new System.Windows.Forms.Label();
            this.Phase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Amplitude
            // 
            this.textBox_Amplitude.Location = new System.Drawing.Point(120, 58);
            this.textBox_Amplitude.Name = "textBox_Amplitude";
            this.textBox_Amplitude.Size = new System.Drawing.Size(148, 26);
            this.textBox_Amplitude.TabIndex = 1;
            // 
            // textBox_Frequency
            // 
            this.textBox_Frequency.Location = new System.Drawing.Point(120, 113);
            this.textBox_Frequency.Name = "textBox_Frequency";
            this.textBox_Frequency.Size = new System.Drawing.Size(148, 26);
            this.textBox_Frequency.TabIndex = 2;
            // 
            // textBox_Phase
            // 
            this.textBox_Phase.Location = new System.Drawing.Point(120, 168);
            this.textBox_Phase.Name = "textBox_Phase";
            this.textBox_Phase.Size = new System.Drawing.Size(148, 26);
            this.textBox_Phase.TabIndex = 3;
            // 
            // label_Amplitude
            // 
            this.label_Amplitude.AutoSize = true;
            this.label_Amplitude.Location = new System.Drawing.Point(12, 61);
            this.label_Amplitude.Name = "label_Amplitude";
            this.label_Amplitude.Size = new System.Drawing.Size(91, 19);
            this.label_Amplitude.TabIndex = 4;
            this.label_Amplitude.Text = "Amplitude[V]";
            // 
            // label_Frequency
            // 
            this.label_Frequency.AutoSize = true;
            this.label_Frequency.Location = new System.Drawing.Point(12, 116);
            this.label_Frequency.Name = "label_Frequency";
            this.label_Frequency.Size = new System.Drawing.Size(99, 19);
            this.label_Frequency.TabIndex = 5;
            this.label_Frequency.Text = "Frequency[Hz]";
            // 
            // Phase
            // 
            this.Phase.AutoSize = true;
            this.Phase.Location = new System.Drawing.Point(12, 171);
            this.Phase.Name = "Phase";
            this.Phase.Size = new System.Drawing.Size(76, 19);
            this.Phase.TabIndex = 6;
            this.Phase.Text = "Phase[deg]";
            // 
            // Form_Power_Parameters
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 287);
            this.Controls.Add(this.Phase);
            this.Controls.Add(this.label_Frequency);
            this.Controls.Add(this.label_Amplitude);
            this.Controls.Add(this.textBox_Phase);
            this.Controls.Add(this.textBox_Frequency);
            this.Controls.Add(this.textBox_Amplitude);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 330);
            this.Name = "Form_Power_Parameters";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Amplitude;
        private System.Windows.Forms.TextBox textBox_Frequency;
        private System.Windows.Forms.TextBox textBox_Phase;
        private System.Windows.Forms.Label label_Amplitude;
        private System.Windows.Forms.Label label_Frequency;
        private System.Windows.Forms.Label Phase;
    }
}