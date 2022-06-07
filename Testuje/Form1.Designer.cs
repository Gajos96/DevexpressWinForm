
namespace Testuje
{
    partial class Aplikacja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplikacja));
            this.data_do = new DevExpress.XtraEditors.DateEdit();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.Lokal = new DevExpress.XtraEditors.ComboBoxEdit();
            this.data_od = new DevExpress.XtraEditors.DateEdit();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.trial_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Godzina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluzytkownik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collokal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button_update = new System.Windows.Forms.Button();
            accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.data_do.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_do.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lokal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_od.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_od.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trial_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControlElement3
            // 
            accordionControlElement3.HeaderControl = this.data_do;
            accordionControlElement3.Name = "accordionControlElement3";
            accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // data_do
            // 
            this.data_do.EditValue = "Do:";
            this.data_do.Location = new System.Drawing.Point(25, 104);
            this.data_do.Name = "data_do";
            this.data_do.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.data_do.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.data_do.Size = new System.Drawing.Size(125, 22);
            this.data_do.TabIndex = 3;
            this.data_do.Tag = "";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Controls.Add(this.Lokal);
            this.accordionControl1.Controls.Add(this.data_od);
            this.accordionControl1.Controls.Add(this.data_do);
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSeparator1,
            this.accordionControlElement1,
            this.accordionControlElement2,
            accordionControlElement3,
            this.accordionControlSeparator2});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(184, 342);
            this.accordionControl1.TabIndex = 0;
            // 
            // Lokal
            // 
            this.Lokal.EditValue = "Lokal:";
            this.Lokal.Location = new System.Drawing.Point(25, 20);
            this.Lokal.Name = "Lokal";
            this.Lokal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lokal.Size = new System.Drawing.Size(125, 22);
            this.Lokal.TabIndex = 1;
            // 
            // data_od
            // 
            this.data_od.EditValue = "Do:";
            this.data_od.Location = new System.Drawing.Point(25, 62);
            this.data_od.Name = "data_od";
            this.data_od.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.data_od.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.data_od.Size = new System.Drawing.Size(125, 22);
            this.data_od.TabIndex = 2;
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.HeaderControl = this.Lokal;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.HeaderControl = this.data_od;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Od:";
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.trial_TableBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(184, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(553, 342);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // trial_TableBindingSource
            // 
            this.trial_TableBindingSource.DataSource = typeof(Testuje.Trial_Table);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nazwa,
            this.Data,
            this.Godzina,
            this.coluzytkownik,
            this.collokal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsPrint.PrintFooter = false;
            this.gridView1.OptionsPrint.PrintGroupFooter = false;
            this.gridView1.OptionsPrint.PrintHeader = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Nazwa
            // 
            this.Nazwa.Caption = "Nazwa";
            this.Nazwa.FieldName = "nazwa_eksportu";
            this.Nazwa.MinWidth = 25;
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.OptionsColumn.AllowEdit = false;
            this.Nazwa.OptionsColumn.AllowFocus = false;
            this.Nazwa.Visible = true;
            this.Nazwa.VisibleIndex = 0;
            this.Nazwa.Width = 94;
            // 
            // Data
            // 
            this.Data.Caption = "Data";
            this.Data.FieldName = "data_wprowadzenia";
            this.Data.MinWidth = 25;
            this.Data.Name = "Data";
            this.Data.OptionsColumn.AllowEdit = false;
            this.Data.OptionsColumn.AllowFocus = false;
            this.Data.Visible = true;
            this.Data.VisibleIndex = 1;
            this.Data.Width = 94;
            // 
            // Godzina
            // 
            this.Godzina.Caption = "Godzina";
            this.Godzina.DisplayFormat.FormatString = "hh:mm";
            this.Godzina.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Godzina.FieldName = "data_wprowadzenia";
            this.Godzina.MinWidth = 25;
            this.Godzina.Name = "Godzina";
            this.Godzina.OptionsColumn.AllowEdit = false;
            this.Godzina.OptionsColumn.AllowFocus = false;
            this.Godzina.Visible = true;
            this.Godzina.VisibleIndex = 2;
            this.Godzina.Width = 94;
            // 
            // coluzytkownik
            // 
            this.coluzytkownik.Caption = "Użytkownik";
            this.coluzytkownik.FieldName = "uzytkownik";
            this.coluzytkownik.MinWidth = 25;
            this.coluzytkownik.Name = "coluzytkownik";
            this.coluzytkownik.OptionsColumn.AllowEdit = false;
            this.coluzytkownik.OptionsColumn.AllowFocus = false;
            this.coluzytkownik.Visible = true;
            this.coluzytkownik.VisibleIndex = 3;
            this.coluzytkownik.Width = 94;
            // 
            // collokal
            // 
            this.collokal.Caption = "Lokal";
            this.collokal.FieldName = "lokal";
            this.collokal.MinWidth = 25;
            this.collokal.Name = "collokal";
            this.collokal.OptionsColumn.AllowEdit = false;
            this.collokal.OptionsColumn.AllowFocus = false;
            this.collokal.Visible = true;
            this.collokal.VisibleIndex = 4;
            this.collokal.Width = 94;
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_update.Location = new System.Drawing.Point(16, 304);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(131, 31);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Zatwierdz";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.Button_update_event);
            // 
            // Aplikacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 342);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.accordionControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Aplikacja.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Aplikacja";
            this.Text = "Aplikacja";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_do.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_do.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lokal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_od.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_od.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trial_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraEditors.ComboBoxEdit Lokal;
        private DevExpress.XtraEditors.DateEdit data_od;
        private DevExpress.XtraEditors.DateEdit data_do;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.BindingSource trial_TableBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn Nazwa;
        private DevExpress.XtraGrid.Columns.GridColumn Data;
        private DevExpress.XtraGrid.Columns.GridColumn Godzina;
        private DevExpress.XtraGrid.Columns.GridColumn coluzytkownik;
        private DevExpress.XtraGrid.Columns.GridColumn collokal;
    }
}

