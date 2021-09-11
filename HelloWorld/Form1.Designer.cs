
namespace HelloWorld
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
            this.btnHello = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHello.Location = new System.Drawing.Point(360, 314);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 28);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Press";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(303, 155);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(183, 43);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "C# Project";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My First Project - Felipe Woods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label lblHello;
    }
}

