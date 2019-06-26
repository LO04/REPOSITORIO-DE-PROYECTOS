namespace Parcial
{
    partial class FrmEvento_Material
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
            this.eventoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgbEvento_Material = new System.Windows.Forms.DataGridView();
            this.ideventomaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ideventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioAlquilerMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarEvento = new System.Windows.Forms.Button();
            this.btnbuscarActividad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.cbEventobuscar = new System.Windows.Forms.ComboBox();
            this.cbMaterialbuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistrarMaterial = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventoMaterialBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEvento_Material)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventoMaterialBindingSource
            // 
            this.eventoMaterialBindingSource.DataSource = typeof(Entities.Evento_Material);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(300, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 462);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgbEvento_Material);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 377);
            this.panel2.TabIndex = 1;
            // 
            // dgbEvento_Material
            // 
            this.dgbEvento_Material.AllowUserToAddRows = false;
            this.dgbEvento_Material.AllowUserToDeleteRows = false;
            this.dgbEvento_Material.AutoGenerateColumns = false;
            this.dgbEvento_Material.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgbEvento_Material.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbEvento_Material.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgbEvento_Material.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbEvento_Material.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgbEvento_Material.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEvento_Material.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbEvento_Material.ColumnHeadersHeight = 30;
            this.dgbEvento_Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbEvento_Material.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ideventomaterialDataGridViewTextBoxColumn,
            this.ideventoDataGridViewTextBoxColumn,
            this.idmaterialDataGridViewTextBoxColumn,
            this.eventoDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.nombreEventoDataGridViewTextBoxColumn,
            this.nombreMaterialDataGridViewTextBoxColumn,
            this.PrecioAlquilerMaterial,
            this.Eliminar});
            this.dgbEvento_Material.DataSource = this.eventoMaterialBindingSource;
            this.dgbEvento_Material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbEvento_Material.EnableHeadersVisualStyles = false;
            this.dgbEvento_Material.GridColor = System.Drawing.Color.SteelBlue;
            this.dgbEvento_Material.Location = new System.Drawing.Point(0, 0);
            this.dgbEvento_Material.Name = "dgbEvento_Material";
            this.dgbEvento_Material.ReadOnly = true;
            this.dgbEvento_Material.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEvento_Material.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgbEvento_Material.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgbEvento_Material.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgbEvento_Material.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbEvento_Material.Size = new System.Drawing.Size(542, 377);
            this.dgbEvento_Material.TabIndex = 2;
            this.dgbEvento_Material.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbEvento_Material_CellClick_2);
            // 
            // ideventomaterialDataGridViewTextBoxColumn
            // 
            this.ideventomaterialDataGridViewTextBoxColumn.DataPropertyName = "id_evento_material";
            this.ideventomaterialDataGridViewTextBoxColumn.HeaderText = "id_evento_material";
            this.ideventomaterialDataGridViewTextBoxColumn.Name = "ideventomaterialDataGridViewTextBoxColumn";
            this.ideventomaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.ideventomaterialDataGridViewTextBoxColumn.Visible = false;
            this.ideventomaterialDataGridViewTextBoxColumn.Width = 159;
            // 
            // ideventoDataGridViewTextBoxColumn
            // 
            this.ideventoDataGridViewTextBoxColumn.DataPropertyName = "id_evento";
            this.ideventoDataGridViewTextBoxColumn.HeaderText = "id_evento";
            this.ideventoDataGridViewTextBoxColumn.Name = "ideventoDataGridViewTextBoxColumn";
            this.ideventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ideventoDataGridViewTextBoxColumn.Visible = false;
            this.ideventoDataGridViewTextBoxColumn.Width = 98;
            // 
            // idmaterialDataGridViewTextBoxColumn
            // 
            this.idmaterialDataGridViewTextBoxColumn.DataPropertyName = "id_material";
            this.idmaterialDataGridViewTextBoxColumn.HeaderText = "id_material";
            this.idmaterialDataGridViewTextBoxColumn.Name = "idmaterialDataGridViewTextBoxColumn";
            this.idmaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmaterialDataGridViewTextBoxColumn.Visible = false;
            this.idmaterialDataGridViewTextBoxColumn.Width = 106;
            // 
            // eventoDataGridViewTextBoxColumn
            // 
            this.eventoDataGridViewTextBoxColumn.DataPropertyName = "Evento";
            this.eventoDataGridViewTextBoxColumn.HeaderText = "Evento";
            this.eventoDataGridViewTextBoxColumn.Name = "eventoDataGridViewTextBoxColumn";
            this.eventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventoDataGridViewTextBoxColumn.Visible = false;
            this.eventoDataGridViewTextBoxColumn.Width = 78;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialDataGridViewTextBoxColumn.Visible = false;
            this.materialDataGridViewTextBoxColumn.Width = 85;
            // 
            // nombreEventoDataGridViewTextBoxColumn
            // 
            this.nombreEventoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreEventoDataGridViewTextBoxColumn.DataPropertyName = "NombreEvento";
            this.nombreEventoDataGridViewTextBoxColumn.FillWeight = 111.9289F;
            this.nombreEventoDataGridViewTextBoxColumn.HeaderText = "NombreEvento";
            this.nombreEventoDataGridViewTextBoxColumn.Name = "nombreEventoDataGridViewTextBoxColumn";
            this.nombreEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMaterialDataGridViewTextBoxColumn
            // 
            this.nombreMaterialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreMaterialDataGridViewTextBoxColumn.DataPropertyName = "NombreMaterial";
            this.nombreMaterialDataGridViewTextBoxColumn.FillWeight = 111.9289F;
            this.nombreMaterialDataGridViewTextBoxColumn.HeaderText = "NombreMaterial";
            this.nombreMaterialDataGridViewTextBoxColumn.Name = "nombreMaterialDataGridViewTextBoxColumn";
            this.nombreMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PrecioAlquilerMaterial
            // 
            this.PrecioAlquilerMaterial.DataPropertyName = "PrecioAlquilerMaterial";
            this.PrecioAlquilerMaterial.HeaderText = "PrecioAlquilerMaterial";
            this.PrecioAlquilerMaterial.Name = "PrecioAlquilerMaterial";
            this.PrecioAlquilerMaterial.ReadOnly = true;
            this.PrecioAlquilerMaterial.Width = 170;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 76.14214F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 62;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 66);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.32061F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.48855F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0478F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0478F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscarEvento, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnbuscarActividad, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnquitar, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbEventobuscar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbMaterialbuscar, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.9697F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.42424F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(542, 66);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Filtrar por:";
            // 
            // btnBuscarEvento
            // 
            this.btnBuscarEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarEvento.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuscarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEvento.FlatAppearance.BorderSize = 0;
            this.btnBuscarEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnBuscarEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBuscarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEvento.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscarEvento.Location = new System.Drawing.Point(141, 42);
            this.btnBuscarEvento.Name = "btnBuscarEvento";
            this.btnBuscarEvento.Size = new System.Drawing.Size(86, 19);
            this.btnBuscarEvento.TabIndex = 9;
            this.btnBuscarEvento.Text = "Buscar";
            this.btnBuscarEvento.UseVisualStyleBackColor = false;
            this.btnBuscarEvento.Click += new System.EventHandler(this.btnBuscarEvento_Click);
            // 
            // btnbuscarActividad
            // 
            this.btnbuscarActividad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbuscarActividad.BackColor = System.Drawing.Color.DarkGray;
            this.btnbuscarActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarActividad.FlatAppearance.BorderSize = 0;
            this.btnbuscarActividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnbuscarActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnbuscarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarActividad.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnbuscarActividad.Location = new System.Drawing.Point(293, 42);
            this.btnbuscarActividad.Name = "btnbuscarActividad";
            this.btnbuscarActividad.Size = new System.Drawing.Size(86, 19);
            this.btnbuscarActividad.TabIndex = 11;
            this.btnbuscarActividad.Text = "Buscar";
            this.btnbuscarActividad.UseVisualStyleBackColor = false;
            this.btnbuscarActividad.Click += new System.EventHandler(this.btnbuscarActividad_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(433, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quitar Filtro:";
            // 
            // btnquitar
            // 
            this.btnquitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnquitar.BackColor = System.Drawing.Color.DarkGray;
            this.btnquitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquitar.FlatAppearance.BorderSize = 0;
            this.btnquitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnquitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitar.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnquitar.Location = new System.Drawing.Point(430, 42);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(86, 19);
            this.btnquitar.TabIndex = 13;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = false;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // cbEventobuscar
            // 
            this.cbEventobuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEventobuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbEventobuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEventobuscar.DisplayMember = "nombre";
            this.cbEventobuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventobuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEventobuscar.Font = new System.Drawing.Font("Arial", 10F);
            this.cbEventobuscar.FormattingEnabled = true;
            this.cbEventobuscar.Location = new System.Drawing.Point(113, 3);
            this.cbEventobuscar.Name = "cbEventobuscar";
            this.cbEventobuscar.Size = new System.Drawing.Size(141, 24);
            this.cbEventobuscar.TabIndex = 14;
            this.cbEventobuscar.ValueMember = "id_evento";
            // 
            // cbMaterialbuscar
            // 
            this.cbMaterialbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaterialbuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbMaterialbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMaterialbuscar.DisplayMember = "nombre";
            this.cbMaterialbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMaterialbuscar.Font = new System.Drawing.Font("Arial", 10F);
            this.cbMaterialbuscar.FormattingEnabled = true;
            this.cbMaterialbuscar.Location = new System.Drawing.Point(272, 3);
            this.cbMaterialbuscar.Name = "cbMaterialbuscar";
            this.cbMaterialbuscar.Size = new System.Drawing.Size(129, 24);
            this.cbMaterialbuscar.TabIndex = 15;
            this.cbMaterialbuscar.ValueMember = "id_material";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE MATERIAL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 66);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 462);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 369);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnRegistrarMaterial, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(288, 71);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnRegistrarMaterial
            // 
            this.btnRegistrarMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarMaterial.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarMaterial.FlatAppearance.BorderSize = 0;
            this.btnRegistrarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnRegistrarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRegistrarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMaterial.Font = new System.Drawing.Font("Arial", 9F);
            this.btnRegistrarMaterial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarMaterial.Location = new System.Drawing.Point(94, 15);
            this.btnRegistrarMaterial.Name = "btnRegistrarMaterial";
            this.btnRegistrarMaterial.Size = new System.Drawing.Size(100, 40);
            this.btnRegistrarMaterial.TabIndex = 3;
            this.btnRegistrarMaterial.Text = "REGISTRAR";
            this.btnRegistrarMaterial.UseVisualStyleBackColor = false;
            this.btnRegistrarMaterial.Click += new System.EventHandler(this.btnRegistrarMaterial_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbMaterial, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbEvento, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 313);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cbMaterial
            // 
            this.cbMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaterial.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMaterial.DisplayMember = "nombre";
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMaterial.Font = new System.Drawing.Font("Arial", 10F);
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(150, 81);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(141, 24);
            this.cbMaterial.TabIndex = 2;
            this.cbMaterial.ValueMember = "id_material";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Evento:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Material:";
            // 
            // cbEvento
            // 
            this.cbEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEvento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEvento.DisplayMember = "nombre";
            this.cbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEvento.Font = new System.Drawing.Font("Arial", 10F);
            this.cbEvento.FormattingEnabled = true;
            this.cbEvento.Location = new System.Drawing.Point(150, 19);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(141, 24);
            this.cbEvento.TabIndex = 1;
            this.cbEvento.ValueMember = "id_evento";
            // 
            // FrmEvento_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(848, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEvento_Material";
            this.Text = "FrmEvento_Material";
            this.Load += new System.EventHandler(this.FrmEvento_Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventoMaterialBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbEvento_Material)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource eventoMaterialBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnRegistrarMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEvento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgbEvento_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideventomaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioAlquilerMaterial;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarEvento;
        private System.Windows.Forms.Button btnbuscarActividad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.ComboBox cbEventobuscar;
        private System.Windows.Forms.ComboBox cbMaterialbuscar;
    }
}