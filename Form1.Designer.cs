namespace cucaho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Marcatxt = new TextBox();
            Modelotxt = new TextBox();
            Preciotxt = new TextBox();
            Stocktxt = new TextBox();
            Cucahosdata = new DataGridView();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ELIMINARBUT = new Button();
            EDITARBUT = new Button();
            BUSCARBUT = new Button();
            INGRESARBUT = new Button();
            label5 = new Label();
            Ascbut = new Button();
            Descebut = new Button();
            buscartxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Cucahosdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(71, 51);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(61, 93);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(71, 129);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 2;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(77, 167);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 3;
            label4.Text = "Stock:";
            // 
            // Marcatxt
            // 
            Marcatxt.BackColor = SystemColors.ControlLightLight;
            Marcatxt.Location = new Point(131, 48);
            Marcatxt.Margin = new Padding(3, 2, 3, 2);
            Marcatxt.Name = "Marcatxt";
            Marcatxt.Size = new Size(164, 25);
            Marcatxt.TabIndex = 4;
            Marcatxt.TextChanged += Marcatxt_TextChanged;
            Marcatxt.KeyPress += Marcatxt_KeyPress;
            // 
            // Modelotxt
            // 
            Modelotxt.BackColor = SystemColors.ControlLightLight;
            Modelotxt.Location = new Point(131, 85);
            Modelotxt.Margin = new Padding(3, 2, 3, 2);
            Modelotxt.Name = "Modelotxt";
            Modelotxt.Size = new Size(164, 25);
            Modelotxt.TabIndex = 5;
            Modelotxt.TextChanged += Modelotxt_TextChanged;
            Modelotxt.KeyPress += Modelotxt_KeyPress;
            // 
            // Preciotxt
            // 
            Preciotxt.BackColor = SystemColors.ControlLightLight;
            Preciotxt.Location = new Point(131, 126);
            Preciotxt.Margin = new Padding(3, 2, 3, 2);
            Preciotxt.Name = "Preciotxt";
            Preciotxt.Size = new Size(164, 25);
            Preciotxt.TabIndex = 6;
            Preciotxt.KeyPress += Preciotxt_KeyPress;
            // 
            // Stocktxt
            // 
            Stocktxt.BackColor = SystemColors.ControlLightLight;
            Stocktxt.Location = new Point(131, 167);
            Stocktxt.Margin = new Padding(3, 2, 3, 2);
            Stocktxt.Name = "Stocktxt";
            Stocktxt.Size = new Size(164, 25);
            Stocktxt.TabIndex = 7;
            Stocktxt.KeyPress += Stocktxt_KeyPress;
            // 
            // Cucahosdata
            // 
            Cucahosdata.BackgroundColor = Color.FromArgb(52, 89, 112);
            Cucahosdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Cucahosdata.Columns.AddRange(new DataGridViewColumn[] { Marca, Modelo, Precio, Stock });
            Cucahosdata.Location = new Point(43, 233);
            Cucahosdata.Margin = new Padding(3, 2, 3, 2);
            Cucahosdata.Name = "Cucahosdata";
            Cucahosdata.RowHeadersWidth = 51;
            Cucahosdata.RowTemplate.Height = 29;
            Cucahosdata.Size = new Size(701, 211);
            Cucahosdata.TabIndex = 8;
            Cucahosdata.CellClick += Cucahosdata_CellClick;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.Width = 125;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.MinimumWidth = 6;
            Modelo.Name = "Modelo";
            Modelo.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 125;
            // 
            // ELIMINARBUT
            // 
            ELIMINARBUT.BackColor = Color.FromArgb(52, 89, 112);
            ELIMINARBUT.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ELIMINARBUT.ForeColor = SystemColors.ControlLightLight;
            ELIMINARBUT.Location = new Point(164, 459);
            ELIMINARBUT.Margin = new Padding(3, 2, 3, 2);
            ELIMINARBUT.Name = "ELIMINARBUT";
            ELIMINARBUT.Size = new Size(94, 35);
            ELIMINARBUT.TabIndex = 9;
            ELIMINARBUT.Text = "ELIMINAR";
            ELIMINARBUT.UseVisualStyleBackColor = false;
            ELIMINARBUT.Click += ELIMINARBUT_Click;
            // 
            // EDITARBUT
            // 
            EDITARBUT.BackColor = Color.FromArgb(52, 89, 112);
            EDITARBUT.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EDITARBUT.ForeColor = SystemColors.ControlLightLight;
            EDITARBUT.Location = new Point(43, 459);
            EDITARBUT.Margin = new Padding(3, 2, 3, 2);
            EDITARBUT.Name = "EDITARBUT";
            EDITARBUT.Size = new Size(94, 35);
            EDITARBUT.TabIndex = 11;
            EDITARBUT.Text = "EDITAR";
            EDITARBUT.UseVisualStyleBackColor = false;
            EDITARBUT.Click += EDITARBUT_Click;
            // 
            // BUSCARBUT
            // 
            BUSCARBUT.BackColor = Color.FromArgb(52, 89, 112);
            BUSCARBUT.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BUSCARBUT.ForeColor = SystemColors.ControlLightLight;
            BUSCARBUT.Location = new Point(410, 170);
            BUSCARBUT.Margin = new Padding(3, 2, 3, 2);
            BUSCARBUT.Name = "BUSCARBUT";
            BUSCARBUT.Size = new Size(94, 36);
            BUSCARBUT.TabIndex = 12;
            BUSCARBUT.Text = "BUSCAR";
            BUSCARBUT.UseVisualStyleBackColor = false;
            BUSCARBUT.Click += BUSCARBUT_Click;
            // 
            // INGRESARBUT
            // 
            INGRESARBUT.BackColor = Color.FromArgb(52, 89, 112);
            INGRESARBUT.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            INGRESARBUT.ForeColor = SystemColors.ControlLightLight;
            INGRESARBUT.Location = new Point(282, 458);
            INGRESARBUT.Margin = new Padding(3, 2, 3, 2);
            INGRESARBUT.Name = "INGRESARBUT";
            INGRESARBUT.Size = new Size(90, 38);
            INGRESARBUT.TabIndex = 13;
            INGRESARBUT.Text = "INGRESAR";
            INGRESARBUT.UseVisualStyleBackColor = false;
            INGRESARBUT.Click += INGRESARBUT_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 64, 64);
            label5.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(522, 469);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 17;
            label5.Text = "ORDEN:";
            // 
            // Ascbut
            // 
            Ascbut.BackColor = Color.FromArgb(52, 89, 112);
            Ascbut.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Ascbut.ForeColor = SystemColors.ControlLightLight;
            Ascbut.Location = new Point(594, 500);
            Ascbut.Name = "Ascbut";
            Ascbut.Size = new Size(150, 34);
            Ascbut.TabIndex = 18;
            Ascbut.Text = "Ascendente";
            Ascbut.UseVisualStyleBackColor = false;
            Ascbut.Click += button1_Click;
            // 
            // Descebut
            // 
            Descebut.BackColor = Color.FromArgb(52, 89, 112);
            Descebut.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Descebut.ForeColor = SystemColors.ControlLightLight;
            Descebut.Location = new Point(594, 461);
            Descebut.Name = "Descebut";
            Descebut.Size = new Size(150, 33);
            Descebut.TabIndex = 19;
            Descebut.Text = "Descendente";
            Descebut.UseVisualStyleBackColor = false;
            Descebut.Click += Descebut_Click;
            // 
            // buscartxt
            // 
            buscartxt.BackColor = SystemColors.ButtonHighlight;
            buscartxt.Location = new Point(510, 177);
            buscartxt.Multiline = true;
            buscartxt.Name = "buscartxt";
            buscartxt.Size = new Size(234, 29);
            buscartxt.TabIndex = 20;
            buscartxt.KeyPress += buscartxt_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(776, 587);
            Controls.Add(buscartxt);
            Controls.Add(Descebut);
            Controls.Add(Ascbut);
            Controls.Add(label5);
            Controls.Add(INGRESARBUT);
            Controls.Add(BUSCARBUT);
            Controls.Add(EDITARBUT);
            Controls.Add(ELIMINARBUT);
            Controls.Add(Cucahosdata);
            Controls.Add(Stocktxt);
            Controls.Add(Preciotxt);
            Controls.Add(Modelotxt);
            Controls.Add(Marcatxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Cucahosdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Marcatxt;
        private TextBox Modelotxt;
        private TextBox Preciotxt;
        private TextBox Stocktxt;
        private DataGridView Cucahosdata;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private Button ELIMINARBUT;
        private Button EDITARBUT;
        private Button BUSCARBUT;
        private Button INGRESARBUT;
        private Label label5;
        private Button Ascbut;
        private Button Descebut;
        private TextBox buscartxt;
    }
}