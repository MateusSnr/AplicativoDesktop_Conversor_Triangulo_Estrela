namespace TP01_200581
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.GpBControl = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblR1 = new System.Windows.Forms.Label();
            this.LblR2 = new System.Windows.Forms.Label();
            this.LblR3 = new System.Windows.Forms.Label();
            this.TxtR1 = new System.Windows.Forms.TextBox();
            this.TxtR2 = new System.Windows.Forms.TextBox();
            this.TxtR3 = new System.Windows.Forms.TextBox();
            this.LblSimbolOhm1 = new System.Windows.Forms.Label();
            this.LblSimbolOhm2 = new System.Windows.Forms.Label();
            this.LblSimbolOhm3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDataHora = new System.Windows.Forms.Label();
            this.TmrDataHora = new System.Windows.Forms.Timer(this.components);
            this.RdBtnResistores = new System.Windows.Forms.RadioButton();
            this.PctBoxAnimacao = new System.Windows.Forms.PictureBox();
            this.TmrAnimacao = new System.Windows.Forms.Timer(this.components);
            this.ListBoxResultados = new System.Windows.Forms.ListBox();
            this.GpBControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxAnimacao)).BeginInit();
            this.SuspendLayout();
            // 
            // GpBControl
            // 
            this.GpBControl.BackColor = System.Drawing.Color.SeaShell;
            this.GpBControl.Controls.Add(this.BtnExit);
            this.GpBControl.Controls.Add(this.BtnClear);
            this.GpBControl.Controls.Add(this.BtnCalculate);
            this.GpBControl.Location = new System.Drawing.Point(6, 186);
            this.GpBControl.Name = "GpBControl";
            this.GpBControl.Size = new System.Drawing.Size(383, 55);
            this.GpBControl.TabIndex = 0;
            this.GpBControl.TabStop = false;
            this.GpBControl.Text = "Área de Controle";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(288, 19);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(80, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Sair";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.LightGray;
            this.BtnClear.Location = new System.Drawing.Point(151, 19);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Limpar";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.Silver;
            this.BtnCalculate.Location = new System.Drawing.Point(16, 19);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "Calcular";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.GhostWhite;
            this.LblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(49, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(305, 19);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Conversor de Circuito Delta para Circiuto Y";
            // 
            // LblR1
            // 
            this.LblR1.AutoSize = true;
            this.LblR1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR1.Location = new System.Drawing.Point(19, 77);
            this.LblR1.Name = "LblR1";
            this.LblR1.Size = new System.Drawing.Size(28, 16);
            this.LblR1.TabIndex = 2;
            this.LblR1.Text = "R1:";
            // 
            // LblR2
            // 
            this.LblR2.AutoSize = true;
            this.LblR2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR2.Location = new System.Drawing.Point(19, 122);
            this.LblR2.Name = "LblR2";
            this.LblR2.Size = new System.Drawing.Size(28, 16);
            this.LblR2.TabIndex = 3;
            this.LblR2.Text = "R2:";
            // 
            // LblR3
            // 
            this.LblR3.AutoSize = true;
            this.LblR3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR3.Location = new System.Drawing.Point(19, 161);
            this.LblR3.Name = "LblR3";
            this.LblR3.Size = new System.Drawing.Size(28, 16);
            this.LblR3.TabIndex = 4;
            this.LblR3.Text = "R3:";
            // 
            // TxtR1
            // 
            this.TxtR1.Location = new System.Drawing.Point(61, 73);
            this.TxtR1.Name = "TxtR1";
            this.TxtR1.Size = new System.Drawing.Size(46, 20);
            this.TxtR1.TabIndex = 5;
            this.TxtR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtR1.Validating += new System.ComponentModel.CancelEventHandler(this.TxtR1_Validating);
            // 
            // TxtR2
            // 
            this.TxtR2.Location = new System.Drawing.Point(61, 118);
            this.TxtR2.Name = "TxtR2";
            this.TxtR2.Size = new System.Drawing.Size(46, 20);
            this.TxtR2.TabIndex = 6;
            this.TxtR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtR2.Validating += new System.ComponentModel.CancelEventHandler(this.TxtR2_Validating);
            // 
            // TxtR3
            // 
            this.TxtR3.Location = new System.Drawing.Point(61, 160);
            this.TxtR3.Name = "TxtR3";
            this.TxtR3.Size = new System.Drawing.Size(46, 20);
            this.TxtR3.TabIndex = 7;
            this.TxtR3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.TxtR3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TxtR3.Validating += new System.ComponentModel.CancelEventHandler(this.TxtR3_Validating);
            // 
            // LblSimbolOhm1
            // 
            this.LblSimbolOhm1.AutoSize = true;
            this.LblSimbolOhm1.Location = new System.Drawing.Point(113, 73);
            this.LblSimbolOhm1.Name = "LblSimbolOhm1";
            this.LblSimbolOhm1.Size = new System.Drawing.Size(16, 13);
            this.LblSimbolOhm1.TabIndex = 8;
            this.LblSimbolOhm1.Text = "Ω";
            // 
            // LblSimbolOhm2
            // 
            this.LblSimbolOhm2.AutoSize = true;
            this.LblSimbolOhm2.Location = new System.Drawing.Point(113, 122);
            this.LblSimbolOhm2.Name = "LblSimbolOhm2";
            this.LblSimbolOhm2.Size = new System.Drawing.Size(16, 13);
            this.LblSimbolOhm2.TabIndex = 9;
            this.LblSimbolOhm2.Text = "Ω";
            // 
            // LblSimbolOhm3
            // 
            this.LblSimbolOhm3.AutoSize = true;
            this.LblSimbolOhm3.Location = new System.Drawing.Point(113, 167);
            this.LblSimbolOhm3.Name = "LblSimbolOhm3";
            this.LblSimbolOhm3.Size = new System.Drawing.Size(16, 13);
            this.LblSimbolOhm3.TabIndex = 10;
            this.LblSimbolOhm3.Text = "Ω";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Circuito Convertido para Y";
            // 
            // LblDataHora
            // 
            this.LblDataHora.AutoSize = true;
            this.LblDataHora.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataHora.Location = new System.Drawing.Point(291, 360);
            this.LblDataHora.Name = "LblDataHora";
            this.LblDataHora.Size = new System.Drawing.Size(63, 14);
            this.LblDataHora.TabIndex = 19;
            this.LblDataHora.Text = "Data e Hora";
            // 
            // TmrDataHora
            // 
            this.TmrDataHora.Enabled = true;
            this.TmrDataHora.Tick += new System.EventHandler(this.TmrDataHora_Tick);
            // 
            // RdBtnResistores
            // 
            this.RdBtnResistores.AutoSize = true;
            this.RdBtnResistores.Location = new System.Drawing.Point(22, 38);
            this.RdBtnResistores.Name = "RdBtnResistores";
            this.RdBtnResistores.Size = new System.Drawing.Size(178, 17);
            this.RdBtnResistores.TabIndex = 20;
            this.RdBtnResistores.TabStop = true;
            this.RdBtnResistores.Text = "Adicionar valores aos Resistores";
            this.RdBtnResistores.UseVisualStyleBackColor = true;
            this.RdBtnResistores.CheckedChanged += new System.EventHandler(this.RdBtnResistores_CheckedChanged);
            // 
            // PctBoxAnimacao
            // 
            this.PctBoxAnimacao.Location = new System.Drawing.Point(142, 261);
            this.PctBoxAnimacao.Name = "PctBoxAnimacao";
            this.PctBoxAnimacao.Size = new System.Drawing.Size(100, 100);
            this.PctBoxAnimacao.TabIndex = 21;
            this.PctBoxAnimacao.TabStop = false;
            // 
            // TmrAnimacao
            // 
            this.TmrAnimacao.Enabled = true;
            this.TmrAnimacao.Tick += new System.EventHandler(this.TmrAnimacao_Tick);
            // 
            // ListBoxResultados
            // 
            this.ListBoxResultados.FormattingEnabled = true;
            this.ListBoxResultados.Location = new System.Drawing.Point(207, 69);
            this.ListBoxResultados.Name = "ListBoxResultados";
            this.ListBoxResultados.Size = new System.Drawing.Size(167, 108);
            this.ListBoxResultados.TabIndex = 22;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(401, 373);
            this.Controls.Add(this.ListBoxResultados);
            this.Controls.Add(this.PctBoxAnimacao);
            this.Controls.Add(this.RdBtnResistores);
            this.Controls.Add(this.LblDataHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblSimbolOhm3);
            this.Controls.Add(this.LblSimbolOhm2);
            this.Controls.Add(this.LblSimbolOhm1);
            this.Controls.Add(this.TxtR3);
            this.Controls.Add(this.TxtR2);
            this.Controls.Add(this.TxtR1);
            this.Controls.Add(this.LblR3);
            this.Controls.Add(this.LblR2);
            this.Controls.Add(this.LblR1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GpBControl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Conversor de Circuitos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.GpBControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxAnimacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GpBControl;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblR1;
        private System.Windows.Forms.Label LblR2;
        private System.Windows.Forms.Label LblR3;
        private System.Windows.Forms.TextBox TxtR1;
        private System.Windows.Forms.TextBox TxtR2;
        private System.Windows.Forms.TextBox TxtR3;
        private System.Windows.Forms.Label LblSimbolOhm1;
        private System.Windows.Forms.Label LblSimbolOhm2;
        private System.Windows.Forms.Label LblSimbolOhm3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDataHora;
        private System.Windows.Forms.Timer TmrDataHora;
        private System.Windows.Forms.RadioButton RdBtnResistores;
        private System.Windows.Forms.PictureBox PctBoxAnimacao;
        private System.Windows.Forms.Timer TmrAnimacao;
        private System.Windows.Forms.ListBox ListBoxResultados;
    }
}

