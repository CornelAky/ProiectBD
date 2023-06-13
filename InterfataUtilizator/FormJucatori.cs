using InterfataUtilizator;
using LibrarieModele;
using NivelAccesDate;
using Oracle.DataAccess.Client;

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DotNetOracle
{
    public partial class FormJucatori : Form
    {
        private const int PRIMA_COLOANA = 0;

        IStocareJucatori stocareJucatori = (IStocareJucatori)new StocareFactory().GetTipStocare(typeof(Jucator));
        IStocareEchipe stocareEchipe = (IStocareEchipe)new StocareFactory().GetTipStocare(typeof(Echipa));

        public FormJucatori()
        {
            InitializeComponent();
            AfiseazaCatalog();
        }

        private void AfiseazaCatalog()
        {
            try
            {
                var jucatori = stocareJucatori.GetJucatori();
                if (jucatori != null && jucatori.Any())
                {
                    dataGridJucatori.DataSource = jucatori.Select(j => new { j.ID, j.Name, j.Salary, j.DateOfBirth, j.Position, Team_Name=j.Team.Team_Name
                                                                             ,j.ContractStartDate,j.ContractEndDate ,j.TeamID }).ToList();

                    dataGridJucatori.Columns["ID"].Visible = false;
                    dataGridJucatori.Columns["TeamID"].Visible = false;
                    dataGridJucatori.Columns["Name"].HeaderText = "Name";
                    dataGridJucatori.Columns["DateOfBirth"].HeaderText = "DateOfBirth";
                    dataGridJucatori.Columns["Salary"].HeaderText = "Salary";
                    dataGridJucatori.Columns["Position"].HeaderText = "Position";
                    dataGridJucatori.Columns["Team_Name"].HeaderText = "Team_Name";
                    dataGridJucatori.Columns["ContractStartDate"].HeaderText = "ContractStartDate";
                    dataGridJucatori.Columns["ContractEndDate"].HeaderText = "ContractEndDate";
                }
                IncarcaEchipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnJucatoriToStart_Click(object sender, EventArgs e)
        {
            try
            {
                FormStart S = new FormStart();
                S.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dataGridJucatori.CurrentCell.RowIndex;
            string idJucator = dataGridJucatori[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            try
            {
                Jucator jucator = stocareJucatori.GetJucator(int.Parse(idJucator));
                //incarcarea datelor in controalele de pe forma
                if (jucator != null)
                {
                    label13.Text=jucator.ID.ToString();
                    txtEditNumeJucator.Text = jucator.Name.Split(' ')[0].ToString();
                    txtEditPrenumeJucator.Text = jucator.Name.Split(' ')[1].ToString();
                    textBox5.Text=jucator.Salary.ToString();
                    dateTimePicker2.Value = jucator.DateOfBirth;
                    txtEditPozitiaJucator.Text=jucator.Position.ToString();
                    dateTimePicker1.Value = jucator.ContractStartDate;
                    dateTimePicker2.Value = jucator.ContractEndDate;

                    cmbEditEchipaJucator.SelectedIndex = cmbEditEchipaJucator.FindStringExact(jucator.Team.Team_Name.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            groupBoxEditJucator.Visible = true;
        }

        private void IncarcaEchipe()
        {
            try
            {
                var echipe = stocareEchipe.GetEchipe();
               
                cmbEditEchipaJucator.Items.Clear();
                comboBox1.Items.Clear();
                if (echipe != null && echipe.Any())
                {
                    foreach (var e in echipe)
                    {
                        cmbEditEchipaJucator.Items.Add(new ComboItem(e.Team_Name, (int)e.ID));
                        comboBox1.Items.Add(new ComboItem(e.Team_Name, (int)e.ID));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAdaugaJucator_Click(object sender, EventArgs e)
        {
            try
            {
                var rezultat = stocareJucatori.AddJucator(
                    new Jucator()
                    {
                        Name = textBox4.Text + " " + textBox3.Text,
                        Salary = Convert.ToDouble(textBox1.Text),
                        DateOfBirth = dateTimePicker5.Value,
                        Position=textBox2.Text,
                        TeamID= ((ComboItem)comboBox1.SelectedItem).Value,
                        ContractStartDate  = dateTimePicker6.Value,
                        ContractEndDate = dateTimePicker4.Value,
                     
                    });

                if (rezultat == true)
                {
                    MessageBox.Show("Jucator adaugat cu succes!");
                    AfiseazaCatalog();
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare Jucator");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exceptie " + ex.Message);
            }
        }

        private void btnAcutalizeazaJucator_Click(object sender, EventArgs e)
        {
            try
            {
                var jucator = new Jucator()
                    {
                        ID=Convert.ToInt64(label13.Text),
                        Name = txtEditNumeJucator.Text + " " + txtEditPrenumeJucator.Text,
                        Salary = Convert.ToDouble(textBox5.Text),
                        DateOfBirth = dateTimePicker2.Value,
                        Position = txtEditPozitiaJucator.Text,
                        TeamID = ((ComboItem)cmbEditEchipaJucator.SelectedItem).Value,
                        ContractStartDate = dateTimePicker1.Value,
                        ContractEndDate = dateTimePicker2.Value,

                    };

                var rezultat = stocareJucatori.UpdateJucator(jucator);
                if (rezultat == true)
                {
                    MessageBox.Show("Jucator actualizata");
                    AfiseazaCatalog();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare Jucator");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = Convert.ToInt64(label13.Text);

                var rezultat = stocareJucatori.DeleteJucator(ID);
                if (rezultat == true)
                {
                    MessageBox.Show("Jucator Sters");
                    AfiseazaCatalog();
                }
                else
                {
                    MessageBox.Show("Eroare la stergerea Jucator");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }
    }
}
