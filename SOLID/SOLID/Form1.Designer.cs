
namespace SOLID
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbshapeType = new System.Windows.Forms.ComboBox();
            this.txtvalue1 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbresult = new System.Windows.Forms.Label();
            this.txtvalue2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbshapeType
            // 
            this.cmbshapeType.FormattingEnabled = true;
            this.cmbshapeType.Location = new System.Drawing.Point(84, 67);
            this.cmbshapeType.Name = "cmbshapeType";
            this.cmbshapeType.Size = new System.Drawing.Size(234, 28);
            this.cmbshapeType.TabIndex = 0;
            // 
            // txtvalue1
            // 
            this.txtvalue1.Location = new System.Drawing.Point(84, 147);
            this.txtvalue1.Name = "txtvalue1";
            this.txtvalue1.Size = new System.Drawing.Size(228, 27);
            this.txtvalue1.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(145, 275);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(122, 29);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "محاسبه مساحت";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(154, 319);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(0, 20);
            this.lbresult.TabIndex = 3;
            // 
            // txtvalue2
            // 
            this.txtvalue2.Location = new System.Drawing.Point(84, 221);
            this.txtvalue2.Name = "txtvalue2";
            this.txtvalue2.Size = new System.Drawing.Size(228, 27);
            this.txtvalue2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "شکل خود را انتخاب کنید";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "  طول مستطیل یا شعاع دایره را وارد کنید";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "عرض مستطیل را وارد کنید";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalue2);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtvalue1);
            this.Controls.Add(this.cmbshapeType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbshapeType;
        private System.Windows.Forms.TextBox txtvalue1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.TextBox txtvalue2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

