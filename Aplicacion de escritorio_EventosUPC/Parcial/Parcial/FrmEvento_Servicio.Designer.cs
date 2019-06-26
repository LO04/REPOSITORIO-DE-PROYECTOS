namespace Parcial
{
    partial class FrmEvento_Servicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eventoServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgbEvento_Servicio = new System.Windows.Forms.DataGridView();
            this.ideventoservicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ideventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idservicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioAlquilerServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEventobuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscarEvento = new System.Windows.Forms.Button();
            this.cbServicioBuscar = new System.Windows.Forms.ComboBox();
            this.btnbuscarServicio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistrarServicio = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventoServicioBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEvento_Servicio)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventoServicioBindingSource
            // 
            this.eventoServicioBindingSource.DataSource = typeof(Entities.Evento_Servicio);
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
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgbEvento_Servicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 377);
            this.panel2.TabIndex = 1;
            // 
            // dgbEvento_Servicio
            // 
            this.dgbEvento_Servicio.AllowUserToAddRows = false;
            this.dgbEvento_Servicio.AllowUserToDeleteRows = false;
            this.dgbEvento_Servicio.AutoGenerateColumns = false;
            this.dgbEvento_Servicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgbEvento_Servicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbEvento_Servicio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgbEvento_Servicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbEvento_Servicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgbEvento_Servicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEvento_Servicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgbEvento_Servicio.ColumnHeadersHeight = 30;
            this.dgbEvento_Servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbEvento_Servicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ideventoservicioDataGridViewTextBoxColumn,
            this.ideventoDataGridViewTextBoxColumn,
            this.idservicioDataGridViewTextBoxColumn,
            this.eventoDataGridViewTextBoxColumn,
            this.servicioDataGridViewTextBoxColumn,
            this.nombreEventoDataGridViewTextBoxColumn,
            this.nombreServicioDataGridViewTextBoxColumn,
            this.PrecioAlquilerServicio,
            this.Eliminar});
            this.dgbEvento_Servicio.DataSource = this.eventoServicioBindingSource;
            this.dgbEvento_Servicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbEvento_Servicio.EnableHeadersVisualStyles = false;
            this.dgbEvento_Servicio.GridColor = System.Drawing.Color.SteelBlue;
            this.dgbEvento_Servicio.Location = new System.Drawing.Point(0, 0);
            this.dgbEvento_Servicio.Name = "dgbEvento_Servicio";
            this.dgbEvento_Servicio.ReadOnly = true;
            this.dgbEvento_Servicio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEvento_Servicio.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgbEvento_Servicio.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgbEvento_Servicio.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgbEvento_Servicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbEvento_Servicio.Size = new System.Drawing.Size(542, 377);
            this.dgbEvento_Servicio.TabIndex = 1;
            this.dgbEvento_Servicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbEvento_Servicio_CellClick_1);
            // 
            // ideventoservicioDataGridViewTextBoxColumn
            // 
            this.ideventoservicioDataGridViewTextBoxColumn.DataPropertyName = "id_evento_servicio";
            this.ideventoservicioDataGridViewTextBoxColumn.HeaderText = "id_evento_servicio";
            this.ideventoservicioDataGridViewTextBoxColumn.Name = "ideventoservicioDataGridViewTextBoxColumn";
            this.ideventoservicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.ideventoservicioDataGridViewTextBoxColumn.Visible = false;
            this.ideventoservicioDataGridViewTextBoxColumn.Width = 153;
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
            // idservicioDataGridViewTextBoxColumn
            // 
            this.idservicioDataGridViewTextBoxColumn.DataPropertyName = "id_servicio";
            this.idservicioDataGridViewTextBoxColumn.HeaderText = "id_servicio";
            this.idservicioDataGridViewTextBoxColumn.Name = "idservicioDataGridViewTextBoxColumn";
            this.idservicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idservicioDataGridViewTextBoxColumn.Visible = false;
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
            // servicioDataGridViewTextBoxColumn
            // 
            this.servicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio";
            this.servicioDataGridViewTextBoxColumn.HeaderText = "Servicio";
            this.servicioDataGridViewTextBoxColumn.Name = "servicioDataGridViewTextBoxColumn";
            this.servicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicioDataGridViewTextBoxColumn.Visible = false;
            this.servicioDataGridViewTextBoxColumn.Width = 82;
            // 
            // nombreEventoDataGridViewTextBoxColumn
            // 
            this.nombreEventoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreEventoDataGridViewTextBoxColumn.DataPropertyName = "NombreEvento";
            this.nombreEventoDataGridViewTextBoxColumn.HeaderText = "NombreEvento";
            this.nombreEventoDataGridViewTextBoxColumn.Name = "nombreEventoDataGridViewTextBoxColumn";
            this.nombreEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreServicioDataGridViewTextBoxColumn
            // 
            this.nombreServicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreServicioDataGridViewTextBoxColumn.DataPropertyName = "NombreServicio";
            this.nombreServicioDataGridViewTextBoxColumn.HeaderText = "NombreServicio";
            this.nombreServicioDataGridViewTextBoxColumn.Name = "nombreServicioDataGridViewTextBoxColumn";
            this.nombreServicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PrecioAlquilerServicio
            // 
            this.PrecioAlquilerServicio.DataPropertyName = "PrecioAlquilerServicio";
            this.PrecioAlquilerServicio.HeaderText = "PrecioAlquilerServicio";
            this.PrecioAlquilerServicio.Name = "PrecioAlquilerServicio";
            this.PrecioAlquilerServicio.ReadOnly = true;
            this.PrecioAlquilerServicio.Width = 167;
            // 
            // Eliminar
            // 
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
            this.tableLayoutPanel3.Controls.Add(this.cbEventobuscar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscarEvento, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbServicioBuscar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnbuscarServicio, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnquitar, 3, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.9697F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.42424F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(542, 66);
            this.tableLayoutPanel3.TabIndex = 4;
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
            this.cbEventobuscar.TabIndex = 2;
            this.cbEventobuscar.ValueMember = "id_evento";
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
            // cbServicioBuscar
            // 
            this.cbServicioBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbServicioBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbServicioBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbServicioBuscar.DisplayMember = "nombre";
            this.cbServicioBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicioBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbServicioBuscar.Font = new System.Drawing.Font("Arial", 10F);
            this.cbServicioBuscar.FormattingEnabled = true;
            this.cbServicioBuscar.Location = new System.Drawing.Point(275, 3);
            this.cbServicioBuscar.Name = "cbServicioBuscar";
            this.cbServicioBuscar.Size = new System.Drawing.Size(123, 24);
            this.cbServicioBuscar.TabIndex = 10;
            this.cbServicioBuscar.ValueMember = "id_servicio";
            // 
            // btnbuscarServicio
            // 
            this.btnbuscarServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbuscarServicio.BackColor = System.Drawing.Color.DarkGray;
            this.btnbuscarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarServicio.FlatAppearance.BorderSize = 0;
            this.btnbuscarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnbuscarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnbuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarServicio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnbuscarServicio.Location = new System.Drawing.Point(293, 42);
            this.btnbuscarServicio.Name = "btnbuscarServicio";
            this.btnbuscarServicio.Size = new System.Drawing.Size(86, 19);
            this.btnbuscarServicio.TabIndex = 11;
            this.btnbuscarServicio.Text = "Buscar";
            this.btnbuscarServicio.UseVisualStyleBackColor = false;
            this.btnbuscarServicio.Click += new System.EventHandler(this.btnbuscarServicio_Click);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE SERVICIO";
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
            this.groupBox1.TabIndex = 12;
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
            this.tableLayoutPanel4.Controls.Add(this.btnRegistrarServicio, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(288, 71);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnRegistrarServicio
            // 
            this.btnRegistrarServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarServicio.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarServicio.FlatAppearance.BorderSize = 0;
            this.btnRegistrarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnRegistrarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRegistrarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarServicio.Font = new System.Drawing.Font("Arial", 9F);
            this.btnRegistrarServicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarServicio.Location = new System.Drawing.Point(94, 15);
            this.btnRegistrarServicio.Name = "btnRegistrarServicio";
            this.btnRegistrarServicio.Size = new System.Drawing.Size(100, 40);
            this.btnRegistrarServicio.TabIndex = 3;
            this.btnRegistrarServicio.Text = "REGISTRAR";
            this.btnRegistrarServicio.UseVisualStyleBackColor = false;
            this.btnRegistrarServicio.Click += new System.EventHandler(this.btnRegistrarServicio_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbServicio, 1, 1);
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
            // cbServicio
            // 
            this.cbServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbServicio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbServicio.DisplayMember = "nombre";
            this.cbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbServicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(150, 81);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(141, 24);
            this.cbServicio.TabIndex = 2;
            this.cbServicio.ValueMember = "id_servicio";
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
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Servicio:";
            // 
            // cbEvento
            // 
            this.cbEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEvento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEvento.DisplayMember = "nombre";
            this.cbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEvento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbEvento.FormattingEnabled = true;
            this.cbEvento.Location = new System.Drawing.Point(150, 19);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(141, 24);
            this.cbEvento.TabIndex = 1;
            this.cbEvento.ValueMember = "id_evento";
            // 
            // FrmEvento_Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(848, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEvento_Servicio";
            this.Text = "FrmEvento_Servicio";
            this.Load += new System.EventHandler(this.FrmEvento_Servicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventoServicioBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbEvento_Servicio)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnRegistrarServicio;
        private System.Windows.Forms.BindingSource eventoServicioBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEvento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgbEvento_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideventoservicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioAlquilerServicio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEventobuscar;
        private System.Windows.Forms.Button btnBuscarEvento;
        private System.Windows.Forms.ComboBox cbServicioBuscar;
        private System.Windows.Forms.Button btnbuscarServicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnquitar;
    }
}