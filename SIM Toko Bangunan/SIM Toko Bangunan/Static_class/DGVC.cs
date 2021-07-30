using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIM_Toko_Bangunan.Static_class
{
    class DGVC
    {

        public static void Setup_DGVC(DataGridView dgv, BindingSource bs)
        {
            try
            {
                if (!(bs.Count > 0))
                {
                    MessageBox.Show("No Records", "Table is Empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dgv.Columns[0].Visible = true;
                dgv.MultiSelect = false;
                dgv.AllowUserToResizeRows = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.RowHeadersVisible = true;

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                dgv.DefaultCellStyle.BackColor = Color.ForestGreen;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.HeaderCell.Style.Font = new Font("Microsoft Tai Le", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel);
                    col.HeaderCell.Style.ForeColor = Color.Black;
                    col.HeaderCell.Style.BackColor = Color.Snow;
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                }

                if (dgv.Rows.Count > 0)
                {
                    if (dgv.SelectedRows.Count <= 0) dgv.Rows[0].Selected = true;

                }
                dgv.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Setup Error" + Environment.NewLine + "Description" + ex.Message.ToString(), "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
