using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Singleton
{
    /*
     * WORK FLOW
     * Có 2 button tên tương ứng với ý nghĩa của nó
     * Form thường mỗi lần được click sẽ tạo mới một instance và reset lại các elements bên trong
     * Đối với Form được khởi tạo bằng singleton: chỉ tạo 1 instance duy nhất
     * ---DEMO
     * bấm vào nút để mở form rồi đóng form mới xuất hiện đó và bấm nút mở lại 
     * Expected result: form thường sẽ tạo mới || form singleton sẽ giữ nguyên thành phần bài hát được tick
     * 
     */
    public partial class FormMain : Form
    {
        int index = 1;
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnFrmThuong_Click(object sender, EventArgs e)
        {
            Form formNormal = new FormNormal(index);
            formNormal.Show();
            index++;
        }

        private void BtnFrmSingleton_Click(object sender, EventArgs e)
        {
           Singleton singleton = Singleton.Instance;
           singleton.showForm();
            
        }
    }
}
