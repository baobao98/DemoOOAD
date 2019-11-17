using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Singleton
{
    public class Singleton
    {
        private Form _frm;
        private static readonly Singleton instance = new Singleton();
        static Singleton()
        {
        }

        private Singleton()
        {
            _frm = new FormSingleton();

        }

        public void showForm()
        {
            _frm.ShowDialog();
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
