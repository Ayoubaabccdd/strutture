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


        public struct ricerca
        {
            public string nome;
            public float prezzo;
        }

        public int RicercaS(string e, prodotto[] p, int dim)
        {
            int risultatoricerca = 0;
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == e)
                {
                    risultatoricerca = i;
                    break;
                }

            }
            return risultatoricerca;
        }


        private void modi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modifica_Click(object sender, EventArgs e)
        {

            int x = RicercaS(modi.Text, p, dim);
            if (x != -1)
            {
                //modifica
                p[x].nome = modinome1.Text;
                p[x].prezzo = float.Parse(modiprezzo.Text);
                visualizza(p);
            }
            else
            {
                MessageBox.Show("Elemento Non trovato");
            }
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void modinome_Click(object sender, EventArgs e)
        {

        }

        private void Cancella_Click(object sender, EventArgs e)
        {
            CancellaS(modi.Text, p, ref dim);
        }

        public void CancellaS(string e, prodotto[] p, ref int dim)
        {

            int x = RicercaS(modi.Text, p, dim);
            if (x == -1)
            {
                MessageBox.Show("Elemento non trovato!", "Errore!");
            }
            else
            {
                for (int j = x; j < dim - 1; j++)
                {
                    p[j] = p[j + 1];
                }
                dim++;
                visualizza(p);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Somma_Click(object sender, EventArgs e)
        {
            float somma = 0;
            for (int j = 0; j < dim; j++)
            {
                somma = p[j].prezzo + somma;
            }
            MessageBox.Show("il totale è: " + somma.ToString()+ "€");
        }
        //percentuale al prodotto
        private void button1_Click(object sender, EventArgs e)
        {
            float a=0;
            for (int j = 0; j < dim; j++)
            {
                a = (p[j].prezzo / 100) * float.Parse(modip.Text);
               
            }
            for (int k = 0; k < dim; k++)
            {
                p[k].prezzo = p[k].prezzo - a;
            }
            visualizza(p);
        }
        public void RicercaMinMax(ref int dim)
        {
            float min = p[0].prezzo;
            float max = p[0].prezzo;
            for (int i = 1; i < dim; i++)
            {
                if (p[i].prezzo > max)
                {
                    max = p[i].prezzo;
                }
                if (p[i].prezzo < min)
                {
                    min = p[i].prezzo;
                }
            }
            MessageBox.Show($"Il prezzo più basso è di {min.ToString("0.00")}€, mentre quello più alto è di {max.ToString("0.00")}€");
        }
        public void button2_Click(object sender, EventArgs e)
        {
            RicercaMinMax(ref dim);

        }
    }
}

