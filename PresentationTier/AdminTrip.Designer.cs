namespace PresentationTier
{
    partial class AdminTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTrip));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEditTrip = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDeleteTrip = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSaveTrip = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TripDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.sYSTEM_BUSDataSet = new PresentationTier.SYSTEM_BUSDataSet();
            this.tRIPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRIPSTableAdapter = new PresentationTier.SYSTEM_BUSDataSetTableAdapters.TRIPSTableAdapter();
            this.AvailableDriverCombo = new System.Windows.Forms.ComboBox();
            this.sPLISTAVAILABLEDRIVERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LIST_AVAILABLE_DRIVERTableAdapter = new PresentationTier.SYSTEM_BUSDataSetTableAdapters.SP_LIST_AVAILABLE_DRIVERTableAdapter();
            this.AvailableBusCombo = new System.Windows.Forms.ComboBox();
            this.sPLISTAVAILABLEBUSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LIST_AVAILABLE_BUSESTableAdapter = new PresentationTier.SYSTEM_BUSDataSetTableAdapters.SP_LIST_AVAILABLE_BUSESTableAdapter();
            this.AvailableRouteCombo = new System.Windows.Forms.ComboBox();
            this.sPLISTAVAILABLEJOURNEYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LIST_AVAILABLE_JOURNEYTableAdapter = new PresentationTier.SYSTEM_BUSDataSetTableAdapters.SP_LIST_AVAILABLE_JOURNEYTableAdapter();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnBavkHome = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.TripDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTEM_BUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTAVAILABLEDRIVERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTAVAILABLEBUSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTAVAILABLEJOURNEYBindingSource)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBavkHome)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditTrip
            // 
            this.BtnEditTrip.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditTrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditTrip.BorderRadius = 0;
            this.BtnEditTrip.ButtonText = "EDITAR";
            this.BtnEditTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditTrip.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditTrip.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditTrip.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEditTrip.Iconimage")));
            this.BtnEditTrip.Iconimage_right = null;
            this.BtnEditTrip.Iconimage_right_Selected = null;
            this.BtnEditTrip.Iconimage_Selected = null;
            this.BtnEditTrip.IconMarginLeft = 0;
            this.BtnEditTrip.IconMarginRight = 0;
            this.BtnEditTrip.IconRightVisible = true;
            this.BtnEditTrip.IconRightZoom = 0D;
            this.BtnEditTrip.IconVisible = true;
            this.BtnEditTrip.IconZoom = 90D;
            this.BtnEditTrip.IsTab = false;
            this.BtnEditTrip.Location = new System.Drawing.Point(414, 60);
            this.BtnEditTrip.Name = "BtnEditTrip";
            this.BtnEditTrip.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnEditTrip.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnEditTrip.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditTrip.selected = false;
            this.BtnEditTrip.Size = new System.Drawing.Size(152, 48);
            this.BtnEditTrip.TabIndex = 45;
            this.BtnEditTrip.Text = "EDITAR";
            this.BtnEditTrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditTrip.Textcolor = System.Drawing.Color.White;
            this.BtnEditTrip.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditTrip.Click += new System.EventHandler(this.BtnEditTrip_Click);
            // 
            // BtnDeleteTrip
            // 
            this.BtnDeleteTrip.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDeleteTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDeleteTrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeleteTrip.BorderRadius = 0;
            this.BtnDeleteTrip.ButtonText = "BORRAR";
            this.BtnDeleteTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteTrip.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDeleteTrip.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDeleteTrip.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteTrip.Iconimage")));
            this.BtnDeleteTrip.Iconimage_right = null;
            this.BtnDeleteTrip.Iconimage_right_Selected = null;
            this.BtnDeleteTrip.Iconimage_Selected = null;
            this.BtnDeleteTrip.IconMarginLeft = 0;
            this.BtnDeleteTrip.IconMarginRight = 0;
            this.BtnDeleteTrip.IconRightVisible = true;
            this.BtnDeleteTrip.IconRightZoom = 0D;
            this.BtnDeleteTrip.IconVisible = true;
            this.BtnDeleteTrip.IconZoom = 90D;
            this.BtnDeleteTrip.IsTab = false;
            this.BtnDeleteTrip.Location = new System.Drawing.Point(223, 60);
            this.BtnDeleteTrip.Name = "BtnDeleteTrip";
            this.BtnDeleteTrip.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDeleteTrip.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnDeleteTrip.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDeleteTrip.selected = false;
            this.BtnDeleteTrip.Size = new System.Drawing.Size(145, 48);
            this.BtnDeleteTrip.TabIndex = 42;
            this.BtnDeleteTrip.Text = "BORRAR";
            this.BtnDeleteTrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteTrip.Textcolor = System.Drawing.Color.White;
            this.BtnDeleteTrip.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteTrip.Click += new System.EventHandler(this.BtnDeleteTrip_Click);
            // 
            // BtnSaveTrip
            // 
            this.BtnSaveTrip.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveTrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSaveTrip.BorderRadius = 0;
            this.BtnSaveTrip.ButtonText = "GUARDAR";
            this.BtnSaveTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveTrip.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSaveTrip.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSaveTrip.Iconimage = null;
            this.BtnSaveTrip.Iconimage_right = null;
            this.BtnSaveTrip.Iconimage_right_Selected = null;
            this.BtnSaveTrip.Iconimage_Selected = null;
            this.BtnSaveTrip.IconMarginLeft = 0;
            this.BtnSaveTrip.IconMarginRight = 0;
            this.BtnSaveTrip.IconRightVisible = true;
            this.BtnSaveTrip.IconRightZoom = 0D;
            this.BtnSaveTrip.IconVisible = true;
            this.BtnSaveTrip.IconZoom = 90D;
            this.BtnSaveTrip.IsTab = false;
            this.BtnSaveTrip.Location = new System.Drawing.Point(29, 60);
            this.BtnSaveTrip.Name = "BtnSaveTrip";
            this.BtnSaveTrip.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSaveTrip.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSaveTrip.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSaveTrip.selected = false;
            this.BtnSaveTrip.Size = new System.Drawing.Size(145, 48);
            this.BtnSaveTrip.TabIndex = 41;
            this.BtnSaveTrip.Text = "GUARDAR";
            this.BtnSaveTrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSaveTrip.Textcolor = System.Drawing.Color.White;
            this.BtnSaveTrip.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveTrip.Click += new System.EventHandler(this.BtnSaveTrip_Click);
            // 
            // TripDataGrid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TripDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TripDataGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.TripDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TripDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TripDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TripDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TripDataGrid.DoubleBuffered = true;
            this.TripDataGrid.EnableHeadersVisualStyles = false;
            this.TripDataGrid.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.TripDataGrid.HeaderForeColor = System.Drawing.Color.SkyBlue;
            this.TripDataGrid.Location = new System.Drawing.Point(29, 114);
            this.TripDataGrid.Name = "TripDataGrid";
            this.TripDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TripDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TripDataGrid.Size = new System.Drawing.Size(537, 377);
            this.TripDataGrid.TabIndex = 37;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(747, 263);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(400, 251);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 43;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 0;
            // 
            // sYSTEM_BUSDataSet
            // 
            this.sYSTEM_BUSDataSet.DataSetName = "SYSTEM_BUSDataSet";
            this.sYSTEM_BUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRIPSBindingSource
            // 
            this.tRIPSBindingSource.DataMember = "TRIPS";
            this.tRIPSBindingSource.DataSource = this.sYSTEM_BUSDataSet;
            // 
            // tRIPSTableAdapter
            // 
            this.tRIPSTableAdapter.ClearBeforeFill = true;
            // 
            // AvailableDriverCombo
            // 
            this.AvailableDriverCombo.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.tRIPSBindingSource, "ID_DRIVER", true));
            this.AvailableDriverCombo.DataSource = this.sPLISTAVAILABLEDRIVERBindingSource;
            this.AvailableDriverCombo.DisplayMember = "FULL NAME";
            this.AvailableDriverCombo.DropDownHeight = 200;
            this.AvailableDriverCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailableDriverCombo.FormattingEnabled = true;
            this.AvailableDriverCombo.IntegralHeight = false;
            this.AvailableDriverCombo.ItemHeight = 13;
            this.AvailableDriverCombo.Location = new System.Drawing.Point(626, 114);
            this.AvailableDriverCombo.Name = "AvailableDriverCombo";
            this.AvailableDriverCombo.Size = new System.Drawing.Size(308, 21);
            this.AvailableDriverCombo.TabIndex = 49;
            this.AvailableDriverCombo.ValueMember = "FULL NAME";
            // 
            // sPLISTAVAILABLEDRIVERBindingSource
            // 
            this.sPLISTAVAILABLEDRIVERBindingSource.DataMember = "SP_LIST_AVAILABLE_DRIVER";
            this.sPLISTAVAILABLEDRIVERBindingSource.DataSource = this.sYSTEM_BUSDataSet;
            // 
            // sP_LIST_AVAILABLE_DRIVERTableAdapter
            // 
            this.sP_LIST_AVAILABLE_DRIVERTableAdapter.ClearBeforeFill = true;
            // 
            // AvailableBusCombo
            // 
            this.AvailableBusCombo.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.tRIPSBindingSource, "ID_DRIVER", true));
            this.AvailableBusCombo.DataSource = this.sPLISTAVAILABLEBUSESBindingSource;
            this.AvailableBusCombo.DisplayMember = "AUTOBUS";
            this.AvailableBusCombo.DropDownHeight = 400;
            this.AvailableBusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailableBusCombo.DropDownWidth = 400;
            this.AvailableBusCombo.FormattingEnabled = true;
            this.AvailableBusCombo.IntegralHeight = false;
            this.AvailableBusCombo.Location = new System.Drawing.Point(626, 191);
            this.AvailableBusCombo.Name = "AvailableBusCombo";
            this.AvailableBusCombo.Size = new System.Drawing.Size(308, 21);
            this.AvailableBusCombo.TabIndex = 50;
            this.AvailableBusCombo.ValueMember = "AUTOBUS";
            // 
            // sPLISTAVAILABLEBUSESBindingSource
            // 
            this.sPLISTAVAILABLEBUSESBindingSource.DataMember = "SP_LIST_AVAILABLE_BUSES";
            this.sPLISTAVAILABLEBUSESBindingSource.DataSource = this.sYSTEM_BUSDataSet;
            // 
            // sP_LIST_AVAILABLE_BUSESTableAdapter
            // 
            this.sP_LIST_AVAILABLE_BUSESTableAdapter.ClearBeforeFill = true;
            // 
            // AvailableRouteCombo
            // 
            this.AvailableRouteCombo.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.tRIPSBindingSource, "ID_DRIVER", true));
            this.AvailableRouteCombo.DataSource = this.sPLISTAVAILABLEJOURNEYBindingSource;
            this.AvailableRouteCombo.DisplayMember = "ROUTE";
            this.AvailableRouteCombo.DropDownHeight = 400;
            this.AvailableRouteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailableRouteCombo.DropDownWidth = 400;
            this.AvailableRouteCombo.FormattingEnabled = true;
            this.AvailableRouteCombo.IntegralHeight = false;
            this.AvailableRouteCombo.Location = new System.Drawing.Point(626, 274);
            this.AvailableRouteCombo.Name = "AvailableRouteCombo";
            this.AvailableRouteCombo.Size = new System.Drawing.Size(308, 21);
            this.AvailableRouteCombo.TabIndex = 51;
            this.AvailableRouteCombo.ValueMember = "ROUTE";
            // 
            // sPLISTAVAILABLEJOURNEYBindingSource
            // 
            this.sPLISTAVAILABLEJOURNEYBindingSource.DataMember = "SP_LIST_AVAILABLE_JOURNEY";
            this.sPLISTAVAILABLEJOURNEYBindingSource.DataSource = this.sYSTEM_BUSDataSet;
            // 
            // sP_LIST_AVAILABLE_JOURNEYTableAdapter
            // 
            this.sP_LIST_AVAILABLE_JOURNEYTableAdapter.ClearBeforeFill = true;
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1001, 53);
            this.bunifuGradientPanel1.TabIndex = 52;
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
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
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
            // AdminTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 529);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.AvailableRouteCombo);
            this.Controls.Add(this.AvailableBusCombo);
            this.Controls.Add(this.AvailableDriverCombo);
            this.Controls.Add(this.BtnEditTrip);
            this.Controls.Add(this.BtnDeleteTrip);
            this.Controls.Add(this.BtnSaveTrip);
            this.Controls.Add(this.TripDataGrid);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "AdminTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTrip";
            this.Load += new System.EventHandler(this.AdminTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TripDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSTEM_BUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTAVAILABLEDRIVERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTAVAILABLEBUSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTAVAILABLEJOURNEYBindingSource)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBavkHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnEditTrip;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDeleteTrip;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSaveTrip;
        private Bunifu.Framework.UI.BunifuCustomDataGrid TripDataGrid;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private SYSTEM_BUSDataSet sYSTEM_BUSDataSet;
        private System.Windows.Forms.BindingSource tRIPSBindingSource;
        private SYSTEM_BUSDataSetTableAdapters.TRIPSTableAdapter tRIPSTableAdapter;
        private System.Windows.Forms.ComboBox AvailableDriverCombo;
        private System.Windows.Forms.BindingSource sPLISTAVAILABLEDRIVERBindingSource;
        private SYSTEM_BUSDataSetTableAdapters.SP_LIST_AVAILABLE_DRIVERTableAdapter sP_LIST_AVAILABLE_DRIVERTableAdapter;
        private System.Windows.Forms.ComboBox AvailableBusCombo;
        private System.Windows.Forms.BindingSource sPLISTAVAILABLEBUSESBindingSource;
        private SYSTEM_BUSDataSetTableAdapters.SP_LIST_AVAILABLE_BUSESTableAdapter sP_LIST_AVAILABLE_BUSESTableAdapter;
        private System.Windows.Forms.ComboBox AvailableRouteCombo;
        private System.Windows.Forms.BindingSource sPLISTAVAILABLEJOURNEYBindingSource;
        private SYSTEM_BUSDataSetTableAdapters.SP_LIST_AVAILABLE_JOURNEYTableAdapter sP_LIST_AVAILABLE_JOURNEYTableAdapter;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton BtnBack;
        private Bunifu.Framework.UI.BunifuImageButton BtnBavkHome;
    }
}