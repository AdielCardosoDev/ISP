using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InfoSys
{
    public partial class FormCadCliente : Form
    {
        int id = 0;
        private bool SoNumero;
        public FormCadCliente(int id)
        {
            InitializeComponent();
            this.id = id; if (this.id > 0) GetClientes(id);

            BloqueaBtn();
        }

        public void BloqueaBtn()
        {
            if(id == 0)
            {
                btn_limpar.Enabled = false;
                Btn_Excluir.Enabled = false;
            }
        }

        //Metodo buscar clientes
        public void GetClientes(int id)
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(Conexao.StringConexao))
                {
                    cn.Open();

                    var sqlSt = "SELECT *FROM CLIENTE WHERE ID=" + id;

                    using (SqlCommand cmd = new SqlCommand(sqlSt, cn))
                    {
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    text_nome.Text = dr["Nome"].ToString();
                                    text_CNPJ.Text = dr["CNPJ"].ToString();
                                    text_CodExterno.Text = dr["CodExterno"].ToString();
                                    text_Supervisor.Text = dr["Supervisor"].ToString();
                                    text_Link.Text = dr["Link"].ToString();
                                    text_Informacoes.Text = dr["Informacoes"].ToString();
                                    
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Que pena, algo deu errado!" + ex, "Poxa");
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja Sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            using(SqlConnection cn = new SqlConnection(Conexao.StringConexao))
            {
                cn.Open();

                var sqlSt = "";

                if(this.id == 0)
                    sqlSt = "INSERT INTO CLIENTE (Nome, CNPJ, CodExterno, Supervisor, Link, Informacoes) VALUES (@Nome, @CNPJ, @CodExterno, @Supervisor, @Link, @Informacoes)";
                else
                    sqlSt = "UPDATE CLIENTE SET Nome=@Nome, CNPJ=@CNPJ, CodExterno=@CodExterno, Supervisor=@Supervisor, Link=@Link, Informacoes=@Informacoes WHERE id=" + this.id;
                
                if (text_nome.Text == "" || text_CNPJ.Text == "" || text_Supervisor.Text == "" || text_Informacoes.Text == "" )
                {
                    MessageBox.Show("Opá, precisa preencher os campos obrigatórios.", "ATENÇÃO");
                }
                else
                {
                    try
                    {
                        using(SqlCommand cmd = new SqlCommand(sqlSt, cn))
                        {
                            cmd.Parameters.AddWithValue("@Nome", text_nome.Text);
                            cmd.Parameters.AddWithValue("@CNPJ", text_CNPJ.Text);
                            cmd.Parameters.AddWithValue("@CodExterno", int.Parse(text_CodExterno.Text));
                            cmd.Parameters.AddWithValue("@Supervisor", text_Supervisor.Text);
                            cmd.Parameters.AddWithValue("@Link", text_Link.Text);
                            cmd.Parameters.AddWithValue("@Informacoes", text_Informacoes.Text);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Boa Campeão, Tudo Certo", "Aviso!");
                        text_nome.Text = "";
                        text_CNPJ.Text = "";
                        text_CodExterno.Text = "";
                        text_Supervisor.Text = "";
                        text_Link.Text = "";
                        text_Informacoes.Text = "";                        

                    }
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show("Que pena, algo deu errado!" + ex, "Poxa");
                    }
                    ListaRegistros();

                }

            }
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            ListaRegistros();
        }

        //Metodo Configuração do DataGrid
        public void configuraDataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "CNPJ/CPF";
            dataGridView1.Columns[3].HeaderText = "Código Externo";
            dataGridView1.Columns[4].HeaderText = "Supervisores";
            dataGridView1.Columns[5].HeaderText = "link";
            dataGridView1.Columns[6].HeaderText = "Informações";


            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;

        }

        //Metodo Listar registro do banco
        public void ListaRegistros()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringConexao))
                {
                    cn.Open();

                    var sqlQuere = "SELECT *FROM CLIENTE";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuere, cn))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }

                    configuraDataGridView();

                    //Total de Registros
                    double Total = 0;
                    foreach (DataGridViewRow linha in dataGridView1.Rows)
                    {
                        Total = dataGridView1.RowCount;
                    }
                    labelTotaldeRegistro.Text = " Total de Registros: " + Total;
                }
            }
            catch
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringConexao))
                {
                    cn.Open();
                    MessageBox.Show("");
                }
            }
        }

        //Metodo Excluir Registro
        public void ExcluirRegistro()
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(Conexao.StringConexao))
                {
                    cn.Open();

                    var sql = "Delete From CLIENTE WHERE ID=" + id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    text_nome.Text = "";
                    text_CNPJ.Text = "";
                    text_CodExterno.Text = "";
                    text_Supervisor.Text = "";
                    text_Link.Text = "";
                    text_Informacoes.Text = "";                    
                    id = 0;
                    ListaRegistros();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao excluir o registro!\n\n" + ex.Message);
            }
        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {
            ListaRegistros();
        }

        private void text_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                
            }
        }

        private void text_CodExterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero", "Atenção");
            }
        }

        private void pictureBoxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if(id <= 0)
            {
                MessageBox.Show("Selecione um Registro", "Atenção");
            }
            else
            {
                DialogResult resp = MessageBox.Show("Deseja Exlcuir:", "Exluir Registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    ExcluirRegistro();
                    ListaRegistros();
                    id = 0;
                }
            }
            
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            FormCadCliente frm = new FormCadCliente(id);
            frm.ShowDialog();
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {            
            
            if(id > 0)
            {
                
                text_nome.Text = "";
                text_CNPJ.Text = "";
                text_CodExterno.Text = "";
                text_Supervisor.Text = "";
                text_Link.Text = "";
                text_Informacoes.Text = "";
                id = 0;


            }

        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if(ValidarBuscar())            
                Buscar();
            
        }

        private bool ValidarBuscar()
        {
            if(cbx_Buscar.Text == "")
            {
                MessageBox.Show("Selecione o campo a ser pesquisado!");
                cbx_Buscar.Focus();
                return false;
            }
            else if(text_Buscar.Text == "")
            {
                MessageBox.Show("Campo buscar é orbigatório, digite algo!");
                text_Buscar.Focus();
                return false;
            }
            return true;
        }

        private void Buscar()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringConexao))
                {
                    cn.Open();

                    var sql = "SELECT * FROM CLIENTE WHERE ";
                    // Nome like '%" + text_Buscar.Text + "%' Order by Nome


                    switch (cbx_Buscar.Text)
                    {
                        case "Nome":
                            sql += "Nome Like '%"+ text_Buscar.Text + "%' ";
                            break;
                        case "CNPJ/CPF":
                            sql += "CNPJ Like '%" + text_Buscar.Text + "%' ";
                            break;
                        case "Cod. Externo":
                            sql += "CodExterno Like '%" + text_Buscar.Text + "%' ";
                            break;
                    }
                    sql += " Order by Nome";



                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Que pena, algo deu errado!" + ex, "Poxa");
            }
        }

        private void cbx_Buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_Buscar.Text = "";
            if(cbx_Buscar.SelectedItem.ToString() == "CNPJ/CPF" || cbx_Buscar.SelectedItem.ToString() == "Cod. Externo")
            {
                SoNumero = true;
            }
            else
            {
                SoNumero = false;
            }
        }

        private void text_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SoNumero)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo aceita somente numero", "Atenção");
                }

            }
        }
    }
}
