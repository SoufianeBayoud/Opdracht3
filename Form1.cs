using System.Windows.Forms;

namespace Opdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stapel<int> integer = new Stapel<int>();
        Stapel<String> String = new Stapel<String>();
        Stapel<Copy> Copy = new Stapel<Copy>();


        //Integer
        private void btn_int_toevoegen_Click(object sender, EventArgs e)
        {
            int stapel_Int = int.Parse(textBox_int.Text);
            integer.Toevoegen(stapel_Int);
        }

        private void btn_int_delete_Click(object sender, EventArgs e)
        {
            integer.Verwijderen();
            MessageBox.Show("Item werd verwijdert.");
            
        }

        private void btn_int_clear_Click(object sender, EventArgs e)
        {
            integer.Leegmaken();
            MessageBox.Show("Lijst werd leeg gemaakt");
        }

        private void btn_int_aanwezig_Click(object sender, EventArgs e)
        {
            int int_Int = int.Parse(textBox_int.Text);
            bool is_Aanwezig = integer.isAanwezig(int_Int);
            MessageBox.Show(is_Aanwezig.ToString());
        }

        private void btn_int_copy_Click(object sender, EventArgs e)
        {
            Stapel<int> integer_CopyList = new Stapel<int>();
            integer_CopyList = integer.Copy();
            MessageBox.Show(integer_CopyList.ToString());
        }

        private void btn_int_tostring_Click(object sender, EventArgs e)
        {
            textBox_int.Text = integer.ToString();
            MessageBox.Show(textBox_int.Text = integer.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //String
        private void btn_str_toevoegen_Click(object sender, EventArgs e)
        {
           
            String.Toevoegen(textBox_str.Text);
        }

        private void btn_str_delete_Click(object sender, EventArgs e)
        {
            String.Verwijderen();
            MessageBox.Show("Item werd verwijdert.");
        }

        private void btn_str_clear_Click(object sender, EventArgs e)
        {
            String.Leegmaken();
            MessageBox.Show("Lijst werd leeg gemaakt");
        }

        private void btn_str_tostring_Click(object sender, EventArgs e)
        {
            textBox_str.Text = String.ToString();
            MessageBox.Show(textBox_str.Text = String.ToString());
        }

        private void btn_str_aanwezig_Click(object sender, EventArgs e)
        {
            String is_Aanwezig = String.isAanwezig(textBox_str.Text).ToString();
            MessageBox.Show(is_Aanwezig);
        }

        private void btn_str_copy_Click(object sender, EventArgs e)
        {
            Stapel<String> String_CopyList = new Stapel<String>();
            String_CopyList = String.Copy();
            MessageBox.Show(String_CopyList.ToString());
        }

        //Klasse 
        private void btn_class_toevoegen_Click(object sender, EventArgs e)
        {
            Copy.Toevoegen(new Copy(textBox_class.Text));
        }

        private void btn_class_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Copy.Verwijderen().ToString());
        }

        private void btn_class_clear_Click(object sender, EventArgs e)
        {
            Copy.Leegmaken();
            MessageBox.Show("Lijst werd leeg gemaakt");
        }

        private void btn_class_tostring_Click(object sender, EventArgs e)
        {
            textBox_class.Text = Copy.ToString();
            MessageBox.Show(textBox_class.Text = Copy.ToString());

        }

        private void btn_class_aanwezig_Click(object sender, EventArgs e)
        {
            Copy copy = new Copy(textBox_class.Text);
            bool is_Aanwezig = Copy.isAanwezig(copy);
            MessageBox.Show(is_Aanwezig.ToString());
        }

        private void btn_class_copy_Click(object sender, EventArgs e)
        {
            Stapel<Copy> Copy_Class = new Stapel<Copy>();
            Copy_Class = Copy.Copy();
            MessageBox.Show(Copy_Class.ToString());
        }
    }
}