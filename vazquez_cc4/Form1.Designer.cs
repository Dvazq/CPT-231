namespace vazquez_cc4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label apptpatientnameLabel;
            System.Windows.Forms.Label apptdateLabel;
            System.Windows.Forms.Label apptdoctornameLabel;
            System.Windows.Forms.Label apptiDLabel;
            this.vazquezMedicalDataSet = new vazquez_cc4.vazquezMedicalDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new vazquez_cc4.vazquezMedicalDataSetTableAdapters.appointmentsTableAdapter();
            this.tableAdapterManager = new vazquez_cc4.vazquezMedicalDataSetTableAdapters.TableAdapterManager();
            this.appointmentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.appointmentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.apptpatientnameTextBox = new System.Windows.Forms.TextBox();
            this.apptdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.apptdoctornameTextBox = new System.Windows.Forms.TextBox();
            this.apptiDListBox = new System.Windows.Forms.ListBox();
            apptpatientnameLabel = new System.Windows.Forms.Label();
            apptdateLabel = new System.Windows.Forms.Label();
            apptdoctornameLabel = new System.Windows.Forms.Label();
            apptiDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vazquezMedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingNavigator)).BeginInit();
            this.appointmentsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // vazquezMedicalDataSet
            // 
            this.vazquezMedicalDataSet.DataSetName = "vazquezMedicalDataSet";
            this.vazquezMedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "appointments";
            this.appointmentsBindingSource.DataSource = this.vazquezMedicalDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appointmentsTableAdapter = this.appointmentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = vazquez_cc4.vazquezMedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appointmentsBindingNavigator
            // 
            this.appointmentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.appointmentsBindingNavigator.BindingSource = this.appointmentsBindingSource;
            this.appointmentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appointmentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.appointmentsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.appointmentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.appointmentsBindingNavigatorSaveItem});
            this.appointmentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.appointmentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appointmentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appointmentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appointmentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appointmentsBindingNavigator.Name = "appointmentsBindingNavigator";
            this.appointmentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appointmentsBindingNavigator.Size = new System.Drawing.Size(824, 31);
            this.appointmentsBindingNavigator.TabIndex = 0;
            this.appointmentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // appointmentsBindingNavigatorSaveItem
            // 
            this.appointmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.appointmentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("appointmentsBindingNavigatorSaveItem.Image")));
            this.appointmentsBindingNavigatorSaveItem.Name = "appointmentsBindingNavigatorSaveItem";
            this.appointmentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.appointmentsBindingNavigatorSaveItem.Text = "Save Data";
            this.appointmentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.appointmentsBindingNavigatorSaveItem_Click);
            // 
            // apptpatientnameLabel
            // 
            apptpatientnameLabel.AutoSize = true;
            apptpatientnameLabel.Location = new System.Drawing.Point(286, 72);
            apptpatientnameLabel.Name = "apptpatientnameLabel";
            apptpatientnameLabel.Size = new System.Drawing.Size(91, 16);
            apptpatientnameLabel.TabIndex = 1;
            apptpatientnameLabel.Text = "Patient Name:";
            apptpatientnameLabel.Click += new System.EventHandler(this.apptpatientnameLabel_Click);
            // 
            // apptpatientnameTextBox
            // 
            this.apptpatientnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "apptpatientname", true));
            this.apptpatientnameTextBox.Location = new System.Drawing.Point(403, 69);
            this.apptpatientnameTextBox.Name = "apptpatientnameTextBox";
            this.apptpatientnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.apptpatientnameTextBox.TabIndex = 2;
            // 
            // apptdateLabel
            // 
            apptdateLabel.AutoSize = true;
            apptdateLabel.Location = new System.Drawing.Point(286, 101);
            apptdateLabel.Name = "apptdateLabel";
            apptdateLabel.Size = new System.Drawing.Size(39, 16);
            apptdateLabel.TabIndex = 3;
            apptdateLabel.Text = "Date:";
            // 
            // apptdateDateTimePicker
            // 
            this.apptdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentsBindingSource, "apptdate", true));
            this.apptdateDateTimePicker.Location = new System.Drawing.Point(403, 97);
            this.apptdateDateTimePicker.Name = "apptdateDateTimePicker";
            this.apptdateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.apptdateDateTimePicker.TabIndex = 4;
            // 
            // apptdoctornameLabel
            // 
            apptdoctornameLabel.AutoSize = true;
            apptdoctornameLabel.Location = new System.Drawing.Point(286, 128);
            apptdoctornameLabel.Name = "apptdoctornameLabel";
            apptdoctornameLabel.Size = new System.Drawing.Size(90, 16);
            apptdoctornameLabel.TabIndex = 5;
            apptdoctornameLabel.Text = "Doctor Name:";
            // 
            // apptdoctornameTextBox
            // 
            this.apptdoctornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentsBindingSource, "apptdoctorname", true));
            this.apptdoctornameTextBox.Location = new System.Drawing.Point(403, 125);
            this.apptdoctornameTextBox.Name = "apptdoctornameTextBox";
            this.apptdoctornameTextBox.Size = new System.Drawing.Size(200, 22);
            this.apptdoctornameTextBox.TabIndex = 6;
            // 
            // apptiDLabel
            // 
            apptiDLabel.AutoSize = true;
            apptiDLabel.Location = new System.Drawing.Point(9, 58);
            apptiDLabel.Name = "apptiDLabel";
            apptiDLabel.Size = new System.Drawing.Size(96, 32);
            apptiDLabel.TabIndex = 7;
            apptiDLabel.Text = "Select an\r\n Apointment ID:";
            // 
            // apptiDListBox
            // 
            this.apptiDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.appointmentsBindingSource, "apptiD", true));
            this.apptiDListBox.DataSource = this.appointmentsBindingSource;
            this.apptiDListBox.DisplayMember = "apptiD";
            this.apptiDListBox.FormattingEnabled = true;
            this.apptiDListBox.ItemHeight = 16;
            this.apptiDListBox.Location = new System.Drawing.Point(126, 58);
            this.apptiDListBox.Name = "apptiDListBox";
            this.apptiDListBox.Size = new System.Drawing.Size(80, 100);
            this.apptiDListBox.TabIndex = 8;
            this.apptiDListBox.ValueMember = "apptiD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(apptiDLabel);
            this.Controls.Add(this.apptiDListBox);
            this.Controls.Add(apptpatientnameLabel);
            this.Controls.Add(this.apptpatientnameTextBox);
            this.Controls.Add(apptdateLabel);
            this.Controls.Add(this.apptdateDateTimePicker);
            this.Controls.Add(apptdoctornameLabel);
            this.Controls.Add(this.apptdoctornameTextBox);
            this.Controls.Add(this.appointmentsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Appointment Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vazquezMedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingNavigator)).EndInit();
            this.appointmentsBindingNavigator.ResumeLayout(false);
            this.appointmentsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vazquezMedicalDataSet vazquezMedicalDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private vazquezMedicalDataSetTableAdapters.appointmentsTableAdapter appointmentsTableAdapter;
        private vazquezMedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator appointmentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton appointmentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox apptpatientnameTextBox;
        private System.Windows.Forms.DateTimePicker apptdateDateTimePicker;
        private System.Windows.Forms.TextBox apptdoctornameTextBox;
        private System.Windows.Forms.ListBox apptiDListBox;
    }
}

