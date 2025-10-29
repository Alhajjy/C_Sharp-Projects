using System;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public void ResetForm()
        {
            rb_small.Checked = true;

            rb_thin.Checked = true;

            chk_extra_cheese.Checked = false;
            chk_mashrooms.Checked = false;
            chk_tomatos.Checked = false;
            chk_onion.Checked = false;
            chk_olives.Checked = false;
            chk_green_peppers.Checked = false;

            rb_eat_in.Checked = true;

            // Enable
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
            ResetForm();
        }

        public float GetSizeCost()
        {
            float Cost = 0;
            if (rb_small.Checked)
            {
                Cost = Convert.ToSingle(rb_small.Tag);
                result_size.Text = rb_small.Text;
            }
            else if (rb_medium.Checked)
            {
                Cost = Convert.ToSingle(rb_medium.Tag);
                result_size.Text = rb_medium.Text;
            }
            else if (rb_large.Checked)
            {
                Cost = Convert.ToSingle(rb_large.Tag);
                result_size.Text = rb_large.Text;
            }

            return Cost;
        }

        public float GetThicknessCost()
        {
            float Cost = 0;
            if (rb_thin.Checked)
            {
                Cost = Convert.ToSingle(rb_thin.Tag);

                result_crust.Text = rb_thin.Text;
            }
            else if (rb_thick.Checked) { Cost = Convert.ToSingle(rb_thick.Tag); ; result_crust.Text = rb_thick.Text; }

            return Cost;
        }

        public void UpdateToppingsList()
        {
            string list = "";
            if (chk_extra_cheese.Checked) list += ", " + chk_extra_cheese.Text;
            if (chk_mashrooms.Checked) list += ", " + chk_mashrooms.Text;
            if (chk_tomatos.Checked) list += ", " + chk_tomatos.Text;
            if (chk_onion.Checked) list += ", " + chk_onion.Text;
            if (chk_olives.Checked) list += ", " + chk_olives.Text;
            if (chk_green_peppers.Checked) list += ", " + chk_green_peppers.Text;

            result_toppings.Text = list;
        }

        public float GetToppingsCost()
        {
            float Cost = 0;
            if (chk_extra_cheese.Checked) Cost += Convert.ToSingle(chk_extra_cheese.Tag);
            if (chk_mashrooms.Checked) Cost += Convert.ToSingle(chk_mashrooms.Tag);
            if (chk_tomatos.Checked) Cost += Convert.ToSingle(chk_tomatos.Tag);
            if (chk_onion.Checked) Cost += Convert.ToSingle(chk_onion.Tag);
            if (chk_olives.Checked) Cost += Convert.ToSingle(chk_olives.Tag);
            if (chk_green_peppers.Checked) Cost += Convert.ToSingle(chk_green_peppers.Tag);
            return Cost;
        }

        public float CalculateTotalPrice()
        {
            return GetSizeCost() + GetThicknessCost() + GetToppingsCost();
        }

        public void UpdateTotalPrice()
        {
            result_price.Text = CalculateTotalPrice() + "$";
        }

        public void OrderPizza()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsList();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_large_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void rb_thick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void chk_extra_cheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsList();
        }

        private void chk_mashrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsList();
        }

        private void chk_tomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsList();
        }

        private void chk_olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsList();
        }

        private void chk_green_peppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppingsList();
        }

        private void rb_eat_in_CheckedChanged(object sender, EventArgs e)
        {
            result_eating_area.Text = rb_eat_in.Text;
        }

        private void rb_take_out_CheckedChanged(object sender, EventArgs e)
        {
            result_eating_area.Text = rb_take_out.Text;
        }

        private void result_toppings_Click(object sender, EventArgs e)
        {

        }

        private void reslut_size_Click(object sender, EventArgs e)
        {

        }

        private void result_crust_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void result_eating_area_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OrderPizza();
        }
    }
}
