using System;
using System.Linq;

namespace Testuje
{
    public partial class Aplikacja : DevExpress.XtraEditors.XtraForm
    {
        public Aplikacja()
        {
            InitializeComponent();
        }

        #region Variables
        private string Premises { get { return Lokal.Text; } }
        private DateTime Data_Od { get { return data_od.DateTime; } }
        private DateTime Data_Do
        {
            get
            {
                if (data_do.EditValue != "Do:" && data_do.EditValue != null) { return data_do.DateTime; } else return DateTime.Now;
            }
        }

        readonly DataClasses1DataContext dataContext = new DataClasses1DataContext();
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            Lokal.Properties.Items.AddRange(Getelement());
            gridControl1.DataSource = dataContext.Trial_Table.ToList();

        }

        private object[] Getelement()
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            var listcombobox = dataContext.Trial_Table.Select(O => O.lokal).Distinct().ToList();
            return listcombobox.ToArray();
        }

        private void Button_update_event(object sender, EventArgs e)
        {
            gridControl1.DataSource = dataContext.Trial_Table.Where(o => Data_Od < o.data_wprowadzenia && Data_Do > o.data_wprowadzenia).Where(o =>
               Lokal.Text != "Kolekcje:" ? o.lokal == Premises : o.lokal != null);
        }



        
    }
}
