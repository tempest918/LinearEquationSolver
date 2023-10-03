
namespace FinalPart2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CoeffA1TextBox = new System.Windows.Forms.TextBox();
            this.equationLabel1 = new System.Windows.Forms.Label();
            this.xLabel1 = new System.Windows.Forms.Label();
            this.CoeffB1TextBox = new System.Windows.Forms.TextBox();
            this.yLabel1 = new System.Windows.Forms.Label();
            this.CoeffC1TextBox = new System.Windows.Forms.TextBox();
            this.CoeffC2TextBox = new System.Windows.Forms.TextBox();
            this.yLabel2 = new System.Windows.Forms.Label();
            this.CoeffB2TextBox = new System.Windows.Forms.TextBox();
            this.xLabel2 = new System.Windows.Forms.Label();
            this.equationLabel2 = new System.Windows.Forms.Label();
            this.CoeffA2TextBox = new System.Windows.Forms.TextBox();
            this.import = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoeffA1TextBox
            // 
            this.CoeffA1TextBox.Location = new System.Drawing.Point(93, 54);
            this.CoeffA1TextBox.Name = "CoeffA1TextBox";
            this.CoeffA1TextBox.Size = new System.Drawing.Size(30, 20);
            this.CoeffA1TextBox.TabIndex = 0;
            // 
            // equationLabel1
            // 
            this.equationLabel1.AutoSize = true;
            this.equationLabel1.Location = new System.Drawing.Point(29, 58);
            this.equationLabel1.Name = "equationLabel1";
            this.equationLabel1.Size = new System.Drawing.Size(58, 13);
            this.equationLabel1.TabIndex = 1;
            this.equationLabel1.Text = "Equation 1";
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.Location = new System.Drawing.Point(124, 58);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(24, 13);
            this.xLabel1.TabIndex = 2;
            this.xLabel1.Text = "x + ";
            // 
            // CoeffB1TextBox
            // 
            this.CoeffB1TextBox.Location = new System.Drawing.Point(145, 54);
            this.CoeffB1TextBox.Name = "CoeffB1TextBox";
            this.CoeffB1TextBox.Size = new System.Drawing.Size(30, 20);
            this.CoeffB1TextBox.TabIndex = 3;
            // 
            // yLabel1
            // 
            this.yLabel1.AutoSize = true;
            this.yLabel1.Location = new System.Drawing.Point(178, 58);
            this.yLabel1.Name = "yLabel1";
            this.yLabel1.Size = new System.Drawing.Size(24, 13);
            this.yLabel1.TabIndex = 4;
            this.yLabel1.Text = "y = ";
            // 
            // CoeffC1TextBox
            // 
            this.CoeffC1TextBox.Location = new System.Drawing.Point(202, 54);
            this.CoeffC1TextBox.Name = "CoeffC1TextBox";
            this.CoeffC1TextBox.Size = new System.Drawing.Size(30, 20);
            this.CoeffC1TextBox.TabIndex = 5;
            // 
            // CoeffC2TextBox
            // 
            this.CoeffC2TextBox.Location = new System.Drawing.Point(430, 54);
            this.CoeffC2TextBox.Name = "CoeffC2TextBox";
            this.CoeffC2TextBox.Size = new System.Drawing.Size(30, 20);
            this.CoeffC2TextBox.TabIndex = 11;
            // 
            // yLabel2
            // 
            this.yLabel2.AutoSize = true;
            this.yLabel2.Location = new System.Drawing.Point(406, 58);
            this.yLabel2.Name = "yLabel2";
            this.yLabel2.Size = new System.Drawing.Size(24, 13);
            this.yLabel2.TabIndex = 10;
            this.yLabel2.Text = "y = ";
            // 
            // CoeffB2TextBox
            // 
            this.CoeffB2TextBox.Location = new System.Drawing.Point(373, 54);
            this.CoeffB2TextBox.Name = "CoeffB2TextBox";
            this.CoeffB2TextBox.Size = new System.Drawing.Size(30, 20);
            this.CoeffB2TextBox.TabIndex = 9;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.Location = new System.Drawing.Point(352, 58);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(24, 13);
            this.xLabel2.TabIndex = 8;
            this.xLabel2.Text = "x + ";
            // 
            // equationLabel2
            // 
            this.equationLabel2.AutoSize = true;
            this.equationLabel2.Location = new System.Drawing.Point(257, 58);
            this.equationLabel2.Name = "equationLabel2";
            this.equationLabel2.Size = new System.Drawing.Size(58, 13);
            this.equationLabel2.TabIndex = 7;
            this.equationLabel2.Text = "Equation 2";
            // 
            // CoeffA2TextBox
            // 
            this.CoeffA2TextBox.Location = new System.Drawing.Point(321, 54);
            this.CoeffA2TextBox.Name = "CoeffA2TextBox";
            this.CoeffA2TextBox.Size = new System.Drawing.Size(30, 20);
            this.CoeffA2TextBox.TabIndex = 6;
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(16, 268);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 23);
            this.import.TabIndex = 12;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.Import_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(136, 268);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(240, 23);
            this.solve.TabIndex = 13;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Input";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(29, 134);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(223, 13);
            this.ResultLabel.TabIndex = 20;
            this.ResultLabel.Text = "Please enter your coefficients or import a file...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Output";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(409, 268);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 21;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 313);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.import);
            this.Controls.Add(this.CoeffC2TextBox);
            this.Controls.Add(this.yLabel2);
            this.Controls.Add(this.CoeffB2TextBox);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.equationLabel2);
            this.Controls.Add(this.CoeffA2TextBox);
            this.Controls.Add(this.CoeffC1TextBox);
            this.Controls.Add(this.yLabel1);
            this.Controls.Add(this.CoeffB1TextBox);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.equationLabel1);
            this.Controls.Add(this.CoeffA1TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Linear Equation Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CoeffA1TextBox;
        private System.Windows.Forms.Label equationLabel1;
        private System.Windows.Forms.Label xLabel1;
        private System.Windows.Forms.TextBox CoeffB1TextBox;
        private System.Windows.Forms.Label yLabel1;
        private System.Windows.Forms.TextBox CoeffC1TextBox;
        private System.Windows.Forms.TextBox CoeffC2TextBox;
        private System.Windows.Forms.Label yLabel2;
        private System.Windows.Forms.TextBox CoeffB2TextBox;
        private System.Windows.Forms.Label xLabel2;
        private System.Windows.Forms.Label equationLabel2;
        private System.Windows.Forms.TextBox CoeffA2TextBox;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear;
    }
}

