using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EliteSmile.Classes
{
    class MasterClass
    {

        //دالة تقوم بتلوين صفوف الجدول داتا جريد  (صف بصف) لون بلون
        public static void ApplyRowStyle(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv != null)
            {
                if (e.RowIndex % 2 == 0)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke; // لون للسطر الزوجي
                }
                else
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gainsboro; // لون للسطر الفردي
                }
            }
        }

        public static void DataGrid_CellPainting(
                                DataGridView dataGridView1,
                                DataGridViewCellPaintingEventArgs e,
                                string searchText,
                                string columnName,
                                TextBox txtSearchBox,
                                bool isRightToLeft = false)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == columnName)
            {
                searchText = txtSearchBox.Text.Trim();

                if (!string.IsNullOrEmpty(searchText))
                {
                    string cellText = Convert.ToString(e.FormattedValue);
                    int startIndex = cellText.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

                    if (startIndex >= 0)
                    {
                        e.Handled = true;
                        e.PaintBackground(e.CellBounds, true);

                        using (SolidBrush normalBrush = new SolidBrush(e.CellStyle.ForeColor))
                        using (SolidBrush highlightBackBrush = new SolidBrush(Color.BlanchedAlmond))
                        {
                            e.PaintContent(e.CellBounds);

                            SizeF textSize = e.Graphics.MeasureString(cellText, e.CellStyle.Font);
                            float textHeight = textSize.Height;

                            SizeF beforeMatchSize = e.Graphics.MeasureString(cellText.Substring(0, startIndex), e.CellStyle.Font);
                            SizeF matchSize = e.Graphics.MeasureString(searchText, e.CellStyle.Font);

                            RectangleF highlightRect;
                            if (!isRightToLeft) // ← الاتجاه من اليسار إلى اليمين
                            {
                                float matchX = e.CellBounds.Left + beforeMatchSize.Width + 2;
                                highlightRect = new RectangleF(
                                    matchX,
                                    e.CellBounds.Y + (e.CellBounds.Height - textHeight) / 2,
                                    matchSize.Width,
                                    textHeight
                                );
                            }
                            else // ← الاتجاه من اليمين إلى اليسار
                            {
                                float matchX = e.CellBounds.Right - beforeMatchSize.Width - matchSize.Width - 2;
                                highlightRect = new RectangleF(
                                    matchX,
                                    e.CellBounds.Y + (e.CellBounds.Height - textHeight) / 2,
                                    matchSize.Width,
                                    textHeight
                                );
                            }

                            e.Graphics.FillRectangle(highlightBackBrush, highlightRect);
                            e.Graphics.DrawString(
                                searchText,
                                e.CellStyle.Font,
                                normalBrush,
                                highlightRect.Location
                            );
                        }
                    }
                }
            }
        }



        public static void DataGridCellPainting(DataGridView dataGridView1, DataGridViewCellPaintingEventArgs e, string columnName, TextBox txtSearchBox)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == columnName)
            {
                string searchText = txtSearchBox.Text.Trim();

                if (!string.IsNullOrEmpty(searchText))
                {
                    string cellText = Convert.ToString(e.FormattedValue);
                    int startIndex = cellText.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

                    if (startIndex >= 0)
                    {
                        e.Handled = true;
                        e.PaintBackground(e.CellBounds, true);

                        // استخدم خط العمود بدلًا من خط الخلية إن وجد
                        Font cellFont = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font
                        ?? dataGridView1.Columns[e.ColumnIndex].DefaultCellStyle.Font
                        ?? e.CellStyle.Font;
                        using (SolidBrush normalBrush = new SolidBrush(e.CellStyle.ForeColor))
                        using (SolidBrush highlightBackBrush = new SolidBrush(Color.BlanchedAlmond))
                        {
                            e.PaintContent(e.CellBounds);

                            SizeF textSize = e.Graphics.MeasureString(cellText, cellFont);
                            float textHeight = textSize.Height;

                            SizeF beforeMatchSize = e.Graphics.MeasureString(cellText.Substring(0, startIndex), cellFont);
                            SizeF matchSize = e.Graphics.MeasureString(searchText, cellFont);

                            RectangleF highlightRect;

                            // حدد الاتجاه من خصائص الـ DataGridView
                            bool isRightToLeft = dataGridView1.RightToLeft == RightToLeft.Yes;

                            if (!isRightToLeft) // من اليسار لليمين
                            {
                                float matchX = e.CellBounds.Left + beforeMatchSize.Width + 2;
                                highlightRect = new RectangleF(
                                    matchX,
                                    e.CellBounds.Y + (e.CellBounds.Height - textHeight) / 2,
                                    matchSize.Width,
                                    textHeight
                                );
                            }
                            else // من اليمين لليسار
                            {
                                float matchX = e.CellBounds.Right - beforeMatchSize.Width - matchSize.Width - 2;
                                highlightRect = new RectangleF(
                                    matchX,
                                    e.CellBounds.Y + (e.CellBounds.Height - textHeight) / 2,
                                    matchSize.Width,
                                    textHeight
                                );
                            }

                            e.Graphics.FillRectangle(highlightBackBrush, highlightRect);
                            e.Graphics.DrawString(
                                searchText,
                                cellFont,
                                normalBrush,
                                highlightRect.Location
                            );
                        }
                    }
                }
            }
        }


        private static Image ResizeImageByHeight(Image originalImage, int targetHeight)
        {
            if (originalImage == null)
                return null;

            float aspectRatio = (float)originalImage.Width / originalImage.Height;
            int targetWidth = (int)(targetHeight * aspectRatio);
            return new Bitmap(originalImage, new Size(targetWidth, targetHeight));
        }

        public static void ResizeButtonImageByHeight(Button btn, int targetHeight)
        {
            if (btn == null || btn.Image == null) return;

            btn.Image = ResizeImageByHeight(btn.Image, targetHeight);
            btn.ImageAlign = ContentAlignment.MiddleLeft;
        }

        public static void ResizeToolStripMenuItemImageByHeight(ToolStripMenuItem item, int targetHeight)
        {
            if (item == null || item.Image == null) return;

            item.Image = ResizeImageByHeight(item.Image, targetHeight);
            item.ImageScaling = ToolStripItemImageScaling.None;
        }

    }
}
