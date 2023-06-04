using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class HomeView : Form
    {
        ArrayList receitas = new ArrayList();
        ArrayList despesas = new ArrayList();
        public HomeView()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaGrid();                          // Pode carregar o Grid com Dados
        }

        private void CarregaGrid()                       // Função para Carregar/Montar Grid
        {
            if (receitas.Count == 0)
                return;
            carregaGridReceitas();
            if (despesas.Count == 0)
                return;
            carregaGridDespesas();
        }

        private void carregaGridReceitas()
        {
            dataGridReceitas.DataSource = null;
            dataGridReceitas.DataSource = receitas;
            setupGridStyle(dataGridReceitas);
        }
        private void carregaGridDespesas()
        {
            dataGridDespesas.DataSource = null;
            dataGridDespesas.DataSource = despesas;
            setupGridStyle(dataGridDespesas);
        }
        private void setupGridStyle(DataGridView dataGrid)
        {
            dataGrid.ClearSelection();
            dataGrid.Columns[0].Width = 380;
            dataGrid.Columns[1].Width = 80;
            dataGrid.Columns[2].Visible = false;
        }

        private void buttonAddReceita_Click(object sender, EventArgs e)
        {
            Lancamento receita = new Receita("", 0.0, new DateTime());
            receitas.Add(receita);
            carregaGridReceitas();
        }

        private void buttonAddDespesa_Click(object sender, EventArgs e)
        {
            Lancamento despesa = new Despesa("", 0.0, new DateTime());
            despesas.Add(despesa);
            carregaGridDespesas();
        }

        private void dataGridReceitas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Lancamento novaReceita = new Receita();
            novaReceita.Descricao = Convert.ToString(dataGridReceitas.CurrentRow.Cells[0].Value);
            novaReceita.Value = Convert.ToDouble(dataGridReceitas.CurrentRow.Cells[1].Value);
            novaReceita.Data = DateTime.Now; // trocar posteriormente por data selecionada

            receitas[dataGridReceitas.CurrentRow.Index] = novaReceita;
        }

        private void dataGridDespesas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Lancamento novaDespesa = new Receita();
            novaDespesa.Descricao = Convert.ToString(dataGridDespesas.CurrentRow.Cells[0].Value);
            novaDespesa.Value = Convert.ToDouble(dataGridDespesas.CurrentRow.Cells[1].Value);
            novaDespesa.Data = DateTime.Now; // trocar posteriormente por data selecionada

            despesas[dataGridDespesas.CurrentRow.Index] = novaDespesa;
        }
    }
}