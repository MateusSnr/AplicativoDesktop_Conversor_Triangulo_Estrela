using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TP01_200581
{
    public partial class FrmPrincipal : Form
    {
        #region Inicialização
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Variáveis Globais
        Double R1, R2, R3;
        int tipo = 0, contador = 0;
        #endregion

        #region Lixo
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Botão Sair simples
        private void BtnExit_Click(object sender, EventArgs e)
        {   //Fechando no evento click e mostrando uma message box
            
            if (MessageBox.Show("Deseja sair ?", "Você perderá todos os seus dados!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                Close();

            }
             
        }
        #endregion

        #region Botão Limpar
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma ?", "Limpar dados...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                TxtR1.Clear();
                TxtR2.Clear();
                TxtR3.Clear();

                ListBoxResultados.Items.Clear();

                RdBtnResistores.Checked = false;

            }
        }
        #endregion

        #region Botão calcular
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Double calculo4;
            Double calculo5;
            Double calculo6;

            R1 = Convert.ToDouble(TxtR1.Text);
            R2 = Convert.ToDouble(TxtR2.Text);
            R3 = Convert.ToDouble(TxtR3.Text);

            calculo4 = ((R1 * R2) / (R1 + R2 + R3));
            calculo5 = ((R2 * R3) / (R1 + R2 + R3));
            calculo6 = ((R3 * R1) / (R1 + R2 + R3));

            ListBoxResultados.Items.Add("R1 : " + calculo4.ToString("#0.0000"));
            ListBoxResultados.Items.Add("R2 : " + calculo5.ToString("#0.0000"));
            ListBoxResultados.Items.Add("R3 : " + calculo6.ToString("#0.0000"));

        }
        #endregion

        #region Validando valores inseridos no resistor 1
        private void TxtR1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                tipo = 1;
                R1 = Convert.ToDouble(TxtR1.Text);
                if (R1 <= 0)
                {
                    CaixadeErros(sender, e);
                }
            }
            catch {

            }
        }
        #endregion

        #region Botão Sair (windows fechar encrementado com forms eventos)
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair ?", "Encerrando programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }
        #endregion

        #region Validando valores inseridos no resistor 2
        private void TxtR2_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                tipo = 2;
                R2 = Convert.ToDouble(TxtR2.Text);
                if (R2 <= 0)
                {
                    CaixadeErros(sender, e);
                }
            }
            catch {

            }
        }
        #endregion

        #region Validando valores inseridos no resistor 3
        private void TxtR3_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                tipo = 3;
                R3 = Convert.ToDouble(TxtR3.Text);
                if (R3 <= 0)
                {
                    CaixadeErros(sender, e);
                }
            }
            catch {

            }
        }
        #endregion

        #region Data e Hora
        private void TmrDataHora_Tick(object sender, EventArgs e)
        {
            LblDataHora.Text = DateTime.Now.ToString();
        }
        #endregion

        #region Form Load
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            TxtR1.Visible = false;
            TxtR2.Visible = false;
            TxtR3.Visible = false;
        }
        #endregion

        #region Radio Btn
        private void RdBtnResistores_CheckedChanged(object sender, EventArgs e)
        {
            TxtR1.Visible = true;
            TxtR2.Visible = true;
            TxtR3.Visible = true;
        }
        #endregion

        #region Timer Animação
        private void TmrAnimacao_Tick(object sender, EventArgs e)
        {
            contador = contador % 9 + 1;
            PctBoxAnimacao.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\num" + Convert.ToString(contador) + ".png");
        }
        #endregion

        #region Caixa de erros
        private void CaixadeErros(object sender, CancelEventArgs e)
        {
            switch (tipo) {
                case 1:
                    MessageBox.Show("Valor do Resistor 1 errado!", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtR1.Clear();TxtR1.Focus();break;
                case 2:
                    MessageBox.Show("Valor do Resistor 2 errado!", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtR2.Clear();TxtR2.Focus();break;
                case 3:
                    MessageBox.Show("Valor do resistor 3 errado!", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtR3.Clear();TxtR3.Focus();break;
            }

        }
        #endregion

        #region Verifica cada caracter digitado 
        private void Verifica(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 8 || e.KeyChar == 44 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion
    }
}