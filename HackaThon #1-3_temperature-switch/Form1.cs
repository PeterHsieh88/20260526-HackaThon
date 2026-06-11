using System.Reflection.Emit;

namespace HackaThon__1_3_temperature_switch;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text += 1;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        textBox1.Text += 2;
    }

    private void button4_Click_1(object sender, EventArgs e)
    {
        textBox1.Text += 3;
    }

    private void button6_Click(object sender, EventArgs e)
    {
        textBox1.Text += 5;
    }

    private void button5_Click(object sender, EventArgs e)
    {
        textBox1.Text += 6;
    }

    private void button10_Click(object sender, EventArgs e)
    {
        textBox1.Text += 7;
    }

    private void button9_Click(object sender, EventArgs e)
    {
        textBox1.Text += 8;
    }

    private void button8_Click(object sender, EventArgs e)
    {
        textBox1.Text += 9;
    }

    private void button11_Click(object sender, EventArgs e)
    {
        textBox1.Text += 0;
    }

    private void button7_Click(object sender, EventArgs e)
    {
        textBox1.Text += 4;
    }

    private void button13_Click(object sender, EventArgs e)
    {
        textBox1.Text += ".";
    }


    private decimal CtoF()
    {
        decimal tempC = decimal.Parse(textBox1.Text);
        decimal tempF = (decimal)9 / 5 * tempC + 32;
        return tempF;
    }

    private decimal FtoC()
    {
        decimal tempF = decimal.Parse(textBox1.Text);
        decimal tempC = (tempF - 32) * (decimal)5 / 9;

        return tempC;
    }


    private void button2_Click(object sender, EventArgs e)
    {
        if (radioButton1.Checked)
        {
            //checkBox2.Enabled = false;
            CtoF();
            result.Text = CtoF().ToString();
        }
        else if (radioButton2.Checked)
        {
            //checkBox1.Enabled = false;
            FtoC();
            result.Text = FtoC().ToString();
        }
        else
        {
            MessageBox.Show("請選擇傳換方法");
        }

    }

    private void button12_Click(object sender, EventArgs e)
    {
        textBox1.Text = "";
        result.Text = "";
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void result_Click(object sender, EventArgs e)
    {
        result.Text = "";
    }
}
