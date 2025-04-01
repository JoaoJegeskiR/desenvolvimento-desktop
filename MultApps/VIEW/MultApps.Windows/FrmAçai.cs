using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmAçai : Form
    {
        public FrmAçai()
        {
            InitializeComponent();
        }

        public class PedidoItem
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Preco { get; set; }

            public PedidoItem(string nome, int quantidade, decimal preco)
            {
                Nome = nome;
                Quantidade = quantidade;
                Preco = preco;
            }

            public override string ToString()
            {
                return $"{Nome} (x{Quantidade}) - R$ {Preco:F2}";
            }



        }

        private void btnSelecionar1_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açai 300ml", 1, 15.00m));
            listBoxPedidos.Visible = true;

        }

        private void btnSelecionar2_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açai 500ml", 1, 20.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnSelecionar3_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açai 700ml", 1, 25.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnSelecionar4_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açai 1L", 1, 35.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnGranola_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Granola", 1, 2.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnBanana_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Banana", 1, 2.50m));
            listBoxPedidos.Visible = true;
        }

        private void btnMorango_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Morango", 1, 3.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnConfetes_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Confetes", 1, 3.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnSucrilhos_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Sucrilhos", 1, 2.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnChocoball_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Chocoball", 1, 2.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnCobMorango_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Cobertura de Morango", 1, 2.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnCobLeiteCondensado_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Cobertura de Leite Condensado", 1, 2.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem != null)
            {
                listBoxPedidos.Items.Remove("Acai de 500 - 30 reais");
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }
    }
}
