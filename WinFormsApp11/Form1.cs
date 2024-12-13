using System.Linq.Expressions;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {

        string[] vetor = new string[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (chbTerapiaCapilar.Checked)
            {
                lsbServicos.Items.Add(chbTerapiaCapilar.Text);
                chbTerapiaCapilar.Checked = false;

            }

            if (chbCachos.Checked)
            {
                lsbServicos.Items.Add(chbCachos.Text);
                chbCachos.Checked = false;

            }

            if (chbHidratacao.Checked)
            {
                lsbServicos.Items.Add(chbHidratacao.Text);
                chbHidratacao.Checked = false;
            }

            if (chbTintura.Checked)
            {
                lsbServicos.Items.Add(chbTintura.Text);
                chbTintura.Checked = false;
            }
            if (chbRestauracao.Checked)
            {
                lsbServicos.Items.Add(chbRestauracao.Text);
                chbRestauracao.Checked = false;
            }
            if (chbCorteSimples.Checked)
            {
                lsbServicos.Items.Add(chbCorteSimples.Text);
                chbCorteSimples.Checked = false;
            }

            if (chbEscova.Checked)
            {
                lsbServicos.Items.Add(chbEscova.Text);
                chbEscova.Checked = false;
            }

            if (chbManicure.Checked)
            {
                lsbServicos.Items.Add(chbManicure.Text);
                chbManicure.Checked = false;

            }

            if (chPedicure.Checked)
            {
                lsbServicos.Items.Add(chPedicure.Text);
                chPedicure.Checked = false;
            }
            if (chbSobrancelha.Checked)
            {
                lsbServicos.Items.Add(chbSobrancelha.Text);
                chbSobrancelha.Checked = false;

            }
            try
            {
                for (int i = 0; i < lsbServicos.Items.Count; i++)
                {
                    vetor[i] = lsbServicos.Items[i].ToString();
                }

            }

            catch
            {
                {
                    MessageBox.Show("O valor máximo para os serviços é  5. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lsbServicos.Items.RemoveAt(5);
                }
            }










        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}