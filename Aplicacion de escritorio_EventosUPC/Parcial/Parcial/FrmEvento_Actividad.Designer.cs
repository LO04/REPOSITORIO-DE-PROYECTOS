namespace Parcial
{
    partial class FrmEvento_Actividad
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
            this.eventoActividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistrarActividad = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idactividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ideventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ideventoactividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbEvento_Acividad = new System.Windows.Forms.DataGridView();
            this.btnquitar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnbuscarActividad = new System.Windows.Forms.Button();
            this.cbActividadBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscarEvento = new System.Windows.Forms.Button();
            this.cbEventobuscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.eventoActividadBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbEvento_Acividad)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventoActividadBindingSource
            // 
            this.eventoActividadBindingSource.DataSource = typeof(Entities.Evento_Actividad);
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
            this.groupBox1.TabIndex = 8;
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
            this.tableLayoutPanel4.Controls.Add(this.btnRegistrarActividad, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(288, 71);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnRegistrarActividad
            // 
            this.btnRegistrarActividad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarActividad.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarActividad.FlatAppearance.BorderSize = 0;
            this.btnRegistrarActividad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnRegistrarActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnRegistrarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarActividad.Font = new System.Drawing.Font("Arial", 9F);
            this.btnRegistrarActividad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarActividad.Location = new System.Drawing.Point(94, 15);
            this.btnRegistrarActividad.Name = "btnRegistrarActividad";
            this.btnRegistrarActividad.Size = new System.Drawing.Size(100, 40);
            this.btnRegistrarActividad.TabIndex = 5;
            this.btnRegistrarActividad.Text = "REGISTRAR";
            this.btnRegistrarActividad.UseVisualStyleBackColor = false;
            this.btnRegistrarActividad.Click += new System.EventHandler(this.btnRegistrarActividad_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dtHoraFin, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbActividad, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbEvento, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtHoraInicio, 1, 2);
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
            // dtHoraFin
            // 
            this.dtHoraFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtHoraFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtHoraFin.Font = new System.Drawing.Font("Arial", 8.5F);
            this.dtHoraFin.Location = new System.Drawing.Point(150, 206);
            this.dtHoraFin.Name = "dtHoraFin";
            this.dtHoraFin.Size = new System.Drawing.Size(141, 21);
            this.dtHoraFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora de inicio:";
            // 
            // cbActividad
            // 
            this.cbActividad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbActividad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbActividad.DisplayMember = "nombre";
            this.cbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActividad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbActividad.Font = new System.Drawing.Font("Arial", 10F);
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(150, 81);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(141, 24);
            this.cbActividad.TabIndex = 2;
            this.cbActividad.ValueMember = "id_Actividad";
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
            this.label3.Location = new System.Drawing.Point(41, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Actividad:";
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
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora de fin:";
            // 
            // dtHoraInicio
            // 
            this.dtHoraInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtHoraInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtHoraInicio.Font = new System.Drawing.Font("Arial", 8.5F);
            this.dtHoraInicio.Location = new System.Drawing.Point(150, 144);
            this.dtHoraInicio.Name = "dtHoraInicio";
            this.dtHoraInicio.Size = new System.Drawing.Size(141, 21);
            this.dtHoraInicio.TabIndex = 3;
            this.dtHoraInicio.ValueChanged += new System.EventHandler(this.dtHoraInicio_ValueChanged);
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
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE ACTIVIDAD";
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
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgbEvento_Acividad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 377);
            this.panel2.TabIndex = 1;
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
            // eventoDataGridViewTextBoxColumn
            // 
            this.eventoDataGridViewTextBoxColumn.DataPropertyName = "Evento";
            this.eventoDataGridViewTextBoxColumn.HeaderText = "Evento";
            this.eventoDataGridViewTextBoxColumn.Name = "eventoDataGridViewTextBoxColumn";
            this.eventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventoDataGridViewTextBoxColumn.Visible = false;
            this.eventoDataGridViewTextBoxColumn.Width = 78;
            // 
            // actividadDataGridViewTextBoxColumn
            // 
            this.actividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actividadDataGridViewTextBoxColumn.DataPropertyName = "Actividad";
            this.actividadDataGridViewTextBoxColumn.HeaderText = "Actividad";
            this.actividadDataGridViewTextBoxColumn.Name = "actividadDataGridViewTextBoxColumn";
            this.actividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.actividadDataGridViewTextBoxColumn.Visible = false;
            // 
            // horafinDataGridViewTextBoxColumn
            // 
            this.horafinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horafinDataGridViewTextBoxColumn.DataPropertyName = "hora_fin";
            this.horafinDataGridViewTextBoxColumn.HeaderText = "hora_fin";
            this.horafinDataGridViewTextBoxColumn.Name = "horafinDataGridViewTextBoxColumn";
            this.horafinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horainicioDataGridViewTextBoxColumn
            // 
            this.horainicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horainicioDataGridViewTextBoxColumn.DataPropertyName = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.HeaderText = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.Name = "horainicioDataGridViewTextBoxColumn";
            this.horainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
            this.nombreActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "NombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "NombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            this.nombreActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEventoDataGridViewTextBoxColumn
            // 
            this.nombreEventoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreEventoDataGridViewTextBoxColumn.DataPropertyName = "NombreEvento";
            this.nombreEventoDataGridViewTextBoxColumn.HeaderText = "NombreEvento";
            this.nombreEventoDataGridViewTextBoxColumn.Name = "nombreEventoDataGridViewTextBoxColumn";
            this.nombreEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idactividadDataGridViewTextBoxColumn
            // 
            this.idactividadDataGridViewTextBoxColumn.DataPropertyName = "id_actividad";
            this.idactividadDataGridViewTextBoxColumn.HeaderText = "id_actividad";
            this.idactividadDataGridViewTextBoxColumn.Name = "idactividadDataGridViewTextBoxColumn";
            this.idactividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idactividadDataGridViewTextBoxColumn.Visible = false;
            this.idactividadDataGridViewTextBoxColumn.Width = 115;
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
            // ideventoactividadDataGridViewTextBoxColumn
            // 
            this.ideventoactividadDataGridViewTextBoxColumn.DataPropertyName = "id_evento_actividad";
            this.ideventoactividadDataGridViewTextBoxColumn.HeaderText = "id_evento_actividad";
            this.ideventoactividadDataGridViewTextBoxColumn.Name = "ideventoactividadDataGridViewTextBoxColumn";
            this.ideventoactividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.ideventoactividadDataGridViewTextBoxColumn.Visible = false;
            this.ideventoactividadDataGridViewTextBoxColumn.Width = 168;
            // 
            // dgbEvento_Acividad
            // 
            this.dgbEvento_Acividad.AllowUserToAddRows = false;
            this.dgbEvento_Acividad.AllowUserToDeleteRows = false;
            this.dgbEvento_Acividad.AutoGenerateColumns = false;
            this.dgbEvento_Acividad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgbEvento_Acividad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbEvento_Acividad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgbEvento_Acividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbEvento_Acividad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgbEvento_Acividad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEvento_Acividad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbEvento_Acividad.ColumnHeadersHeight = 30;
            this.dgbEvento_Acividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgbEvento_Acividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ideventoactividadDataGridViewTextBoxColumn,
            this.ideventoDataGridViewTextBoxColumn,
            this.idactividadDataGridViewTextBoxColumn,
            this.nombreEventoDataGridViewTextBoxColumn,
            this.nombreActividadDataGridViewTextBoxColumn,
            this.horainicioDataGridViewTextBoxColumn,
            this.horafinDataGridViewTextBoxColumn,
            this.actividadDataGridViewTextBoxColumn,
            this.eventoDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dgbEvento_Acividad.DataSource = this.eventoActividadBindingSource;
            this.dgbEvento_Acividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbEvento_Acividad.EnableHeadersVisualStyles = false;
            this.dgbEvento_Acividad.GridColor = System.Drawing.Color.SteelBlue;
            this.dgbEvento_Acividad.Location = new System.Drawing.Point(0, 0);
            this.dgbEvento_Acividad.Name = "dgbEvento_Acividad";
            this.dgbEvento_Acividad.ReadOnly = true;
            this.dgbEvento_Acividad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbEvento_Acividad.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgbEvento_Acividad.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgbEvento_Acividad.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgbEvento_Acividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbEvento_Acividad.Size = new System.Drawing.Size(542, 377);
            this.dgbEvento_Acividad.TabIndex = 1;
            this.dgbEvento_Acividad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbEvento_Acividad_CellClick_2);
            this.dgbEvento_Acividad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbEvento_Acividad_CellContentClick);
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
            // cbActividadBuscar
            // 
            this.cbActividadBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbActividadBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbActividadBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbActividadBuscar.DisplayMember = "nombre";
            this.cbActividadBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActividadBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbActividadBuscar.Font = new System.Drawing.Font("Arial", 10F);
            this.cbActividadBuscar.FormattingEnabled = true;
            this.cbActividadBuscar.Location = new System.Drawing.Point(272, 3);
            this.cbActividadBuscar.Name = "cbActividadBuscar";
            this.cbActividadBuscar.Size = new System.Drawing.Size(129, 24);
            this.cbActividadBuscar.TabIndex = 10;
            this.cbActividadBuscar.ValueMember = "id_actividad";
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
            this.tableLayoutPanel3.Controls.Add(this.cbActividadBuscar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnbuscarActividad, 2, 2);
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
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // FrmEvento_Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(848, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEvento_Actividad";
            this.Text = "FrmEvento_Actividad";
            this.Load += new System.EventHandler(this.FrmEvento_Actividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventoActividadBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbEvento_Acividad)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource eventoActividadBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnRegistrarActividad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtHoraFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtHoraInicio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgbEvento_Acividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideventoactividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idactividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEventobuscar;
        private System.Windows.Forms.Button btnBuscarEvento;
        private System.Windows.Forms.ComboBox cbActividadBuscar;
        private System.Windows.Forms.Button btnbuscarActividad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnquitar;
    }
}