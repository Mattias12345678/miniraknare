namespace miniräknare_upg
{
    partial class FormMiniräknare
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplikation = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnLikamed = new System.Windows.Forms.Button();
            this.btnKomma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRadera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txtResult.Location = new System.Drawing.Point(13, 13);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(725, 65);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn7.Location = new System.Drawing.Point(12, 177);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(87, 88);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn8.Location = new System.Drawing.Point(105, 177);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(87, 88);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn9.Location = new System.Drawing.Point(198, 176);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(87, 88);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDivision.Location = new System.Drawing.Point(291, 177);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(87, 88);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.NumberOper);
            // 
            // btnMultiplikation
            // 
            this.btnMultiplikation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMultiplikation.Location = new System.Drawing.Point(291, 270);
            this.btnMultiplikation.Name = "btnMultiplikation";
            this.btnMultiplikation.Size = new System.Drawing.Size(87, 88);
            this.btnMultiplikation.TabIndex = 8;
            this.btnMultiplikation.Text = "*";
            this.btnMultiplikation.UseVisualStyleBackColor = true;
            this.btnMultiplikation.Click += new System.EventHandler(this.NumberOper);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn6.Location = new System.Drawing.Point(198, 270);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(87, 88);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn5.Location = new System.Drawing.Point(105, 271);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(87, 88);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn4.Location = new System.Drawing.Point(12, 271);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(87, 88);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSubtraktion.Location = new System.Drawing.Point(291, 364);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(87, 88);
            this.btnSubtraktion.TabIndex = 12;
            this.btnSubtraktion.Text = "-";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.NumberOper);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn3.Location = new System.Drawing.Point(198, 364);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(87, 88);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn2.Location = new System.Drawing.Point(105, 365);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(87, 88);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn1.Location = new System.Drawing.Point(12, 365);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(87, 88);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAddition.Location = new System.Drawing.Point(291, 458);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(87, 88);
            this.btnAddition.TabIndex = 16;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.NumberOper);
            // 
            // btnLikamed
            // 
            this.btnLikamed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnLikamed.Location = new System.Drawing.Point(198, 459);
            this.btnLikamed.Name = "btnLikamed";
            this.btnLikamed.Size = new System.Drawing.Size(87, 88);
            this.btnLikamed.TabIndex = 15;
            this.btnLikamed.Text = "=";
            this.btnLikamed.UseVisualStyleBackColor = true;
            this.btnLikamed.Click += new System.EventHandler(this.btnLikamed_Click);
            // 
            // btnKomma
            // 
            this.btnKomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnKomma.Location = new System.Drawing.Point(105, 459);
            this.btnKomma.Name = "btnKomma";
            this.btnKomma.Size = new System.Drawing.Size(87, 88);
            this.btnKomma.TabIndex = 14;
            this.btnKomma.Text = ",";
            this.btnKomma.UseVisualStyleBackColor = true;
            this.btnKomma.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn0.Location = new System.Drawing.Point(12, 459);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(87, 88);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.EnterNumber);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnClear.Location = new System.Drawing.Point(291, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 88);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRadera
            // 
            this.btnRadera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRadera.Location = new System.Drawing.Point(198, 83);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(87, 88);
            this.btnRadera.TabIndex = 19;
            this.btnRadera.Text = "CE";
            this.btnRadera.UseVisualStyleBackColor = true;
            this.btnRadera.Click += new System.EventHandler(this.btnRadera_Click);
            // 
            // FormMiniräknare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 626);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRadera);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnLikamed);
            this.Controls.Add(this.btnKomma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMultiplikation);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResult);
            this.Name = "FormMiniräknare";
            this.Text = "Miniräknäre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplikation;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnLikamed;
        private System.Windows.Forms.Button btnKomma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRadera;
    }
}

