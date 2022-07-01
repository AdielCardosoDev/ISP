namespace InfoSys
{
    partial class FormCadCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCliente));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_Buscar = new System.Windows.Forms.ComboBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.text_Buscar = new System.Windows.Forms.TextBox();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.labelTotaldeRegistro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.text_Informacoes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_Link = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_Supervisor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_CodExterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_CNPJ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBoxMini);
            this.panel2.Controls.Add(this.pictureBoxClose);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1391, 35);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InfoSys.Properties.Resources.aplicativos1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.Image = global::InfoSys.Properties.Resources.Menor;
            this.pictureBoxMini.Location = new System.Drawing.Point(1330, 6);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMini.TabIndex = 5;
            this.pictureBoxMini.TabStop = false;
            this.pictureBoxMini.Click += new System.EventHandler(this.pictureBoxMini_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::InfoSys.Properties.Resources.Close;
            this.pictureBoxClose.Location = new System.Drawing.Point(1356, 6);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 4;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(201)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(42, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cadastro - Informações";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.cbx_Buscar);
            this.panel1.Controls.Add(this.Btn_consultar);
            this.panel1.Controls.Add(this.text_Buscar);
            this.panel1.Controls.Add(this.Btn_Atualizar);
            this.panel1.Controls.Add(this.labelTotaldeRegistro);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 644);
            this.panel1.TabIndex = 2;
            // 
            // cbx_Buscar
            // 
            this.cbx_Buscar.BackColor = System.Drawing.Color.White;
            this.cbx_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Buscar.Font = new System.Drawing.Font("Roboto", 12F);
            this.cbx_Buscar.FormattingEnabled = true;
            this.cbx_Buscar.Items.AddRange(new object[] {
            "Nome",
            "CNPJ/CPF",
            "Cod. Externo"});
            this.cbx_Buscar.Location = new System.Drawing.Point(756, 62);
            this.cbx_Buscar.Name = "cbx_Buscar";
            this.cbx_Buscar.Size = new System.Drawing.Size(121, 27);
            this.cbx_Buscar.TabIndex = 18;
            this.cbx_Buscar.SelectedIndexChanged += new System.EventHandler(this.cbx_Buscar_SelectedIndexChanged);
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.Btn_consultar.FlatAppearance.BorderSize = 0;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_consultar.ForeColor = System.Drawing.Color.White;
            this.Btn_consultar.Location = new System.Drawing.Point(1258, 60);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(117, 31);
            this.Btn_consultar.TabIndex = 16;
            this.Btn_consultar.Text = "Buscar";
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // text_Buscar
            // 
            this.text_Buscar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Buscar.Location = new System.Drawing.Point(883, 62);
            this.text_Buscar.MaxLength = 500;
            this.text_Buscar.Name = "text_Buscar";
            this.text_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Buscar.Size = new System.Drawing.Size(369, 27);
            this.text_Buscar.TabIndex = 15;
            this.text_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Buscar_KeyPress);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.Btn_Atualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Atualizar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Atualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Atualizar.Location = new System.Drawing.Point(1258, 593);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(117, 39);
            this.Btn_Atualizar.TabIndex = 8;
            this.Btn_Atualizar.Text = "Atualizar Lista";
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // labelTotaldeRegistro
            // 
            this.labelTotaldeRegistro.AutoSize = true;
            this.labelTotaldeRegistro.Font = new System.Drawing.Font("Roboto Condensed", 17F, System.Drawing.FontStyle.Bold);
            this.labelTotaldeRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.labelTotaldeRegistro.Location = new System.Drawing.Point(540, 61);
            this.labelTotaldeRegistro.Name = "labelTotaldeRegistro";
            this.labelTotaldeRegistro.Size = new System.Drawing.Size(202, 28);
            this.labelTotaldeRegistro.TabIndex = 7;
            this.labelTotaldeRegistro.Text = "Total De Registros: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.text_Informacoes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_Link);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.text_Supervisor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_CodExterno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_CNPJ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 534);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Salvar);
            this.panel3.Controls.Add(this.btn_limpar);
            this.panel3.Controls.Add(this.Btn_Excluir);
            this.panel3.Controls.Add(this.Btn_Editar);
            this.panel3.Location = new System.Drawing.Point(342, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 235);
            this.panel3.TabIndex = 15;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.Btn_Salvar.FlatAppearance.BorderSize = 0;
            this.Btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salvar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(11, 74);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(120, 39);
            this.Btn_Salvar.TabIndex = 4;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(11, 29);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(120, 39);
            this.btn_limpar.TabIndex = 17;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.Btn_Excluir.FlatAppearance.BorderSize = 0;
            this.Btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Excluir.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.Btn_Excluir.Location = new System.Drawing.Point(11, 164);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(120, 39);
            this.Btn_Excluir.TabIndex = 5;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = false;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.Btn_Editar.FlatAppearance.BorderSize = 0;
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Editar.ForeColor = System.Drawing.Color.White;
            this.Btn_Editar.Location = new System.Drawing.Point(11, 119);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(120, 39);
            this.Btn_Editar.TabIndex = 6;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label8.Location = new System.Drawing.Point(354, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "* Campos Obrigatórios.";
            // 
            // text_Informacoes
            // 
            this.text_Informacoes.Location = new System.Drawing.Point(14, 305);
            this.text_Informacoes.MaxLength = 500;
            this.text_Informacoes.Multiline = true;
            this.text_Informacoes.Name = "text_Informacoes";
            this.text_Informacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Informacoes.Size = new System.Drawing.Size(474, 209);
            this.text_Informacoes.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(11, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "*Informações";
            // 
            // text_Link
            // 
            this.text_Link.Location = new System.Drawing.Point(15, 253);
            this.text_Link.MaxLength = 130;
            this.text_Link.Name = "text_Link";
            this.text_Link.Size = new System.Drawing.Size(321, 27);
            this.text_Link.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Site:";
            // 
            // text_Supervisor
            // 
            this.text_Supervisor.Location = new System.Drawing.Point(14, 201);
            this.text_Supervisor.MaxLength = 130;
            this.text_Supervisor.Name = "text_Supervisor";
            this.text_Supervisor.Size = new System.Drawing.Size(322, 27);
            this.text_Supervisor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Supervisores:";
            // 
            // text_CodExterno
            // 
            this.text_CodExterno.Location = new System.Drawing.Point(14, 149);
            this.text_CodExterno.MaxLength = 10;
            this.text_CodExterno.Name = "text_CodExterno";
            this.text_CodExterno.Size = new System.Drawing.Size(106, 27);
            this.text_CodExterno.TabIndex = 8;
            this.text_CodExterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_CodExterno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código Externo:";
            // 
            // text_CNPJ
            // 
            this.text_CNPJ.Location = new System.Drawing.Point(14, 97);
            this.text_CNPJ.MaxLength = 14;
            this.text_CNPJ.Name = "text_CNPJ";
            this.text_CNPJ.Size = new System.Drawing.Size(322, 27);
            this.text_CNPJ.TabIndex = 6;
            this.text_CNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_CNPJ_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "*CNPJ/CPF";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(14, 45);
            this.text_nome.MaxLength = 130;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(322, 27);
            this.text_nome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nome: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(536, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(201)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(839, 483);
            this.dataGridView1.TabIndex = 3;
            // 
            // FormCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 644);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes ";
            this.Load += new System.EventHandler(this.FormCadCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxMini;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotaldeRegistro;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_Informacoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_Link;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_Supervisor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_CodExterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_CNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.TextBox text_Buscar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbx_Buscar;
        private System.Windows.Forms.Panel panel3;
    }
}