using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaji_MatrixCalc
{
    public partial class frmMatrixCalculator : Form
    {

        public frmMatrixCalculator()
        {
            InitializeComponent();

        }
        int rowsA;
        int colsA;
        int rowsB;
        int colsB;
        double[,] matrixA;
        string printMA;
        string printMB;
        string printMC;
        double[,] matrixB;
        double[,] matrixC;


        private void btnMakeA_Click(object sender, EventArgs e)
        {

            if (IsValidDataA())
            {
                try
                {
                    printMA = "";
                    rowsA = Convert.ToInt32(txtRowsA.Text);
                    colsA = Convert.ToInt32(txtColsA.Text);
                    matrixA = new double[rowsA, colsA];
                    createMatrix(rowsA, colsA, matrixA);
                    txtMatrixA.Text = printMatrix(rowsA, colsA, printMA, matrixA);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnMakeB_Click(object sender, EventArgs e)
        {
            if (IsValidDataB())
            {
                try
                {


                    printMB = "";
                    rowsB = Convert.ToInt32(txtRowsB.Text);
                    colsB = Convert.ToInt32(txtColsB.Text);
                    matrixB = new double[rowsB, colsB];
                    createMatrix(rowsB, colsB, matrixB);
                    txtMatrixB.Text = printMatrix(rowsB, colsB, printMB, matrixB);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnBIdentity_Click(object sender, EventArgs e)
        {
            if (IsValidDataB())
            {
                try
                {
                    printMB = "";
                    rowsB = Convert.ToInt32(txtRowsB.Text);
                    colsB = Convert.ToInt32(txtColsB.Text);
                    matrixB = new double[rowsB, colsB];
                    identityMatrix(rowsB, colsB, matrixB);
                    txtMatrixB.Text = printMatrix(rowsB, colsB, printMB, matrixB);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public double[,] identityMatrix(int rows, int cols, double[,] matrix)
        {
            if (identity(rows, cols))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i == j)
                        {
                            matrix[i, j] = 1.0;
                        }
                        else
                        {
                            matrix[i, j] = 0.0;
                        }
                    }
                }
            }
            return matrix;
        }


        public bool multiplicationCheck(int rowA, int colB)
        {
            if (rowA != colB)
            {
                MessageBox.Show("Cannot perform multiplication. Please check dimensions and try again.");
                return false;
            }
            return true;
        }


        public bool identity(int rows, int cols)
        {
            if (rows != cols)
            {
                MessageBox.Show("Row and column values do not match. Please try again.");
                return false;
            }
            return true;
        }

        public double[,] createMatrix(int rows, int cols, double[,] matrix)
        {
            Random createNum = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = createNum.NextDouble() * 10.0;

                }
            }
            return matrix;
        }

        public bool IsValidDataB()
        {
            return

                IsPresent(txtRowsB, "Row length for B ") &&
                IsInt(txtRowsB, "Row length for B ") &&
                IsPresent(txtColsB, "Column length for B ") &&
                IsInt(txtColsB, "Comlumn length for B ");
        }
        public bool IsValidDataA()
        {
            return

                IsPresent(txtRowsA, "Row length for A ") &&
                IsInt(txtRowsA, "Row length for A ") &&
                IsPresent(txtColsA, "Column length for A ") &&
                IsInt(txtColsA, "Comlumn length for A ");

        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsInt(TextBox textBox, string name)
        {
            Int32 number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a valid integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool addCheck(int rowA, int rowB, int colA, int colB)
        {

            if (rowA != rowB || colsA != colB)
            {
                MessageBox.Show("Cannot perform addition. Please check dimentsions and try again.");
                return false;
            }

            return true;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rdbtnAdd.Checked == true)
            {
                if (addCheck(rowsA, rowsB, colsA, colsB))
                {
                    printMC = "";
                    matrixC = new double[rowsA, rowsB];
                    addMatrix(rowsA, rowsB, colsA, colsB, matrixA, matrixB, matrixC);
                    txtMatrixC.Text = printMatrix(rowsA, colsA, printMC, matrixC);
                }
            }

            if (rdbtnSub.Checked == true)
            {
                if (addCheck(rowsA, rowsB, colsA, colsB))
                {
                    printMC = "";
                    matrixC = new double[rowsA, rowsB];
                    subMatrix(rowsA, rowsB, colsA, colsB, matrixA, matrixB, matrixC);
                    txtMatrixC.Text = printMatrix(rowsA, colsA, printMC, matrixC);
                }
            }
            if (rdbtnMultiply.Checked == true)
            {
                if (multiplicationCheck(rowsA,colsB))
                {
                    printMC = "";
                    matrixC = new double[rowsA, colsB];
                    multiplyMatrix(rowsA, rowsB, colsA, colsB, matrixA, matrixB, matrixC);
                    txtMatrixC.Text = printMatrix(rowsA, colsB, printMC, matrixC);
                }
            }

        }
        public string printMatrix(int rows, int cols, string test, double[,] matrix)
        {
            test = "";
            for (int i = 0; i < rows; i++)
            {
                test += "\r\n";
                for (int j = 0; j < cols; j++)
                {
                    test += String.Format("{0:0.00}", matrix[i, j]) + "\t";
                    //MessageBox.Show(test);


                }
            }
            return test;
        }

        public double[,] multiplyMatrix(int rowA, int rowB, int colA, int colB, double[,] matrixA, double[,] matrixB, double[,] matrixC)
        {
            for(int i=0; i<rowsA; i++)
            {
                for(int j=0; j<colsB; j++)
                {
                    matrixC[i, j] = 0;
                    for(int k=0; k<colsA; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return matrixC; 
        }
        public double[,] addMatrix(int rowA, int rowB, int colA, int colB, double[,] matrixA, double[,] matrixB, double[,] matrixC)
        {
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    //MessageBox.Show(matrixC[i, j].ToString());
                }
            }

            return matrixC;
        }

        public double[,] subMatrix(int rowA, int rowB, int colA, int colB, double[,] matrixA, double[,] matrixB, double[,] matrixC)
        {
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    matrixC[i, j] = matrixA[i, j] - matrixB[i, j];
                    //MessageBox.Show(matrixC[i, j].ToString());
                }
            }

            return matrixC;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRowsA.Text = "3";
            txtColsA.Text = "3";
            txtRowsB.Text = "3";
            txtColsB.Text = "3";

            matrixA = new double[rowsA, colsA];
            matrixB = new double[rowsB, colsB];
            
            txtMatrixA.Text = "";
            txtMatrixB.Text = "";
            txtMatrixC.Text = ""; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRowsA_TextChanged(object sender, EventArgs e)
        {
            if(txtRowsA.Text != "") { 
            try { 
            Int32.Parse(txtRowsA.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Not a valid value. Please enter an Integer. " + ex.ToString());
            }
        }
        }

        private void txtColsA_TextChanged(object sender, EventArgs e)
        {
            if (txtColsA.Text != "")
            {
                try
                {
                    Int32.Parse(txtColsA.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not a valid value. Please enter an Integer. " + ex.ToString());
                }
            }
        }

        private void txtRowsB_TextChanged(object sender, EventArgs e)
        {
            if (txtRowsB.Text != "")
            {
                try
                {
                    Int32.Parse(txtRowsB.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not a valid value. Please enter an Integer. " + ex.ToString());
                }
            }
        }

        private void txtColsB_TextChanged(object sender, EventArgs e)
        {
            if (txtColsB.Text != "")
            {
                try
                {
                    Int32.Parse(txtColsB.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not a valid value. Please enter an Integer. " + ex.ToString());
                }
            }
        }
    }
}
