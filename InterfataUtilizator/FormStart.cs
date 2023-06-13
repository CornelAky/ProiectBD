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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormEchipa E = new FormEchipa();
                E.Show();
                this.Hide();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception " + ex.Message);
            }
        }

        private void lblStartJucatori_Click(object sender, EventArgs e)
        {
            try
            {
                FormJucatori J = new FormJucatori();
                J.Show();
                this.Hide();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception " + ex.Message);
            }
        }

        private void btnStartTurneu_Click(object sender, EventArgs e)
        {
            try
            {
                FormAntrenor   T = new FormAntrenor();
                T.Show();
                this.Hide();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception " + ex.Message);
            }
        }

        private void btnStartMeciuri_Click(object sender, EventArgs e)
        {
            try
            {
                FormAntrenor M = new FormAntrenor();
                M.Show();
                this.Hide();

            }
            catch (OracleException ex)
            {
                MessageBox.Show("Exception " + ex.Message);
            }
        }
    }
}
