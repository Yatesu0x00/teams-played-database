
namespace MannschaftSpiel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpSpiel = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmbHeim = new System.Windows.Forms.ComboBox();
            this.mannschaftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorDataSet = new MannschaftSpiel.gorDataSet();
            this.cmbGast = new System.Windows.Forms.ComboBox();
            this.mannschaftBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSpieltag = new System.Windows.Forms.NumericUpDown();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSpieltagAnzeigen = new System.Windows.Forms.Button();
            this.grpDataGrid = new System.Windows.Forms.GroupBox();
            this.cmbSpieltag = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mannschaftTableAdapter = new MannschaftSpiel.gorDataSetTableAdapters.mannschaftTableAdapter();
            this.spielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spielTableAdapter = new MannschaftSpiel.gorDataSetTableAdapters.spielTableAdapter();
            this.mannschaftBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mannschaftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mannschaftBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpieltag)).BeginInit();
            this.grpDelete.SuspendLayout();
            this.grpDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mannschaftBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(295, 485);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(83, 54);
            this.btnDeleteAll.TabIndex = 19;
            this.btnDeleteAll.Text = "Alles löschen";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 214);
            this.dataGridView1.TabIndex = 21;
            // 
            // grpSpiel
            // 
            this.grpSpiel.Controls.Add(this.btnInsert);
            this.grpSpiel.Controls.Add(this.cmbHeim);
            this.grpSpiel.Controls.Add(this.cmbGast);
            this.grpSpiel.Controls.Add(this.label1);
            this.grpSpiel.Controls.Add(this.label5);
            this.grpSpiel.Controls.Add(this.label2);
            this.grpSpiel.Controls.Add(this.label4);
            this.grpSpiel.Controls.Add(this.label3);
            this.grpSpiel.Controls.Add(this.nudSpieltag);
            this.grpSpiel.Controls.Add(this.dtpDatum);
            this.grpSpiel.Location = new System.Drawing.Point(15, 12);
            this.grpSpiel.Name = "grpSpiel";
            this.grpSpiel.Size = new System.Drawing.Size(776, 160);
            this.grpSpiel.TabIndex = 20;
            this.grpSpiel.TabStop = false;
            this.grpSpiel.Text = "Spiel anlegen";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(6, 111);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(764, 43);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Spiel anlegen!";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbHeim
            // 
            this.cmbHeim.DataSource = this.mannschaftBindingSource;
            this.cmbHeim.DisplayMember = "MName";
            this.cmbHeim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHeim.FormattingEnabled = true;
            this.cmbHeim.Location = new System.Drawing.Point(8, 65);
            this.cmbHeim.Name = "cmbHeim";
            this.cmbHeim.Size = new System.Drawing.Size(168, 24);
            this.cmbHeim.TabIndex = 0;
            this.cmbHeim.ValueMember = "MKurz";
            // 
            // mannschaftBindingSource
            // 
            this.mannschaftBindingSource.DataMember = "mannschaft";
            this.mannschaftBindingSource.DataSource = this.gorDataSet;
            // 
            // gorDataSet
            // 
            this.gorDataSet.DataSetName = "gorDataSet";
            this.gorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbGast
            // 
            this.cmbGast.DataSource = this.mannschaftBindingSource1;
            this.cmbGast.DisplayMember = "MName";
            this.cmbGast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGast.FormattingEnabled = true;
            this.cmbGast.Location = new System.Drawing.Point(201, 65);
            this.cmbGast.Name = "cmbGast";
            this.cmbGast.Size = new System.Drawing.Size(168, 24);
            this.cmbGast.TabIndex = 1;
            this.cmbGast.ValueMember = "MKurz";
            // 
            // mannschaftBindingSource1
            // 
            this.mannschaftBindingSource1.DataMember = "mannschaft";
            this.mannschaftBindingSource1.DataSource = this.gorDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Heim-Mannschaft";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gast-Mannschaft";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spieltag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // nudSpieltag
            // 
            this.nudSpieltag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSpieltag.Location = new System.Drawing.Point(422, 65);
            this.nudSpieltag.Maximum = new decimal(new int[] {
            34,
            0,
            0,
            0});
            this.nudSpieltag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpieltag.Name = "nudSpieltag";
            this.nudSpieltag.Size = new System.Drawing.Size(54, 26);
            this.nudSpieltag.TabIndex = 6;
            this.nudSpieltag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Location = new System.Drawing.Point(501, 65);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(269, 26);
            this.dtpDatum.TabIndex = 5;
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Location = new System.Drawing.Point(12, 466);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(372, 87);
            this.grpDelete.TabIndex = 12;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(271, 54);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Spieltag";
            // 
            // btnSpieltagAnzeigen
            // 
            this.btnSpieltagAnzeigen.Location = new System.Drawing.Point(92, 36);
            this.btnSpieltagAnzeigen.Name = "btnSpieltagAnzeigen";
            this.btnSpieltagAnzeigen.Size = new System.Drawing.Size(84, 26);
            this.btnSpieltagAnzeigen.TabIndex = 22;
            this.btnSpieltagAnzeigen.Text = "Anzeigen";
            this.btnSpieltagAnzeigen.UseVisualStyleBackColor = true;
            // 
            // grpDataGrid
            // 
            this.grpDataGrid.Controls.Add(this.cmbSpieltag);
            this.grpDataGrid.Controls.Add(this.button2);
            this.grpDataGrid.Controls.Add(this.button1);
            this.grpDataGrid.Controls.Add(this.btnSpieltagAnzeigen);
            this.grpDataGrid.Controls.Add(this.label9);
            this.grpDataGrid.Controls.Add(this.dataGridView1);
            this.grpDataGrid.Location = new System.Drawing.Point(15, 172);
            this.grpDataGrid.Name = "grpDataGrid";
            this.grpDataGrid.Size = new System.Drawing.Size(871, 288);
            this.grpDataGrid.TabIndex = 23;
            this.grpDataGrid.TabStop = false;
            this.grpDataGrid.Text = "Data Grid";
            // 
            // cmbSpieltag
            // 
            this.cmbSpieltag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpieltag.FormattingEnabled = true;
            this.cmbSpieltag.Location = new System.Drawing.Point(11, 38);
            this.cmbSpieltag.Name = "cmbSpieltag";
            this.cmbSpieltag.Size = new System.Drawing.Size(75, 24);
            this.cmbSpieltag.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "Mannschaften anzeigen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 23;
            this.button1.Text = "Spiele anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mannschaftTableAdapter
            // 
            this.mannschaftTableAdapter.ClearBeforeFill = true;
            // 
            // spielBindingSource
            // 
            this.spielBindingSource.DataMember = "spiel";
            this.spielBindingSource.DataSource = this.gorDataSet;
            // 
            // spielTableAdapter
            // 
            this.spielTableAdapter.ClearBeforeFill = true;
            // 
            // mannschaftBindingSource2
            // 
            this.mannschaftBindingSource2.DataMember = "mannschaft";
            this.mannschaftBindingSource2.DataSource = this.gorDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 563);
            this.Controls.Add(this.grpDataGrid);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpSpiel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpSpiel.ResumeLayout(false);
            this.grpSpiel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mannschaftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mannschaftBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpieltag)).EndInit();
            this.grpDelete.ResumeLayout(false);
            this.grpDataGrid.ResumeLayout(false);
            this.grpDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mannschaftBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpSpiel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cmbHeim;
        private System.Windows.Forms.ComboBox cmbGast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSpieltag;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSpieltagAnzeigen;
        private System.Windows.Forms.GroupBox grpDataGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSpieltag;
        private gorDataSet gorDataSet;
        private System.Windows.Forms.BindingSource mannschaftBindingSource;
        private gorDataSetTableAdapters.mannschaftTableAdapter mannschaftTableAdapter;
        private System.Windows.Forms.BindingSource mannschaftBindingSource1;
        private System.Windows.Forms.BindingSource spielBindingSource;
        private gorDataSetTableAdapters.spielTableAdapter spielTableAdapter;
        private System.Windows.Forms.BindingSource mannschaftBindingSource2;
    }
}

