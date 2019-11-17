using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_MidtermTest
{
    public partial class frmDemoStateCodeBehind : Form
    {
        PhichCam2Chan phichCam2Chan;
        PhichCam3Chan phichCam3Chan;

        /*
         * WORK FLOW
         * Có 2 loại phích cắm: 2 chấu và 3 chấu kết nối tới ổ cắm
         * Ổ Cắm chỉ nhận phích 2 chấu và thực hiện chức năng kiểm tra nguồn cắm điện của 2 chấu | set = 1: hoạt động, 0: không hoạt động
         * Vì chấu 3 chấu không tương thích với ổ cắm
         * Sử dụng 1 adapter implement từ interface class 2 chấu: để convert từ phích 3 chấu thành (input) thành tín hiệu 2 chấu mà ổ điện có thể hiểu
         * ---------
         * frmDemoStateCodeBehind: có nhiệm vụ thể hiện trạng thái của các chức năng
         * frmUI: thêm code UI: hình cục sạc: 2 chấu, 3 chấu; hình máy tính => bật/tắt, hình && code animation vào đúng class để thực hiện
        */
        public frmDemoStateCodeBehind()
        {
            InitializeComponent();

            phichCam2Chan = new PhichCam2Chan(1, 1);
            phichCam3Chan =  new PhichCam3Chan(1, 1, 1);
        }

        private void Btn_KetNoi_Click(object sender, EventArgs e)
        {
            // 1. Check option combobox
            // 2. Check using Adapter [ chỉ ở phích 3 chấu ]
            // 3. Show result

            if (cb_PhichCam.Text == "Phich Cam 2 Chan")
            {
                if (O_Dien.KetNoi(this.phichCam2Chan) == true)
                {
                    lbl_KetQua.Text = "Hoạt động [ Phích 2 chân ]";
                }
                else
                {
                    lbl_KetQua.Text = "Không kết nối được! vui lòng kiểm tra nguồn";
                }
            }

            if (cb_PhichCam.Text == "Phich Cam 3 Chan")
            {
                if (ck_adapter.Checked)
                {
                    //using adapter
                    Adapter_03Phich_to_02Phich adapter_03Phich_To_02Phich = new Adapter_03Phich_to_02Phich(phichCam3Chan);

                    if (O_Dien.KetNoi(adapter_03Phich_To_02Phich.convert()) == true)
                    {
                        lbl_KetQua.Text = "Hoạt động [ Phích 3 chân ]";
                    }
                    else
                        lbl_KetQua.Text = "Không kết nối được! vui lòng kiểm tra nguồn";
                }
                else
                {
                    lbl_KetQua.Text = "Không kết nối được do khác cấu trúc!!";
                }
            }
        }
    }
}
