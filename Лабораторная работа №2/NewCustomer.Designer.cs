namespace Лабораторная_работа__2
{
    partial class NewCustomer
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
            groupBox1 = new GroupBox();
            txtCustomerID = new TextBox();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtpOrderDate = new DateTimePicker();
            numOrderAmount = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btnPlaceOrder = new Button();
            btnCreateAccount = new Button();
            btnAddFinish = new Button();
            btnAddAnotherAccount = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление учетной записи";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(206, 85);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(130, 27);
            txtCustomerID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 88);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 2;
            label2.Text = "Идентификатор клиента";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(143, 42);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(193, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 45);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя заказчика";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpOrderDate);
            groupBox2.Controls.Add(numOrderAmount);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 151);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Создать заказ";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(143, 83);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(150, 27);
            dtpOrderDate.TabIndex = 5;
            // 
            // numOrderAmount
            // 
            numOrderAmount.Location = new Point(143, 43);
            numOrderAmount.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numOrderAmount.Name = "numOrderAmount";
            numOrderAmount.Size = new Size(150, 27);
            numOrderAmount.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 88);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Дата заказа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 45);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 0;
            label4.Text = "Сумма заказа";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(396, 310);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(199, 29);
            btnPlaceOrder.TabIndex = 4;
            btnPlaceOrder.Text = "Разместить заказ";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(396, 134);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(199, 29);
            btnCreateAccount.TabIndex = 5;
            btnCreateAccount.Text = "Создать учетную запись";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnAddFinish
            // 
            btnAddFinish.Location = new Point(12, 397);
            btnAddFinish.Name = "btnAddFinish";
            btnAddFinish.Size = new Size(199, 29);
            btnAddFinish.TabIndex = 6;
            btnAddFinish.Text = "Готово";
            btnAddFinish.UseVisualStyleBackColor = true;
            btnAddFinish.Click += btnAddFinish_Click;
            // 
            // btnAddAnotherAccount
            // 
            btnAddAnotherAccount.Location = new Point(310, 397);
            btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            btnAddAnotherAccount.Size = new Size(285, 29);
            btnAddAnotherAccount.TabIndex = 7;
            btnAddAnotherAccount.Text = "Добавить другую учётную запись";
            btnAddAnotherAccount.UseVisualStyleBackColor = true;
            btnAddAnotherAccount.Click += btnAddAnotherAccount_Click;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(btnAddAnotherAccount);
            Controls.Add(btnAddFinish);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnCreateAccount);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NewCustomer";
            Text = "Новая учетная запись и заказ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCustomerID;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dtpOrderDate;
        private NumericUpDown numOrderAmount;
        private Label label3;
        private Label label4;
        private Button btnPlaceOrder;
        private Button btnCreateAccount;
        private Button btnAddFinish;
        private Button btnAddAnotherAccount;
    }
}