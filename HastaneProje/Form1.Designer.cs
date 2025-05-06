namespace HastaneProje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DoktorBtn = new System.Windows.Forms.Button();
            this.SekreterBtn = new System.Windows.Forms.Button();
            this.HastaBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sekreter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doktor";
            // 
            // DoktorBtn
            // 
            this.DoktorBtn.BackgroundImage = global::HastaneProje.Properties.Resources.pngtree_vector_doctor_icon_png_image_4277629;
            this.DoktorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoktorBtn.Location = new System.Drawing.Point(651, 267);
            this.DoktorBtn.Name = "DoktorBtn";
            this.DoktorBtn.Size = new System.Drawing.Size(266, 167);
            this.DoktorBtn.TabIndex = 2;
            this.DoktorBtn.UseVisualStyleBackColor = true;
            this.DoktorBtn.Click += new System.EventHandler(this.DoktorBtn_Click);
            // 
            // SekreterBtn
            // 
            this.SekreterBtn.BackColor = System.Drawing.Color.White;
            this.SekreterBtn.BackgroundImage = global::HastaneProje.Properties.Resources._5292669;
            this.SekreterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SekreterBtn.Location = new System.Drawing.Point(332, 267);
            this.SekreterBtn.Name = "SekreterBtn";
            this.SekreterBtn.Size = new System.Drawing.Size(266, 167);
            this.SekreterBtn.TabIndex = 1;
            this.SekreterBtn.UseVisualStyleBackColor = false;
            this.SekreterBtn.Click += new System.EventHandler(this.SekreterBtn_Click);
            // 
            // HastaBtn
            // 
            this.HastaBtn.BackColor = System.Drawing.Color.White;
            this.HastaBtn.BackgroundImage = global::HastaneProje.Properties.Resources.patient_icon_png_21;
            this.HastaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HastaBtn.Location = new System.Drawing.Point(12, 267);
            this.HastaBtn.Name = "HastaBtn";
            this.HastaBtn.Size = new System.Drawing.Size(266, 167);
            this.HastaBtn.TabIndex = 0;
            this.HastaBtn.UseVisualStyleBackColor = false;
            this.HastaBtn.Click += new System.EventHandler(this.HastaBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneProje.Properties.Resources.istockphoto_1396260353_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(360, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tuzla Devlet Hastanesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(929, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoktorBtn);
            this.Controls.Add(this.SekreterBtn);
            this.Controls.Add(this.HastaBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HastaBtn;
        private System.Windows.Forms.Button SekreterBtn;
        private System.Windows.Forms.Button DoktorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

