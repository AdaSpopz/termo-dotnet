using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Termo.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Termo
{
    public partial class Form1 : Form
    {
        public List<String> listaPalavras;
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Textos
        {
            public static string RemoveDiacritics(string Text)
            {
                return new Regex(@"\p{Mn}", RegexOptions.Compiled).Replace(Text.Normalize(NormalizationForm.FormD), string.Empty);
            }
        }
        public static class Globals
        {


            public static string palavra = "";
            public static string palpite = "";
            public static int tentativas = 0;
            public static int repetido = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("termo.txt");
            listaPalavras = new List<string>();


            string linha;
            while ((linha = sr.ReadLine()) != null)
            {
                listaPalavras.Add(linha);
            }


            Random rnd = new Random();
            string palavraAleatoria = listaPalavras[rnd.Next(0, listaPalavras.Count)];
            Globals.palavra = palavraAleatoria.ToUpper();


        }

        private void box_guess_TextChanged(object sender, EventArgs e)
        {
            box_guess.SelectionStart = box_guess.Text.Length;
            box_guess.Text = box_guess.Text.ToUpper();
        }


        private void Verificar()
        {
            string palpiteGuarda = Textos.RemoveDiacritics(box_guess.Text);
            Globals.palpite = palpiteGuarda;
            box_guess.Text = "";


            if (Globals.palpite.Length < 5)
            {
                MessageBox.Show("Por favor, insira uma palavra com no mínimo 5 letras.", "Aviso");
            }
            else
            {

                Globals.tentativas++;
                bool[] resolveu = new bool[5];




                //tentativa 1
                if (Globals.tentativas == 1)
                {

                    for (int i = 0; i <= 4; i++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {

                            char caracPalpite = Globals.palpite[i];

                            char caracPalavra = Globals.palavra[j];


                            ///////////////// inicio linha 1 /////////////////

                            if (i == 0 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_1.Image = Properties.Resources.fundo_verde;
                                lbl_1.Text = caracPalpite.ToString();
                                resolveu[0] = true;

                            }

                            else if (i == 0 && i != j && caracPalpite == caracPalavra && pic_1.Image == null && resolveu[j] != true)
                            {

                                pic_1.Image = Properties.Resources.amarelo;
                                lbl_1.Text = caracPalpite.ToString();

                            }

                            else if (i == 0 && i != j && caracPalpite != caracPalavra)
                            {
                                lbl_1.Text = caracPalpite.ToString();

                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 1 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_2.Image = Properties.Resources.fundo_verde;
                                lbl_2.Text = caracPalpite.ToString();
                                resolveu[1] = true;

                            }

                            else if (i == 1 && i != j && caracPalpite == caracPalavra && pic_2.Image == null && resolveu[j] != true)
                            {
                                pic_2.Image = Properties.Resources.amarelo;
                                lbl_2.Text = caracPalpite.ToString();

                            }

                            else if (i == 1 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_2.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 2 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_3.Image = Properties.Resources.fundo_verde;
                                lbl_3.Text = caracPalpite.ToString();
                                resolveu[2] = true;

                            }

                            else if (i == 2 && i != j && caracPalpite == caracPalavra && pic_3.Image == null && resolveu[j] != true)
                            {

                                pic_3.Image = Properties.Resources.amarelo;
                                lbl_3.Text = caracPalpite.ToString();

                            }

                            else if (i == 2 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_3.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///

                            if (i == 3 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_4.Image = Properties.Resources.fundo_verde;
                                lbl_4.Text = caracPalpite.ToString();
                                resolveu[3] = true;

                            }

                            else if (i == 3 && i != j && caracPalpite == caracPalavra && pic_4.Image == null && resolveu[j] != true)
                            {
                                pic_4.Image = Properties.Resources.amarelo;
                                lbl_4.Text = caracPalpite.ToString();

                            }

                            else if (i == 3 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_4.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 4 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_5.Image = Properties.Resources.fundo_verde;
                                lbl_5.Text = caracPalpite.ToString();
                                resolveu[4] = true;
                            }

                            else if (i == 4 && i != j && caracPalpite == caracPalavra && pic_5.Image == null && resolveu[j] != true)
                            {
                                pic_5.Image = Properties.Resources.amarelo;
                                lbl_5.Text = caracPalpite.ToString();

                            }

                            else if (i == 4 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_5.Text = caracPalpite.ToString();
                            }

                        }
                    }
                }







                //tentativa 2
                if (Globals.tentativas == 2)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {

                            char caracPalpite = Globals.palpite[i];

                            char caracPalavra = Globals.palavra[j];


                            ///////////////// inicio linha 1 /////////////////

                            if (i == 0 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_6.Image = Properties.Resources.fundo_verde;
                                lbl_6.Text = caracPalpite.ToString();
                                resolveu[0] = true;

                            }

                            else if (i == 0 && i != j && caracPalpite == caracPalavra && pic_6.Image == null && resolveu[j] != true)
                            {

                                pic_6.Image = Properties.Resources.amarelo;
                                lbl_6.Text = caracPalpite.ToString();

                            }

                            else if (i == 0 && i != j && caracPalpite != caracPalavra)
                            {
                                lbl_6.Text = caracPalpite.ToString();

                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 1 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_7.Image = Properties.Resources.fundo_verde;
                                lbl_7.Text = caracPalpite.ToString();
                                resolveu[1] = true;

                            }

                            else if (i == 1 && i != j && caracPalpite == caracPalavra && pic_7.Image == null && resolveu[j] != true)
                            {
                                pic_7.Image = Properties.Resources.amarelo;
                                lbl_7.Text = caracPalpite.ToString();

                            }

                            else if (i == 1 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_7.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 2 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_8.Image = Properties.Resources.fundo_verde;
                                lbl_8.Text = caracPalpite.ToString();
                                resolveu[2] = true;

                            }

                            else if (i == 2 && i != j && caracPalpite == caracPalavra && pic_8.Image == null && resolveu[j] != true)
                            {

                                pic_8.Image = Properties.Resources.amarelo;
                                lbl_8.Text = caracPalpite.ToString();

                            }

                            else if (i == 2 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_8.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///

                            if (i == 3 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_9.Image = Properties.Resources.fundo_verde;
                                lbl_9.Text = caracPalpite.ToString();
                                resolveu[3] = true;

                            }

                            else if (i == 3 && i != j && caracPalpite == caracPalavra && pic_9.Image == null && resolveu[j] != true)
                            {
                                pic_9.Image = Properties.Resources.amarelo;
                                lbl_9.Text = caracPalpite.ToString();

                            }

                            else if (i == 3 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_9.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 4 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_10.Image = Properties.Resources.fundo_verde;
                                lbl_10.Text = caracPalpite.ToString();
                                resolveu[4] = true;
                            }

                            else if (i == 4 && i != j && caracPalpite == caracPalavra && pic_10.Image == null && resolveu[j] != true)
                            {
                                pic_10.Image = Properties.Resources.amarelo;
                                lbl_10.Text = caracPalpite.ToString();

                            }

                            else if (i == 4 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_10.Text = caracPalpite.ToString();
                            }

                        }

                    }
                }










                //tentativa 3
                if (Globals.tentativas == 3)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {

                            char caracPalpite = Globals.palpite[i];

                            char caracPalavra = Globals.palavra[j];


                            ///////////////// inicio linha 1 /////////////////

                            if (i == 0 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_11.Image = Properties.Resources.fundo_verde;
                                lbl_11.Text = caracPalpite.ToString();
                                resolveu[0] = true;

                            }

                            else if (i == 0 && i != j && caracPalpite == caracPalavra && pic_11.Image == null && resolveu[j] != true)
                            {

                                pic_11.Image = Properties.Resources.amarelo;
                                lbl_11.Text = caracPalpite.ToString();

                            }

                            else if (i == 0 && i != j && caracPalpite != caracPalavra)
                            {
                                lbl_11.Text = caracPalpite.ToString();

                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 1 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_12.Image = Properties.Resources.fundo_verde;
                                lbl_12.Text = caracPalpite.ToString();
                                resolveu[1] = true;

                            }

                            else if (i == 1 && i != j && caracPalpite == caracPalavra && pic_12.Image == null && resolveu[j] != true)
                            {
                                pic_12.Image = Properties.Resources.amarelo;
                                lbl_12.Text = caracPalpite.ToString();

                            }

                            else if (i == 1 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_12.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 2 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_13.Image = Properties.Resources.fundo_verde;
                                lbl_13.Text = caracPalpite.ToString();
                                resolveu[2] = true;

                            }

                            else if (i == 2 && i != j && caracPalpite == caracPalavra && pic_13.Image == null && resolveu[j] != true)
                            {

                                pic_13.Image = Properties.Resources.amarelo;
                                lbl_13.Text = caracPalpite.ToString();

                            }

                            else if (i == 2 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_13.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///

                            if (i == 3 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_14.Image = Properties.Resources.fundo_verde;
                                lbl_14.Text = caracPalpite.ToString();
                                resolveu[3] = true;

                            }

                            else if (i == 3 && i != j && caracPalpite == caracPalavra && pic_14.Image == null && resolveu[j] != true)
                            {
                                pic_14.Image = Properties.Resources.amarelo;
                                lbl_14.Text = caracPalpite.ToString();

                            }

                            else if (i == 3 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_14.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 4 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_15.Image = Properties.Resources.fundo_verde;
                                lbl_15.Text = caracPalpite.ToString();
                                resolveu[4] = true;
                            }

                            else if (i == 4 && i != j && caracPalpite == caracPalavra && pic_15.Image == null && resolveu[j] != true)
                            {
                                pic_15.Image = Properties.Resources.amarelo;
                                lbl_15.Text = caracPalpite.ToString();

                            }

                            else if (i == 4 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_15.Text = caracPalpite.ToString();
                            }

                        }

                    }
                }








                //tentativa 4
                if (Globals.tentativas == 4)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {

                            char caracPalpite = Globals.palpite[i];

                            char caracPalavra = Globals.palavra[j];


                            ///////////////// inicio linha 1 /////////////////

                            if (i == 0 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_16.Image = Properties.Resources.fundo_verde;
                                lbl_16.Text = caracPalpite.ToString();
                                resolveu[0] = true;

                            }

                            else if (i == 0 && i != j && caracPalpite == caracPalavra && pic_16.Image == null && resolveu[j] != true)
                            {

                                pic_16.Image = Properties.Resources.amarelo;
                                lbl_16.Text = caracPalpite.ToString();

                            }

                            else if (i == 0 && i != j && caracPalpite != caracPalavra)
                            {
                                lbl_16.Text = caracPalpite.ToString();

                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 1 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_17.Image = Properties.Resources.fundo_verde;
                                lbl_17.Text = caracPalpite.ToString();
                                resolveu[1] = true;

                            }

                            else if (i == 1 && i != j && caracPalpite == caracPalavra && pic_17.Image == null && resolveu[j] != true)
                            {
                                pic_17.Image = Properties.Resources.amarelo;
                                lbl_17.Text = caracPalpite.ToString();

                            }

                            else if (i == 1 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_17.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 2 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_18.Image = Properties.Resources.fundo_verde;
                                lbl_18.Text = caracPalpite.ToString();
                                resolveu[2] = true;

                            }

                            else if (i == 2 && i != j && caracPalpite == caracPalavra && pic_18.Image == null && resolveu[j] != true)
                            {

                                pic_18.Image = Properties.Resources.amarelo;
                                lbl_18.Text = caracPalpite.ToString();

                            }

                            else if (i == 2 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_18.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///

                            if (i == 3 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_19.Image = Properties.Resources.fundo_verde;
                                lbl_19.Text = caracPalpite.ToString();
                                resolveu[3] = true;

                            }

                            else if (i == 3 && i != j && caracPalpite == caracPalavra && pic_19.Image == null && resolveu[j] != true)
                            {
                                pic_19.Image = Properties.Resources.amarelo;
                                lbl_19.Text = caracPalpite.ToString();

                            }

                            else if (i == 3 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_19.Text = caracPalpite.ToString();
                            }

                            //////////////////////////////////////////////////////////////
                            ///


                            if (i == 4 && i == j && caracPalpite == caracPalavra)
                            {
                                pic_20.Image = Properties.Resources.fundo_verde;
                                lbl_20.Text = caracPalpite.ToString();
                                resolveu[4] = true;
                            }

                            else if (i == 4 && i != j && caracPalpite == caracPalavra && pic_20.Image == null && resolveu[j] != true)
                            {
                                pic_20.Image = Properties.Resources.amarelo;
                                lbl_20.Text = caracPalpite.ToString();

                            }

                            else if (i == 4 && i == j && caracPalpite != caracPalavra)

                            {

                                lbl_20.Text = caracPalpite.ToString();
                            }

                        }

                    }
                }

            }
            if (Globals.palpite == Globals.palavra)
            {
                string palavraMinus = Globals.palavra.ToLower();
                DialogResult popup = MessageBox.Show($" Você venceu! {Environment.NewLine} A palavra era: {palavraMinus} {Environment.NewLine} Tentativas: {Globals.tentativas}/4 {Environment.NewLine}{Environment.NewLine} Gostaria de jogar novamente?", "Tela de Resultados", MessageBoxButtons.OKCancel);

                if (popup == DialogResult.OK)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (Globals.palpite != Globals.palavra && Globals.tentativas == 4)
            {
                string palavraMinus = Globals.palavra.ToLower();
                DialogResult popup = MessageBox.Show($" Você perdeu! {Environment.NewLine} A palavra era: {palavraMinus} {Environment.NewLine} Tentativas: {Globals.tentativas}/4 {Environment.NewLine}{Environment.NewLine} Gostaria de jogar novamente?", "Tela de Resultados", MessageBoxButtons.OKCancel);

                if (popup == DialogResult.OK)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0);
                }

            }
        }


        private void btn_enviar_Click(object sender, EventArgs e)
        {

            Verificar();

        }

        private void box_guess_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void box_guess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Verificar();
            }
        }
    }
}
