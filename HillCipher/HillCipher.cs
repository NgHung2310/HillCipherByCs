using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HillCipher
{
    public partial class HillCipher : Form
    {
        
        string[] myStr = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "", "_", "+", "=", "|", "\\", "\"", "\n", "\t", "{", "[", "]", "}", ":", ";", "'", "<", ",", ".", ">", "?", "/", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public HillCipher()
        {
            InitializeComponent();
            rbtnEncipher.Checked = true;
            rtbxMatrix.Enabled = false;
            rtbxReverseMatrix.Enabled = false;
            btnCalc.Enabled = false;
        }

        private void rbtnEncipher_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEncipher.Checked == true)
            {
                tbxPlainText.Enabled = true;
                tbxCiphetText.Enabled = false;
            }
            else
            {
                tbxPlainText.Enabled = false;
                tbxCiphetText.Enabled = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string res = "";
            int[,] matrix = ConvertKeyToMatrix(ReadFileKey());
            if (matrix == null)
            {
                MessageBox.Show("Key is not valid, please input key is number square matrix!");
                return;
            }
            if (matrix != null)
            {
                Matrix = matrix;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        res += matrix[i, j] + "\t";
                    }
                    res += "\n\n";
                }
                rtbxMatrix.Text = res;
                res = "";
                int[,] reserveMatrix = ReverseMatrix(matrix);
                for (int i = 0; i < reserveMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < reserveMatrix.GetLength(1); j++)
                    {
                        res += reserveMatrix[i, j] + "\t";
                    }
                    res += "\n\n";
                }
                rtbxReverseMatrix.Text = res;
            }
        }
        int[,] Matrix;
        private void button1_Click(object sender, EventArgs e)
        {
            string plainText=tbxPlainText.Text;
            string cipherText = tbxCiphetText.Text;   
            foreach(char item in plainText)
            {
                if (!myStr.Contains(item.ToString()))
                {
                    MessageBox.Show("Plaintext is out of string array, please input valid plaintext!");
                    return;
                }
            }
            foreach (char item in cipherText)
            {
                if (!myStr.Contains(item.ToString()))
                {
                    MessageBox.Show("Ciphertext is out of string array, please input valid ciphertext!");
                    return;
                }
            }
            if (rbtnEncipher.Checked == true)
            {
                if(plainText.Length<=0)
                    MessageBox.Show("Please enter plain text");
                else
                    tbxCiphetText.Text = Encipher(plainText);
            }
            else
            {
                if (cipherText.Length <= 0)
                    MessageBox.Show("Please enter cipher text");
                else
                    tbxPlainText.Text = Decipher(cipherText);
            }
        }
