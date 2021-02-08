using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MannschaftSpiel
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        void update()
        {
            this.spielTableAdapter.Fill(this.gorDataSet.spiel);
            this.mannschaftTableAdapter.Fill(this.gorDataSet.mannschaft);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.spielTableAdapter.Fill(this.gorDataSet.spiel);
            this.mannschaftTableAdapter.Fill(this.gorDataSet.mannschaft);

            //Combobox is readonly
            cmbHeim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGast.DropDownStyle = ComboBoxStyle.DropDownList;

            //Spiel Tabelle standardmäßig in Data Grid anzeigen lassen
            dataGridView1.DataSource = spielBindingSource;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbHeim.SelectedValue.ToString() == cmbGast.SelectedValue.ToString())
            {
                MessageBox.Show("Fehler: Die Mannschaft kann nicht gegen sich selber spielen!");
                return;
            }

            try
            {
                spielTableAdapter.AddSpiel(cmbHeim.SelectedValue.ToString(), cmbGast.SelectedValue.ToString(), (int)nudSpieltag.Value, dtpDatum.Value);
                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow drSpiel;

            try
            {
                if (spielBindingSource != null)
                {
                    drSpiel = ((DataRowView)spielBindingSource.Current).Row;

                    String strHM = drSpiel["HMKurz"].ToString();
                    String strGM = drSpiel["GMKurz"].ToString();

                    spielTableAdapter.Delete1(strHM, strGM);
                    update();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                spielTableAdapter.DeleteAll();
                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = spielBindingSource;
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mannschaftBindingSource2;
            update();
        }
    }
}
