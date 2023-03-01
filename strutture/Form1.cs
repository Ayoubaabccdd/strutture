using System;

using System.Windows.Forms;

namespace strutture
{
    public partial class Form1 : Form
    {
        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto[] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salva_Click(object sender, EventArgs e)
        {
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            dim++;
            visualizza(p);

        }
        public string prodString(prodotto p)
        {
            return "Nome:" + p.nome + " prezzo:" + p.prezzo.ToString();
        }
        public void visualizza(prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(p[i]));
            }
        }

        private void visu_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(p[i]));
            }
        }

        private void modifica_Click(object sender, EventArgs e)
        {

            p[dim].nome = modifica.Text;

            int y=0;
            ricercamod(p, y);
        }
        public struct ricerca
        {
            public string nome;
            public float prezzo;
        }
        public void ricercamod(int[] vet, int dim)
        {
            int x = 30, y = 30;
            int cerca = 0;
            int conta = 0;
            bool trovato = false;
            int[] array = new int[dim];
            do
            {
                if (vet[conta] == cerca);
                {
                    trovato = true;
                }


            } while (((conta < x) && (trovato = false)) || (array[conta] > cerca));

        }
        private void modi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
