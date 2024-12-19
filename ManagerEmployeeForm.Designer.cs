namespace CUSTOMER_MANAGERMENT
{
    partial class ManageEmployee
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
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblAuthorityLevel = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dtgEmployee = new System.Windows.Forms.DataGridView();
            this.gbManageEmployee = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.gbEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.cbAuthorityLevel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
            this.gbManageEmployee.SuspendLayout();
            this.gbEmployeeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(40, 58);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(47, 20);
            this.lblEmployeeCode.TabIndex = 0;
            this.lblEmployeeCode.Text = "Code";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(40, 134);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(74, 20);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Fullname";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(40, 208);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 20);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position";
            // 
            // lblAuthorityLevel
            // 
            this.lblAuthorityLevel.AutoSize = true;
            this.lblAuthorityLevel.Location = new System.Drawing.Point(40, 271);
            this.lblAuthorityLevel.Name = "lblAuthorityLevel";
            this.lblAuthorityLevel.Size = new System.Drawing.Size(42, 20);
            this.lblAuthorityLevel.TabIndex = 3;
            this.lblAuthorityLevel.Text = "Role";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(40, 323);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 383);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(194, 428);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(194, 480);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 589);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 34);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(194, 58);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(100, 26);
            this.txtEmployeeCode.TabIndex = 12;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(194, 134);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 26);
            this.txtEmployeeName.TabIndex = 13;
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(194, 208);
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(100, 26);
            this.txtEmployeePosition.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(194, 320);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 26);
            this.txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(194, 380);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 26);
            this.txtPassword.TabIndex = 17;
            // 
            // dtgEmployee
            // 
            this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployee.Location = new System.Drawing.Point(386, 65);
            this.dtgEmployee.Name = "dtgEmployee";
            this.dtgEmployee.RowHeadersWidth = 62;
            this.dtgEmployee.RowTemplate.Height = 28;
            this.dtgEmployee.Size = new System.Drawing.Size(386, 432);
            this.dtgEmployee.TabIndex = 18;
            this.dtgEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployee_CellContentClick_1);
            // 
            // gbManageEmployee
            // 
            this.gbManageEmployee.Controls.Add(this.txtSearch);
            this.gbManageEmployee.Controls.Add(this.dtgEmployee);
            this.gbManageEmployee.Controls.Add(this.lblEmployeeList);
            this.gbManageEmployee.Controls.Add(this.gbEmployeeInformation);
            this.gbManageEmployee.Location = new System.Drawing.Point(4, 5);
            this.gbManageEmployee.Name = "gbManageEmployee";
            this.gbManageEmployee.Size = new System.Drawing.Size(784, 578);
            this.gbManageEmployee.TabIndex = 19;
            this.gbManageEmployee.TabStop = false;
            this.gbManageEmployee.Text = "Manage Employee";
            this.gbManageEmployee.Enter += new System.EventHandler(this.gbManageEmployee_Enter);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(618, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 26);
            this.txtSearch.TabIndex = 19;
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Location = new System.Drawing.Point(382, 31);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(102, 20);
            this.lblEmployeeList.TabIndex = 1;
            this.lblEmployeeList.Text = "Employee list";
            // 
            // gbEmployeeInformation
            // 
            this.gbEmployeeInformation.Controls.Add(this.cbAuthorityLevel);
            this.gbEmployeeInformation.Controls.Add(this.btnDelete);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeeCode);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeeName);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeePosition);
            this.gbEmployeeInformation.Controls.Add(this.txtUsername);
            this.gbEmployeeInformation.Controls.Add(this.txtPassword);
            this.gbEmployeeInformation.Controls.Add(this.btnClear);
            this.gbEmployeeInformation.Controls.Add(this.btnUpdate);
            this.gbEmployeeInformation.Controls.Add(this.btnAdd);
            this.gbEmployeeInformation.Controls.Add(this.lblPassword);
            this.gbEmployeeInformation.Controls.Add(this.lblUsername);
            this.gbEmployeeInformation.Controls.Add(this.lblAuthorityLevel);
            this.gbEmployeeInformation.Controls.Add(this.lblPosition);
            this.gbEmployeeInformation.Controls.Add(this.lblEmployeeCode);
            this.gbEmployeeInformation.Controls.Add(this.lblEmployeeName);
            this.gbEmployeeInformation.Location = new System.Drawing.Point(8, 38);
            this.gbEmployeeInformation.Name = "gbEmployeeInformation";
            this.gbEmployeeInformation.Size = new System.Drawing.Size(348, 529);
            this.gbEmployeeInformation.TabIndex = 0;
            this.gbEmployeeInformation.TabStop = false;
            this.gbEmployeeInformation.Text = "Employee Information ";
            // 
            // cbAuthorityLevel
            // 
            this.cbAuthorityLevel.FormattingEnabled = true;
            this.cbAuthorityLevel.Location = new System.Drawing.Point(201, 259);
            this.cbAuthorityLevel.Name = "cbAuthorityLevel";
            this.cbAuthorityLevel.Size = new System.Drawing.Size(121, 28);
            this.cbAuthorityLevel.TabIndex = 18;
            this.cbAuthorityLevel.SelectedIndexChanged += new System.EventHandler(this.cbAuthorityLevel_SelectedIndexChanged_1);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 694);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbManageEmployee);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployeeForm";
            this.Load += new System.EventHandler(this.ManagerEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
            this.gbManageEmployee.ResumeLayout(false);
            this.gbManageEmployee.PerformLayout();
            this.gbEmployeeInformation.ResumeLayout(false);
            this.gbEmployeeInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblAuthorityLevel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dtgEmployee;
        private System.Windows.Forms.GroupBox gbManageEmployee;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.GroupBox gbEmployeeInformation;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbAuthorityLevel;
    }
}