namespace Run
{
    partial class FrmRun
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
            this.picCarro01 = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.picCarro02 = new System.Windows.Forms.PictureBox();
            this.picCarro03 = new System.Windows.Forms.PictureBox();
            this.lblPosicion01 = new System.Windows.Forms.Label();
            this.lblPosicion02 = new System.Windows.Forms.Label();
            this.lblPosicion03 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro03)).BeginInit();
            this.SuspendLayout();
            // 
            // picCarro01
            // 
            this.picCarro01.BackColor = System.Drawing.Color.Transparent;
            this.picCarro01.BackgroundImage = global::Run.Properties.Resources._68321;
            this.picCarro01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarro01.Image = global::Run.Properties.Resources._68321;
            this.picCarro01.Location = new System.Drawing.Point(12, 12);
            this.picCarro01.Name = "picCarro01";
            this.picCarro01.Size = new System.Drawing.Size(50, 50);
            this.picCarro01.TabIndex = 0;
            this.picCarro01.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 220);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // picCarro02
            // 
            this.picCarro02.BackColor = System.Drawing.Color.Transparent;
            this.picCarro02.BackgroundImage = global::Run.Properties.Resources._68321;
            this.picCarro02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarro02.Location = new System.Drawing.Point(12, 68);
            this.picCarro02.Name = "picCarro02";
            this.picCarro02.Size = new System.Drawing.Size(50, 50);
            this.picCarro02.TabIndex = 2;
            this.picCarro02.TabStop = false;
            // 
            // picCarro03
            // 
            this.picCarro03.BackColor = System.Drawing.Color.Transparent;
            this.picCarro03.BackgroundImage = global::Run.Properties.Resources._68321;
            this.picCarro03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarro03.Location = new System.Drawing.Point(12, 124);
            this.picCarro03.Name = "picCarro03";
            this.picCarro03.Size = new System.Drawing.Size(50, 50);
            this.picCarro03.TabIndex = 3;
            this.picCarro03.TabStop = false;
            // 
            // lblPosicion01
            // 
            this.lblPosicion01.AutoSize = true;
            this.lblPosicion01.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion01.Location = new System.Drawing.Point(1032, 20);
            this.lblPosicion01.Name = "lblPosicion01";
            this.lblPosicion01.Size = new System.Drawing.Size(40, 42);
            this.lblPosicion01.TabIndex = 7;
            this.lblPosicion01.Text = "0";
            // 
            // lblPosicion02
            // 
            this.lblPosicion02.AutoSize = true;
            this.lblPosicion02.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion02.Location = new System.Drawing.Point(1032, 76);
            this.lblPosicion02.Name = "lblPosicion02";
            this.lblPosicion02.Size = new System.Drawing.Size(40, 42);
            this.lblPosicion02.TabIndex = 8;
            this.lblPosicion02.Text = "0";
            // 
            // lblPosicion03
            // 
            this.lblPosicion03.AutoSize = true;
            this.lblPosicion03.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion03.Location = new System.Drawing.Point(1032, 132);
            this.lblPosicion03.Name = "lblPosicion03";
            this.lblPosicion03.Size = new System.Drawing.Size(40, 42);
            this.lblPosicion03.TabIndex = 9;
            this.lblPosicion03.Text = "0";
            // 
            // FrmRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 255);
            this.Controls.Add(this.lblPosicion03);
            this.Controls.Add(this.lblPosicion02);
            this.Controls.Add(this.lblPosicion01);
            this.Controls.Add(this.picCarro03);
            this.Controls.Add(this.picCarro02);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.picCarro01);
            this.Name = "FrmRun";
            this.Text = "FrmRun";
            ((System.ComponentModel.ISupportInitialize)(this.picCarro01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarro03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCarro01;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.PictureBox picCarro02;
        private System.Windows.Forms.PictureBox picCarro03;
        private System.Windows.Forms.Label lblPosicion01;
        private System.Windows.Forms.Label lblPosicion02;
        private System.Windows.Forms.Label lblPosicion03;
    }
}