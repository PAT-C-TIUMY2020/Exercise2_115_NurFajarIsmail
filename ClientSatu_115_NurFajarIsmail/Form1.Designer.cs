
namespace ClientSatu_115_NurFajarIsmail
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btTambahData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.btCari = new System.Windows.Forms.Button();
            this.btSinkkronisasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTambahData
            // 
            this.btTambahData.Location = new System.Drawing.Point(401, 64);
            this.btTambahData.Name = "btTambahData";
            this.btTambahData.Size = new System.Drawing.Size(134, 23);
            this.btTambahData.TabIndex = 0;
            this.btTambahData.Text = "Tambah Data Baru";
            this.btTambahData.UseVisualStyleBackColor = true;
            this.btTambahData.Click += new System.EventHandler(this.btTambahData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 216);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silahkan Masukkan NIM :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(184, 24);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(192, 20);
            this.textBoxNIM.TabIndex = 3;
            // 
            // btCari
            // 
            this.btCari.Location = new System.Drawing.Point(401, 24);
            this.btCari.Name = "btCari";
            this.btCari.Size = new System.Drawing.Size(134, 23);
            this.btCari.TabIndex = 4;
            this.btCari.Text = "Cari";
            this.btCari.UseVisualStyleBackColor = true;
            this.btCari.Click += new System.EventHandler(this.btCari_Click);
            // 
            // btSinkkronisasi
            // 
            this.btSinkkronisasi.Location = new System.Drawing.Point(30, 64);
            this.btSinkkronisasi.Name = "btSinkkronisasi";
            this.btSinkkronisasi.Size = new System.Drawing.Size(142, 23);
            this.btSinkkronisasi.TabIndex = 5;
            this.btSinkkronisasi.Text = "Sinkkronisasi";
            this.btSinkkronisasi.UseVisualStyleBackColor = true;
            this.btSinkkronisasi.Click += new System.EventHandler(this.btSinkkronisasi_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btSinkkronisasi);
            this.Controls.Add(this.btCari);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btTambahData);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTambahData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.Button btCari;
        private System.Windows.Forms.Button btSinkkronisasi;
    }
}

