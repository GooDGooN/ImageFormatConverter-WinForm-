
using System.Windows.Forms;

namespace ImageFormatConverterWinForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
    }
}


public class MyHandler<T>
{
    protected T form;
    public MyHandler(T form)
    {
        this.form = form;
    }
}