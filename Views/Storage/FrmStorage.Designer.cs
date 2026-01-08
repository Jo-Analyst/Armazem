namespace Interface
{
    partial class FrmStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStorage));
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRows = new System.Windows.Forms.ComboBox();
            this.cbPage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDateEntry = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ndQuantityStock = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ColRegisterExit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantityStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantityExit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantityStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 40;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRegisterExit,
            this.ColEdit,
            this.ColDelete,
            this.ColId,
            this.ColDateEntry,
            this.ColQuantityStock,
            this.ColQuantityExit,
            this.ColBalance});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(31, 161);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.Size = new System.Drawing.Size(835, 229);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProduct.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellMouseEnter);
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
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 49);
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
            this.cbPage.Location = new System.Drawing.Point(660, 11);
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
            this.label2.Location = new System.Drawing.Point(591, 14);
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
            this.btnArrowRight.Location = new System.Drawing.Point(826, 6);
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
            this.btnArrowLeft.Location = new System.Drawing.Point(780, 6);
            this.btnArrowLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(38, 35);
            this.btnArrowLeft.TabIndex = 9;
            this.btnArrowLeft.TabStop = false;
            this.toolTip.SetToolTip(this.btnArrowLeft, "Voltar para a lista anterior - CTRL+Seta Esquerda");
            this.btnArrowLeft.UseVisualStyleBackColor = true;
            this.btnArrowLeft.Click += new System.EventHandler(this.btnArrowLeft_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome do produto";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.BackColor = System.Drawing.Color.White;
            this.lblNameProduct.ForeColor = System.Drawing.Color.Black;
            this.lblNameProduct.Location = new System.Drawing.Point(28, 48);
            this.lblNameProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(331, 24);
            this.lblNameProduct.TabIndex = 0;
            this.lblNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data de Entrada";
            // 
            // dtDateEntry
            // 
            this.dtDateEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateEntry.Location = new System.Drawing.Point(31, 114);
            this.dtDateEntry.Name = "dtDateEntry";
            this.dtDateEntry.Size = new System.Drawing.Size(126, 26);
            this.dtDateEntry.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantidade no estoque";
            // 
            // ndQuantityStock
            // 
            this.ndQuantityStock.Location = new System.Drawing.Point(178, 114);
            this.ndQuantityStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ndQuantityStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndQuantityStock.Name = "ndQuantityStock";
            this.ndQuantityStock.Size = new System.Drawing.Size(167, 26);
            this.ndQuantityStock.TabIndex = 2;
            this.ndQuantityStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ndQuantityStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(564, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 52);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(370, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 52);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ColRegisterExit
            // 
            this.ColRegisterExit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRegisterExit.HeaderText = "Registrar Saída";
            this.ColRegisterExit.Name = "ColRegisterExit";
            this.ColRegisterExit.ReadOnly = true;
            this.ColRegisterExit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColRegisterExit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColRegisterExit.Width = 142;
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
            // ColDateEntry
            // 
            this.ColDateEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDateEntry.HeaderText = "Data de Entrada";
            this.ColDateEntry.MinimumWidth = 6;
            this.ColDateEntry.Name = "ColDateEntry";
            this.ColDateEntry.ReadOnly = true;
            // 
            // ColQuantityStock
            // 
            this.ColQuantityStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColQuantityStock.HeaderText = "Quant. Inicial";
            this.ColQuantityStock.Name = "ColQuantityStock";
            this.ColQuantityStock.ReadOnly = true;
            this.ColQuantityStock.Width = 121;
            // 
            // ColQuantityExit
            // 
            this.ColQuantityExit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColQuantityExit.HeaderText = "Quant. de saídas";
            this.ColQuantityExit.Name = "ColQuantityExit";
            this.ColQuantityExit.ReadOnly = true;
            this.ColQuantityExit.Width = 150;
            // 
            // ColBalance
            // 
            this.ColBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColBalance.HeaderText = "Saldo";
            this.ColBalance.Name = "ColBalance";
            this.ColBalance.ReadOnly = true;
            this.ColBalance.Width = 74;
            // 
            // FrmStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(883, 447);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ndQuantityStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateEntry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProduct);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(899, 486);
            this.Name = "FrmStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProducts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantityStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPage;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cbRows;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDateEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ndQuantityStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewImageColumn ColRegisterExit;
        private System.Windows.Forms.DataGridViewImageColumn ColEdit;
        private System.Windows.Forms.DataGridViewImageColumn ColDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantityStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantityExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBalance;
    }
}