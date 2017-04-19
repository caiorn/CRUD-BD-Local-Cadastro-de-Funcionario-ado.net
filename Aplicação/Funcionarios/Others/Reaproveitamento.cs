using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios.Others
{
    public static class Reaproveitamento
    {
        
        /// <summary>
        /// Limpa os controles que contem valores a partir de um formulario ou containers
        /// </summary>
        /// <param name="controles">Formulario ou Container(ex: this, groupBox1, Panel1)</param>
        public static void LimparTodosCampos(Control controles)
        {
            foreach(Control ctr in controles.Controls)
            {
                if(ctr is TextBox)
                    (ctr as TextBox).Text = "";
                if(ctr is MaskedTextBox)
                    (ctr as MaskedTextBox).Text = "";
                if(ctr is ComboBox)
                    (ctr as ComboBox).SelectedIndex = -1;
                if(ctr is DateTimePicker)
                    (ctr as DateTimePicker).Value = DateTime.Now;
                if(ctr is PictureBox)
                    (ctr as PictureBox).Image = null;
                if(ctr.HasChildren)
                    LimparTodosCampos(ctr);
            }
        }

        /// <summary>
        /// Permite digitar somente letras, utilizar com evento KeyPress
        /// </summary>
        /// <param name="e"></param>
        public static void ApenasLetras(KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
            //if(!char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32)
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Apenas letras");
            //}
        }

        /// <summary>
        /// Permite digitar apenas numeros, utilizar com evento KeyPress
        /// </summary>
        /// <param name="n"></param>
        public static void ApenasNumeros(KeyPressEventArgs n)
        {
            n.Handled = char.IsNumber(n.KeyChar) || n.KeyChar == 8 ? false : true;
        }

        /// <summary>
        /// TextBox dinamico no formato moeda, utilizar evento TextChange
        /// </summary>
        /// <param name="txt"></param>
        public static void FormatoMoeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                //if(n.Equals(""))
                //    n = "";
                n = n.PadLeft(3, '0');
                if(n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch(Exception) { }
        }

        /// <summary>
        /// Verifica se o Cpf é valido
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool CPFValido(string cpf)
        {
            if(cpf == "000.000.000.00" ||
               cpf == "111.111.111-11" ||
               cpf == "222.222.222-22" ||
               cpf == "333.333.333-33" ||
               cpf == "444.444.444-44" ||
               cpf == "555.555.555-55" ||
               cpf == "666.666.666-66" ||
               cpf == "777.777.777-77" ||
               cpf == "888.888.888-88" ||
               cpf == "999.999.999-99")
            {
                return false;
            }
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if(cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for(int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for(int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        /// <summary>
        /// Verifica se o email está dentro do padrão
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool EmailValido(string email)
        {   //using System.Text.RegularExpressions;
            Regex regExpEmail = new Regex("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$");
            Match match = regExpEmail.Match(email);

            if(match.Success)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Varificação genérica, Verifica se o formulario ou algum controle do formulario possui erro do objeto erroProvinder.
        /// </summary>
        /// <param name="controles">>Controle que deseja verificar apartir dele(Ex: this, groupBox1..)</param>
        /// <param name="errorProvider">ErrorProvider para qual seja feita a verificaçao (ex: errorProvider1)</param>
        /// <returns></returns>
        public static bool formularioPossuiErrosDoErroProvider(Control controles, ErrorProvider errorProvider)
        {
            bool existeErro = false;

            foreach(Control ctr in controles.Controls)
            {
                if(ctr is TextBox || ctr is MaskedTextBox || ctr is MaskedTextBox || ctr is ComboBox || ctr is DateTimePicker)
                {
                    var erro = errorProvider.GetError(ctr);

                    if(!string.IsNullOrEmpty(erro))
                    {
                        existeErro = true;
                        ctr.Focus();
                        break;
                    }
                }

                if(ctr.HasChildren)
                    formularioPossuiErrosDoErroProvider(ctr, errorProvider);

            }

            return existeErro;
        }

        /// <summary>
        /// Escala o tamanho da Imagem proporcionalmente para o tamanho maximo definido na largura(width) ou altura
        /// </summary>
        /// <param name="image">Imagem a modificar o tamanho</param>
        /// <param name="maxWidth">tamanho maximo da largura que ela poderá ter</param>
        /// <param name="maxHeight">tamanho maximo da altura que ela poderá ter</param>
        /// <returns>Image com novo tamanho</returns>
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using(var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }  

    }
}
