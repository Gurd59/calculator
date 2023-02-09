namespace Kalkulkulačka
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnlomeno = new System.Windows.Forms.Button();
            this.btnhvezda = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpluss = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btncarka = new System.Windows.Forms.Button();
            this.btnminuss = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn7.Location = new System.Drawing.Point(16, 109);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnklik);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn8.Location = new System.Drawing.Point(72, 109);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnklik);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn9.Location = new System.Drawing.Point(128, 109);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnklik);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnC.Location = new System.Drawing.Point(240, 109);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnlomeno
            // 
            this.btnlomeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnlomeno.Location = new System.Drawing.Point(184, 109);
            this.btnlomeno.Name = "btnlomeno";
            this.btnlomeno.Size = new System.Drawing.Size(50, 50);
            this.btnlomeno.TabIndex = 4;
            this.btnlomeno.Text = "/";
            this.btnlomeno.UseVisualStyleBackColor = true;
            this.btnlomeno.Click += new System.EventHandler(this.btndeleno);
            // 
            // btnhvezda
            // 
            this.btnhvezda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnhvezda.Location = new System.Drawing.Point(184, 165);
            this.btnhvezda.Name = "btnhvezda";
            this.btnhvezda.Size = new System.Drawing.Size(50, 50);
            this.btnhvezda.TabIndex = 9;
            this.btnhvezda.Text = "*";
            this.btnhvezda.UseVisualStyleBackColor = true;
            this.btnhvezda.Click += new System.EventHandler(this.btnkrat);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnCE.Location = new System.Drawing.Point(240, 165);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(50, 50);
            this.btnCE.TabIndex = 8;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnresetuj);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn6.Location = new System.Drawing.Point(128, 165);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnklik);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn5.Location = new System.Drawing.Point(72, 165);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnklik);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn4.Location = new System.Drawing.Point(16, 165);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnklik);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn0.Location = new System.Drawing.Point(16, 277);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(106, 50);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnklik);
            // 
            // btnplus
            // 
            this.btnpluss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnpluss.Location = new System.Drawing.Point(184, 221);
            this.btnpluss.Name = "btnplus";
            this.btnpluss.Size = new System.Drawing.Size(50, 50);
            this.btnpluss.TabIndex = 13;
            this.btnpluss.Text = "+";
            this.btnpluss.UseVisualStyleBackColor = true;
            this.btnpluss.Click += new System.EventHandler(this.btnplus);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn3.Location = new System.Drawing.Point(128, 221);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnklik);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn2.Location = new System.Drawing.Point(72, 221);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnklik);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn1.Location = new System.Drawing.Point(16, 221);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnklik);
            // 
            // btncarka
            // 
            this.btncarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btncarka.Location = new System.Drawing.Point(128, 277);
            this.btncarka.Name = "btncarka";
            this.btncarka.Size = new System.Drawing.Size(50, 50);
            this.btncarka.TabIndex = 19;
            this.btncarka.Text = ",";
            this.btncarka.UseVisualStyleBackColor = true;
            this.btncarka.Click += new System.EventHandler(this.btnklik);
            // 
            // btnminus
            // 
            this.btnminuss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnminuss.Location = new System.Drawing.Point(184, 277);
            this.btnminuss.Name = "btnminus";
            this.btnminuss.Size = new System.Drawing.Size(50, 50);
            this.btnminuss.TabIndex = 18;
            this.btnminuss.Text = "-";
            this.btnminuss.UseVisualStyleBackColor = true;
            this.btnminuss.Click += new System.EventHandler(this.btnminus);
            // 
            // btnequal
            // 
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnequal.Location = new System.Drawing.Point(240, 221);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(50, 106);
            this.btnequal.TabIndex = 15;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnrovnasa);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtOutput.Location = new System.Drawing.Point(16, 21);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(274, 31);
            this.txtOutput.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btncarka);
            this.Controls.Add(this.btnminuss);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnpluss);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnhvezda);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnlomeno);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnlomeno;
        private System.Windows.Forms.Button btnhvezda;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnpluss;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btncarka;
        private System.Windows.Forms.Button btnminuss;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
    }
}

