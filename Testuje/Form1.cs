using System;
using System.Linq;

namespace Testuje
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        private string premises { get { return Lokal.Text; } }
        private DateTime data_Od { get { return data_od.DateTime; } }
        private DateTime data_Do { get {
                if (data_do.EditValue != "Do:") { return data_do.DateTime; } else return DateTime.Now ;  } }
        DataClasses1DataContext dataContext = new DataClasses1DataContext();
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Lokal.Properties.Items.AddRange(getelement());
            gridControl1.DataSource = dataContext.Trial_Table.ToList();
  
        }

        private object [] getelement()
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            var listcombobox = dataContext.Trial_Table.Select(O => O.lokal).Distinct().ToList();
            return listcombobox.ToArray();
        }

        private void button_update_event(object sender, EventArgs e)
        {

            gridControl1.DataSource = dataContext.Trial_Table.Where(o => data_Od < o.data_wprowadzenia && data_Do > o.data_wprowadzenia).Where(o =>
               Lokal.EditValue != "Kolekcje:" ? o.lokal == premises : o.lokal != null);



        }
    }
}
