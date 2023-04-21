using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.UI
{
    public static class Utilities
    {
        #region RadioButtons
        public static System.Windows.Forms.RadioButton? GetSelectedRadioButton(GroupBox gbx)
        {
            return gbx.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
        }
        public static void UnSelectAllRadioButtons(GroupBox gbx)
        {
            foreach (Control ctrl in gbx.Controls)
            {
                if (ctrl is System.Windows.Forms.RadioButton)
                    ((System.Windows.Forms.RadioButton)ctrl).Checked = false;
            }
        }
        public static void SelectRadioButton(GroupBox gbx, string buttonText)
        {
            foreach (Control ctrl in gbx.Controls)
            {
                if (ctrl is System.Windows.Forms.RadioButton)
                {
                    if (buttonText == ((System.Windows.Forms.RadioButton)ctrl).Text)
                    {
                        ((System.Windows.Forms.RadioButton)ctrl).Checked = true;
                    }
                }
            }
        }
        #endregion

        #region DataGridViews
        public static DataGridViewRow GetSelectedRow(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
                return dgv.SelectedRows[0];
            else
                return null;
        }
        public static DataGridViewCell GetSelectedRowCell(DataGridView dgv, int cellIndex)
        {
            return dgv.SelectedRows[0].Cells[cellIndex];
        }
        #endregion

        #region General
        public static bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }
        public static bool IsDecimal(string value)
        {
            return decimal.TryParse(value, out _);
        }

        public static bool IsValidCurrency(Control ctrl)
        {
            bool isValid = false;
            if (IsNumeric(ctrl.Text) || IsDecimal(ctrl.Text))            
                isValid = true;

            return isValid;
            
        }
        public static bool IsEmpty(Control ctrl)
        {
            return ctrl.Text == String.Empty;
        }
        public static string FormatCurrency(decimal value)
        {
            return string.Format("{0:C}", value);
        }
        public static string FormatCurrency(string value)
        {
            return (value == null || value == "None" || value == "-") ? "-" : string.Format("{0:C}", decimal.Parse(value));
        }
        #endregion
    }
}
