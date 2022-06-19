using DevExpress.XtraPrinting.BarCode;
using Do_an_Co_so.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;

namespace Do_an_Co_so
{
    public partial class F_thanh_toan_momo : Form
    {
        private string so_tien;
        public F_thanh_toan_momo(int id_pg,int id_bannn,int tt)
        {
            InitializeComponent();
            so_tien = tt.ToString();
            _id_phieu_goi = id_pg;
            _id_ban = id_bannn;

            CultureInfo culture = new CultureInfo("vi-VN");
            label_tt.Text = tt.ToString("c", culture);
        }
        private int _id_phieu_goi;
        private int _id_ban;

        private void custom_btn1_Click(object sender, EventArgs e)
        {
            if(custom_btn1.Text== "Lấy mã")
            {
                string sdt = "0373019800";
                string ho_ten = "Bùi Chánh Tín";
                string email = "tin0373019800@gmail.com";
                var qrcode_text = $"2|99|{sdt.Trim()}|{ho_ten.Trim()}|{email.Trim()}|0|0|{so_tien.Trim()}";

                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 317, Height = 317, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.Level1);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(qrcode_text);
                Bitmap logo = resizeImage(Properties.Resources.momo, 32, 32) as Bitmap;
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));

                pictureBox1.BackgroundImage = bitmap;

                custom_btn2.Visible = true;
                custom_btn1.Text = "Thanh toán";
                custom_btn1.BackColor = Color.FromArgb(227, 75, 142);
            }
            else
            {
                DataProvider.Thuc_Thi.Thuc_hien_cau_truy_van("thanh_toan @id_phieu_goi_mon , @id_ban ", new object[] { _id_phieu_goi, _id_ban });
                MessageBox.Show("Thanh toán bằng momo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void custom_btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
