using System;
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
        public HillCipher()
        {
            InitializeComponent();
            rbtnEncipher.Checked = true;
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
            string res="";
            int[,] arr = ConvertStringToMatrix(ReadFileKey());
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    res += arr[i, j] + "       ";
                }
                res += "\n\n";
            }
            lbMatrix.Text = res;
            MessageBox.Show(detK(arr).ToString());
        }

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
                }
            }
            return res;
        }

        private int[,] ConvertStringToMatrix(string str)
        {
            string[] arr = str.Trim().Split(' ');
            int n=0;
            bool isSquare = false;
            for (int i=1;i<=Math.Sqrt(arr.Length)+1;i++)
            {
                if (i * i == arr.Length)
                {
                    n = i;
                    isSquare = true;
                }
            }
            if (!isSquare)
            {
                MessageBox.Show("Key is not square matrix");
                return null;
            }
            int[,] res = new int[n, n];
            int k = 0;
            for(int i=0;i<res.GetLength(0);i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    res[i, j] = int.Parse(arr[k]);
                    k++;
                }
            }
            return res;
        }

        private int detK(int[,] arr)
        {
            int det = 0;
            int arrLevel = arr.GetLength(0);
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 0; i < arrLevel; i++)
                for (int j = 0; j < arrLevel; j++)
                {
                }
            return det;
        }

        //private static float MatrixDeterminant(float[,] matrix)
        //{
        //    int[] perm;
        //    int toggle;
        //    float[,] lum = MatrixDecompose(matrix, out perm, out toggle);
        //    if (lum == null)
        //        throw new Exception("Unable to compute MatrixDeterminant");
        //    float result = toggle;
        //    for (int i = 0; i < lum.GetLength(0); ++i)
        //        result *= lum[i, i];

        //    return result;
        //}
    }
}
