
namespace Anket
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbx_Anketa = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.mtb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.tbx_Surname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbx_Display = new System.Windows.Forms.ListBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tbx_FileName = new System.Windows.Forms.TextBox();
            this.gbx_Anketa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Anketa
            // 
            this.gbx_Anketa.Controls.Add(this.btn_Add);
            this.gbx_Anketa.Controls.Add(this.dtp_DateOfBirth);
            this.gbx_Anketa.Controls.Add(this.mtb_Phone);
            this.gbx_Anketa.Controls.Add(this.tbx_Email);
            this.gbx_Anketa.Controls.Add(this.tbx_Surname);
            this.gbx_Anketa.Controls.Add(this.label5);
            this.gbx_Anketa.Controls.Add(this.label4);
            this.gbx_Anketa.Controls.Add(this.label3);
            this.gbx_Anketa.Controls.Add(this.label2);
            this.gbx_Anketa.Controls.Add(this.label1);
            this.gbx_Anketa.Controls.Add(this.tbx_Name);
            this.gbx_Anketa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbx_Anketa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbx_Anketa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbx_Anketa.Location = new System.Drawing.Point(12, 12);
            this.gbx_Anketa.Name = "gbx_Anketa";
            this.gbx_Anketa.Size = new System.Drawing.Size(463, 426);
            this.gbx_Anketa.TabIndex = 0;
            this.gbx_Anketa.TabStop = false;
            this.gbx_Anketa.Text = "Anketa";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Add.Enabled = false;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(309, 370);
            this.btn_Add.MaximumSize = new System.Drawing.Size(139, 31);
            this.btn_Add.MinimumSize = new System.Drawing.Size(139, 31);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(139, 31);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.CalendarForeColor = System.Drawing.Color.DarkGray;
            this.dtp_DateOfBirth.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(125, 176);
            this.dtp_DateOfBirth.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtp_DateOfBirth.MaximumSize = new System.Drawing.Size(159, 26);
            this.dtp_DateOfBirth.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtp_DateOfBirth.MinimumSize = new System.Drawing.Size(159, 26);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(159, 26);
            this.dtp_DateOfBirth.TabIndex = 4;
            this.dtp_DateOfBirth.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // mtb_Phone
            // 
            this.mtb_Phone.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mtb_Phone.Location = new System.Drawing.Point(125, 138);
            this.mtb_Phone.Mask = "(000) 000-00-00";
            this.mtb_Phone.MaximumSize = new System.Drawing.Size(146, 26);
            this.mtb_Phone.MinimumSize = new System.Drawing.Size(146, 26);
            this.mtb_Phone.Name = "mtb_Phone";
            this.mtb_Phone.Size = new System.Drawing.Size(146, 26);
            this.mtb_Phone.TabIndex = 3;
            this.mtb_Phone.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // tbx_Email
            // 
            this.tbx_Email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbx_Email.Location = new System.Drawing.Point(125, 104);
            this.tbx_Email.MaximumSize = new System.Drawing.Size(323, 26);
            this.tbx_Email.MinimumSize = new System.Drawing.Size(323, 26);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(323, 26);
            this.tbx_Email.TabIndex = 2;
            this.tbx_Email.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // tbx_Surname
            // 
            this.tbx_Surname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbx_Surname.Location = new System.Drawing.Point(125, 69);
            this.tbx_Surname.MaximumSize = new System.Drawing.Size(323, 26);
            this.tbx_Surname.MinimumSize = new System.Drawing.Size(323, 26);
            this.tbx_Surname.Name = "tbx_Surname";
            this.tbx_Surname.Size = new System.Drawing.Size(323, 26);
            this.tbx_Surname.TabIndex = 1;
            this.tbx_Surname.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // tbx_Name
            // 
            this.tbx_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbx_Name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbx_Name.Location = new System.Drawing.Point(125, 33);
            this.tbx_Name.MaximumSize = new System.Drawing.Size(323, 26);
            this.tbx_Name.MinimumSize = new System.Drawing.Size(323, 26);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(323, 26);
            this.tbx_Name.TabIndex = 0;
            this.tbx_Name.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // lbx_Display
            // 
            this.lbx_Display.BackColor = System.Drawing.Color.LightCyan;
            this.lbx_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbx_Display.ForeColor = System.Drawing.Color.DimGray;
            this.lbx_Display.FormattingEnabled = true;
            this.lbx_Display.ItemHeight = 16;
            this.lbx_Display.Location = new System.Drawing.Point(483, 22);
            this.lbx_Display.Margin = new System.Windows.Forms.Padding(1);
            this.lbx_Display.MaximumSize = new System.Drawing.Size(307, 324);
            this.lbx_Display.MinimumSize = new System.Drawing.Size(307, 324);
            this.lbx_Display.Name = "lbx_Display";
            this.lbx_Display.Size = new System.Drawing.Size(307, 324);
            this.lbx_Display.TabIndex = 1;
            this.lbx_Display.SelectedIndexChanged += new System.EventHandler(this.lbx_Display_SelectedIndexChanged);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Load.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Load.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Load.Location = new System.Drawing.Point(481, 382);
            this.btn_Load.MaximumSize = new System.Drawing.Size(139, 31);
            this.btn_Load.MinimumSize = new System.Drawing.Size(139, 31);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(139, 31);
            this.btn_Load.TabIndex = 6;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Location = new System.Drawing.Point(649, 382);
            this.btn_Save.MaximumSize = new System.Drawing.Size(139, 31);
            this.btn_Save.MinimumSize = new System.Drawing.Size(139, 31);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(139, 31);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tbx_FileName
            // 
            this.tbx_FileName.BackColor = System.Drawing.Color.LightCyan;
            this.tbx_FileName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_FileName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbx_FileName.Location = new System.Drawing.Point(483, 350);
            this.tbx_FileName.MaximumSize = new System.Drawing.Size(307, 26);
            this.tbx_FileName.MinimumSize = new System.Drawing.Size(307, 26);
            this.tbx_FileName.Multiline = true;
            this.tbx_FileName.Name = "tbx_FileName";
            this.tbx_FileName.Size = new System.Drawing.Size(307, 26);
            this.tbx_FileName.TabIndex = 6;
            this.tbx_FileName.Text = "filename.json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_FileName);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.lbx_Display);
            this.Controls.Add(this.gbx_Anketa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_Anketa.ResumeLayout(false);
            this.gbx_Anketa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Anketa;
        private System.Windows.Forms.MaskedTextBox mtb_Phone;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.TextBox tbx_Surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox lbx_Display;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tbx_FileName;
    }
}

