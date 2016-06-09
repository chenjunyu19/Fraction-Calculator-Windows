using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fraction_Calculator
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private bool CheckTextBox()
    {
      if (TextBox2.Text == "")
      {
        TextBox2.Text = "1";
      }
      if (TextBox4.Text == "")
      {
        TextBox4.Text = "1";
      }
      if (TextBox1.Text != "" && TextBox3.Text != "")
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (CheckTextBox())
      {
        Fractions.Fraction[] fs = new Fractions.Fraction[2];
        Fractions.Fraction f;
        fs[0].Numerator = int.Parse(TextBox1.Text);
        fs[0].Denominator = int.Parse(TextBox2.Text);
        fs[1].Numerator = int.Parse(TextBox3.Text);
        fs[1].Denominator = int.Parse(TextBox4.Text);
        f = Fractions.Addition(fs[0], fs[1]);
        TextBox5.Text = Convert.ToString(f.Numerator);
        TextBox6.Text = Convert.ToString(f.Denominator);
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (CheckTextBox())
      {
        Fractions.Fraction[] fs = new Fractions.Fraction[2];
        Fractions.Fraction f;
        fs[0].Numerator = int.Parse(TextBox1.Text);
        fs[0].Denominator = int.Parse(TextBox2.Text);
        fs[1].Numerator = int.Parse(TextBox3.Text);
        fs[1].Denominator = int.Parse(TextBox4.Text);
        f = Fractions.Subaddition(fs[0], fs[1]);
        TextBox5.Text = Convert.ToString(f.Numerator);
        TextBox6.Text = Convert.ToString(f.Denominator);
      }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      if (CheckTextBox())
      {
        Fractions.Fraction[] f = new Fractions.Fraction[3];
        f[0].Numerator = int.Parse(TextBox1.Text);
        f[0].Denominator = int.Parse(TextBox2.Text);
        f[1].Numerator = int.Parse(TextBox3.Text);
        f[1].Denominator = int.Parse(TextBox4.Text);
        f[2] = Fractions.Multiplication(f[0], f[1]);
        TextBox5.Text = Convert.ToString(f[2].Numerator);
        TextBox6.Text = Convert.ToString(f[2].Denominator);
      }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      if (CheckTextBox())
      {
        Fractions.Fraction[] f = new Fractions.Fraction[3];
        f[0].Numerator = int.Parse(TextBox1.Text);
        f[0].Denominator = int.Parse(TextBox2.Text);
        f[1].Numerator = int.Parse(TextBox3.Text);
        f[1].Denominator = int.Parse(TextBox4.Text);
        f[2] = Fractions.Division(f[0], f[1]);
        TextBox5.Text = Convert.ToString(f[2].Numerator);
        TextBox6.Text = Convert.ToString(f[2].Denominator);
      }
    }
  }
}
