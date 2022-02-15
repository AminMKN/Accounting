using System;
using System.Windows.Forms;
using Accounting.Infrastructure.Contracts;
using Accounting.Tools;

namespace Accounting.Forms
{
    public partial class frmSewingBreakDown : Form
    {
        private readonly ISewingBreakDownRepository _sewingBreakDownRepository;

        public frmSewingBreakDown(ISewingBreakDownRepository sewingBreakDownRepository)
        {
            _sewingBreakDownRepository = sewingBreakDownRepository;
            InitializeComponent();
        }

        private void BindGrid()
        {
            dgvSewingBreakDown.DataSource = _sewingBreakDownRepository.GetAll();
            dgvSewingBreakDown.Columns["Id"].HeaderText = Convertors.Id;
            dgvSewingBreakDown.Columns["Code"].HeaderText = lblCode.Text;
            dgvSewingBreakDown.Columns["Name"].HeaderText = lblName.Text;
            dgvSewingBreakDown.Columns["Color"].HeaderText = lblColor.Text;
            dgvSewingBreakDown.Columns["Size"].HeaderText = lblSize.Text;
            dgvSewingBreakDown.Columns["Qty"].HeaderText = lblQty.Text;
            dgvSewingBreakDown.Columns["PercentBreakDown"].HeaderText = lblPercentage.Text;
            dgvSewingBreakDown.Columns["Description"].HeaderText = lblDescription.Text;
            dgvSewingBreakDown.Columns["Date"].HeaderText = lblDate.Text;
        }

        private void RefreshAll()
        {
            BindGrid();
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtSize.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtPercenBreakDown.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtSearchName.Text = string.Empty;
            txtSearchCode.Text = string.Empty;
            txtSearchDate.Text = string.Empty;
        }

        private void frmSewingBreakDown_Load(object sender, EventArgs e)
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

                _sewingBreakDownRepository.Create(txtCode.Text, txtName.Text, txtColor.Text, txtSize.Text, txtQty.Text,
                    txtPercenBreakDown.Text, txtDescription.Text, txtDate.PersianDate.ToString());
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
                    if (dgvSewingBreakDown.CurrentRow != null)
                        _sewingBreakDownRepository.Delete((int)dgvSewingBreakDown.CurrentRow.Cells[0].Value);

                    BindGrid();
                    Messages.Success();
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
                    if (dgvSewingBreakDown.CurrentRow != null)
                        _sewingBreakDownRepository.Edit((int)dgvSewingBreakDown.CurrentRow.Cells[0].Value, txtCode.Text, txtName.Text, txtColor.Text, txtSize.Text, txtQty.Text,
                            txtPercenBreakDown.Text, txtDescription.Text, txtDate.PersianDate.ToString());
                    BindGrid();
                    Messages.Success();
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
                    dgvSewingBreakDown.DataSource = _sewingBreakDownRepository.SearchCode(txtSearchCode.Text);
                }
                else if (!string.IsNullOrWhiteSpace(txtSearchName.Text))
                {
                    dgvSewingBreakDown.DataSource = _sewingBreakDownRepository.SearchName(txtSearchName.Text);
                }
                else if (!string.IsNullOrWhiteSpace(txtSearchDate.Text))
                {
                    dgvSewingBreakDown.DataSource = _sewingBreakDownRepository.SearchDate(txtSearchDate.Text);
                }
            }
            catch
            {
                // ignored
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void dgvSewingBreakDown_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCode.Text = dgvSewingBreakDown.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dgvSewingBreakDown.CurrentRow.Cells[2].Value.ToString();
                txtColor.Text = dgvSewingBreakDown.CurrentRow.Cells[3].Value.ToString();
                txtSize.Text = dgvSewingBreakDown.CurrentRow.Cells[4].Value.ToString();
                txtQty.Text = dgvSewingBreakDown.CurrentRow.Cells[5].Value.ToString();
                txtPercenBreakDown.Text = dgvSewingBreakDown.CurrentRow.Cells[6].Value.ToString();
                txtDescription.Text = dgvSewingBreakDown.CurrentRow.Cells[7].Value.ToString();

            }
            catch
            {
                // ignored
            }
        }
    }
}
