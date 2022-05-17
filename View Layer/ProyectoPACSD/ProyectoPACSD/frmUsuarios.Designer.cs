namespace ProyectoPACSD
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
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
            this.gcUsuario = new DevExpress.XtraGrid.GridControl();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellidoP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellidoM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontrasena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            barManager = new DevExpress.XtraBars.BarManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).BeginInit();
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
            // gcUsuario
            // 
            this.gcUsuario.DataSource = this.usuarioBindingSource;
            this.gcUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsuario.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcUsuario.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcUsuario.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcUsuario.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcUsuario.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcUsuario.Location = new System.Drawing.Point(0, 24);
            this.gcUsuario.MainView = this.gvUsuario;
            this.gcUsuario.MenuManager = barManager;
            this.gcUsuario.Name = "gcUsuario";
            this.gcUsuario.Size = new System.Drawing.Size(626, 308);
            this.gcUsuario.TabIndex = 7;
            this.gcUsuario.UseEmbeddedNavigator = true;
            this.gcUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsuario});
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(BML.Usuario);
            // 
            // gvUsuario
            // 
            this.gvUsuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidUsuario,
            this.colnombre,
            this.colapellidoP,
            this.colapellidoM,
            this.coltelefono,
            this.colcorreo,
            this.coltipo,
            this.colusuario,
            this.colcontrasena,
            this.colactivo});
            this.gvUsuario.GridControl = this.gcUsuario;
            this.gvUsuario.Name = "gvUsuario";
            this.gvUsuario.OptionsBehavior.Editable = false;
            this.gvUsuario.OptionsCustomization.AllowColumnResizing = false;
            this.gvUsuario.OptionsView.ColumnAutoWidth = false;
            this.gvUsuario.OptionsView.ShowAutoFilterRow = true;
            this.gvUsuario.OptionsView.ShowGroupPanel = false;
            // 
            // colidUsuario
            // 
            this.colidUsuario.Caption = "ID";
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.OptionsColumn.AllowMove = false;
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre(s)";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.OptionsColumn.AllowMove = false;
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // colapellidoP
            // 
            this.colapellidoP.Caption = "Apellido Paterno";
            this.colapellidoP.FieldName = "apellidoP";
            this.colapellidoP.Name = "colapellidoP";
            this.colapellidoP.OptionsColumn.AllowMove = false;
            this.colapellidoP.Visible = true;
            this.colapellidoP.VisibleIndex = 2;
            // 
            // colapellidoM
            // 
            this.colapellidoM.Caption = "Apellido Materno";
            this.colapellidoM.FieldName = "apellidoM";
            this.colapellidoM.Name = "colapellidoM";
            this.colapellidoM.OptionsColumn.AllowMove = false;
            this.colapellidoM.Visible = true;
            this.colapellidoM.VisibleIndex = 3;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Telefono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.OptionsColumn.AllowMove = false;
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 4;
            // 
            // colcorreo
            // 
            this.colcorreo.Caption = "Correo Electronico";
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.OptionsColumn.AllowMove = false;
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 5;
            // 
            // coltipo
            // 
            this.coltipo.Caption = "Tipo de Usuario";
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            this.coltipo.OptionsColumn.AllowMove = false;
            this.coltipo.Visible = true;
            this.coltipo.VisibleIndex = 6;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "Usuario";
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.OptionsColumn.AllowMove = false;
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 7;
            // 
            // colcontrasena
            // 
            this.colcontrasena.Caption = "Contraseña";
            this.colcontrasena.FieldName = "contrasena";
            this.colcontrasena.Name = "colcontrasena";
            this.colcontrasena.OptionsColumn.AllowMove = false;
            this.colcontrasena.Visible = true;
            this.colcontrasena.VisibleIndex = 8;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.Name = "colactivo";
            this.colactivo.OptionsColumn.AllowMove = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 332);
            this.Controls.Add(this.gcUsuario);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmUsuarios.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuario)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsuario;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colapellidoP;
        private DevExpress.XtraGrid.Columns.GridColumn colapellidoM;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colcontrasena;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}