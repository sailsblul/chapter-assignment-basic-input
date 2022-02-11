namespace chapter_assignment_basic_input
{
    partial class BasicInput
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
            this.lblGetName = new System.Windows.Forms.Label();
            this.lblGetAge = new System.Windows.Forms.Label();
            this.lblGetHeight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblMetres = new System.Windows.Forms.Label();
            this.lblNameMsg = new System.Windows.Forms.Label();
            this.lblAgeMsg = new System.Windows.Forms.Label();
            this.lblHeightMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGetName
            // 
            this.lblGetName.AutoSize = true;
            this.lblGetName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetName.Location = new System.Drawing.Point(29, 32);
            this.lblGetName.Name = "lblGetName";
            this.lblGetName.Size = new System.Drawing.Size(94, 13);
            this.lblGetName.TabIndex = 0;
            this.lblGetName.Text = "Enter your name:";
            // 
            // lblGetAge
            // 
            this.lblGetAge.AutoSize = true;
            this.lblGetAge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetAge.Location = new System.Drawing.Point(186, 32);
            this.lblGetAge.Name = "lblGetAge";
            this.lblGetAge.Size = new System.Drawing.Size(85, 13);
            this.lblGetAge.TabIndex = 1;
            this.lblGetAge.Text = "Enter your age:";
            // 
            // lblGetHeight
            // 
            this.lblGetHeight.AutoSize = true;
            this.lblGetHeight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetHeight.Location = new System.Drawing.Point(328, 32);
            this.lblGetHeight.Name = "lblGetHeight";
            this.lblGetHeight.Size = new System.Drawing.Size(100, 13);
            this.lblGetHeight.TabIndex = 2;
            this.lblGetHeight.Text = "Enter your height:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(32, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(503, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(285, 91);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(198, 61);
            this.numAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numAge.Size = new System.Drawing.Size(44, 20);
            this.numAge.TabIndex = 5;
            this.numAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(331, 61);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 6;
            // 
            // lblMetres
            // 
            this.lblMetres.AutoSize = true;
            this.lblMetres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetres.Location = new System.Drawing.Point(437, 68);
            this.lblMetres.Name = "lblMetres";
            this.lblMetres.Size = new System.Drawing.Size(41, 13);
            this.lblMetres.TabIndex = 7;
            this.lblMetres.Text = "metres";
            // 
            // lblNameMsg
            // 
            this.lblNameMsg.AutoSize = true;
            this.lblNameMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMsg.Location = new System.Drawing.Point(29, 150);
            this.lblNameMsg.Name = "lblNameMsg";
            this.lblNameMsg.Size = new System.Drawing.Size(0, 25);
            this.lblNameMsg.TabIndex = 8;
            // 
            // lblAgeMsg
            // 
            this.lblAgeMsg.AutoSize = true;
            this.lblAgeMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeMsg.Location = new System.Drawing.Point(29, 228);
            this.lblAgeMsg.Name = "lblAgeMsg";
            this.lblAgeMsg.Size = new System.Drawing.Size(0, 25);
            this.lblAgeMsg.TabIndex = 9;
            // 
            // lblHeightMsg
            // 
            this.lblHeightMsg.AutoSize = true;
            this.lblHeightMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightMsg.Location = new System.Drawing.Point(29, 316);
            this.lblHeightMsg.Name = "lblHeightMsg";
            this.lblHeightMsg.Size = new System.Drawing.Size(0, 25);
            this.lblHeightMsg.TabIndex = 10;
            // 
            // BasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.lblHeightMsg);
            this.Controls.Add(this.lblAgeMsg);
            this.Controls.Add(this.lblNameMsg);
            this.Controls.Add(this.lblMetres);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGetHeight);
            this.Controls.Add(this.lblGetAge);
            this.Controls.Add(this.lblGetName);
            this.Name = "BasicInput";
            this.Text = "Basic Input";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetName;
        private System.Windows.Forms.Label lblGetAge;
        private System.Windows.Forms.Label lblGetHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblMetres;
        private System.Windows.Forms.Label lblNameMsg;
        private System.Windows.Forms.Label lblAgeMsg;
        private System.Windows.Forms.Label lblHeightMsg;
    }
}

