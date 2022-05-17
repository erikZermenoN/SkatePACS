namespace ProyectoPACSD
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
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
            this.gcProveedor = new DevExpress.XtraGrid.GridControl();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            barManager = new DevExpress.XtraBars.BarManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedor)).BeginInit();
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
            this.btnModificar,
            this.btnNuevo,
            this.btnEliminar});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 10;
            this.btnModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModificar.ImageOptions.SvgImage")));
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 12;
            this.btnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminar.ImageOptions.SvgImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
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
            // gcProveedor
            // 
            this.gcProveedor.DataSource = this.proveedorBindingSource;
            this.gcProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProveedor.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcProveedor.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcProveedor.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcProveedor.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcProveedor.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcProveedor.Location = new System.Drawing.Point(0, 24);
            this.gcProveedor.MainView = this.gvProveedor;
            this.gcProveedor.MenuManager = barManager;
            this.gcProveedor.Name = "gcProveedor";
            this.gcProveedor.Size = new System.Drawing.Size(626, 308);
            this.gcProveedor.TabIndex = 8;
            this.gcProveedor.UseEmbeddedNavigator = true;
            this.gcProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProveedor});
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(BML.Proveedor);
            // 
            // gvProveedor
            // 
            this.gvProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidProveedor,
            this.colnombre,
            this.coltelefono,
            this.colcorreo,
            this.colactivo});
            this.gvProveedor.GridControl = this.gcProveedor;
            this.gvProveedor.Name = "gvProveedor";
            this.gvProveedor.OptionsBehavior.Editable = false;
            this.gvProveedor.OptionsCustomization.AllowColumnResizing = false;
            this.gvProveedor.OptionsView.ColumnAutoWidth = false;
            this.gvProveedor.OptionsView.ShowAutoFilterRow = true;
            this.gvProveedor.OptionsView.ShowGroupPanel = false;
            // 
            // colidProveedor
            // 
            this.colidProveedor.Caption = "ID";
            this.colidProveedor.FieldName = "idProveedor";
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.OptionsColumn.AllowMove = false;
            this.colidProveedor.Visible = true;
            this.colidProveedor.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowMove = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.AllowMove = false;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 2;
            // 
            // colcorreo
            // 
            this.colcorreo.Caption = "Correo Electronico";
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.OptionsColumn.AllowMove = false;
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 3;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.OptionsColumn.AllowMove = false;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 332);
            this.Controls.Add(this.gcProveedor);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmProveedores.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarButtonItem btnCategoria;
        private DevExpress.XtraBars.BarButtonItem btnArticulo;
        private DevExpress.XtraBars.BarButtonItem btnProveedor;
        private DevExpress.XtraBars.BarButtonItem btnVenta;
        private DevExpress.XtraBars.BarButtonItem btnsuario;
        private DevExpress.XtraGrid.GridControl gcProveedor;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colidProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}