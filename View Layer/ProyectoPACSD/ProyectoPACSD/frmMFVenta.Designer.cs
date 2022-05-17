namespace ProyectoPACSD
{
    partial class frmMFVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMFVenta));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnRegresar = new DevExpress.XtraEditors.SimpleButton();
            this.gcDetalleVenta = new DevExpress.XtraGrid.GridControl();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDetalleVenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidDetalleVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupArticulo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupPrecio = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.txtFecha = new DevExpress.XtraEditors.LabelControl();
            this.txtEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTotal);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnRegresar);
            this.groupControl1.Controls.Add(this.gcDetalleVenta);
            this.groupControl1.Controls.Add(this.txtFecha);
            this.groupControl1.Controls.Add(this.txtEmpleado);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(335, 309);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(228, 282);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(0, 13);
            this.txtTotal.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(185, 282);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Total: $";
            // 
            // btnRegresar
            // 
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegresar.Location = new System.Drawing.Point(82, 277);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gcDetalleVenta
            // 
            this.gcDetalleVenta.DataSource = this.detalleVentaBindingSource;
            this.gcDetalleVenta.Location = new System.Drawing.Point(12, 71);
            this.gcDetalleVenta.MainView = this.gvDetalleVenta;
            this.gcDetalleVenta.Name = "gcDetalleVenta";
            this.gcDetalleVenta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupArticulo,
            this.rlupPrecio});
            this.gcDetalleVenta.Size = new System.Drawing.Size(311, 200);
            this.gcDetalleVenta.TabIndex = 5;
            this.gcDetalleVenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalleVenta});
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataSource = typeof(BML.DetalleVenta);
            // 
            // gvDetalleVenta
            // 
            this.gvDetalleVenta.ActiveFilterEnabled = false;
            this.gvDetalleVenta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidDetalleVenta,
            this.colidArticulo,
            this.colidVenta,
            this.colcantidad,
            this.coltotal,
            this.gridColumn1});
            this.gvDetalleVenta.GridControl = this.gcDetalleVenta;
            this.gvDetalleVenta.Name = "gvDetalleVenta";
            this.gvDetalleVenta.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvDetalleVenta.OptionsBehavior.Editable = false;
            this.gvDetalleVenta.OptionsCustomization.AllowColumnMoving = false;
            this.gvDetalleVenta.OptionsCustomization.AllowColumnResizing = false;
            this.gvDetalleVenta.OptionsCustomization.AllowFilter = false;
            this.gvDetalleVenta.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.gvDetalleVenta.OptionsFilter.AllowFilterEditor = false;
            this.gvDetalleVenta.OptionsFilter.InHeaderSearchMode = DevExpress.XtraGrid.Views.Grid.GridInHeaderSearchMode.Disabled;
            this.gvDetalleVenta.OptionsFilter.ShowInHeaderSearchResults = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchResultsMode.None;
            this.gvDetalleVenta.OptionsFind.ShowSearchNavButtons = false;
            this.gvDetalleVenta.OptionsHint.ShowColumnHeaderHints = false;
            this.gvDetalleVenta.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gvDetalleVenta.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDetalleVenta.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvDetalleVenta.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvDetalleVenta.OptionsSelection.UseIndicatorForSelection = false;
            this.gvDetalleVenta.OptionsView.ColumnAutoWidth = false;
            this.gvDetalleVenta.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvDetalleVenta.OptionsView.ShowGroupPanel = false;
            // 
            // colidDetalleVenta
            // 
            this.colidDetalleVenta.FieldName = "idDetalleVenta";
            this.colidDetalleVenta.Name = "colidDetalleVenta";
            this.colidDetalleVenta.OptionsColumn.AllowIncrementalSearch = false;
            this.colidDetalleVenta.OptionsColumn.AllowMove = false;
            this.colidDetalleVenta.OptionsFilter.AllowAutoFilter = false;
            this.colidDetalleVenta.OptionsFilter.AllowFilter = false;
            // 
            // colidArticulo
            // 
            this.colidArticulo.Caption = "Articulo";
            this.colidArticulo.ColumnEdit = this.rlupArticulo;
            this.colidArticulo.FieldName = "idArticulo";
            this.colidArticulo.Name = "colidArticulo";
            this.colidArticulo.OptionsColumn.AllowIncrementalSearch = false;
            this.colidArticulo.OptionsColumn.AllowMove = false;
            this.colidArticulo.OptionsFilter.AllowAutoFilter = false;
            this.colidArticulo.OptionsFilter.AllowFilter = false;
            this.colidArticulo.Visible = true;
            this.colidArticulo.VisibleIndex = 0;
            // 
            // rlupArticulo
            // 
            this.rlupArticulo.AutoHeight = false;
            this.rlupArticulo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupArticulo.DataSource = this.articuloBindingSource;
            this.rlupArticulo.DisplayMember = "nombre";
            this.rlupArticulo.Name = "rlupArticulo";
            this.rlupArticulo.ShowFooter = false;
            this.rlupArticulo.ShowHeader = false;
            this.rlupArticulo.ValueMember = "idArticulo";
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(BML.Articulo);
            // 
            // colidVenta
            // 
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.OptionsColumn.AllowIncrementalSearch = false;
            this.colidVenta.OptionsColumn.AllowMove = false;
            this.colidVenta.OptionsFilter.AllowAutoFilter = false;
            this.colidVenta.OptionsFilter.AllowFilter = false;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.OptionsColumn.AllowIncrementalSearch = false;
            this.colcantidad.OptionsColumn.AllowMove = false;
            this.colcantidad.OptionsFilter.AllowAutoFilter = false;
            this.colcantidad.OptionsFilter.AllowFilter = false;
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowIncrementalSearch = false;
            this.coltotal.OptionsColumn.AllowMove = false;
            this.coltotal.OptionsFilter.AllowAutoFilter = false;
            this.coltotal.OptionsFilter.AllowFilter = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Precio Unitario";
            this.gridColumn1.ColumnEdit = this.rlupPrecio;
            this.gridColumn1.FieldName = "idArticulo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowIncrementalSearch = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // rlupPrecio
            // 
            this.rlupPrecio.AutoHeight = false;
            this.rlupPrecio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupPrecio.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idArticulo", "id Articulo", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCategoria", "id Categoria", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idProveedor", "id Proveedor", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("precio", "precio", 5, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("existencia", "existencia", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("imagen", "imagen", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupPrecio.DataSource = this.articuloBindingSource;
            this.rlupPrecio.DisplayMember = "precio";
            this.rlupPrecio.Name = "rlupPrecio";
            this.rlupPrecio.ShowFooter = false;
            this.rlupPrecio.ShowHeader = false;
            this.rlupPrecio.ValueMember = "idArticulo";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(178, 40);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(0, 13);
            this.txtFecha.TabIndex = 4;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(178, 12);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(0, 13);
            this.txtEmpleado.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(82, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha de la venta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(147, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Empleado que realizo la venta:";
            // 
            // frmMFVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRegresar;
            this.ClientSize = new System.Drawing.Size(335, 309);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMFVenta.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmMFVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mostrar Factura";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnRegresar;
        private DevExpress.XtraGrid.GridControl gcDetalleVenta;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalleVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidDetalleVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl txtFecha;
        private DevExpress.XtraEditors.LabelControl txtEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupArticulo;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupPrecio;
    }
}