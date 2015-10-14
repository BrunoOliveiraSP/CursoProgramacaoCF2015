namespace Estudo.Variaveis.String
{
    partial class frmStrings
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
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnPadRight = new System.Windows.Forms.Button();
            this.btnPadLeft = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnTrimStart = new System.Windows.Forms.Button();
            this.btnTrimEnd = new System.Windows.Forms.Button();
            this.btnIsNullOrEmpty = new System.Windows.Forms.Button();
            this.btnConcat = new System.Windows.Forms.Button();
            this.btnDtToStr = new System.Windows.Forms.Button();
            this.btnBoolToStr = new System.Windows.Forms.Button();
            this.btnDecToStr = new System.Windows.Forms.Button();
            this.btnIntToString = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(22, 157);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(94, 23);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(22, 203);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(94, 23);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(282, 157);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(75, 23);
            this.btnToUpper.TabIndex = 2;
            this.btnToUpper.Text = "ToUpper";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(282, 205);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(75, 23);
            this.btnToLower.TabIndex = 3;
            this.btnToLower.Text = "ToLower";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(282, 259);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(75, 23);
            this.btnTrim.TabIndex = 4;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(402, 157);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(75, 23);
            this.btnLength.TabIndex = 9;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(160, 259);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(75, 23);
            this.btnContains.TabIndex = 8;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(160, 205);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(75, 23);
            this.btnEndsWith.TabIndex = 7;
            this.btnEndsWith.Text = "EndsWith";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(160, 361);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(160, 313);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(75, 23);
            this.btnSubstring.TabIndex = 5;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(402, 313);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(75, 23);
            this.btnFormat.TabIndex = 11;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnPadRight
            // 
            this.btnPadRight.Location = new System.Drawing.Point(402, 211);
            this.btnPadRight.Name = "btnPadRight";
            this.btnPadRight.Size = new System.Drawing.Size(75, 23);
            this.btnPadRight.TabIndex = 10;
            this.btnPadRight.Text = "PadRight";
            this.btnPadRight.UseVisualStyleBackColor = true;
            this.btnPadRight.Click += new System.EventHandler(this.btnPadRight_Click);
            // 
            // btnPadLeft
            // 
            this.btnPadLeft.Location = new System.Drawing.Point(402, 265);
            this.btnPadLeft.Name = "btnPadLeft";
            this.btnPadLeft.Size = new System.Drawing.Size(75, 23);
            this.btnPadLeft.TabIndex = 16;
            this.btnPadLeft.Text = "PadLeft";
            this.btnPadLeft.UseVisualStyleBackColor = true;
            this.btnPadLeft.Click += new System.EventHandler(this.btnPadLeft_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(160, 157);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(75, 23);
            this.btnStartsWith.TabIndex = 15;
            this.btnStartsWith.Text = "StartsWith";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnTrimStart
            // 
            this.btnTrimStart.Location = new System.Drawing.Point(282, 313);
            this.btnTrimStart.Name = "btnTrimStart";
            this.btnTrimStart.Size = new System.Drawing.Size(75, 23);
            this.btnTrimStart.TabIndex = 12;
            this.btnTrimStart.Text = "TrimStart";
            this.btnTrimStart.UseVisualStyleBackColor = true;
            this.btnTrimStart.Click += new System.EventHandler(this.btnTrimStart_Click);
            // 
            // btnTrimEnd
            // 
            this.btnTrimEnd.Location = new System.Drawing.Point(282, 361);
            this.btnTrimEnd.Name = "btnTrimEnd";
            this.btnTrimEnd.Size = new System.Drawing.Size(75, 23);
            this.btnTrimEnd.TabIndex = 13;
            this.btnTrimEnd.Text = "TrimEnd";
            this.btnTrimEnd.UseVisualStyleBackColor = true;
            this.btnTrimEnd.Click += new System.EventHandler(this.btnTrimEnd_Click);
            // 
            // btnIsNullOrEmpty
            // 
            this.btnIsNullOrEmpty.Location = new System.Drawing.Point(22, 259);
            this.btnIsNullOrEmpty.Name = "btnIsNullOrEmpty";
            this.btnIsNullOrEmpty.Size = new System.Drawing.Size(94, 23);
            this.btnIsNullOrEmpty.TabIndex = 14;
            this.btnIsNullOrEmpty.Text = "IsNullOrEmpty";
            this.btnIsNullOrEmpty.UseVisualStyleBackColor = true;
            this.btnIsNullOrEmpty.Click += new System.EventHandler(this.btnIsNullOrEmpty_Click);
            // 
            // btnConcat
            // 
            this.btnConcat.Location = new System.Drawing.Point(22, 313);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(94, 23);
            this.btnConcat.TabIndex = 17;
            this.btnConcat.Text = "Concat";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // btnDtToStr
            // 
            this.btnDtToStr.Location = new System.Drawing.Point(523, 265);
            this.btnDtToStr.Name = "btnDtToStr";
            this.btnDtToStr.Size = new System.Drawing.Size(124, 23);
            this.btnDtToStr.TabIndex = 21;
            this.btnDtToStr.Text = "DateTime - ToString()";
            this.btnDtToStr.UseVisualStyleBackColor = true;
            this.btnDtToStr.Click += new System.EventHandler(this.btnDtToStr_Click);
            // 
            // btnBoolToStr
            // 
            this.btnBoolToStr.Location = new System.Drawing.Point(523, 313);
            this.btnBoolToStr.Name = "btnBoolToStr";
            this.btnBoolToStr.Size = new System.Drawing.Size(124, 23);
            this.btnBoolToStr.TabIndex = 20;
            this.btnBoolToStr.Text = "bool - ToString()";
            this.btnBoolToStr.UseVisualStyleBackColor = true;
            this.btnBoolToStr.Click += new System.EventHandler(this.btnBoolToStr_Click);
            // 
            // btnDecToStr
            // 
            this.btnDecToStr.Location = new System.Drawing.Point(523, 211);
            this.btnDecToStr.Name = "btnDecToStr";
            this.btnDecToStr.Size = new System.Drawing.Size(124, 23);
            this.btnDecToStr.TabIndex = 19;
            this.btnDecToStr.Text = "decimal - ToString()";
            this.btnDecToStr.UseVisualStyleBackColor = true;
            this.btnDecToStr.Click += new System.EventHandler(this.btnDecToStr_Click);
            // 
            // btnIntToString
            // 
            this.btnIntToString.Location = new System.Drawing.Point(523, 157);
            this.btnIntToString.Name = "btnIntToString";
            this.btnIntToString.Size = new System.Drawing.Size(124, 23);
            this.btnIntToString.TabIndex = 18;
            this.btnIntToString.Text = "int - ToString()";
            this.btnIntToString.UseVisualStyleBackColor = true;
            this.btnIntToString.Click += new System.EventHandler(this.btnIntToString_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(22, 22);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(625, 54);
            this.txtTexto.TabIndex = 22;
            this.txtTexto.Text = "Digite aqui algum texto ^^ #Curti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(110, 89);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(14, 20);
            this.lblResultado.TabIndex = 24;
            this.lblResultado.Text = "-";
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(22, 361);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(94, 23);
            this.btnIndexOf.TabIndex = 25;
            this.btnIndexOf.Text = "IndexOf";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // frmStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 399);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnDtToStr);
            this.Controls.Add(this.btnBoolToStr);
            this.Controls.Add(this.btnDecToStr);
            this.Controls.Add(this.btnIntToString);
            this.Controls.Add(this.btnConcat);
            this.Controls.Add(this.btnPadLeft);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnIsNullOrEmpty);
            this.Controls.Add(this.btnTrimEnd);
            this.Controls.Add(this.btnTrimStart);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnPadRight);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnToLower);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnReplace);
            this.Name = "frmStrings";
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnPadRight;
        private System.Windows.Forms.Button btnPadLeft;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnTrimStart;
        private System.Windows.Forms.Button btnTrimEnd;
        private System.Windows.Forms.Button btnIsNullOrEmpty;
        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.Button btnDtToStr;
        private System.Windows.Forms.Button btnBoolToStr;
        private System.Windows.Forms.Button btnDecToStr;
        private System.Windows.Forms.Button btnIntToString;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnIndexOf;
    }
}

