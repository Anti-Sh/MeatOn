﻿namespace MeatOn
{
    partial class index
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelForInput = new System.Windows.Forms.Label();
            this.inputNumber = new System.Windows.Forms.NumericUpDown();
            this.inputType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.querySelect = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.orderDishes = new System.Windows.Forms.DataGridView();
            this.dish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.query1 = new System.Windows.Forms.GroupBox();
            this.fullcost = new System.Windows.Forms.TextBox();
            this.dateto = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.selectOrders = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.query2 = new System.Windows.Forms.GroupBox();
            this.countOrders = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.query3 = new System.Windows.Forms.GroupBox();
            this.revenue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDishes)).BeginInit();
            this.query1.SuspendLayout();
            this.query2.SuspendLayout();
            this.query3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MeatOn.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Запрос:";
            // 
            // labelForInput
            // 
            this.labelForInput.AutoSize = true;
            this.labelForInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelForInput.ForeColor = System.Drawing.SystemColors.Control;
            this.labelForInput.Location = new System.Drawing.Point(12, 121);
            this.labelForInput.Name = "labelForInput";
            this.labelForInput.Size = new System.Drawing.Size(79, 20);
            this.labelForInput.TabIndex = 3;
            this.labelForInput.Text = "Период:";
            // 
            // inputNumber
            // 
            this.inputNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.inputNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputNumber.ForeColor = System.Drawing.Color.White;
            this.inputNumber.Location = new System.Drawing.Point(99, 120);
            this.inputNumber.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(66, 23);
            this.inputNumber.TabIndex = 4;
            // 
            // inputType
            // 
            this.inputType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.inputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputType.ForeColor = System.Drawing.Color.White;
            this.inputType.FormattingEnabled = true;
            this.inputType.Items.AddRange(new object[] {
            "м",
            "ч",
            "д"});
            this.inputType.Location = new System.Drawing.Point(171, 119);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(54, 24);
            this.inputType.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.querySelect);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // querySelect
            // 
            this.querySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.querySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.querySelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.querySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.querySelect.ForeColor = System.Drawing.Color.White;
            this.querySelect.FormattingEnabled = true;
            this.querySelect.Items.AddRange(new object[] {
            "Заказы, которые предстоит выполнить",
            "Количество заказов до определенной стоимости",
            "Суммарная выручка по заказам за период времени"});
            this.querySelect.Location = new System.Drawing.Point(94, 18);
            this.querySelect.Name = "querySelect";
            this.querySelect.Size = new System.Drawing.Size(409, 28);
            this.querySelect.TabIndex = 1;
            this.querySelect.SelectionChangeCommitted += new System.EventHandler(this.querySelect_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(398, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderDishes
            // 
            this.orderDishes.AllowUserToAddRows = false;
            this.orderDishes.AllowUserToDeleteRows = false;
            this.orderDishes.AllowUserToResizeColumns = false;
            this.orderDishes.AllowUserToResizeRows = false;
            this.orderDishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.orderDishes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderDishes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.orderDishes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDishes.CausesValidation = false;
            this.orderDishes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(184)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDishes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dish,
            this.count,
            this.cost});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(184)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDishes.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderDishes.GridColor = System.Drawing.Color.Black;
            this.orderDishes.Location = new System.Drawing.Point(11, 246);
            this.orderDishes.Name = "orderDishes";
            this.orderDishes.ReadOnly = true;
            this.orderDishes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.orderDishes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.orderDishes.Size = new System.Drawing.Size(438, 136);
            this.orderDishes.TabIndex = 9;
            // 
            // dish
            // 
            this.dish.HeaderText = "Блюдо";
            this.dish.Name = "dish";
            this.dish.ReadOnly = true;
            this.dish.Width = 76;
            // 
            // count
            // 
            this.count.HeaderText = "Количество";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 111;
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 103;
            // 
            // query1
            // 
            this.query1.Controls.Add(this.fullcost);
            this.query1.Controls.Add(this.dateto);
            this.query1.Controls.Add(this.tel);
            this.query1.Controls.Add(this.address);
            this.query1.Controls.Add(this.user);
            this.query1.Controls.Add(this.selectOrders);
            this.query1.Controls.Add(this.label8);
            this.query1.Controls.Add(this.label7);
            this.query1.Controls.Add(this.label6);
            this.query1.Controls.Add(this.label5);
            this.query1.Controls.Add(this.label3);
            this.query1.Controls.Add(this.label2);
            this.query1.Controls.Add(this.label4);
            this.query1.Controls.Add(this.orderDishes);
            this.query1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.query1.ForeColor = System.Drawing.Color.White;
            this.query1.Location = new System.Drawing.Point(5, 163);
            this.query1.Name = "query1";
            this.query1.Size = new System.Drawing.Size(771, 390);
            this.query1.TabIndex = 7;
            this.query1.TabStop = false;
            this.query1.Text = "Выходные данные";
            this.query1.Visible = false;
            // 
            // fullcost
            // 
            this.fullcost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.fullcost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fullcost.ForeColor = System.Drawing.Color.White;
            this.fullcost.Location = new System.Drawing.Point(178, 189);
            this.fullcost.Name = "fullcost";
            this.fullcost.Size = new System.Drawing.Size(271, 26);
            this.fullcost.TabIndex = 20;
            // 
            // dateto
            // 
            this.dateto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dateto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateto.ForeColor = System.Drawing.Color.White;
            this.dateto.Location = new System.Drawing.Point(178, 157);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(271, 26);
            this.dateto.TabIndex = 19;
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tel.ForeColor = System.Drawing.Color.White;
            this.tel.Location = new System.Drawing.Point(178, 125);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(271, 26);
            this.tel.TabIndex = 18;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(110, 93);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(339, 26);
            this.address.TabIndex = 17;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(110, 61);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(339, 26);
            this.user.TabIndex = 16;
            // 
            // selectOrders
            // 
            this.selectOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.selectOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectOrders.ForeColor = System.Drawing.Color.White;
            this.selectOrders.FormattingEnabled = true;
            this.selectOrders.Location = new System.Drawing.Point(81, 26);
            this.selectOrders.Name = "selectOrders";
            this.selectOrders.Size = new System.Drawing.Size(368, 28);
            this.selectOrders.TabIndex = 2;
            this.selectOrders.SelectionChangeCommitted += new System.EventHandler(this.selectOrders_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(11, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Состав заказа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(11, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер телефона:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(11, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Стоимость:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(11, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата и время:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Заказ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Заказчик:";
            // 
            // query2
            // 
            this.query2.Controls.Add(this.countOrders);
            this.query2.Controls.Add(this.label14);
            this.query2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.query2.ForeColor = System.Drawing.Color.White;
            this.query2.Location = new System.Drawing.Point(5, 163);
            this.query2.Name = "query2";
            this.query2.Size = new System.Drawing.Size(771, 390);
            this.query2.TabIndex = 8;
            this.query2.TabStop = false;
            this.query2.Text = "Выходные данные";
            this.query2.Visible = false;
            // 
            // countOrders
            // 
            this.countOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.countOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.countOrders.ForeColor = System.Drawing.Color.White;
            this.countOrders.Location = new System.Drawing.Point(203, 28);
            this.countOrders.Name = "countOrders";
            this.countOrders.Size = new System.Drawing.Size(271, 26);
            this.countOrders.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(11, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Количество заказов:";
            // 
            // query3
            // 
            this.query3.Controls.Add(this.revenue);
            this.query3.Controls.Add(this.label9);
            this.query3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.query3.ForeColor = System.Drawing.Color.White;
            this.query3.Location = new System.Drawing.Point(5, 163);
            this.query3.Name = "query3";
            this.query3.Size = new System.Drawing.Size(771, 390);
            this.query3.TabIndex = 9;
            this.query3.TabStop = false;
            this.query3.Text = "Выходные данные";
            this.query3.Visible = false;
            // 
            // revenue
            // 
            this.revenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.revenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.revenue.ForeColor = System.Drawing.Color.White;
            this.revenue.Location = new System.Drawing.Point(102, 27);
            this.revenue.Name = "revenue";
            this.revenue.Size = new System.Drawing.Size(372, 26);
            this.revenue.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(11, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Выручка:";
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.query1);
            this.Controls.Add(this.query3);
            this.Controls.Add(this.query2);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.labelForInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "index";
            this.Text = "MeatOn";
            this.Load += new System.EventHandler(this.index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDishes)).EndInit();
            this.query1.ResumeLayout(false);
            this.query1.PerformLayout();
            this.query2.ResumeLayout(false);
            this.query2.PerformLayout();
            this.query3.ResumeLayout(false);
            this.query3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelForInput;
        private System.Windows.Forms.NumericUpDown inputNumber;
        private System.Windows.Forms.ComboBox inputType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView orderDishes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dish;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.GroupBox query1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox querySelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectOrders;
        private System.Windows.Forms.TextBox fullcost;
        private System.Windows.Forms.TextBox dateto;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.GroupBox query2;
        private System.Windows.Forms.TextBox countOrders;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox query3;
        private System.Windows.Forms.TextBox revenue;
        private System.Windows.Forms.Label label9;
    }
}

