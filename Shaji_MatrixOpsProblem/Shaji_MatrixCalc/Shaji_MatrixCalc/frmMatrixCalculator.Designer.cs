namespace Shaji_MatrixCalc
{
    partial class frmMatrixCalculator
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
            this.txtMatrixA = new System.Windows.Forms.TextBox();
            this.txtMatrixB = new System.Windows.Forms.TextBox();
            this.txtMatrixC = new System.Windows.Forms.TextBox();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.lblMatrixC = new System.Windows.Forms.Label();
            this.btnMakeA = new System.Windows.Forms.Button();
            this.btnMakeB = new System.Windows.Forms.Button();
            this.txtRowsA = new System.Windows.Forms.TextBox();
            this.txtRowsB = new System.Windows.Forms.TextBox();
            this.txtColsA = new System.Windows.Forms.TextBox();
            this.txtColsB = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.btnBIdentity = new System.Windows.Forms.Button();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.rdbtnSub = new System.Windows.Forms.RadioButton();
            this.rdbtnAdd = new System.Windows.Forms.RadioButton();
            this.rdbtnMultiply = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(8, 37);
            this.txtMatrixA.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatrixA.Multiline = true;
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.ReadOnly = true;
            this.txtMatrixA.Size = new System.Drawing.Size(127, 80);
            this.txtMatrixA.TabIndex = 4;
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(152, 37);
            this.txtMatrixB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatrixB.Multiline = true;
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.ReadOnly = true;
            this.txtMatrixB.Size = new System.Drawing.Size(127, 80);
            this.txtMatrixB.TabIndex = 5;
            // 
            // txtMatrixC
            // 
            this.txtMatrixC.Location = new System.Drawing.Point(288, 37);
            this.txtMatrixC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatrixC.Multiline = true;
            this.txtMatrixC.Name = "txtMatrixC";
            this.txtMatrixC.ReadOnly = true;
            this.txtMatrixC.Size = new System.Drawing.Size(127, 80);
            this.txtMatrixC.TabIndex = 6;
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(6, 17);
            this.lblMatrixA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(48, 13);
            this.lblMatrixA.TabIndex = 3;
            this.lblMatrixA.Text = "Matrix A:";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(150, 17);
            this.lblMatrixB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(48, 13);
            this.lblMatrixB.TabIndex = 4;
            this.lblMatrixB.Text = "Matrix B:";
            // 
            // lblMatrixC
            // 
            this.lblMatrixC.AutoSize = true;
            this.lblMatrixC.Location = new System.Drawing.Point(286, 11);
            this.lblMatrixC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatrixC.Name = "lblMatrixC";
            this.lblMatrixC.Size = new System.Drawing.Size(48, 13);
            this.lblMatrixC.TabIndex = 5;
            this.lblMatrixC.Text = "Matrix C:";
            // 
            // btnMakeA
            // 
            this.btnMakeA.Location = new System.Drawing.Point(6, 146);
            this.btnMakeA.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeA.Name = "btnMakeA";
            this.btnMakeA.Size = new System.Drawing.Size(96, 22);
            this.btnMakeA.TabIndex = 6;
            this.btnMakeA.Text = "Make Matrix A ";
            this.btnMakeA.UseVisualStyleBackColor = true;
            this.btnMakeA.Click += new System.EventHandler(this.btnMakeA_Click);
            // 
            // btnMakeB
            // 
            this.btnMakeB.Location = new System.Drawing.Point(6, 182);
            this.btnMakeB.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeB.Name = "btnMakeB";
            this.btnMakeB.Size = new System.Drawing.Size(96, 23);
            this.btnMakeB.TabIndex = 7;
            this.btnMakeB.Text = "Make Matrix B";
            this.btnMakeB.UseVisualStyleBackColor = true;
            this.btnMakeB.Click += new System.EventHandler(this.btnMakeB_Click);
            // 
            // txtRowsA
            // 
            this.txtRowsA.Location = new System.Drawing.Point(138, 145);
            this.txtRowsA.Margin = new System.Windows.Forms.Padding(2);
            this.txtRowsA.Name = "txtRowsA";
            this.txtRowsA.Size = new System.Drawing.Size(77, 20);
            this.txtRowsA.TabIndex = 0;
            this.txtRowsA.Text = "3";
            this.txtRowsA.TextChanged += new System.EventHandler(this.txtRowsA_TextChanged);
            // 
            // txtRowsB
            // 
            this.txtRowsB.Location = new System.Drawing.Point(138, 182);
            this.txtRowsB.Margin = new System.Windows.Forms.Padding(2);
            this.txtRowsB.Name = "txtRowsB";
            this.txtRowsB.Size = new System.Drawing.Size(77, 20);
            this.txtRowsB.TabIndex = 2;
            this.txtRowsB.Text = "3";
            this.txtRowsB.TextChanged += new System.EventHandler(this.txtRowsB_TextChanged);
            // 
            // txtColsA
            // 
            this.txtColsA.Location = new System.Drawing.Point(241, 145);
            this.txtColsA.Margin = new System.Windows.Forms.Padding(2);
            this.txtColsA.Name = "txtColsA";
            this.txtColsA.Size = new System.Drawing.Size(77, 20);
            this.txtColsA.TabIndex = 1;
            this.txtColsA.Text = "3";
            this.txtColsA.TextChanged += new System.EventHandler(this.txtColsA_TextChanged);
            // 
            // txtColsB
            // 
            this.txtColsB.Location = new System.Drawing.Point(241, 182);
            this.txtColsB.Margin = new System.Windows.Forms.Padding(2);
            this.txtColsB.Name = "txtColsB";
            this.txtColsB.Size = new System.Drawing.Size(77, 20);
            this.txtColsB.TabIndex = 3;
            this.txtColsB.Text = "3";
            this.txtColsB.TextChanged += new System.EventHandler(this.txtColsB_TextChanged);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(138, 129);
            this.lblRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(34, 13);
            this.lblRows.TabIndex = 12;
            this.lblRows.Text = "Rows";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(238, 129);
            this.lblCols.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(47, 13);
            this.lblCols.TabIndex = 13;
            this.lblCols.Text = "Columns";
            // 
            // btnBIdentity
            // 
            this.btnBIdentity.Location = new System.Drawing.Point(328, 178);
            this.btnBIdentity.Margin = new System.Windows.Forms.Padding(2);
            this.btnBIdentity.Name = "btnBIdentity";
            this.btnBIdentity.Size = new System.Drawing.Size(94, 23);
            this.btnBIdentity.TabIndex = 14;
            this.btnBIdentity.Text = "Make B Identity";
            this.btnBIdentity.UseVisualStyleBackColor = true;
            this.btnBIdentity.Click += new System.EventHandler(this.btnBIdentity_Click);
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.rdbtnSub);
            this.grpOperations.Controls.Add(this.rdbtnAdd);
            this.grpOperations.Controls.Add(this.rdbtnMultiply);
            this.grpOperations.Location = new System.Drawing.Point(6, 213);
            this.grpOperations.Margin = new System.Windows.Forms.Padding(2);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Padding = new System.Windows.Forms.Padding(2);
            this.grpOperations.Size = new System.Drawing.Size(258, 49);
            this.grpOperations.TabIndex = 15;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Select Operation:";
            // 
            // rdbtnSub
            // 
            this.rdbtnSub.AutoSize = true;
            this.rdbtnSub.Location = new System.Drawing.Point(174, 21);
            this.rdbtnSub.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnSub.Name = "rdbtnSub";
            this.rdbtnSub.Size = new System.Drawing.Size(79, 17);
            this.rdbtnSub.TabIndex = 2;
            this.rdbtnSub.Text = "Subtraction";
            this.rdbtnSub.UseVisualStyleBackColor = true;
            // 
            // rdbtnAdd
            // 
            this.rdbtnAdd.AutoSize = true;
            this.rdbtnAdd.Location = new System.Drawing.Point(101, 21);
            this.rdbtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnAdd.Name = "rdbtnAdd";
            this.rdbtnAdd.Size = new System.Drawing.Size(63, 17);
            this.rdbtnAdd.TabIndex = 1;
            this.rdbtnAdd.Text = "Addition";
            this.rdbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rdbtnMultiply
            // 
            this.rdbtnMultiply.AutoSize = true;
            this.rdbtnMultiply.Checked = true;
            this.rdbtnMultiply.Location = new System.Drawing.Point(8, 21);
            this.rdbtnMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnMultiply.Name = "rdbtnMultiply";
            this.rdbtnMultiply.Size = new System.Drawing.Size(86, 17);
            this.rdbtnMultiply.TabIndex = 0;
            this.rdbtnMultiply.TabStop = true;
            this.rdbtnMultiply.Text = "Multiplication";
            this.rdbtnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 270);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(55, 24);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(266, 270);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 24);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear Matrices";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(366, 270);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 24);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMatrixCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(434, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.btnBIdentity);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.txtColsB);
            this.Controls.Add(this.txtColsA);
            this.Controls.Add(this.txtRowsB);
            this.Controls.Add(this.txtRowsA);
            this.Controls.Add(this.btnMakeB);
            this.Controls.Add(this.btnMakeA);
            this.Controls.Add(this.lblMatrixC);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.lblMatrixA);
            this.Controls.Add(this.txtMatrixC);
            this.Controls.Add(this.txtMatrixB);
            this.Controls.Add(this.txtMatrixA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMatrixCalculator";
            this.Text = "Matrix Calculator";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.TextBox txtMatrixC;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Label lblMatrixC;
        private System.Windows.Forms.Button btnMakeA;
        private System.Windows.Forms.Button btnMakeB;
        private System.Windows.Forms.TextBox txtRowsA;
        private System.Windows.Forms.TextBox txtRowsB;
        private System.Windows.Forms.TextBox txtColsA;
        private System.Windows.Forms.TextBox txtColsB;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.Button btnBIdentity;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rdbtnSub;
        private System.Windows.Forms.RadioButton rdbtnAdd;
        private System.Windows.Forms.RadioButton rdbtnMultiply;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

