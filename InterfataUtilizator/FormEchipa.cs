using InterfataUtilizator;
using LibrarieModele;
using NivelAccesDate;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DotNetOracle
{
    public partial class FormEchipa : Form
    {
        private const int PRIMA_COLOANA = 0;
        IStocareEchipe stocareEchipe = (IStocareEchipe)new StocareFactory().GetTipStocare(typeof(Echipa));
        IStocareAntrenor stocareAntrenori = (IStocareAntrenor)new StocareFactory().GetTipStocare(typeof(Antrenor));

        public FormEchipa()
        {
            InitializeComponent();
            AfiseazaCatalog();
        }

        private void AfiseazaCatalog()
        {
            try
            {
                var echipe = stocareEchipe.GetEchipe();
                if (echipe != null && echipe.Any())
                {
                    dataGridEchipe.DataSource = echipe.Select(e => new { ID=e.ID, Team_Name=e.Team_Name, CoachName=e.Coach.Name, CoachID=e.CoachID }).ToList();

                    dataGridEchipe.Columns["ID"].Visible = false;
                    dataGridEchipe.Columns["CoachID"].Visible = false;
                    dataGridEchipe.Columns["Team_Name"].HeaderText = "Team_Name";
                    dataGridEchipe.Columns["CoachName"].HeaderText = "CoachName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            IncarcaAntrenor();
        }

        private void btnAdaugareEchipa_Click(object sender, EventArgs e)
        {
            try
            {
                var rezultat = stocareEchipe.AddEchipa(
                    new Echipa(
                        txtNumeEchipa.Text,
                         ((ComboItem)cmbAntrenor1.SelectedItem).Value
                        )
                    );
                if (rezultat == true)
                {
                    MessageBox.Show("Echipa adaugata cu succes!");
                    AfiseazaCatalog();
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare Echipa");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exceptie " + ex.Message);
            }

        }

        private void btnEchipaToStart_Click(object sender, EventArgs e)
        {
            FormStart S = new FormStart();
            S.Show();
            this.Hide();
        }

        private void dataGridEchipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridEchipe.CurrentCell.RowIndex;
            string idEchipa = dataGridEchipe[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            try
            {
                Echipa echipa = stocareEchipe.GetEchipa(int.Parse(idEchipa));

                //incarcarea datelor in controalele de pe forma
                if (echipa != null)
                {
                    label3.Text=echipa.ID.ToString();
                    txtEditNumeEchipa.Text = echipa.Team_Name.ToString();
                    cmbAntrenorEdit1.SelectedIndex = cmbAntrenorEdit1.FindStringExact(echipa.Coach.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            groupBoxActualizeazaEchipa.Visible = true;
        }

        private void btnActualizareEchipa_Click(object sender, EventArgs e)
        {
            try
            {
                Echipa echipa = new Echipa()
                {
                    ID = Convert.ToInt64(label3.Text),
                    Team_Name=txtEditNumeEchipa.Text,
                    CoachID=((ComboItem)cmbAntrenorEdit1.SelectedItem).Value
                };
                    

                var rezultat = stocareEchipe.UpdateEchipa(echipa);
                if (rezultat == true)
                {
                    MessageBox.Show("Echipa actualizata");
                    AfiseazaCatalog();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare echipa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IncarcaAntrenor()
        {
            try
            {
                var antenorLibei = stocareAntrenori.GetAntrenorLiberi();
                var antenor = stocareAntrenori.GetAntrenor();
                cmbAntrenor1.Items.Clear();
                cmbAntrenorEdit1.Items.Clear();
                if (antenor != null && antenor.Any())
                {
                    foreach (var e in antenor)
                    {
                        cmbAntrenorEdit1.Items.Add(new ComboItem(e.Name, (int)e.ID));
                    }
                }
                if (antenorLibei != null && antenorLibei.Any())
                {
                    foreach (var e in antenorLibei)
                    {
                        cmbAntrenor1.Items.Add(new ComboItem(e.Name, (int)e.ID));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
