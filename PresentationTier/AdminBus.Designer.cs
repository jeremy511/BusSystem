namespace PresentationTier
{
    partial class AdminBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnBavkHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.BusesDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bUSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSTEMBUSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSTEM_BUSDataSet = new PresentationTier.SYSTEM_BUSDataSet();
            this.TxtBrand = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtModel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtColor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnSaveBus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDeleteBus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.TxtYear = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtLicensePlate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bUSESTableAdapter = new PresentationTier.SYSTEM_BUSDataSetTableAdapters.BUSESTableAdapter();
            this.BtnEditBus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sPFINDDRIVERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_FIND_DRIVERTableAdapter = new PresentationTier.SYSTEM_BUSDataSetTableAdapters.SP_FIND_DRIVERTableAdapter();
            this.bUSESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sPFINDBUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_FIND_BUSTableAdapter = new PresentationTier.SYSTEM_BUSDataSetTableAdapters.SP_FIND_BUSTableAdapter();
            this.TxtId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBavkHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTEMBUSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTEM_BUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFINDDRIVERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFINDBUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtnBack);
            this.bunifuGradientPanel1.Controls.Add(this.BtnBavkHome);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(948, 53);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageActive = null;
            this.BtnBack.Location = new System.Drawing.Point(8, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(34, 33);
            this.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnBack.TabIndex = 3;
            this.BtnBack.TabStop = false;
            this.BtnBack.WaitOnLoad = true;
            this.BtnBack.Zoom = 6;
            this.BtnBack.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // BtnBavkHome
            // 
            this.BtnBavkHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnBavkHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnBavkHome.Image")));
            this.BtnBavkHome.ImageActive = null;
            this.BtnBavkHome.Location = new System.Drawing.Point(48, -7);
            this.BtnBavkHome.Name = "BtnBavkHome";
            this.BtnBavkHome.Size = new System.Drawing.Size(67, 60);
            this.BtnBavkHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBavkHome.TabIndex = 0;
            this.BtnBavkHome.TabStop = false;
            this.BtnBavkHome.Zoom = 0;
            // 
            // BusesDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BusesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BusesDataGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.BusesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BusesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BusesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusesDataGrid.DoubleBuffered = true;
            this.BusesDataGrid.EnableHeadersVisualStyles = false;
            this.BusesDataGrid.HeaderBgColor = System.Drawing.Color.Transparent;
            this.BusesDataGrid.HeaderForeColor = System.Drawing.Color.Transparent;
            this.BusesDataGrid.Location = new System.Drawing.Point(8, 154);
            this.BusesDataGrid.Name = "BusesDataGrid";
            this.BusesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BusesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BusesDataGrid.Size = new System.Drawing.Size(537, 377);
            this.BusesDataGrid.TabIndex = 2;
            // 
            // bUSESBindingSource
            // 
            this.bUSESBindingSource.DataMember = "BUSES";
            this.bUSESBindingSource.DataSource = this.sYSTEMBUSDataSetBindingSource;
            // 
            // sYSTEMBUSDataSetBindingSource
            // 
            this.sYSTEMBUSDataSetBindingSource.DataSource = this.sYSTEM_BUSDataSet;
            this.sYSTEMBUSDataSetBindingSource.Position = 0;
            // 
            // sYSTEM_BUSDataSet
            // 
            this.sYSTEM_BUSDataSet.DataSetName = "SYSTEM_BUSDataSet";
            this.sYSTEM_BUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtBrand
            // 
            this.TxtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBrand.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBrand.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBrand.HintText = "MARCA";
            this.TxtBrand.isPassword = false;
            this.TxtBrand.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtBrand.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtBrand.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtBrand.LineThickness = 3;
            this.TxtBrand.Location = new System.Drawing.Point(561, 154);
            this.TxtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(344, 44);
            this.TxtBrand.TabIndex = 3;
            this.TxtBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtModel
            // 
            this.TxtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtModel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtModel.HintForeColor = System.Drawing.Color.Empty;
            this.TxtModel.HintText = "MODELO";
            this.TxtModel.isPassword = false;
            this.TxtModel.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtModel.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtModel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtModel.LineThickness = 3;
            this.TxtModel.Location = new System.Drawing.Point(561, 226);
            this.TxtModel.Margin = new System.Windows.Forms.Padding(4);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(344, 44);
            this.TxtModel.TabIndex = 4;
            this.TxtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtColor
            // 
            this.TxtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtColor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtColor.HintForeColor = System.Drawing.Color.Empty;
            this.TxtColor.HintText = "COLOR";
            this.TxtColor.isPassword = false;
            this.TxtColor.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtColor.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtColor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtColor.LineThickness = 3;
            this.TxtColor.Location = new System.Drawing.Point(561, 384);
            this.TxtColor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(344, 44);
            this.TxtColor.TabIndex = 6;
            this.TxtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnSaveBus
            // 
            this.BtnSaveBus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSaveBus.BorderRadius = 0;
            this.BtnSaveBus.ButtonText = "GUARDAR";
            this.BtnSaveBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveBus.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSaveBus.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSaveBus.Iconimage = null;
            this.BtnSaveBus.Iconimage_right = null;
            this.BtnSaveBus.Iconimage_right_Selected = null;
            this.BtnSaveBus.Iconimage_Selected = null;
            this.BtnSaveBus.IconMarginLeft = 0;
            this.BtnSaveBus.IconMarginRight = 0;
            this.BtnSaveBus.IconRightVisible = true;
            this.BtnSaveBus.IconRightZoom = 0D;
            this.BtnSaveBus.IconVisible = true;
            this.BtnSaveBus.IconZoom = 90D;
            this.BtnSaveBus.IsTab = false;
            this.BtnSaveBus.Location = new System.Drawing.Point(12, 100);
            this.BtnSaveBus.Name = "BtnSaveBus";
            this.BtnSaveBus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveBus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSaveBus.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSaveBus.selected = false;
            this.BtnSaveBus.Size = new System.Drawing.Size(145, 48);
            this.BtnSaveBus.TabIndex = 7;
            this.BtnSaveBus.Text = "GUARDAR";
            this.BtnSaveBus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveBus.Textcolor = System.Drawing.Color.White;
            this.BtnSaveBus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveBus.Click += new System.EventHandler(this.BtnSaveBus_Click);
            // 
            // BtnDeleteBus
            // 
            this.BtnDeleteBus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDeleteBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDeleteBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeleteBus.BorderRadius = 0;
            this.BtnDeleteBus.ButtonText = "BORRAR";
            this.BtnDeleteBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteBus.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDeleteBus.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDeleteBus.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteBus.Iconimage")));
            this.BtnDeleteBus.Iconimage_right = null;
            this.BtnDeleteBus.Iconimage_right_Selected = null;
            this.BtnDeleteBus.Iconimage_Selected = null;
            this.BtnDeleteBus.IconMarginLeft = 0;
            this.BtnDeleteBus.IconMarginRight = 0;
            this.BtnDeleteBus.IconRightVisible = true;
            this.BtnDeleteBus.IconRightZoom = 0D;
            this.BtnDeleteBus.IconVisible = true;
            this.BtnDeleteBus.IconZoom = 90D;
            this.BtnDeleteBus.IsTab = false;
            this.BtnDeleteBus.Location = new System.Drawing.Point(203, 100);
            this.BtnDeleteBus.Name = "BtnDeleteBus";
            this.BtnDeleteBus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDeleteBus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnDeleteBus.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDeleteBus.selected = false;
            this.BtnDeleteBus.Size = new System.Drawing.Size(145, 48);
            this.BtnDeleteBus.TabIndex = 8;
            this.BtnDeleteBus.Text = "BORRAR";
            this.BtnDeleteBus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteBus.Textcolor = System.Drawing.Color.White;
            this.BtnDeleteBus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteBus.Click += new System.EventHandler(this.BtnDeleteBus_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(649, 303);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(400, 253);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 0;
            // 
            // TxtYear
            // 
            this.TxtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtYear.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtYear.HintForeColor = System.Drawing.Color.Empty;
            this.TxtYear.HintText = "ANO";
            this.TxtYear.isPassword = false;
            this.TxtYear.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtYear.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtYear.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtYear.LineThickness = 3;
            this.TxtYear.Location = new System.Drawing.Point(561, 462);
            this.TxtYear.Margin = new System.Windows.Forms.Padding(4);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(344, 44);
            this.TxtYear.TabIndex = 12;
            this.TxtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtLicensePlate
            // 
            this.TxtLicensePlate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLicensePlate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtLicensePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtLicensePlate.HintForeColor = System.Drawing.Color.Empty;
            this.TxtLicensePlate.HintText = "PLACA";
            this.TxtLicensePlate.isPassword = false;
            this.TxtLicensePlate.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtLicensePlate.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtLicensePlate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtLicensePlate.LineThickness = 3;
            this.TxtLicensePlate.Location = new System.Drawing.Point(561, 303);
            this.TxtLicensePlate.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLicensePlate.Name = "TxtLicensePlate";
            this.TxtLicensePlate.Size = new System.Drawing.Size(344, 44);
            this.TxtLicensePlate.TabIndex = 13;
            this.TxtLicensePlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bUSESTableAdapter
            // 
            this.bUSESTableAdapter.ClearBeforeFill = true;
            // 
            // BtnEditBus
            // 
            this.BtnEditBus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditBus.BorderRadius = 0;
            this.BtnEditBus.ButtonText = "EDITAR";
            this.BtnEditBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditBus.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditBus.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditBus.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEditBus.Iconimage")));
            this.BtnEditBus.Iconimage_right = null;
            this.BtnEditBus.Iconimage_right_Selected = null;
            this.BtnEditBus.Iconimage_Selected = null;
            this.BtnEditBus.IconMarginLeft = 0;
            this.BtnEditBus.IconMarginRight = 0;
            this.BtnEditBus.IconRightVisible = true;
            this.BtnEditBus.IconRightZoom = 0D;
            this.BtnEditBus.IconVisible = true;
            this.BtnEditBus.IconZoom = 90D;
            this.BtnEditBus.IsTab = false;
            this.BtnEditBus.Location = new System.Drawing.Point(393, 100);
            this.BtnEditBus.Name = "BtnEditBus";
            this.BtnEditBus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditBus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEditBus.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditBus.selected = false;
            this.BtnEditBus.Size = new System.Drawing.Size(152, 48);
            this.BtnEditBus.TabIndex = 15;
            this.BtnEditBus.Text = "EDITAR";
            this.BtnEditBus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditBus.Textcolor = System.Drawing.Color.White;
            this.BtnEditBus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditBus.Click += new System.EventHandler(this.BtnEditBus_Click_1);
            // 
            // sPFINDDRIVERBindingSource
            // 
            this.sPFINDDRIVERBindingSource.DataMember = "SP_FIND_DRIVER";
            this.sPFINDDRIVERBindingSource.DataSource = this.sYSTEMBUSDataSetBindingSource;
            // 
            // sP_FIND_DRIVERTableAdapter
            // 
            this.sP_FIND_DRIVERTableAdapter.ClearBeforeFill = true;
            // 
            // bUSESBindingSource1
            // 
            this.bUSESBindingSource1.DataMember = "BUSES";
            this.bUSESBindingSource1.DataSource = this.sYSTEMBUSDataSetBindingSource;
            // 
            // sPFINDBUSBindingSource
            // 
            this.sPFINDBUSBindingSource.DataMember = "SP_FIND_BUS";
            this.sPFINDBUSBindingSource.DataSource = this.sYSTEMBUSDataSetBindingSource;
            // 
            // sP_FIND_BUSTableAdapter
            // 
            this.sP_FIND_BUSTableAdapter.ClearBeforeFill = true;
            // 
            // TxtId
            // 
            this.TxtId.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtId.BorderThickness = 3;
            this.TxtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtId.isPassword = false;
            this.TxtId.Location = new System.Drawing.Point(561, 84);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(315, 44);
            this.TxtId.TabIndex = 14;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            this.TxtId.Click += new System.EventHandler(this.TxtId_Click);
            // 
            // AdminBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 543);
            this.Controls.Add(this.BtnEditBus);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtLicensePlate);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.BtnDeleteBus);
            this.Controls.Add(this.BtnSaveBus);
            this.Controls.Add(this.TxtColor);
            this.Controls.Add(this.TxtModel);
            this.Controls.Add(this.TxtBrand);
            this.Controls.Add(this.BusesDataGrid);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "AdminBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminBus_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBavkHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTEMBUSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTEM_BUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFINDDRIVERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFINDBUSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton BtnBavkHome;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BusesDataGrid;
        private Bunifu.Framework.UI.BunifuImageButton BtnBack;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBrand;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtModel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtColor;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSaveBus;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDeleteBus;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtYear;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtLicensePlate;
        private System.Windows.Forms.BindingSource sYSTEMBUSDataSetBindingSource;
        private SYSTEM_BUSDataSet sYSTEM_BUSDataSet;
        private System.Windows.Forms.BindingSource bUSESBindingSource;
        private SYSTEM_BUSDataSetTableAdapters.BUSESTableAdapter bUSESTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditBus;
        private System.Windows.Forms.BindingSource sPFINDDRIVERBindingSource;
        private SYSTEM_BUSDataSetTableAdapters.SP_FIND_DRIVERTableAdapter sP_FIND_DRIVERTableAdapter;
        private System.Windows.Forms.BindingSource bUSESBindingSource1;
        private System.Windows.Forms.BindingSource sPFINDBUSBindingSource;
        private SYSTEM_BUSDataSetTableAdapters.SP_FIND_BUSTableAdapter sP_FIND_BUSTableAdapter;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtId;
    }
}