namespace Interface
{
    partial class FrmDeparture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeparture));
            this.dgvDeparture = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.cbPage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dtDateExit = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ndQuantityExit = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegisterExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuantityRegistered = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rtDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ColEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantityExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalExit = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeparture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantityExit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeparture
            // 
            this.dgvDeparture.AllowUserToAddRows = false;
            this.dgvDeparture.AllowUserToDeleteRows = false;
            this.dgvDeparture.AllowUserToResizeColumns = false;
            this.dgvDeparture.AllowUserToResizeRows = false;
            this.dgvDeparture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeparture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvDeparture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeparture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeparture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeparture.ColumnHeadersHeight = 40;
            this.dgvDeparture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEdit,
            this.ColDelete,
            this.ColId,
            this.ColDescription,
            this.ColDateExit,
            this.ColQuantityExit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeparture.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeparture.EnableHeadersVisualStyles = false;
            this.dgvDeparture.Location = new System.Drawing.Point(33, 336);
            this.dgvDeparture.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvDeparture.MultiSelect = false;
            this.dgvDeparture.Name = "dgvDeparture";
            this.dgvDeparture.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeparture.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeparture.RowHeadersVisible = false;
            this.dgvDeparture.RowHeadersWidth = 51;
            this.dgvDeparture.Size = new System.Drawing.Size(717, 107);
            this.dgvDeparture.TabIndex = 0;
            this.dgvDeparture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeparture_CellClick);
            this.dgvDeparture.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeparture_CellMouseEnter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbRows);
            this.panel1.Controls.Add(this.cbPage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnArrowRight);
            this.panel1.Controls.Add(this.btnArrowLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 49);
            this.panel1.TabIndex = 3;
            // 
            // cbRows
            // 
            this.cbRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.cbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRows.ForeColor = System.Drawing.Color.White;
            this.cbRows.FormattingEnabled = true;
            this.cbRows.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.cbRows.Location = new System.Drawing.Point(67, 11);
            this.cbRows.Name = "cbRows";
            this.cbRows.Size = new System.Drawing.Size(94, 26);
            this.cbRows.TabIndex = 16;
            this.cbRows.TabStop = false;
            // 
            // cbPage
            // 
            this.cbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.cbPage.DropDownHeight = 150;
            this.cbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPage.ForeColor = System.Drawing.Color.White;
            this.cbPage.FormattingEnabled = true;
            this.cbPage.IntegralHeight = false;
            this.cbPage.ItemHeight = 18;
            this.cbPage.Location = new System.Drawing.Point(539, 11);
            this.cbPage.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cbPage.Name = "cbPage";
            this.cbPage.Size = new System.Drawing.Size(97, 26);
            this.cbPage.TabIndex = 15;
            this.cbPage.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Página";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Exibir";
            // 
            // btnArrowRight
            // 
            this.btnArrowRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArrowRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowRight.Enabled = false;
            this.btnArrowRight.FlatAppearance.BorderSize = 0;
            this.btnArrowRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowRight.Image = global::Interface.Properties.Resources.right_arrow_grey;
            this.btnArrowRight.Location = new System.Drawing.Point(705, 6);
            this.btnArrowRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnArrowRight.Name = "btnArrowRight";
            this.btnArrowRight.Size = new System.Drawing.Size(38, 35);
            this.btnArrowRight.TabIndex = 10;
            this.btnArrowRight.TabStop = false;
            this.toolTip.SetToolTip(this.btnArrowRight, "Avançar para a próxima lista - CTRL+Seta Direita");
            this.btnArrowRight.UseVisualStyleBackColor = true;
            this.btnArrowRight.Click += new System.EventHandler(this.btnArrowRight_Click);
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowLeft.Enabled = false;
            this.btnArrowLeft.FlatAppearance.BorderSize = 0;
            this.btnArrowLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowLeft.Image = global::Interface.Properties.Resources.left_arrow_grey;
            this.btnArrowLeft.Location = new System.Drawing.Point(659, 6);
            this.btnArrowLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(38, 35);
            this.btnArrowLeft.TabIndex = 9;
            this.btnArrowLeft.TabStop = false;
            this.toolTip.SetToolTip(this.btnArrowLeft, "Voltar para a lista anterior - CTRL+Seta Esquerda");
            this.btnArrowLeft.UseVisualStyleBackColor = true;
            this.btnArrowLeft.Click += new System.EventHandler(this.btnArrowLeft_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data de saída";
            // 
            // dtDateExit
            // 
            this.dtDateExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDateExit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateExit.Location = new System.Drawing.Point(491, 197);
            this.dtDateExit.Name = "dtDateExit";
            this.dtDateExit.Size = new System.Drawing.Size(126, 26);
            this.dtDateExit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantidade ";
            // 
            // ndQuantityExit
            // 
            this.ndQuantityExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ndQuantityExit.Location = new System.Drawing.Point(623, 197);
            this.ndQuantityExit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndQuantityExit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndQuantityExit.Name = "ndQuantityExit";
            this.ndQuantityExit.Size = new System.Drawing.Size(110, 26);
            this.ndQuantityExit.TabIndex = 2;
            this.ndQuantityExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ndQuantityExit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(371, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 52);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegisterExit
            // 
            this.btnRegisterExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterExit.Location = new System.Drawing.Point(557, 256);
            this.btnRegisterExit.Name = "btnRegisterExit";
            this.btnRegisterExit.Size = new System.Drawing.Size(193, 52);
            this.btnRegisterExit.TabIndex = 3;
            this.btnRegisterExit.TabStop = false;
            this.btnRegisterExit.Text = "Registrar saída";
            this.btnRegisterExit.UseVisualStyleBackColor = true;
            this.btnRegisterExit.Click += new System.EventHandler(this.btnRegisterExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblTotalExit);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblQuantityRegistered);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblNameProduct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 122);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblQuantityRegistered
            // 
            this.lblQuantityRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantityRegistered.BackColor = System.Drawing.Color.White;
            this.lblQuantityRegistered.ForeColor = System.Drawing.Color.Black;
            this.lblQuantityRegistered.Location = new System.Drawing.Point(303, 62);
            this.lblQuantityRegistered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityRegistered.Name = "lblQuantityRegistered";
            this.lblQuantityRegistered.Size = new System.Drawing.Size(112, 24);
            this.lblQuantityRegistered.TabIndex = 19;
            this.lblQuantityRegistered.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quant. inicial";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameProduct.BackColor = System.Drawing.Color.White;
            this.lblNameProduct.ForeColor = System.Drawing.Color.Black;
            this.lblNameProduct.Location = new System.Drawing.Point(21, 62);
            this.lblNameProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(274, 24);
            this.lblNameProduct.TabIndex = 16;
            this.lblNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome do produto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(42, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 25);
            this.panel2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Detalhes";
            // 
            // rtDescription
            // 
            this.rtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtDescription.Location = new System.Drawing.Point(31, 169);
            this.rtDescription.Name = "rtDescription";
            this.rtDescription.Size = new System.Drawing.Size(454, 68);
            this.rtDescription.TabIndex = 24;
            this.rtDescription.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Descrição";
            // 
            // ColEdit
            // 
            this.ColEdit.HeaderText = "Editar";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "Excluir";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            // 
            // ColId
            // 
            this.ColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColId.Visible = false;
            this.ColId.Width = 26;
            // 
            // ColDescription
            // 
            this.ColDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDescription.HeaderText = "Descrição";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.ReadOnly = true;
            // 
            // ColDateExit
            // 
            this.ColDateExit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDateExit.HeaderText = "Data da saída";
            this.ColDateExit.MinimumWidth = 6;
            this.ColDateExit.Name = "ColDateExit";
            this.ColDateExit.ReadOnly = true;
            this.ColDateExit.Width = 131;
            // 
            // ColQuantityExit
            // 
            this.ColQuantityExit.HeaderText = "Quantidade";
            this.ColQuantityExit.Name = "ColQuantityExit";
            this.ColQuantityExit.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Quant. saídas";
            // 
            // label10
            // 
            this.lblTotalExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalExit.BackColor = System.Drawing.Color.White;
            this.lblTotalExit.ForeColor = System.Drawing.Color.Black;
            this.lblTotalExit.Location = new System.Drawing.Point(423, 62);
            this.lblTotalExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalExit.Name = "label10";
            this.lblTotalExit.Size = new System.Drawing.Size(112, 24);
            this.lblTotalExit.TabIndex = 21;
            this.lblTotalExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(543, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 24);
            this.label11.TabIndex = 23;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(543, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Saldo";
            // 
            // FrmDeparture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(762, 499);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtDescription);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterExit);
            this.Controls.Add(this.ndQuantityExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDeparture);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(778, 486);
            this.Name = "FrmDeparture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Saída";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProducts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeparture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantityExit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDeparture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPage;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cbRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDateExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ndQuantityExit;
        private System.Windows.Forms.Button  btnRegisterExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQuantityRegistered;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewImageColumn ColEdit;
        private System.Windows.Forms.DataGridViewImageColumn ColDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantityExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalExit;
        private System.Windows.Forms.Label label9;
    }
}