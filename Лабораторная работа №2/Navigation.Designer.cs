namespace Лабораторная_работа__2
{
    partial class Navigation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnGoToFillOrCancel = new Button();
            btnGoToAdd = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGoToFillOrCancel);
            groupBox1.Controls.Add(btnGoToAdd);
            groupBox1.Location = new Point(18, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите действие";
            // 
            // btnGoToFillOrCancel
            // 
            btnGoToFillOrCancel.Location = new Point(16, 126);
            btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            btnGoToFillOrCancel.Size = new Size(318, 29);
            btnGoToFillOrCancel.TabIndex = 1;
            btnGoToFillOrCancel.Text = "Заполнить или отменить заказ";
            btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            btnGoToFillOrCancel.Click += btnGoToFillOrCancel_Click;
            // 
            // btnGoToAdd
            // 
            btnGoToAdd.Location = new Point(50, 59);
            btnGoToAdd.Name = "btnGoToAdd";
            btnGoToAdd.Size = new Size(260, 29);
            btnGoToAdd.TabIndex = 0;
            btnGoToAdd.Text = "Добавить учётную запись";
            btnGoToAdd.UseVisualStyleBackColor = true;
            btnGoToAdd.Click += btnGoToAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(307, 236);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(147, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Выйти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Navigation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 279);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "Navigation";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGoToFillOrCancel;
        private Button btnGoToAdd;
        private Button btnExit;
    }
}