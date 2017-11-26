namespace Quick_Math_Jr_App_for_Kids
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
            this.mnuXeBus = new System.Windows.Forms.Button();
            this.mnuThuyen = new System.Windows.Forms.Button();
            this.mnuNha = new System.Windows.Forms.Button();
            this.mnuCamera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mnuXeBus
            // 
            this.mnuXeBus.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.images__1_1;
            this.mnuXeBus.Location = new System.Drawing.Point(12, 12);
            this.mnuXeBus.Name = "mnuXeBus";
            this.mnuXeBus.Size = new System.Drawing.Size(260, 210);
            this.mnuXeBus.TabIndex = 3;
            this.mnuXeBus.UseVisualStyleBackColor = true;
            // 
            // mnuThuyen
            // 
            this.mnuThuyen.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.images__1_;
            this.mnuThuyen.Location = new System.Drawing.Point(12, 246);
            this.mnuThuyen.Name = "mnuThuyen";
            this.mnuThuyen.Size = new System.Drawing.Size(260, 210);
            this.mnuThuyen.TabIndex = 2;
            this.mnuThuyen.UseVisualStyleBackColor = true;
            // 
            // mnuNha
            // 
            this.mnuNha.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.logo;
            this.mnuNha.Location = new System.Drawing.Point(300, 12);
            this.mnuNha.Name = "mnuNha";
            this.mnuNha.Size = new System.Drawing.Size(260, 210);
            this.mnuNha.TabIndex = 1;
            this.mnuNha.UseVisualStyleBackColor = true;
            // 
            // mnuCamera
            // 
            this.mnuCamera.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.images;
            this.mnuCamera.Location = new System.Drawing.Point(300, 246);
            this.mnuCamera.Name = "mnuCamera";
            this.mnuCamera.Size = new System.Drawing.Size(260, 210);
            this.mnuCamera.TabIndex = 0;
            this.mnuCamera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 468);
            this.Controls.Add(this.mnuXeBus);
            this.Controls.Add(this.mnuThuyen);
            this.Controls.Add(this.mnuNha);
            this.Controls.Add(this.mnuCamera);
            this.Name = "Form1";
            this.Text = "Quick Math Jr App for Kids";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mnuCamera;
        private System.Windows.Forms.Button mnuNha;
        private System.Windows.Forms.Button mnuThuyen;
        private System.Windows.Forms.Button mnuXeBus;
    }
}

