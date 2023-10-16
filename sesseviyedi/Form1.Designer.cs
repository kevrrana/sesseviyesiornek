namespace sesseviyedi
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
            this.tbSes = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSesSeviyesi = new System.Windows.Forms.Label();
            this.lblSesDegeri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSes
            // 
            this.tbSes.Location = new System.Drawing.Point(166, 49);
            this.tbSes.Maximum = 100;
            this.tbSes.Name = "tbSes";
            this.tbSes.Size = new System.Drawing.Size(455, 45);
            this.tbSes.TabIndex = 0;
            this.tbSes.Scroll += new System.EventHandler(this.tbSes_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ses Seviyesi:";
            // 
            // lblSesSeviyesi
            // 
            this.lblSesSeviyesi.AutoSize = true;
            this.lblSesSeviyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSesSeviyesi.Location = new System.Drawing.Point(12, 158);
            this.lblSesSeviyesi.Name = "lblSesSeviyesi";
            this.lblSesSeviyesi.Size = new System.Drawing.Size(155, 25);
            this.lblSesSeviyesi.TabIndex = 2;
            this.lblSesSeviyesi.Text = "Ses Seviyesi:";
            // 
            // lblSesDegeri
            // 
            this.lblSesDegeri.AutoSize = true;
            this.lblSesDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSesDegeri.Location = new System.Drawing.Point(640, 58);
            this.lblSesDegeri.Name = "lblSesDegeri";
            this.lblSesDegeri.Size = new System.Drawing.Size(142, 25);
            this.lblSesDegeri.TabIndex = 3;
            this.lblSesDegeri.Text = "Ses Değeri :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSesDegeri);
            this.Controls.Add(this.lblSesSeviyesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbSes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSesSeviyesi;
        private System.Windows.Forms.Label lblSesDegeri;
    }
}

