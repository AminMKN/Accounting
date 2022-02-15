using System;
using System.Windows.Forms;
using Accounting.Infrastructure.Contracts;
using Accounting.Tools;

namespace Accounting.Forms
{
    public partial class frmPrintBreakDown : Form
    {
        private readonly IPrintBreakDownRepository _printBreakDownRepository;

        public frmPrintBreakDown(IPrintBreakDownRepository printBreakDownRepository)
        {
            _printBreakDownRepository = printBreakDownRepository;
            InitializeComponent();
        }

        private void BindGrid()
        {
            dgvPrintBreakDown.DataSource = _printBreakDownRepository.GetAll();
            dgvPrintBreakDown.Columns["Id"].HeaderText = Convertors.Id;
            dgvPrintBreakDown.Columns["Code"].HeaderText = lblCode.Text;
            dgvPrintBreakDown.Columns["Name"].HeaderText = lblName.Text;
            dgvPrintBreakDown.Columns["Color"].HeaderText = lblColor.Text;
            dgvPrintBreakDown.Columns["Size"].HeaderText = lblSize.Text;
            dgvPrintBreakDown.Columns["Qty"].HeaderText = lblQty.Text;
            dgvPrintBreakDown.Columns["PercentBreakDown"].HeaderText = lblPercentage.Text;
            dgvPrintBreakDown.Columns["Description"].HeaderText = lblDescription.Text;
            dgvPrintBreakDown.Columns["Date"].HeaderText = lblDate.Text;
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

        private void frmPrintBreakDown_Load(object sender, EventArgs e)
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

                _printBreakDownRepository.Create(txtCode.Text, txtName.Text, txtColor.Text, txtSize.Text, txtQty.Text,
                    txtPercenBreakDown.Text, txtDescription.Text, txtDate.PersianDate.ToString());
                _printBreakDownRepository.SaveChanges();
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
                    if (dgvPrintBreakDown.CurrentRow != null)
                        _printBreakDownRepository.Delete((int)dgvPrintBreakDown.CurrentRow.Cells[0].Value);
                    _printBreakDownRepository.SaveChanges();
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
                    if (dgvPrintBreakDown.CurrentRow != null)
                        _printBreakDownRepository.Edit((int)dgvPrintBreakDown.CurrentRow.Cells[0].Value, txtCode.Text, txtName.Text, txtColor.Text, txtSize.Text, txtQty.Text,
                            txtPercenBreakDown.Text, txtDescription.Text, txtDate.PersianDate.ToString());
                    _printBreakDownRepository.SaveChanges();
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
                    dgvPrintBreakDown.DataSource = _printBreakDownRepository.SearchCode(txtSearchCode.Text);
                }
                else if (!string.IsNullOrWhiteSpace(txtSearchName.Text))
                {
                    dgvPrintBreakDown.DataSource = _printBreakDownRepository.SearchName(txtSearchName.Text);
                }
                else if (!string.IsNullOrWhiteSpace(txtSearchDate.Text))
                {
                    dgvPrintBreakDown.DataSource = _printBreakDownRepository.SearchDate(txtSearchDate.Text);
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

        private void dgvPrintBreakDown_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCode.Text = dgvPrintBreakDown.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dgvPrintBreakDown.CurrentRow.Cells[2].Value.ToString();
                txtColor.Text = dgvPrintBreakDown.CurrentRow.Cells[3].Value.ToString();
                txtSize.Text = dgvPrintBreakDown.CurrentRow.Cells[4].Value.ToString();
                txtQty.Text = dgvPrintBreakDown.CurrentRow.Cells[5].Value.ToString();
                txtPercenBreakDown.Text = dgvPrintBreakDown.CurrentRow.Cells[6].Value.ToString();
                txtDescription.Text = dgvPrintBreakDown.CurrentRow.Cells[7].Value.ToString();

            }
            catch
            {
                Messages.Failed();
            }
        }
    }
}
