namespace telacadastro.Forms
{
    partial class Empresa
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
            this.tx_razao_social = new System.Windows.Forms.TextBox();
            this.cmb_natureza = new System.Windows.Forms.ComboBox();
            this.txt_cidd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_nome_fanta = new System.Windows.Forms.TextBox();
            this.mtx_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valormoneta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_situation_cad = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tx_nomepropri = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPorte = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.panelTipo = new System.Windows.Forms.Panel();
            this.panelRegime = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_cpfpro = new System.Windows.Forms.MaskedTextBox();
            this.panelPorte.SuspendLayout();
            this.panelTipo.SuspendLayout();
            this.panelRegime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_razao_social
            // 
            this.tx_razao_social.Location = new System.Drawing.Point(376, 147);
            this.tx_razao_social.Name = "tx_razao_social";
            this.tx_razao_social.Size = new System.Drawing.Size(289, 22);
            this.tx_razao_social.TabIndex = 64;
            // 
            // cmb_natureza
            // 
            this.cmb_natureza.FormattingEnabled = true;
            this.cmb_natureza.Items.AddRange(new object[] {
            "Médico",
            "Programador",
            "Professor",
            "Nenhum"});
            this.cmb_natureza.Location = new System.Drawing.Point(376, 566);
            this.cmb_natureza.Name = "cmb_natureza";
            this.cmb_natureza.Size = new System.Drawing.Size(180, 24);
            this.cmb_natureza.TabIndex = 62;
            // 
            // txt_cidd
            // 
            this.txt_cidd.Location = new System.Drawing.Point(716, 342);
            this.txt_cidd.Name = "txt_cidd";
            this.txt_cidd.Size = new System.Drawing.Size(180, 22);
            this.txt_cidd.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(711, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 30);
            this.label13.TabIndex = 60;
            this.label13.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(381, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 30);
            this.label14.TabIndex = 58;
            this.label14.Text = "Estado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-13, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(994, 65);
            this.label12.TabIndex = 57;
            this.label12.Text = "----------------------------------------------";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(840, 758);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 42);
            this.button2.TabIndex = 56;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_nome_fanta
            // 
            this.txt_nome_fanta.Location = new System.Drawing.Point(32, 147);
            this.txt_nome_fanta.Name = "txt_nome_fanta";
            this.txt_nome_fanta.Size = new System.Drawing.Size(242, 22);
            this.txt_nome_fanta.TabIndex = 54;
            // 
            // mtx_cnpj
            // 
            this.mtx_cnpj.Location = new System.Drawing.Point(32, 230);
            this.mtx_cnpj.Mask = "00,000,000/0000-00";
            this.mtx_cnpj.Name = "mtx_cnpj";
            this.mtx_cnpj.Size = new System.Drawing.Size(241, 22);
            this.mtx_cnpj.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nome Fantasia";
            // 
            // txt_valormoneta
            // 
            this.txt_valormoneta.Location = new System.Drawing.Point(716, 566);
            this.txt_valormoneta.Name = "txt_valormoneta";
            this.txt_valormoneta.Size = new System.Drawing.Size(179, 22);
            this.txt_valormoneta.TabIndex = 51;
            this.txt_valormoneta.TextChanged += new System.EventHandler(this.txt_salario_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(711, 537);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 30);
            this.label11.TabIndex = 50;
            this.label11.Text = "Valor Monetário";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 30);
            this.label9.TabIndex = 49;
            this.label9.Text = "Natureza Juridica";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(32, 340);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(223, 22);
            this.txt_end.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 30);
            this.label7.TabIndex = 46;
            this.label7.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(691, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 30);
            this.label6.TabIndex = 42;
            this.label6.Text = "Inicio Atividades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 30);
            this.label5.TabIndex = 40;
            this.label5.Text = "Situação Cadastral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Razão Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "CNPJ";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(840, 147);
            this.txt_id.MaxLength = 5;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(56, 22);
            this.txt_id.TabIndex = 37;
            this.txt_id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(835, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "ID";
            // 
            // cmb_situation_cad
            // 
            this.cmb_situation_cad.FormattingEnabled = true;
            this.cmb_situation_cad.Items.AddRange(new object[] {
            "Ativa ",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.cmb_situation_cad.Location = new System.Drawing.Point(404, 230);
            this.cmb_situation_cad.Name = "cmb_situation_cad";
            this.cmb_situation_cad.Size = new System.Drawing.Size(192, 24);
            this.cmb_situation_cad.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 537);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 30);
            this.label15.TabIndex = 69;
            this.label15.Text = "Telefone";
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)",
            "Distrito Federal (DF)"});
            this.cmb_estado.Location = new System.Drawing.Point(386, 340);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(180, 24);
            this.cmb_estado.TabIndex = 71;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(47, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 30);
            this.label17.TabIndex = 75;
            this.label17.Text = "Porte da Empresa";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(330, 647);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 30);
            this.label18.TabIndex = 82;
            this.label18.Text = "CPF";
            // 
            // tx_nomepropri
            // 
            this.tx_nomepropri.Location = new System.Drawing.Point(32, 674);
            this.tx_nomepropri.Name = "tx_nomepropri";
            this.tx_nomepropri.Size = new System.Drawing.Size(223, 22);
            this.tx_nomepropri.TabIndex = 80;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(27, 647);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(174, 30);
            this.label20.TabIndex = 79;
            this.label20.Text = "Nome proprietário";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(447, 65);
            this.label19.TabIndex = 84;
            this.label19.Text = "Cadastro Empresarial";
            // 
            // dtp_data
            // 
            this.dtp_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_data.CustomFormat = "0000-00-00";
            this.dtp_data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_data.Location = new System.Drawing.Point(695, 230);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(200, 22);
            this.dtp_data.TabIndex = 85;
            this.dtp_data.Value = new System.DateTime(2023, 11, 20, 22, 53, 0, 0);
            this.dtp_data.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(682, 758);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 55;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPorte
            // 
            this.panelPorte.Controls.Add(this.radioButton8);
            this.panelPorte.Controls.Add(this.radioButton7);
            this.panelPorte.Controls.Add(this.radioButton6);
            this.panelPorte.Controls.Add(this.label17);
            this.panelPorte.Location = new System.Drawing.Point(664, 379);
            this.panelPorte.Name = "panelPorte";
            this.panelPorte.Size = new System.Drawing.Size(241, 100);
            this.panelPorte.TabIndex = 89;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(164, 56);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(73, 20);
            this.radioButton8.TabIndex = 90;
            this.radioButton8.Text = "Grande";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(92, 56);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(66, 20);
            this.radioButton7.TabIndex = 77;
            this.radioButton7.Text = "Médio";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 56);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(83, 20);
            this.radioButton6.TabIndex = 76;
            this.radioButton6.Text = "Pequeno";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(29, 52);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(63, 20);
            this.radioButton4.TabIndex = 86;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Matriz";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(58, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 30);
            this.label16.TabIndex = 72;
            this.label16.Text = "Tipo";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(98, 52);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(56, 20);
            this.radioButton5.TabIndex = 87;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Filial";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // panelTipo
            // 
            this.panelTipo.Controls.Add(this.radioButton5);
            this.panelTipo.Controls.Add(this.label16);
            this.panelTipo.Controls.Add(this.radioButton4);
            this.panelTipo.Location = new System.Drawing.Point(416, 383);
            this.panelTipo.Name = "panelTipo";
            this.panelTipo.Size = new System.Drawing.Size(167, 96);
            this.panelTipo.TabIndex = 88;
            // 
            // panelRegime
            // 
            this.panelRegime.Controls.Add(this.label8);
            this.panelRegime.Controls.Add(this.radioButton1);
            this.panelRegime.Controls.Add(this.radioButton2);
            this.panelRegime.Controls.Add(this.radioButton3);
            this.panelRegime.Location = new System.Drawing.Point(14, 383);
            this.panelRegime.Name = "panelRegime";
            this.panelRegime.Size = new System.Drawing.Size(381, 96);
            this.panelRegime.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 30);
            this.label8.TabIndex = 44;
            this.label8.Text = "Regime Tributário";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 20);
            this.radioButton1.TabIndex = 66;
            this.radioButton1.Text = "Simples Nacional";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 20);
            this.radioButton2.TabIndex = 67;
            this.radioButton2.Text = "Lucro Presumido";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(321, 52);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 20);
            this.radioButton3.TabIndex = 68;
            this.radioButton3.Text = "Real";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // tx_telefone
            // 
            this.tx_telefone.Location = new System.Drawing.Point(31, 566);
            this.tx_telefone.Mask = "(00) 00000-0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(169, 22);
            this.tx_telefone.TabIndex = 90;
            // 
            // tx_cpfpro
            // 
            this.tx_cpfpro.Location = new System.Drawing.Point(335, 674);
            this.tx_cpfpro.Mask = "000,000,000-00";
            this.tx_cpfpro.Name = "tx_cpfpro";
            this.tx_cpfpro.Size = new System.Drawing.Size(190, 22);
            this.tx_cpfpro.TabIndex = 91;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(994, 822);
            this.Controls.Add(this.tx_cpfpro);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.panelPorte);
            this.Controls.Add(this.panelTipo);
            this.Controls.Add(this.panelRegime);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tx_nomepropri);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmb_situation_cad);
            this.Controls.Add(this.tx_razao_social);
            this.Controls.Add(this.cmb_natureza);
            this.Controls.Add(this.txt_cidd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nome_fanta);
            this.Controls.Add(this.mtx_cnpj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valormoneta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Name = "Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.Empresa_Load);
            this.panelPorte.ResumeLayout(false);
            this.panelPorte.PerformLayout();
            this.panelTipo.ResumeLayout(false);
            this.panelTipo.PerformLayout();
            this.panelRegime.ResumeLayout(false);
            this.panelRegime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_razao_social;
        private System.Windows.Forms.ComboBox cmb_natureza;
        private System.Windows.Forms.TextBox txt_cidd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_nome_fanta;
        private System.Windows.Forms.MaskedTextBox mtx_cnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valormoneta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_situation_cad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tx_nomepropri;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelPorte;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Panel panelTipo;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Panel panelRegime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.MaskedTextBox tx_cpfpro;
    }
}