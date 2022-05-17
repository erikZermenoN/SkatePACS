namespace ProyectoPACSD
{
    partial class frmVentas
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
            DevExpress.XtraBars.BarManager barManager;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnMostrarFactura = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategoria = new DevExpress.XtraBars.BarButtonItem();
            this.btnArticulo = new DevExpress.XtraBars.BarButtonItem();
            this.btnProveedor = new DevExpress.XtraBars.BarButtonItem();
            this.btnVenta = new DevExpress.XtraBars.BarButtonItem();
            this.btnsuario = new DevExpress.XtraBars.BarButtonItem();
            this.gcVenta = new DevExpress.XtraGrid.GridControl();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colnoComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            barManager = new DevExpress.XtraBars.BarManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            barManager.DockControls.Add(this.barDockControl1);
            barManager.DockControls.Add(this.barDockControlBottom);
            barManager.DockControls.Add(this.barDockControlLeft);
            barManager.DockControls.Add(this.barDockControlRight);
            barManager.Form = this;
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.btnCategoria,
            this.btnArticulo,
            this.btnProveedor,
            this.btnVenta,
            this.btnsuario,
            this.btnActualizar,
            this.btnMostrarFactura,
            this.btnNuevo});
            barManager.MaxItemId = 13;
            barManager.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Never;
            barManager.OptionsLayout.AllowAddNewItems = false;
            barManager.PopupMenuAlignment = DevExpress.XtraBars.PopupMenuAlignment.Left;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMostrarFactura, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 1;
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 9;
            this.btnActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizar.ImageOptions.SvgImage")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 11;
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnMostrarFactura
            // 
            this.btnMostrarFactura.Caption = "Mostrar Factura";
            this.btnMostrarFactura.Id = 10;
            this.btnMostrarFactura.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMostrarFactura.ImageOptions.SvgImage")));
            this.btnMostrarFactura.Name = "btnMostrarFactura";
            this.btnMostrarFactura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMostrarFactura_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = barManager;
            this.barDockControl1.Size = new System.Drawing.Size(626, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 332);
            this.barDockControlBottom.Manager = barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(626, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 308);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(626, 24);
            this.barDockControlRight.Manager = barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 308);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 3;
            this.btnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSalir.ImageOptions.SvgImage")));
            this.btnSalir.Name = "btnSalir";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Caption = "Categorias";
            this.btnCategoria.Id = 4;
            this.btnCategoria.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCategoria.ImageOptions.SvgImage")));
            this.btnCategoria.Name = "btnCategoria";
            // 
            // btnArticulo
            // 
            this.btnArticulo.Caption = "Articulos";
            this.btnArticulo.Id = 5;
            this.btnArticulo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnArticulo.ImageOptions.SvgImage")));
            this.btnArticulo.Name = "btnArticulo";
            // 
            // btnProveedor
            // 
            this.btnProveedor.Caption = "Proveedores";
            this.btnProveedor.Id = 6;
            this.btnProveedor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProveedor.ImageOptions.SvgImage")));
            this.btnProveedor.Name = "btnProveedor";
            // 
            // btnVenta
            // 
            this.btnVenta.Caption = "Ventas";
            this.btnVenta.Id = 7;
            this.btnVenta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVenta.ImageOptions.SvgImage")));
            this.btnVenta.Name = "btnVenta";
            // 
            // btnsuario
            // 
            this.btnsuario.Caption = "Usuarios";
            this.btnsuario.Id = 8;
            this.btnsuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsuario.ImageOptions.SvgImage")));
            this.btnsuario.Name = "btnsuario";
            // 
            // gcVenta
            // 
            this.gcVenta.DataSource = this.ventaBindingSource;
            this.gcVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVenta.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcVenta.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcVenta.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcVenta.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcVenta.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcVenta.Location = new System.Drawing.Point(0, 24);
            this.gcVenta.MainView = this.gvVenta;
            this.gcVenta.MenuManager = barManager;
            this.gcVenta.Name = "gcVenta";
            this.gcVenta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupUsuario});
            this.gcVenta.Size = new System.Drawing.Size(626, 308);
            this.gcVenta.TabIndex = 5;
            this.gcVenta.UseEmbeddedNavigator = true;
            this.gcVenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVenta});
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(BML.Venta);
            // 
            // gvVenta
            // 
            this.gvVenta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVenta,
            this.colidUsuario,
            this.colnoComprobante,
            this.colfecha,
            this.coltotal});
            this.gvVenta.GridControl = this.gcVenta;
            this.gvVenta.Name = "gvVenta";
            this.gvVenta.OptionsBehavior.Editable = false;
            this.gvVenta.OptionsCustomization.AllowColumnResizing = false;
            this.gvVenta.OptionsView.ColumnAutoWidth = false;
            this.gvVenta.OptionsView.ShowAutoFilterRow = true;
            this.gvVenta.OptionsView.ShowGroupPanel = false;
            // 
            // colidVenta
            // 
            this.colidVenta.Caption = "ID";
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.OptionsColumn.AllowMove = false;
            this.colidVenta.Visible = true;
            this.colidVenta.VisibleIndex = 0;
            // 
            // colidUsuario
            // 
            this.colidUsuario.Caption = "Empleado";
            this.colidUsuario.ColumnEdit = this.rlupUsuario;
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.OptionsColumn.AllowMove = false;
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 2;
            // 
            // rlupUsuario
            // 
            this.rlupUsuario.AutoHeight = false;
            this.rlupUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupUsuario.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idUsuario", "id Usuario", 56, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Empleado", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoP", "apellido P", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apellidoM", "apellido M", 56, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("correo", "correo", 40, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "tipo", 27, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuario", "usuario", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("contrasena", "contrasena", 63, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 38, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupUsuario.DataSource = this.usuarioBindingSource;
            this.rlupUsuario.DisplayMember = "nombre";
            this.rlupUsuario.Name = "rlupUsuario";
            this.rlupUsuario.ShowFooter = false;
            this.rlupUsuario.ShowHeader = false;
            this.rlupUsuario.ValueMember = "idUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(BML.Usuario);
            // 
            // colnoComprobante
            // 
            this.colnoComprobante.Caption = "No. Comprobante";
            this.colnoComprobante.FieldName = "noComprobante";
            this.colnoComprobante.Name = "colnoComprobante";
            this.colnoComprobante.OptionsColumn.AllowMove = false;
            this.colnoComprobante.Visible = true;
            this.colnoComprobante.VisibleIndex = 1;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.AllowMove = false;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowMove = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 4;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 332);
            this.Controls.Add(this.gcVenta);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmVentas.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnMostrarFactura;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcVenta;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupUsuario;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnoComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarButtonItem btnCategoria;
        private DevExpress.XtraBars.BarButtonItem btnArticulo;
        private DevExpress.XtraBars.BarButtonItem btnProveedor;
        private DevExpress.XtraBars.BarButtonItem btnVenta;
        private DevExpress.XtraBars.BarButtonItem btnsuario;
    }
}