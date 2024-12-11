using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbshapeType.Items.Add("مستطیل");
            cmbshapeType.Items.Add("دایره");
            cmbshapeType.SelectedIndex = 0;
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Shape shape = null;
                if (cmbshapeType.SelectedItem.ToString()=="مستطیل")
                {
                    double length = double.Parse(txtvalue1.Text);
                    double width = double.Parse(txtvalue2.Text);
                    shape = new Rectangle(length, width);
                }
                else if (cmbshapeType.SelectedItem.ToString() == "دایره")
                {
                    double radius = double.Parse(txtvalue1.Text);
                    shape = new Circle(radius);
                }
                if (shape!=null)
                {
                    double area = shape.CalculateArea();
                    lbresult.Text = $"مساحت: {area:F2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    public  abstract class Shape
    {
    public abstract double CalculateArea();
    }
    public class Circle : Shape
    {
    public double Radius { get; set; }
     public Circle (double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
   }
    public class Rectangle : Shape
    {
     public double Lenght { get; set; }
     public double Width { get; set; }
    public Rectangle (double length, double width)
    {
        Lenght = length;
        Width = width;
    }
    public override double CalculateArea()
    {
        return Lenght * Width;
    }
}  


