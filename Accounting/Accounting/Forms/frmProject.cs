using System;
using System.Windows.Forms;
using Accounting.Infrastructure.Contracts;
using Accounting.Tools;

namespace Accounting.Forms
{
    public partial class frmProject : Form
    {
        private readonly IProjectRepository _projectRepository;

        public frmProject(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
            InitializeComponent();
        }

        private void BindGrid()
        {
            dgvProject.DataSource = _projectRepository.GetAll();
            dgvProject.Columns["Id"].HeaderText = Convertors.CodeAlpha;
            dgvProject.Columns["Code"].HeaderText = lblCode.Text;
            dgvProject.Columns["Name"].HeaderText = lblName.Text;
            dgvProject.Columns["Customer"].HeaderText = lblCustomer.Text;
            dgvProject.Columns["Date"].HeaderText = lblDate.Text;
            dgvProject.Columns["Qty"].HeaderText = lblQty.Text;
            dgvProject.Columns["BarCode"].HeaderText = lblBarcode.Text;
        }

        private void RefreshAll()
        {
            BindGrid();
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCustomer.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            txtSearchCustomer.Text = string.Empty;
            txtSearchCode.Text = string.Empty;
            txtSearchDate.Text = string.Empty;
        }

        private void frmProject_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDate.PersianDate.ToString() == string.Empty)
                {
                    Messages.EnterDate();
                    return;
                }

                _projectRepository.Create(txtCode.Text, txtName.Text, txtCustomer.Text, txtDate.PersianDate.ToString(), txtQty.Text, txtBarcode.Text);
                _projectRepository.SaveChanges();
                BindGrid();
                Messages.Success();
            }
            catch
            {
                Messages.Failed();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Messages.Question() == DialogResult.OK)
                {
                    if (dgvProject.CurrentRow != null)
                    {
                        _projectRepository.Delete((int)dgvProject.CurrentRow.Cells[0].Value);
                        _projectRepository.SaveChanges();
                        BindGrid();
                        Messages.Success();
                    }
                }
            }
            catch
            {
                Messages.Failed();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDate.PersianDate.ToString() == string.Empty)
                {
                    Messages.EnterDate();
                    return;
                }

                if (Messages.Question() == DialogResult.OK)
                {
                    if (dgvProject.CurrentRow != null)
                    {
                        _projectRepository.Edit((int)dgvProject.CurrentRow.Cells[0].Value, txtCode.Text, txtName.Text,
                            txtCustomer.Text, txtDate.PersianDate.ToString(), txtQty.Text, txtBarcode.Text);
                        _projectRepository.SaveChanges();
                        BindGrid();
                        Messages.Success();
                    }

                }
            }
            catch
            {
                Messages.Failed();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtSearchCode.Text))
                {
                    dgvProject.DataSource = _projectRepository.SearchCode(txtSearchCode.Text);
                }
                else if (!string.IsNullOrWhiteSpace(txtSearchCustomer.Text))
                {
                    dgvProject.DataSource = _projectRepository.SearchCustomer(txtSearchCustomer.Text);
                }
                else if (!string.IsNullOrWhiteSpace(txtSearchDate.Text))
                {
                    dgvProject.DataSource = _projectRepository.SearchDate(txtSearchDate.Text);
                }
            }
            catch
            {
                Messages.Failed();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void dgvProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCode.Text = dgvProject.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dgvProject.CurrentRow.Cells[2].Value.ToString();
                txtCustomer.Text = dgvProject.CurrentRow.Cells[3].Value.ToString();
                txtQty.Text = dgvProject.CurrentRow.Cells[5].Value.ToString();
                txtBarcode.Text = dgvProject.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                Messages.Failed();
            }
        }
    }
}
