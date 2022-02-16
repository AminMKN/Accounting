using System;
using System.Windows.Forms;
using Accounting.Infrastructure.Contracts;
using Accounting.Tools;

namespace Accounting.Forms
{
    public partial class frmRemainingReport : Form
    {
        private readonly IRemainingReportRepository _remainingReportRepository;

        public frmRemainingReport(IRemainingReportRepository remainingReportRepository)
        {
            _remainingReportRepository = remainingReportRepository;
            InitializeComponent();
        }

        private void BindGrid()
        {
            dgvRemainingReport.DataSource = _remainingReportRepository.GetAll();
            dgvRemainingReport.Columns["Id"].HeaderText = Convertors.Id;
            dgvRemainingReport.Columns["Code"].HeaderText = lblCode.Text;
            dgvRemainingReport.Columns["Name"].HeaderText = lblName.Text;
            dgvRemainingReport.Columns["Color"].HeaderText = lblColor.Text;
            dgvRemainingReport.Columns["Size"].HeaderText = lblSize.Text;
            dgvRemainingReport.Columns["Qty"].HeaderText = lblQty.Text;
            dgvRemainingReport.Columns["Percentage"].HeaderText = lblPercentage.Text;
            dgvRemainingReport.Columns["Type"].HeaderText = lblType.Text;
            dgvRemainingReport.Columns["Description"].HeaderText = lblDescription.Text;
            dgvRemainingReport.Columns["Date"].HeaderText = lblDate.Text;
        }

        private void RefreshAll()
        {
            BindGrid();
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtSize.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtPercentage.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtSearchName.Text = string.Empty;
            txtSearchCode.Text = string.Empty;
            txtSearchDate.Text = string.Empty;
            txtType.SelectedIndex = -1;
        }

        private void frmRemainingReport_Load(object sender, EventArgs e)
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

                _remainingReportRepository.Create(txtCode.Text, txtName.Text, txtColor.Text, txtSize.Text, txtQty.Text,
                    txtPercentage.Text, txtType.Text, txtDescription.Text, txtDate.PersianDate.ToString());
                _remainingReportRepository.SaveChanges();
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
                    if (dgvRemainingReport.CurrentRow != null)
                    {
                        _remainingReportRepository.Delete((int)dgvRemainingReport.CurrentRow.Cells[0].Value);
                        _remainingReportRepository.SaveChanges();
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
                    if (dgvRemainingReport.CurrentRow != null)
                    {
                        _remainingReportRepository.Edit((int)dgvRemainingReport.CurrentRow.Cells[0].Value, txtCode.Text, txtName.Text, txtColor.Text, txtSize.Text, txtQty.Text,
                            txtPercentage.Text, txtType.Text, txtDescription.Text, txtDate.PersianDate.ToString());
                        _remainingReportRepository.SaveChanges();
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
                    dgvRemainingReport.DataSource = _remainingReportRepository.SearchCode(txtSearchCode.Text);
                }
                else if (!string.IsNullOrWhiteSpace(txtSearchName.Text))
                {
                    dgvRemainingReport.DataSource = _remainingReportRepository.SearchName(txtSearchName.Text);
                }
                else if (!string.IsNullOrWhiteSpace(txtSearchDate.Text))
                {
                    dgvRemainingReport.DataSource = _remainingReportRepository.SearchDate(txtSearchDate.Text);
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

        private void dgvRemainingReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCode.Text = dgvRemainingReport.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dgvRemainingReport.CurrentRow.Cells[2].Value.ToString();
                txtColor.Text = dgvRemainingReport.CurrentRow.Cells[3].Value.ToString();
                txtSize.Text = dgvRemainingReport.CurrentRow.Cells[4].Value.ToString();
                txtQty.Text = dgvRemainingReport.CurrentRow.Cells[5].Value.ToString();
                txtPercentage.Text = dgvRemainingReport.CurrentRow.Cells[6].Value.ToString();
                txtType.Text = dgvRemainingReport.CurrentRow.Cells[7].Value.ToString();
                txtDescription.Text = dgvRemainingReport.CurrentRow.Cells[8].Value.ToString();

            }
            catch
            {
                Messages.Failed();
            }
        }
    }
}
