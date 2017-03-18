namespace UnitVector
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
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpVector = new System.Windows.Forms.TabPage();
            this.tpCircle = new System.Windows.Forms.TabPage();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnitVecMag = new System.Windows.Forms.Label();
            this.lblMag = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbCirc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpVector.SuspendLayout();
            this.tpCircle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGraph
            // 
            this.pbGraph.Location = new System.Drawing.Point(12, 117);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(500, 500);
            this.pbGraph.TabIndex = 2;
            this.pbGraph.TabStop = false;
            this.pbGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpVector);
            this.tabControl1.Controls.Add(this.tpCircle);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 100);
            this.tabControl1.TabIndex = 3;
            // 
            // tpVector
            // 
            this.tpVector.Controls.Add(this.lbl1);
            this.tpVector.Controls.Add(this.lblAngle);
            this.tpVector.Controls.Add(this.label2);
            this.tpVector.Controls.Add(this.label1);
            this.tpVector.Controls.Add(this.lblUnitVecMag);
            this.tpVector.Controls.Add(this.lblMag);
            this.tpVector.Controls.Add(this.tbB);
            this.tpVector.Controls.Add(this.tbA);
            this.tpVector.Location = new System.Drawing.Point(4, 22);
            this.tpVector.Name = "tpVector";
            this.tpVector.Padding = new System.Windows.Forms.Padding(3);
            this.tpVector.Size = new System.Drawing.Size(491, 74);
            this.tpVector.TabIndex = 0;
            this.tpVector.Text = "Vector";
            this.tpVector.UseVisualStyleBackColor = true;
            // 
            // tpCircle
            // 
            this.tpCircle.Controls.Add(this.tbCirc);
            this.tpCircle.Location = new System.Drawing.Point(4, 22);
            this.tpCircle.Name = "tpCircle";
            this.tpCircle.Padding = new System.Windows.Forms.Padding(3);
            this.tpCircle.Size = new System.Drawing.Size(491, 74);
            this.tpCircle.TabIndex = 1;
            this.tpCircle.Text = "Circle";
            this.tpCircle.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(112, 35);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(34, 13);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Angle";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(236, 35);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(27, 13);
            this.lblAngle.TabIndex = 16;
            this.lblAngle.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Unit Vector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Magnitude ";
            // 
            // lblUnitVecMag
            // 
            this.lblUnitVecMag.AutoSize = true;
            this.lblUnitVecMag.Location = new System.Drawing.Point(236, 22);
            this.lblUnitVecMag.Name = "lblUnitVecMag";
            this.lblUnitVecMag.Size = new System.Drawing.Size(27, 13);
            this.lblUnitVecMag.TabIndex = 13;
            this.lblUnitVecMag.Text = "N/A";
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(236, 9);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(27, 13);
            this.lblMag.TabIndex = 12;
            this.lblMag.Text = "N/A";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(5, 32);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 11;
            this.tbB.TextChanged += new System.EventHandler(this.refreshVector);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(6, 6);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 10;
            this.tbA.TextChanged += new System.EventHandler(this.refreshVector);
            // 
            // tbCirc
            // 
            this.tbCirc.Location = new System.Drawing.Point(7, 7);
            this.tbCirc.Name = "tbCirc";
            this.tbCirc.Size = new System.Drawing.Size(100, 20);
            this.tbCirc.TabIndex = 0;
            this.tbCirc.TextChanged += new System.EventHandler(this.MakeCircle);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 629);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pbGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpVector.ResumeLayout(false);
            this.tpVector.PerformLayout();
            this.tpCircle.ResumeLayout(false);
            this.tpCircle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpVector;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnitVecMag;
        private System.Windows.Forms.Label lblMag;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TabPage tpCircle;
        private System.Windows.Forms.TextBox tbCirc;
    }
}

