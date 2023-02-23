
namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.generatePassBT = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.generatePassBT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordTB, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 229);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // generatePassBT
            // 
            this.generatePassBT.Location = new System.Drawing.Point(65, 144);
            this.generatePassBT.Margin = new System.Windows.Forms.Padding(65, 30, 3, 3);
            this.generatePassBT.Name = "generatePassBT";
            this.generatePassBT.Size = new System.Drawing.Size(171, 54);
            this.generatePassBT.TabIndex = 0;
            this.generatePassBT.Text = "Generate password";
            this.generatePassBT.UseVisualStyleBackColor = true;
            this.generatePassBT.Click += new System.EventHandler(this.generatePassBT_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(65, 70);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(65, 70, 3, 3);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(174, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(297, 224);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button generatePassBT;
        private System.Windows.Forms.TextBox passwordTB;
    }
}

