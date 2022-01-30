
namespace Actividad_1__Aplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label ratingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cATEGORIABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Actividad_1__Aplicacion.BibliotecaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cATEGORIABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cATEGORIATableAdapter = new Actividad_1__Aplicacion.BibliotecaDataSetTableAdapters.CATEGORIATableAdapter();
            this.tableAdapterManager = new Actividad_1__Aplicacion.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.datosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasDataSet = new Actividad_1__Aplicacion.PeliculasDataSet();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.datosTableAdapter = new Actividad_1__Aplicacion.PeliculasDataSetTableAdapters.DatosTableAdapter();
            this.tableAdapterManager1 = new Actividad_1__Aplicacion.PeliculasDataSetTableAdapters.TableAdapterManager();
            this.peliculaTableAdapter = new Actividad_1__Aplicacion.PeliculasDataSetTableAdapters.PeliculaTableAdapter();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingNavigator)).BeginInit();
            this.cATEGORIABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(18, 82);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 117);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 20);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 152);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "Description:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(12, 183);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(58, 20);
            fechaLabel.TabIndex = 10;
            fechaLabel.Text = "Fecha:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(12, 217);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(67, 20);
            generoLabel.TabIndex = 12;
            generoLabel.Text = "Genero:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(12, 248);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(69, 20);
            directorLabel.TabIndex = 14;
            directorLabel.Text = "Director:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(12, 277);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(60, 20);
            ratingLabel.TabIndex = 16;
            ratingLabel.Text = "Rating:";
            // 
            // cATEGORIABindingNavigator
            // 
            this.cATEGORIABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cATEGORIABindingNavigator.BindingSource = this.cATEGORIABindingSource;
            this.cATEGORIABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cATEGORIABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cATEGORIABindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cATEGORIABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cATEGORIABindingNavigatorSaveItem});
            this.cATEGORIABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cATEGORIABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cATEGORIABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cATEGORIABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cATEGORIABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cATEGORIABindingNavigator.Name = "cATEGORIABindingNavigator";
            this.cATEGORIABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cATEGORIABindingNavigator.Size = new System.Drawing.Size(1574, 33);
            this.cATEGORIABindingNavigator.TabIndex = 1;
            this.cATEGORIABindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // cATEGORIABindingNavigatorSaveItem
            // 
            this.cATEGORIABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cATEGORIABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cATEGORIABindingNavigatorSaveItem.Image")));
            this.cATEGORIABindingNavigatorSaveItem.Name = "cATEGORIABindingNavigatorSaveItem";
            this.cATEGORIABindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.cATEGORIABindingNavigatorSaveItem.Text = "Guardar datos";
            this.cATEGORIABindingNavigatorSaveItem.Click += new System.EventHandler(this.cATEGORIABindingNavigatorSaveItem_Click);
            // 
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = this.cATEGORIATableAdapter;
            this.tableAdapterManager.LIBROTableAdapter = null;
            this.tableAdapterManager.LIBROUNIDADESTableAdapter = null;
            this.tableAdapterManager.UBICACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Actividad_1__Aplicacion.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENTATableAdapter = null;
            // 
            // datosDataGridView1
            // 
            this.datosDataGridView1.AutoGenerateColumns = false;
            this.datosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.datosDataGridView1.DataSource = this.datosBindingSource;
            this.datosDataGridView1.Location = new System.Drawing.Point(386, 82);
            this.datosDataGridView1.Name = "datosDataGridView1";
            this.datosDataGridView1.RowHeadersWidth = 62;
            this.datosDataGridView1.RowTemplate.Height = 28;
            this.datosDataGridView1.Size = new System.Drawing.Size(1112, 234);
            this.datosDataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn12.HeaderText = "name";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn13.HeaderText = "Description";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn14.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn15.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Director";
            this.dataGridViewTextBoxColumn16.HeaderText = "Director";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn17.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataMember = "Datos";
            this.datosBindingSource.DataSource = this.peliculasDataSet;
            // 
            // peliculasDataSet
            // 
            this.peliculasDataSet.DataSetName = "PeliculasDataSet";
            this.peliculasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(117, 82);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(219, 26);
            this.iDTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(117, 114);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(219, 26);
            this.nameTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(117, 146);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(219, 26);
            this.descriptionTextBox.TabIndex = 9;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datosBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(117, 178);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(219, 26);
            this.fechaDateTimePicker.TabIndex = 11;
            // 
            // generoTextBox
            // 
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosBindingSource, "Genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(117, 210);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(219, 26);
            this.generoTextBox.TabIndex = 13;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosBindingSource, "Director", true));
            this.directorTextBox.Location = new System.Drawing.Point(117, 242);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(219, 26);
            this.directorTextBox.TabIndex = 15;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datosBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(117, 274);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(219, 26);
            this.ratingTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 30);
            this.button3.TabIndex = 20;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // datosTableAdapter
            // 
            this.datosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DatosTableAdapter = this.datosTableAdapter;
            this.tableAdapterManager1.PeliculaTableAdapter = this.peliculaTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Actividad_1__Aplicacion.PeliculasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // peliculaTableAdapter
            // 
            this.peliculaTableAdapter.ClearBeforeFill = true;
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataMember = "Pelicula";
            this.peliculaBindingSource.DataSource = this.peliculasDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.datosDataGridView1);
            this.Controls.Add(this.cATEGORIABindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingNavigator)).EndInit();
            this.cATEGORIABindingNavigator.ResumeLayout(false);
            this.cATEGORIABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private BibliotecaDataSetTableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cATEGORIABindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cATEGORIABindingNavigatorSaveItem;
        private PeliculasDataSet peliculasDataSet;
        private System.Windows.Forms.BindingSource datosBindingSource;
        private PeliculasDataSetTableAdapters.DatosTableAdapter datosTableAdapter;
        private PeliculasDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private PeliculasDataSetTableAdapters.PeliculaTableAdapter peliculaTableAdapter;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private System.Windows.Forms.DataGridView datosDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