/// <summary>
/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
/// <returns></returns>
        private string ReadFileKey()
        {
            string res = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                if (File.Exists(filePath))
                {
                    StreamReader reader;
                    reader = File.OpenText(filePath);
                    string line;
                    do
                    {
                        line = reader.ReadLine();
                        res += line + " ";
                    }
                    while (line != null);
                    reader.Close();
                    btnCalc.Enabled = true;
                }
            }
            return res;
        }

        private int[,] ConvertKeyToMatrix(string str)
        {
            string[] arr = str.Trim().Split(' ');
            int n = 0;
            bool isSquare = false;
            for (int i = 1; i <= Math.Sqrt(arr.Length) + 1; i++)
            {
                if (i * i == arr.Length)
                {
                    n = i;
                    isSquare = true;
                }
            }
            if (!isSquare)
            {
                MessageBox.Show("Key is not square matrix, please intput key is square matrix!");
                return null;
            }
            int[,] res = new int[n, n];
            int k = 0;
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    if (!int.TryParse(arr[k], out res[i, j]))
                        return null;
                    k++;
                }
            }
            return res;
        }

        private int detK(int[,] arr)
        {
            int det = 0;
            int arrLevel = arr.GetLength(0);
            if(arrLevel==2)
            {
                det = arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0];
                return det;
            }    
            int temp1 = 0;
            int temp2 = 0;
            int temp = 1;
            for (int i = 0; i < arrLevel; i++)
            {
                temp = 1;
                for (int j = 0; j < arrLevel; j++)
                {
                    temp *= arr[j, (j + i) % arrLevel];
                }
                temp1 += temp;
            }
            for (int i = 0; i < arrLevel; i++)
            {
                temp = 1;
                for (int j = 0; j < arrLevel; j++)
                {
                    temp *= arr[j, (2 * arrLevel - 1 - j - i) % arrLevel];
                }
                temp2 += temp;
            }
            det = temp1 - temp2;
            while(det<0)
            {
                det += 97;
            }
            return det % 97;
        }

        private int detIK(int detK)
        {
            int detIK = 0;
            int a1 = 1, a2 = 0, a3 = myStr.Length;
            int b1 = 0, b2 = 1, b3 = detK;
            int q, t1, t2, t3;
            try
            {
                do
                {
                    q = a3 / b3;
                    t1 = a1 - q * b1;
                    t2 = a2 - q * b2;
                    t3 = a3 - q * b3;
                    a1 = b1;
                    a2 = b2;
                    a3 = b3;
                    b1 = t1;
                    b2 = t2;
                    b3 = t3;
                } while (t3 != 1);
                detIK = t2;
                while (detIK < 0)
                {
                    detIK += 97;
                }
                detIK %= 97;
            }catch
            {
                MessageBox.Show("Matrix cannot calc, please fix your matrix!");
                btnCalc.Enabled = false;
            }
            return detIK;
        }

        private int[,] ReverseMatrix(int[,] matrix)
        {
            int matrixLevel = matrix.GetLength(0);
            int[,] reserveMatrix = new int[matrixLevel, matrixLevel];
            int[,] temMP = new int[matrixLevel, matrixLevel];
            int detik = detIK(detK(matrix));
            int p = 0, q = 0;
            for (int i=0;i<matrixLevel;i++)
            {
                for (int j = 0; j < matrixLevel; j++)
                {
                    temMP[i, j] = ((int)Math.Pow(-1, i + j) * detK(ChildMatrix(matrix, i, j))) % 97;
                    temMP[i, j] = (temMP[i, j] * detik) % 97;
                    while(temMP[i, j]<0)
                    {
                        temMP[i, j] += 97;
                    }
                    reserveMatrix[j, i] = temMP[i, j];
                }
            }
            return reserveMatrix;
        }

        private int[,] ChildMatrix(int[,] matrix, int n, int m)
        {
            int matrixLevel = matrix.GetLength(0);
            int[,] childMatrix = new int[matrixLevel - 1, matrixLevel - 1];
            int p = 0, q = 0;
            for (int i = 0; i < matrixLevel; i++)
            {
                if (i != n)
                {
                    q = 0;
                    for (int j = 0; j < matrixLevel; j++)
                    {
                        if (j != m)
                        {
                            childMatrix[p, q] = matrix[i, j];
                            q++;
                        }
                    }
                    p++;
                }
            }
            return childMatrix;
        }

        public int[,] MulMatrix(int[,] A, int[,] B)
        {
            int cA = A.GetLength(1);
            int rB = B.GetLength(0);
            if (cA != rB)
            {
                MessageBox.Show("Matrixes can't be multiplied!!");
                return null;
            }
            else
            {
                int[,] result = new int[B.GetLength(0), B.GetLength(1)];
                int temp = 0;
                for (int k = 0; k < result.GetLength(1); k++)
                {
                    for (int i = 0; i < result.GetLength(0); i++)
                    {
                        temp = 0;
                        for (int j = 0; j < result.GetLength(0); j++)
                        {
                            temp += A[i, j] * B[j, k];
                        }
                        result[i, k] = temp ;
                    }
                }
                return result;
            }
        }

        private ArrayList StringToArray(string str)
        {
            int[,] arr = Matrix;
            char[] chrArr = str.ToCharArray();            
            int[] intArr = new int[chrArr.Length];
            for (int i=0;i< chrArr.Length;i++)
            {
                intArr[i] = Array.IndexOf(myStr, chrArr[i].ToString());
            }
            int[] strArr = intArr;
            ArrayList arrlst = new ArrayList();
            int matrixLevel = arr.GetLength(0);
            int[,] strMatrix=new int[matrixLevel, strArr.Length / matrixLevel];
            int[] strOdd = new int[strArr.Length - strArr.Length / matrixLevel * matrixLevel];
            int k = 0;
            for (int j = 0; j < strMatrix.GetLength(1); j++)
            {
                for (int i = 0; i < strMatrix.GetLength(0); i++)
                {
                    strMatrix[i, j] = strArr[k];
                    k++;
                }
            }
            int p = 0;
            while (k< strArr.Length)
            {
                strOdd[p] = strArr[k];
                p++;
                k++;
            }
            arrlst.Add(strMatrix);
            arrlst.Add(strOdd);
            return arrlst;
        }

        private string Encipher(string plainText)
        {
            int[,] key = Matrix;
            string res = "";
            ArrayList plainMatrix = StringToArray(plainText);
            int[,] strMatrix = (int[,])plainMatrix[0];
            int[] strOdd = (int[])plainMatrix[1];
            int[,] matrixMul = MulMatrix(key, strMatrix);
            for (int j = 0; j < matrixMul.GetLength(1); j++)
            {
                for (int i = 0; i < matrixMul.GetLength(0); i++)
                {
                    res += myStr[matrixMul[i, j] % 97];
                }
            }
            for (int i = 0; i < strOdd.Length; i++)
            {
                res += myStr[strOdd[i]];
            }
            return res;
        }

        private string Decipher(string plainText)
        {
            int[,] key = ReverseMatrix(Matrix);
            string res = "";
            ArrayList plainMatrix = StringToArray(plainText);
            int[,] strMatrix = (int[,])plainMatrix[0];
            int[] strOdd = (int[])plainMatrix[1];
            int[,] matrixMul = MulMatrix(key, strMatrix);
            for (int j = 0; j < matrixMul.GetLength(1); j++)
            {
                for (int i = 0; i < matrixMul.GetLength(0); i++)
                {
                    res += myStr[matrixMul[i, j] % 97];
                }
            }
            for (int i = 0; i < strOdd.Length; i++)
            {
                res += myStr[strOdd[i]];
            }
            return res;
        }
    }
}
