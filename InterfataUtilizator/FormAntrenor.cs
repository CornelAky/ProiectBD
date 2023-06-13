using InterfataUtilizator;
using LibrarieModele;
using NivelAccesDate;

using Oracle.DataAccess.Client;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetOracle
{
    public partial class FormAntrenor : Form
    {
        private const int PRIMA_COLOANA = 0;

        IStocareAntrenor stocareAntrenor = (IStocareAntrenor)new StocareFactory().GetTipStocare(typeof(Antrenor));
        IStocareJucatori stocareJucatori = (IStocareJucatori)new StocareFactory().GetTipStocare(typeof(Jucator));
        IStocareEchipe stocareEchipe = (IStocareEchipe)new StocareFactory().GetTipStocare(typeof(Echipa));

        public FormAntrenor()
        {
            InitializeComponent();
            AfiseazaCatalog();
        }

        private void AfiseazaCatalog()
        {
            try
            {
                var antrenori = stocareAntrenor.GetAntrenor();
                var echipe = stocareEchipe.GetEchipe();
                var jucatori = stocareJucatori.GetJucatori();
                if (antrenori != null && antrenori.Any())
                {
                    

                    dataGridMeciuri.DataSource = antrenori.Select(m => new { m.ID,m.Name,m.DateOfBirth, m.ContractStartDate, m.ContractEndDate,}).ToList();

                    dataGridMeciuri.Columns["ID"].Visible = false;
                    dataGridMeciuri.Columns["Name"].HeaderText = "Name";
                    dataGridMeciuri.Columns["DateOfBirth"].HeaderText = "DateOfBirth";
                    dataGridMeciuri.Columns["ContractStartDate"].HeaderText = "ContractStartDate ";
                    dataGridMeciuri.Columns["ContractEndDate"].HeaderText = "ContractEndDate";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAdaugaTurneu_Click(object sender, EventArgs e)
        {
            try
            {
                var rezultat = stocareAntrenor.AddAntrenor(
                    new Antrenor(textBox8.Text + " " + textBox7.Text, dateTimePicker2.Value)
                    ) ;
                if (rezultat == true)
                {
                    MessageBox.Show("Antrenor adaugat cu succes!");
                    AfiseazaCatalog();
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare Antrenor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie " + ex.Message);
            }
        }

        private void dataGridMeciuri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridMeciuri.CurrentCell.RowIndex;
            string idMeci = dataGridMeciuri[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            try
            {

                Antrenor antrenor = stocareAntrenor.GetAntrenor(long.Parse(idMeci));
                
                if (antrenor != null )
                {
                    label4.Text = antrenor.ID.ToString();
                    textBox2.Text = antrenor.Name.Split(' ')[0].ToString();
                    textBox1.Text = antrenor.Name.Split(' ')[1].ToString();
                    dateTimePicker1.Value = antrenor.DateOfBirth;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            groupBoxEditMeci.Visible = true;
        }

        private void btnAcutalizeazaTurneu_Click(object sender, EventArgs e)
        {
            try
            {
                Antrenor resultat = new Antrenor()
                {
                    ID = Convert.ToInt64(label4.Text),
                    Name=(textBox2.Text + " " + textBox1.Text).ToString(),
                    DateOfBirth=dateTimePicker1.Value
                };

                var rezultat = stocareAntrenor.UpdateAntrenor(resultat);
                if (rezultat == true)
                {
                    MessageBox.Show("Antrenor actualizat");
                    AfiseazaCatalog();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare Antrenor!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }

        }

        private void btnMeciuriToStart_Click(object sender, EventArgs e)
        {
            try
            {
                FormStart S = new FormStart();
                S.Show();
                this.Hide();
            }
            catch(Exception)
            {

            }
        }

        private void FormAntrenor_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
