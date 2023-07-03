namespace projeto_calcula_frete
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
            this.components = new System.ComponentModel.Container();
            this.Cadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_smart = new System.Windows.Forms.TextBox();
            this.tbox_gold = new System.Windows.Forms.TextBox();
            this.tbox_premium = new System.Windows.Forms.TextBox();
            this.rb_smart = new System.Windows.Forms.RadioButton();
            this.rb_gold = new System.Windows.Forms.RadioButton();
            this.rb_premium = new System.Windows.Forms.RadioButton();
            this.tbox_datanasc = new System.Windows.Forms.MaskedTextBox();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.tbox_rua = new System.Windows.Forms.TextBox();
            this.tbox_cidade = new System.Windows.Forms.TextBox();
            this.tbox_uf = new System.Windows.Forms.ComboBox();
            this.tbox_num = new System.Windows.Forms.TextBox();
            this.tbox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_frete = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_ufdestino = new System.Windows.Forms.Label();
            this.lb_valoruf = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.lb_total.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.Location = new System.Drawing.Point(315, 9);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(87, 25);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "N°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data de nascimento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "CPF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_smart);
            this.groupBox1.Controls.Add(this.tbox_gold);
            this.groupBox1.Controls.Add(this.tbox_premium);
            this.groupBox1.Controls.Add(this.rb_smart);
            this.groupBox1.Controls.Add(this.rb_gold);
            this.groupBox1.Controls.Add(this.rb_premium);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 157);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DO FRETE:";
            // 
            // tbox_smart
            // 
            this.tbox_smart.Location = new System.Drawing.Point(415, 76);
            this.tbox_smart.Name = "tbox_smart";
            this.tbox_smart.Size = new System.Drawing.Size(140, 32);
            this.tbox_smart.TabIndex = 18;
            // 
            // tbox_gold
            // 
            this.tbox_gold.Location = new System.Drawing.Point(225, 76);
            this.tbox_gold.Name = "tbox_gold";
            this.tbox_gold.Size = new System.Drawing.Size(140, 32);
            this.tbox_gold.TabIndex = 17;
            // 
            // tbox_premium
            // 
            this.tbox_premium.Location = new System.Drawing.Point(15, 76);
            this.tbox_premium.Name = "tbox_premium";
            this.tbox_premium.Size = new System.Drawing.Size(140, 32);
            this.tbox_premium.TabIndex = 16;
            // 
            // rb_smart
            // 
            this.rb_smart.AutoSize = true;
            this.rb_smart.Location = new System.Drawing.Point(415, 41);
            this.rb_smart.Name = "rb_smart";
            this.rb_smart.Size = new System.Drawing.Size(89, 29);
            this.rb_smart.TabIndex = 2;
            this.rb_smart.TabStop = true;
            this.rb_smart.Text = "SMART";
            this.rb_smart.UseVisualStyleBackColor = true;
            // 
            // rb_gold
            // 
            this.rb_gold.AutoSize = true;
            this.rb_gold.Location = new System.Drawing.Point(225, 41);
            this.rb_gold.Name = "rb_gold";
            this.rb_gold.Size = new System.Drawing.Size(79, 29);
            this.rb_gold.TabIndex = 1;
            this.rb_gold.TabStop = true;
            this.rb_gold.Text = "GOLD";
            this.rb_gold.UseVisualStyleBackColor = true;
            // 
            // rb_premium
            // 
            this.rb_premium.AutoSize = true;
            this.rb_premium.Location = new System.Drawing.Point(15, 41);
            this.rb_premium.Name = "rb_premium";
            this.rb_premium.Size = new System.Drawing.Size(114, 29);
            this.rb_premium.TabIndex = 0;
            this.rb_premium.TabStop = true;
            this.rb_premium.Text = "PREMIUM";
            this.rb_premium.UseVisualStyleBackColor = true;
            // 
            // tbox_datanasc
            // 
            this.tbox_datanasc.Location = new System.Drawing.Point(509, 63);
            this.tbox_datanasc.Mask = "00/00/0000";
            this.tbox_datanasc.Name = "tbox_datanasc";
            this.tbox_datanasc.Size = new System.Drawing.Size(114, 32);
            this.tbox_datanasc.TabIndex = 9;
            this.tbox_datanasc.ValidatingType = typeof(System.DateTime);
            // 
            // tbox_nome
            // 
            this.tbox_nome.Location = new System.Drawing.Point(12, 126);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(390, 32);
            this.tbox_nome.TabIndex = 11;
            // 
            // tbox_rua
            // 
            this.tbox_rua.Location = new System.Drawing.Point(12, 189);
            this.tbox_rua.Name = "tbox_rua";
            this.tbox_rua.Size = new System.Drawing.Size(430, 32);
            this.tbox_rua.TabIndex = 12;
            // 
            // tbox_cidade
            // 
            this.tbox_cidade.Location = new System.Drawing.Point(12, 255);
            this.tbox_cidade.Name = "tbox_cidade";
            this.tbox_cidade.Size = new System.Drawing.Size(430, 32);
            this.tbox_cidade.TabIndex = 13;
            // 
            // tbox_uf
            // 
            this.tbox_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbox_uf.FormattingEnabled = true;
            this.tbox_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "GO",
            "ES",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.tbox_uf.Location = new System.Drawing.Point(509, 189);
            this.tbox_uf.Name = "tbox_uf";
            this.tbox_uf.Size = new System.Drawing.Size(192, 33);
            this.tbox_uf.TabIndex = 14;
            // 
            // tbox_num
            // 
            this.tbox_num.Location = new System.Drawing.Point(509, 126);
            this.tbox_num.Name = "tbox_num";
            this.tbox_num.Size = new System.Drawing.Size(114, 32);
            this.tbox_num.TabIndex = 15;
            // 
            // tbox_cpf
            // 
            this.tbox_cpf.Location = new System.Drawing.Point(12, 63);
            this.tbox_cpf.Mask = "000,000,000-00";
            this.tbox_cpf.Name = "tbox_cpf";
            this.tbox_cpf.Size = new System.Drawing.Size(167, 32);
            this.tbox_cpf.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefone:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(509, 255);
            this.maskedTextBox1.Mask = "(00) 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(114, 32);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(89, 468);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(155, 39);
            this.btn_calcular.TabIndex = 19;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(376, 468);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(155, 39);
            this.btn_limpar.TabIndex = 20;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // lb_total
            // 
            this.lb_total.Controls.Add(this.lb_valoruf);
            this.lb_total.Controls.Add(this.lb_ufdestino);
            this.lb_total.Controls.Add(this.label16);
            this.lb_total.Controls.Add(this.label15);
            this.lb_total.Controls.Add(this.label14);
            this.lb_total.Controls.Add(this.lb_frete);
            this.lb_total.Controls.Add(this.label12);
            this.lb_total.Controls.Add(this.label11);
            this.lb_total.Controls.Add(this.lb_cidade);
            this.lb_total.Controls.Add(this.label9);
            this.lb_total.Location = new System.Drawing.Point(12, 580);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(698, 163);
            this.lb_total.TabIndex = 21;
            this.lb_total.TabStop = false;
            this.lb_total.Text = "INFORMAÇOES FINAIS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "CIDADE DESTINO:";
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Location = new System.Drawing.Point(190, 28);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(16, 25);
            this.lb_cidade.TabIndex = 1;
            this.lb_cidade.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "VALOR TIPO FRETE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "VALOR TOTAL:";
            // 
            // lb_frete
            // 
            this.lb_frete.AutoSize = true;
            this.lb_frete.Location = new System.Drawing.Point(190, 85);
            this.lb_frete.Name = "lb_frete";
            this.lb_frete.Size = new System.Drawing.Size(16, 25);
            this.lb_frete.TabIndex = 4;
            this.lb_frete.Text = ".";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(147, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = ".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(342, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 25);
            this.label15.TabIndex = 6;
            this.label15.Text = "UF DESTINO:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(342, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 25);
            this.label16.TabIndex = 7;
            this.label16.Text = "VALOR UF:";
            // 
            // lb_ufdestino
            // 
            this.lb_ufdestino.AutoSize = true;
            this.lb_ufdestino.Location = new System.Drawing.Point(467, 28);
            this.lb_ufdestino.Name = "lb_ufdestino";
            this.lb_ufdestino.Size = new System.Drawing.Size(16, 25);
            this.lb_ufdestino.TabIndex = 8;
            this.lb_ufdestino.Text = ".";
            // 
            // lb_valoruf
            // 
            this.lb_valoruf.AutoSize = true;
            this.lb_valoruf.Location = new System.Drawing.Point(446, 64);
            this.lb_valoruf.Name = "lb_valoruf";
            this.lb_valoruf.Size = new System.Drawing.Size(16, 25);
            this.lb_valoruf.TabIndex = 9;
            this.lb_valoruf.Text = ".";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbdata,
            this.toolStripStatusLabel2,
            this.lb_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 758);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(750, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked_1);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "HOJE É: ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lbdata
            // 
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(118, 17);
            this.lbdata.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel2.Text = "| E SÃO:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // lb_hora
            // 
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(118, 17);
            this.lb_hora.Text = "toolStripStatusLabel3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 780);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbox_cpf);
            this.Controls.Add(this.tbox_num);
            this.Controls.Add(this.tbox_uf);
            this.Controls.Add(this.tbox_cidade);
            this.Controls.Add(this.tbox_rua);
            this.Controls.Add(this.tbox_nome);
            this.Controls.Add(this.tbox_datanasc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cadastro);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcula frete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lb_total.ResumeLayout(false);
            this.lb_total.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Cadastro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox tbox_smart;
        private TextBox tbox_gold;
        private TextBox tbox_premium;
        private RadioButton rb_smart;
        private RadioButton rb_gold;
        private RadioButton rb_premium;
        private MaskedTextBox tbox_datanasc;
        private TextBox tbox_nome;
        private TextBox tbox_rua;
        private TextBox tbox_cidade;
        private ComboBox tbox_uf;
        private TextBox tbox_num;
        private MaskedTextBox tbox_cpf;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
        private Button btn_calcular;
        private Button btn_limpar;
        private GroupBox lb_total;
        private Label lb_valoruf;
        private Label lb_ufdestino;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label lb_frete;
        private Label label12;
        private Label label11;
        private Label lb_cidade;
        private Label label9;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lbdata;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lb_hora;
        private System.Windows.Forms.Timer timer1;
    }
}