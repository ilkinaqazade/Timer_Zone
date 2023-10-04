namespace _1_Task
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
            this.BakuBtr = new System.Windows.Forms.Button();
            this.LondonBtr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BakuBtr
            // 
            this.BakuBtr.Location = new System.Drawing.Point(52, 68);
            this.BakuBtr.Name = "BakuBtr";
            this.BakuBtr.Size = new System.Drawing.Size(215, 96);
            this.BakuBtr.TabIndex = 0;
            this.BakuBtr.Text = "Baku";
            this.BakuBtr.UseVisualStyleBackColor = true;
            this.BakuBtr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BakuBtr_MouseClick);
            // 
            // LondonBtr
            // 
            this.LondonBtr.Location = new System.Drawing.Point(52, 244);
            this.LondonBtr.Name = "LondonBtr";
            this.LondonBtr.Size = new System.Drawing.Size(215, 96);
            this.LondonBtr.TabIndex = 1;
            this.LondonBtr.Text = "London";
            this.LondonBtr.UseVisualStyleBackColor = true;
            this.LondonBtr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LondonBtr_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(439, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 69);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_1_Task.Properties.Resources.Baku;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LondonBtr);
            this.Controls.Add(this.BakuBtr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BakuBtr;
        private System.Windows.Forms.Button LondonBtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

