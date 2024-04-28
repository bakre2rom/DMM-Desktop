namespace DMM
{
    partial class DMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMM));
            this.Form = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.pn_container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.btn_home = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_supplier = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_customer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_report = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_analysis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_setting = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_about = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_container)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form.Location = new System.Drawing.Point(0, 39);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(828, 680);
            this.Form.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_home,
            this.btn_supplier,
            this.btn_customer,
            this.btn_report,
            this.btn_analysis,
            this.btn_users,
            this.btn_setting,
            this.btn_about});
            this.accordionControl1.Location = new System.Drawing.Point(828, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(250, 680);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.Click += new System.EventHandler(this.accordionControl1_Click);
            // 
            // pn_container
            // 
            this.pn_container.FluentDesignForm = this;
            this.pn_container.Location = new System.Drawing.Point(0, 0);
            this.pn_container.Manager = this.fluentFormDefaultManager1;
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(1078, 39);
            this.pn_container.TabIndex = 2;
            this.pn_container.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // btn_home
            // 
            this.btn_home.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Appearance.Normal.Options.UseFont = true;
            this.btn_home.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_home.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.btn_home.Name = "btn_home";
            this.btn_home.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_home.Text = "الرئيسية";
            this.btn_home.Click += new System.EventHandler(this.accordionControlElement2_Click_1);
            // 
            // btn_supplier
            // 
            this.btn_supplier.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplier.Appearance.Normal.Options.UseFont = true;
            this.btn_supplier.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_supplier.Text = "الموردين";
            // 
            // btn_customer
            // 
            this.btn_customer.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.Appearance.Normal.Options.UseFont = true;
            this.btn_customer.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_customer.Text = "العملاء";
            this.btn_customer.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // btn_report
            // 
            this.btn_report.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Appearance.Normal.Options.UseFont = true;
            this.btn_report.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_report.Name = "btn_report";
            this.btn_report.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_report.Text = "التقارير";
            // 
            // btn_analysis
            // 
            this.btn_analysis.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analysis.Appearance.Normal.Options.UseFont = true;
            this.btn_analysis.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_analysis.Text = "تحليل";
            // 
            // btn_users
            // 
            this.btn_users.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.Appearance.Normal.Options.UseFont = true;
            this.btn_users.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_users.Name = "btn_users";
            this.btn_users.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_users.Text = "المستخدمين";
            // 
            // btn_setting
            // 
            this.btn_setting.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.Appearance.Normal.Options.UseFont = true;
            this.btn_setting.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_setting.Text = "الإعدادات";
            // 
            // btn_about
            // 
            this.btn_about.Appearance.Normal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Appearance.Normal.Options.UseFont = true;
            this.btn_about.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.btn_about.Name = "btn_about";
            this.btn_about.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_about.Text = "حول";
            // 
            // DMM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1078, 719);
            this.ControlContainer = this.Form;
            this.Controls.Add(this.Form);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.pn_container);
            this.FluentDesignFormControl = this.pn_container;
            this.Name = "DMM";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_container)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer Form;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl pn_container;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_home;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_supplier;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_customer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_report;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_analysis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_users;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_setting;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_about;
    }
}

