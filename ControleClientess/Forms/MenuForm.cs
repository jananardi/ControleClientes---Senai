namespace ControleClientess
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm cliente = new ClienteForm();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ladoALadoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ladoALadoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void íconesMinimizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CidadeForm cidade = new CidadeForm();
            cidade.MdiParent = this;
            cidade.Show();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicoForm servico = new ServicoForm();
            servico.MdiParent = this;
            servico.Show();
        }

        private void ordemdeServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdemDeServicoForm ordemDeServico = new OrdemDeServicoForm();
            ordemDeServico.MdiParent = this;
            ordemDeServico.Show();
        }
    }
}
