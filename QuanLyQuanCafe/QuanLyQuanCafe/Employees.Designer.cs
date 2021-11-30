
namespace QuanLyQuanCafe
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dpDOB = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.cbAccType = new System.Windows.Forms.ComboBox();
            this.btnResetPwd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnModify = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCreate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvEmployee);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 455);
            this.panel2.TabIndex = 10;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToOrderColumns = true;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(478, 455);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(85, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(243, 26);
            this.txtID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loại TK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "CMND:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dpDOB);
            this.panel3.Controls.Add(this.cbAccType);
            this.panel3.Controls.Add(this.btnResetPwd);
            this.panel3.Controls.Add(this.txtxAddress);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtAccount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtEmpNo);
            this.panel3.Location = new System.Drawing.Point(484, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 312);
            this.panel3.TabIndex = 11;
            // 
            // dpDOB
            // 
            this.dpDOB.BackColor = System.Drawing.Color.Transparent;
            this.dpDOB.BorderColor = System.Drawing.Color.Silver;
            this.dpDOB.BorderRadius = 1;
            this.dpDOB.Color = System.Drawing.Color.Silver;
            this.dpDOB.CustomFormat = "dd/MM/yyyy";
            this.dpDOB.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dpDOB.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpDOB.DisabledColor = System.Drawing.Color.Gray;
            this.dpDOB.DisplayWeekNumbers = false;
            this.dpDOB.DPHeight = 0;
            this.dpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpDOB.FillDatePicker = false;
            this.dpDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDOB.ForeColor = System.Drawing.Color.Black;
            this.dpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDOB.Icon = ((System.Drawing.Image)(resources.GetObject("dpDOB.Icon")));
            this.dpDOB.IconColor = System.Drawing.Color.Gray;
            this.dpDOB.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpDOB.LeftTextMargin = 5;
            this.dpDOB.Location = new System.Drawing.Point(85, 38);
            this.dpDOB.MinimumSize = new System.Drawing.Size(4, 32);
            this.dpDOB.Name = "dpDOB";
            this.dpDOB.Size = new System.Drawing.Size(243, 32);
            this.dpDOB.TabIndex = 2;
            // 
            // cbAccType
            // 
            this.cbAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbAccType.Location = new System.Drawing.Point(85, 212);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(243, 28);
            this.cbAccType.TabIndex = 6;
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.AllowAnimations = true;
            this.btnResetPwd.AllowMouseEffects = true;
            this.btnResetPwd.AllowToggling = false;
            this.btnResetPwd.AnimationSpeed = 200;
            this.btnResetPwd.AutoGenerateColors = false;
            this.btnResetPwd.AutoRoundBorders = false;
            this.btnResetPwd.AutoSizeLeftIcon = true;
            this.btnResetPwd.AutoSizeRightIcon = true;
            this.btnResetPwd.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPwd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnResetPwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetPwd.BackgroundImage")));
            this.btnResetPwd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnResetPwd.ButtonText = "Đặt lại mật khẩu";
            this.btnResetPwd.ButtonTextMarginLeft = 0;
            this.btnResetPwd.ColorContrastOnClick = 45;
            this.btnResetPwd.ColorContrastOnHover = 45;
            this.btnResetPwd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnResetPwd.CustomizableEdges = borderEdges1;
            this.btnResetPwd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnResetPwd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnResetPwd.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnResetPwd.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnResetPwd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnResetPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetPwd.ForeColor = System.Drawing.Color.White;
            this.btnResetPwd.IconLeft = null;
            this.btnResetPwd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPwd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnResetPwd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnResetPwd.IconMarginLeft = 11;
            this.btnResetPwd.IconPadding = 10;
            this.btnResetPwd.IconRight = null;
            this.btnResetPwd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPwd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnResetPwd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnResetPwd.IconSize = 25;
            this.btnResetPwd.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnResetPwd.IdleBorderRadius = 0;
            this.btnResetPwd.IdleBorderThickness = 0;
            this.btnResetPwd.IdleFillColor = System.Drawing.Color.Empty;
            this.btnResetPwd.IdleIconLeftImage = null;
            this.btnResetPwd.IdleIconRightImage = null;
            this.btnResetPwd.IndicateFocus = false;
            this.btnResetPwd.Location = new System.Drawing.Point(228, 252);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnResetPwd.OnDisabledState.BorderRadius = 1;
            this.btnResetPwd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnResetPwd.OnDisabledState.BorderThickness = 1;
            this.btnResetPwd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnResetPwd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnResetPwd.OnDisabledState.IconLeftImage = null;
            this.btnResetPwd.OnDisabledState.IconRightImage = null;
            this.btnResetPwd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnResetPwd.onHoverState.BorderRadius = 1;
            this.btnResetPwd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnResetPwd.onHoverState.BorderThickness = 1;
            this.btnResetPwd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnResetPwd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnResetPwd.onHoverState.IconLeftImage = null;
            this.btnResetPwd.onHoverState.IconRightImage = null;
            this.btnResetPwd.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnResetPwd.OnIdleState.BorderRadius = 1;
            this.btnResetPwd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnResetPwd.OnIdleState.BorderThickness = 1;
            this.btnResetPwd.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnResetPwd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnResetPwd.OnIdleState.IconLeftImage = null;
            this.btnResetPwd.OnIdleState.IconRightImage = null;
            this.btnResetPwd.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnResetPwd.OnPressedState.BorderRadius = 1;
            this.btnResetPwd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnResetPwd.OnPressedState.BorderThickness = 1;
            this.btnResetPwd.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnResetPwd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnResetPwd.OnPressedState.IconLeftImage = null;
            this.btnResetPwd.OnPressedState.IconRightImage = null;
            this.btnResetPwd.Size = new System.Drawing.Size(100, 48);
            this.btnResetPwd.TabIndex = 0;
            this.btnResetPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResetPwd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnResetPwd.TextMarginLeft = 0;
            this.btnResetPwd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnResetPwd.UseDefaultRadiusAndThickness = true;
            this.btnResetPwd.Click += new System.EventHandler(this.bunifuButton6_Click);
            // 
            // txtxAddress
            // 
            this.txtxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxAddress.Location = new System.Drawing.Point(85, 108);
            this.txtxAddress.Multiline = true;
            this.txtxAddress.Name = "txtxAddress";
            this.txtxAddress.Size = new System.Drawing.Size(243, 66);
            this.txtxAddress.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(85, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ tên:";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(85, 180);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(243, 26);
            this.txtAccount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tài khoản:";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(95, 9);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(100, 20);
            this.txtEmpNo.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(484, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 63);
            this.panel1.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.AllowAnimations = true;
            this.btnClear.AllowMouseEffects = true;
            this.btnClear.AllowToggling = false;
            this.btnClear.AnimationSpeed = 200;
            this.btnClear.AutoGenerateColors = false;
            this.btnClear.AutoRoundBorders = false;
            this.btnClear.AutoSizeLeftIcon = true;
            this.btnClear.AutoSizeRightIcon = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.ButtonTextMarginLeft = 0;
            this.btnClear.ColorContrastOnClick = 45;
            this.btnClear.ColorContrastOnHover = 45;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnClear.CustomizableEdges = borderEdges2;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClear.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClear.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconLeft = null;
            this.btnClear.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClear.IconMarginLeft = 11;
            this.btnClear.IconPadding = 10;
            this.btnClear.IconRight = null;
            this.btnClear.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClear.IconSize = 25;
            this.btnClear.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClear.IdleBorderRadius = 0;
            this.btnClear.IdleBorderThickness = 0;
            this.btnClear.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClear.IdleIconLeftImage = null;
            this.btnClear.IdleIconRightImage = null;
            this.btnClear.IndicateFocus = false;
            this.btnClear.Location = new System.Drawing.Point(251, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClear.OnDisabledState.BorderRadius = 1;
            this.btnClear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnDisabledState.BorderThickness = 1;
            this.btnClear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClear.OnDisabledState.IconLeftImage = null;
            this.btnClear.OnDisabledState.IconRightImage = null;
            this.btnClear.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClear.onHoverState.BorderRadius = 1;
            this.btnClear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.onHoverState.BorderThickness = 1;
            this.btnClear.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClear.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.onHoverState.IconLeftImage = null;
            this.btnClear.onHoverState.IconRightImage = null;
            this.btnClear.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.OnIdleState.BorderRadius = 1;
            this.btnClear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnIdleState.BorderThickness = 1;
            this.btnClear.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClear.OnIdleState.IconLeftImage = null;
            this.btnClear.OnIdleState.IconRightImage = null;
            this.btnClear.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.OnPressedState.BorderRadius = 1;
            this.btnClear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnPressedState.BorderThickness = 1;
            this.btnClear.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClear.OnPressedState.IconLeftImage = null;
            this.btnClear.OnPressedState.IconRightImage = null;
            this.btnClear.Size = new System.Drawing.Size(72, 48);
            this.btnClear.TabIndex = 0;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.TextMarginLeft = 0;
            this.btnClear.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClear.UseDefaultRadiusAndThickness = true;
            this.btnClear.Click += new System.EventHandler(this.bunifuButton4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowMouseEffects = true;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.AnimationSpeed = 200;
            this.btnDelete.AutoGenerateColors = false;
            this.btnDelete.AutoRoundBorders = false;
            this.btnDelete.AutoSizeLeftIcon = true;
            this.btnDelete.AutoSizeRightIcon = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.ButtonText = "Xóa";
            this.btnDelete.ButtonTextMarginLeft = 0;
            this.btnDelete.ColorContrastOnClick = 45;
            this.btnDelete.ColorContrastOnHover = 45;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnDelete.CustomizableEdges = borderEdges3;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDelete.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconLeft = null;
            this.btnDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDelete.IconMarginLeft = 11;
            this.btnDelete.IconPadding = 10;
            this.btnDelete.IconRight = null;
            this.btnDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDelete.IconSize = 25;
            this.btnDelete.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDelete.IdleBorderRadius = 0;
            this.btnDelete.IdleBorderThickness = 0;
            this.btnDelete.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDelete.IdleIconLeftImage = null;
            this.btnDelete.IdleIconRightImage = null;
            this.btnDelete.IndicateFocus = false;
            this.btnDelete.Location = new System.Drawing.Point(173, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.OnDisabledState.BorderRadius = 1;
            this.btnDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnDisabledState.BorderThickness = 1;
            this.btnDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.OnDisabledState.IconLeftImage = null;
            this.btnDelete.OnDisabledState.IconRightImage = null;
            this.btnDelete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDelete.onHoverState.BorderRadius = 1;
            this.btnDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.onHoverState.BorderThickness = 1;
            this.btnDelete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.onHoverState.IconLeftImage = null;
            this.btnDelete.onHoverState.IconRightImage = null;
            this.btnDelete.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.OnIdleState.BorderRadius = 1;
            this.btnDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnIdleState.BorderThickness = 1;
            this.btnDelete.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnIdleState.IconLeftImage = null;
            this.btnDelete.OnIdleState.IconRightImage = null;
            this.btnDelete.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.OnPressedState.BorderRadius = 1;
            this.btnDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnPressedState.BorderThickness = 1;
            this.btnDelete.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnPressedState.IconLeftImage = null;
            this.btnDelete.OnPressedState.IconRightImage = null;
            this.btnDelete.Size = new System.Drawing.Size(72, 48);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextMarginLeft = 0;
            this.btnDelete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDelete.UseDefaultRadiusAndThickness = true;
            this.btnDelete.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // btnModify
            // 
            this.btnModify.AllowAnimations = true;
            this.btnModify.AllowMouseEffects = true;
            this.btnModify.AllowToggling = false;
            this.btnModify.AnimationSpeed = 200;
            this.btnModify.AutoGenerateColors = false;
            this.btnModify.AutoRoundBorders = false;
            this.btnModify.AutoSizeLeftIcon = true;
            this.btnModify.AutoSizeRightIcon = true;
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnModify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModify.BackgroundImage")));
            this.btnModify.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModify.ButtonText = "Sửa";
            this.btnModify.ButtonTextMarginLeft = 0;
            this.btnModify.ColorContrastOnClick = 45;
            this.btnModify.ColorContrastOnHover = 45;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnModify.CustomizableEdges = borderEdges4;
            this.btnModify.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModify.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModify.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnModify.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnModify.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.IconLeft = null;
            this.btnModify.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnModify.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnModify.IconMarginLeft = 11;
            this.btnModify.IconPadding = 10;
            this.btnModify.IconRight = null;
            this.btnModify.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnModify.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnModify.IconSize = 25;
            this.btnModify.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnModify.IdleBorderRadius = 0;
            this.btnModify.IdleBorderThickness = 0;
            this.btnModify.IdleFillColor = System.Drawing.Color.Empty;
            this.btnModify.IdleIconLeftImage = null;
            this.btnModify.IdleIconRightImage = null;
            this.btnModify.IndicateFocus = false;
            this.btnModify.Location = new System.Drawing.Point(95, 7);
            this.btnModify.Name = "btnModify";
            this.btnModify.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModify.OnDisabledState.BorderRadius = 1;
            this.btnModify.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModify.OnDisabledState.BorderThickness = 1;
            this.btnModify.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModify.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModify.OnDisabledState.IconLeftImage = null;
            this.btnModify.OnDisabledState.IconRightImage = null;
            this.btnModify.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnModify.onHoverState.BorderRadius = 1;
            this.btnModify.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModify.onHoverState.BorderThickness = 1;
            this.btnModify.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnModify.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnModify.onHoverState.IconLeftImage = null;
            this.btnModify.onHoverState.IconRightImage = null;
            this.btnModify.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModify.OnIdleState.BorderRadius = 1;
            this.btnModify.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModify.OnIdleState.BorderThickness = 1;
            this.btnModify.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnModify.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnModify.OnIdleState.IconLeftImage = null;
            this.btnModify.OnIdleState.IconRightImage = null;
            this.btnModify.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModify.OnPressedState.BorderRadius = 1;
            this.btnModify.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModify.OnPressedState.BorderThickness = 1;
            this.btnModify.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnModify.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnModify.OnPressedState.IconLeftImage = null;
            this.btnModify.OnPressedState.IconRightImage = null;
            this.btnModify.Size = new System.Drawing.Size(72, 48);
            this.btnModify.TabIndex = 0;
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModify.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModify.TextMarginLeft = 0;
            this.btnModify.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnModify.UseDefaultRadiusAndThickness = true;
            this.btnModify.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.AllowAnimations = true;
            this.btnCreate.AllowMouseEffects = true;
            this.btnCreate.AllowToggling = false;
            this.btnCreate.AnimationSpeed = 200;
            this.btnCreate.AutoGenerateColors = false;
            this.btnCreate.AutoRoundBorders = false;
            this.btnCreate.AutoSizeLeftIcon = true;
            this.btnCreate.AutoSizeRightIcon = true;
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreate.ButtonText = "Thêm";
            this.btnCreate.ButtonTextMarginLeft = 0;
            this.btnCreate.ColorContrastOnClick = 45;
            this.btnCreate.ColorContrastOnHover = 45;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnCreate.CustomizableEdges = borderEdges5;
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreate.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCreate.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCreate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.IconLeft = null;
            this.btnCreate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCreate.IconMarginLeft = 11;
            this.btnCreate.IconPadding = 10;
            this.btnCreate.IconRight = null;
            this.btnCreate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCreate.IconSize = 25;
            this.btnCreate.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCreate.IdleBorderRadius = 0;
            this.btnCreate.IdleBorderThickness = 0;
            this.btnCreate.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCreate.IdleIconLeftImage = null;
            this.btnCreate.IdleIconRightImage = null;
            this.btnCreate.IndicateFocus = false;
            this.btnCreate.Location = new System.Drawing.Point(17, 7);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreate.OnDisabledState.BorderRadius = 1;
            this.btnCreate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreate.OnDisabledState.BorderThickness = 1;
            this.btnCreate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreate.OnDisabledState.IconLeftImage = null;
            this.btnCreate.OnDisabledState.IconRightImage = null;
            this.btnCreate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnCreate.onHoverState.BorderRadius = 1;
            this.btnCreate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreate.onHoverState.BorderThickness = 1;
            this.btnCreate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnCreate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCreate.onHoverState.IconLeftImage = null;
            this.btnCreate.onHoverState.IconRightImage = null;
            this.btnCreate.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.OnIdleState.BorderRadius = 1;
            this.btnCreate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreate.OnIdleState.BorderThickness = 1;
            this.btnCreate.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCreate.OnIdleState.IconLeftImage = null;
            this.btnCreate.OnIdleState.IconRightImage = null;
            this.btnCreate.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.OnPressedState.BorderRadius = 1;
            this.btnCreate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreate.OnPressedState.BorderThickness = 1;
            this.btnCreate.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCreate.OnPressedState.IconLeftImage = null;
            this.btnCreate.OnPressedState.IconRightImage = null;
            this.btnCreate.Size = new System.Drawing.Size(72, 48);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreate.TextMarginLeft = 0;
            this.btnCreate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCreate.UseDefaultRadiusAndThickness = true;
            this.btnCreate.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(12, 21);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(289, 20);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.txtFilter);
            this.panel4.Location = new System.Drawing.Point(484, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 63);
            this.panel4.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyQuanCafe.Properties.Resources.loupe;
            this.pictureBox1.Location = new System.Drawing.Point(307, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Employees";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnResetPwd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnModify;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCreate;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClear;
        private System.Windows.Forms.ComboBox cbAccType;
        private System.Windows.Forms.TextBox txtxAddress;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDatePicker dpDOB;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}