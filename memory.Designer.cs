namespace Intel8086GUI
{
    partial class memory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memory));
            this.label1 = new System.Windows.Forms.Label();
            this.wartoscmatka = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.mainmemorytable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainmemorytable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "symulacja Pamięci";
            // 
            // wartoscmatka
            // 
            this.wartoscmatka.AutoSize = true;
            this.wartoscmatka.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wartoscmatka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wartoscmatka.Location = new System.Drawing.Point(36, 122);
            this.wartoscmatka.Name = "wartoscmatka";
            this.wartoscmatka.Size = new System.Drawing.Size(81, 37);
            this.wartoscmatka.TabIndex = 1;
            this.wartoscmatka.Text = "dede";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Symulacja wartości pamięci";
            // 
            // mainmemorytable
            // 
            this.mainmemorytable.AllowUserToAddRows = false;
            this.mainmemorytable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainmemorytable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mainmemorytable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainmemorytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainmemorytable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainmemorytable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainmemorytable.Location = new System.Drawing.Point(0, 63);
            this.mainmemorytable.Name = "mainmemorytable";
            this.mainmemorytable.ReadOnly = true;
            this.mainmemorytable.RowTemplate.Height = 25;
            this.mainmemorytable.Size = new System.Drawing.Size(425, 763);
            this.mainmemorytable.TabIndex = 1;
            // 
            // memory
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(425, 826);
            this.ControlBox = false;
            this.Controls.Add(this.mainmemorytable);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "memory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.memory_FormClosing);
            this.Load += new System.EventHandler(this.memory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainmemorytable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label wartoscmatka;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView mainmemorytable;
        private Button losoweWartosci;
    }
}