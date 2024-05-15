namespace Лабораторная_работа__2
{
    partial class FillOrCancel
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
            label2 = new Label();
            txtOrderID = new TextBox();
            btnFindByOrderID = new Button();
            label1 = new Label();
            dtpFillDate = new DateTimePicker();
            dgvCustomerOrders = new DataGridView();
            btnCancelOrder = new Button();
            btnFillOrder = new Button();
            btnFinishUpdates = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 3;
            label2.Text = "Идентификатор заказа";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(201, 15);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(191, 27);
            txtOrderID.TabIndex = 4;
            // 
            // btnFindByOrderID
            // 
            btnFindByOrderID.Location = new Point(461, 18);
            btnFindByOrderID.Name = "btnFindByOrderID";
            btnFindByOrderID.Size = new Size(136, 29);
            btnFindByOrderID.TabIndex = 5;
            btnFindByOrderID.Text = "Найти заказ";
            btnFindByOrderID.UseVisualStyleBackColor = true;
            btnFindByOrderID.Click += btnFindByOrderID_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 126);
            label1.Name = "label1";
            label1.Size = new Size(357, 20);
            label1.TabIndex = 6;
            label1.Text = "При заполнении заказа укажите дату заполнения";
            // 
            // dtpFillDate
            // 
            dtpFillDate.Format = DateTimePickerFormat.Short;
            dtpFillDate.Location = new Point(409, 121);
            dtpFillDate.Name = "dtpFillDate";
            dtpFillDate.Size = new Size(125, 27);
            dtpFillDate.TabIndex = 7;
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(12, 171);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.RowHeadersVisible = false;
            dgvCustomerOrders.RowHeadersWidth = 51;
            dgvCustomerOrders.RowTemplate.Height = 29;
            dgvCustomerOrders.Size = new Size(522, 138);
            dgvCustomerOrders.TabIndex = 8;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(12, 367);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(136, 29);
            btnCancelOrder.TabIndex = 9;
            btnCancelOrder.Text = "Отменить заказ";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnFillOrder
            // 
            btnFillOrder.Location = new Point(175, 367);
            btnFillOrder.Name = "btnFillOrder";
            btnFillOrder.Size = new Size(136, 29);
            btnFillOrder.TabIndex = 10;
            btnFillOrder.Text = "Заполнить заказ";
            btnFillOrder.UseVisualStyleBackColor = true;
            btnFillOrder.Click += btnFillOrder_Click;
            // 
            // btnFinishUpdates
            // 
            btnFinishUpdates.Location = new Point(461, 367);
            btnFinishUpdates.Name = "btnFinishUpdates";
            btnFinishUpdates.Size = new Size(136, 29);
            btnFinishUpdates.TabIndex = 11;
            btnFinishUpdates.Text = "Готово";
            btnFinishUpdates.UseVisualStyleBackColor = true;
            // 
            // FillOrCancel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 415);
            Controls.Add(btnFinishUpdates);
            Controls.Add(btnFillOrder);
            Controls.Add(btnCancelOrder);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(dtpFillDate);
            Controls.Add(label1);
            Controls.Add(btnFindByOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(label2);
            Name = "FillOrCancel";
            Text = "Заполнение или отмена заказа";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtOrderID;
        private Button btnFindByOrderID;
        private Label label1;
        private DateTimePicker dtpFillDate;
        private DataGridView dgvCustomerOrders;
        private Button btnCancelOrder;
        private Button btnFillOrder;
        private Button btnFinishUpdates;
    }
}