using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMatches
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAction_Click(object sender, EventArgs e)
        {
            labelForMatches.Text = "";
            labelForResults.Text = "";
            double lmbd = (double)lambda.Value;
            int[] teams = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int[,] matches = new int[8,8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    double[] possibilites = new double[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    for (int k = 0; k < 15; k++)
                    {
                        int m = 0;
                        double S = 0;
                        while (m < 10)
                        {
                            double a = rnd.NextDouble() % 1;
                            S += Math.Log(a);
                            if (S < -lmbd)
                                break;
                            else
                                m++;
                        }
                        if (m >= 10)
                            continue;
                        else
                        {
                            possibilites[m] = (Math.Pow(lmbd, m) * Math.Pow(Math.E, -lmbd) / fact(m));
                        }
                    }
                    for (int k = 0; k < 10; k++)
                    {
                        double a = rnd.NextDouble() % 1;
                        a -= possibilites[k];
                        if (a <= 0)
                        {
                            matches[i,j] = k;
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    labelForMatches.Text += "Команда " + (i + 1) + " " + matches[i, j] + " - " + matches[j,i] + " " + "Команда" + (j + 1) + "\n";
                    if(matches[i, j] > matches[j, i])
                    {
                        teams[i] += 2;
                    }
                    else if (matches[i, j] < matches[j, i])
                    {
                        teams[j] += 2;
                    }
                    else
                    {
                        teams[i]++;
                        teams[j]++;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                int max = 0;
                int teamMax = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (teams[j] > max)
                    {
                        max = teams[j];
                        teamMax = j + 1;
                    }
                }
                labelForResults.Text += "Команда " + teamMax + " - " + (max - 2) + " Очков" + "\n";
                teams[teamMax - 1] = 0;
            }
        }
        public int fact(int m)
        {
            int factorial = 1;
            for(int g = 1; g <= m; g++)
            {
                factorial *= g;
            }
            return factorial;
        }
    }
}
