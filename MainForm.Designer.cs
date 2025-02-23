namespace RMBackground
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SubColorPanel = new SaaUI.SaaPanel();
            this.InputFileDraggerPANEL = new System.Windows.Forms.Panel();
            this.FinalImagePreview = new System.Windows.Forms.Panel();
            this.PANELpngBackground = new System.Windows.Forms.Panel();
            this.PICBOXFinalPreviewer = new System.Windows.Forms.PictureBox();
            this.PANELFinalQuickActions = new System.Windows.Forms.Panel();
            this.BTNCopyImage = new MaterialSkin.Controls.MaterialButton();
            this.BTNSaveImage = new MaterialSkin.Controls.MaterialButton();
            this.DragDropInstructionLABEL = new System.Windows.Forms.Label();
            this.ImagePathVALUE = new System.Windows.Forms.TextBox();
            this.OperationLoadingPANEL = new SaaUI.SaaPanel();
            this.saaPreloader1 = new SaaUI.SaaPreloader();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.SubColorPanel.SuspendLayout();
            this.InputFileDraggerPANEL.SuspendLayout();
            this.FinalImagePreview.SuspendLayout();
            this.PANELpngBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOXFinalPreviewer)).BeginInit();
            this.PANELFinalQuickActions.SuspendLayout();
            this.OperationLoadingPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubColorPanel
            // 
            this.SubColorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubColorPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubColorPanel.BackColorAngle = 90F;
            this.SubColorPanel.Border = 0;
            this.SubColorPanel.BorderColor = System.Drawing.Color.Transparent;
            this.SubColorPanel.BorderColor2 = System.Drawing.Color.Transparent;
            this.SubColorPanel.BorderColorAngle = 0;
            this.SubColorPanel.ColorType = SaaUI.PanelColorType.Default;
            this.SubColorPanel.Controls.Add(this.InputFileDraggerPANEL);
            this.SubColorPanel.EnableDoubleBuffering = true;
            this.SubColorPanel.ForceDrawRegion = true;
            this.SubColorPanel.Location = new System.Drawing.Point(39, 39);
            this.SubColorPanel.Margin = new System.Windows.Forms.Padding(30);
            this.SubColorPanel.Name = "SubColorPanel";
            this.SubColorPanel.Radius.BottomLeft = 30;
            this.SubColorPanel.Radius.BottomRight = 30;
            this.SubColorPanel.Radius.TopLeft = 30;
            this.SubColorPanel.Radius.TopRight = 30;
            this.SubColorPanel.Size = new System.Drawing.Size(706, 483);
            this.SubColorPanel.TabIndex = 0;
            this.SubColorPanel.Transparence = 100;
            // 
            // InputFileDraggerPANEL
            // 
            this.InputFileDraggerPANEL.AllowDrop = true;
            this.InputFileDraggerPANEL.Controls.Add(this.FinalImagePreview);
            this.InputFileDraggerPANEL.Controls.Add(this.DragDropInstructionLABEL);
            this.InputFileDraggerPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputFileDraggerPANEL.Location = new System.Drawing.Point(0, 0);
            this.InputFileDraggerPANEL.Name = "InputFileDraggerPANEL";
            this.InputFileDraggerPANEL.Size = new System.Drawing.Size(706, 483);
            this.InputFileDraggerPANEL.TabIndex = 1;
            this.InputFileDraggerPANEL.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputFileDraggerPANEL_DragDrop);
            this.InputFileDraggerPANEL.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputFileDraggerPANEL_DragEnter);
            // 
            // FinalImagePreview
            // 
            this.FinalImagePreview.Controls.Add(this.PANELpngBackground);
            this.FinalImagePreview.Controls.Add(this.PANELFinalQuickActions);
            this.FinalImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalImagePreview.Location = new System.Drawing.Point(0, 0);
            this.FinalImagePreview.Name = "FinalImagePreview";
            this.FinalImagePreview.Size = new System.Drawing.Size(706, 483);
            this.FinalImagePreview.TabIndex = 1;
            this.FinalImagePreview.Visible = false;
            // 
            // PANELpngBackground
            // 
            this.PANELpngBackground.BackgroundImage = global::RMBackground.Properties.Resources.png32;
            this.PANELpngBackground.Controls.Add(this.PICBOXFinalPreviewer);
            this.PANELpngBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANELpngBackground.Location = new System.Drawing.Point(0, 0);
            this.PANELpngBackground.Name = "PANELpngBackground";
            this.PANELpngBackground.Size = new System.Drawing.Size(706, 408);
            this.PANELpngBackground.TabIndex = 1;
            // 
            // PICBOXFinalPreviewer
            // 
            this.PICBOXFinalPreviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PICBOXFinalPreviewer.Location = new System.Drawing.Point(0, 0);
            this.PICBOXFinalPreviewer.Name = "PICBOXFinalPreviewer";
            this.PICBOXFinalPreviewer.Size = new System.Drawing.Size(706, 408);
            this.PICBOXFinalPreviewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICBOXFinalPreviewer.TabIndex = 0;
            this.PICBOXFinalPreviewer.TabStop = false;
            // 
            // PANELFinalQuickActions
            // 
            this.PANELFinalQuickActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PANELFinalQuickActions.Controls.Add(this.BTNCopyImage);
            this.PANELFinalQuickActions.Controls.Add(this.BTNSaveImage);
            this.PANELFinalQuickActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PANELFinalQuickActions.Location = new System.Drawing.Point(0, 408);
            this.PANELFinalQuickActions.Name = "PANELFinalQuickActions";
            this.PANELFinalQuickActions.Size = new System.Drawing.Size(706, 75);
            this.PANELFinalQuickActions.TabIndex = 0;
            // 
            // BTNCopyImage
            // 
            this.BTNCopyImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNCopyImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTNCopyImage.Depth = 0;
            this.BTNCopyImage.HighEmphasis = true;
            this.BTNCopyImage.Icon = null;
            this.BTNCopyImage.Location = new System.Drawing.Point(115, 19);
            this.BTNCopyImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTNCopyImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTNCopyImage.Name = "BTNCopyImage";
            this.BTNCopyImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTNCopyImage.Size = new System.Drawing.Size(140, 36);
            this.BTNCopyImage.TabIndex = 1;
            this.BTNCopyImage.Text = "Copy the image";
            this.BTNCopyImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTNCopyImage.UseAccentColor = false;
            this.BTNCopyImage.UseVisualStyleBackColor = false;
            this.BTNCopyImage.Click += new System.EventHandler(this.BTNCopyImage_Click);
            // 
            // BTNSaveImage
            // 
            this.BTNSaveImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNSaveImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTNSaveImage.Depth = 0;
            this.BTNSaveImage.HighEmphasis = true;
            this.BTNSaveImage.Icon = null;
            this.BTNSaveImage.Location = new System.Drawing.Point(27, 19);
            this.BTNSaveImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTNSaveImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTNSaveImage.Name = "BTNSaveImage";
            this.BTNSaveImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTNSaveImage.Size = new System.Drawing.Size(80, 36);
            this.BTNSaveImage.TabIndex = 0;
            this.BTNSaveImage.Text = "Save As";
            this.BTNSaveImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTNSaveImage.UseAccentColor = false;
            this.BTNSaveImage.UseMnemonic = false;
            this.BTNSaveImage.UseVisualStyleBackColor = false;
            this.BTNSaveImage.Click += new System.EventHandler(this.BTNSaveImage_Click);
            // 
            // DragDropInstructionLABEL
            // 
            this.DragDropInstructionLABEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DragDropInstructionLABEL.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropInstructionLABEL.ForeColor = System.Drawing.Color.Gray;
            this.DragDropInstructionLABEL.Location = new System.Drawing.Point(0, 0);
            this.DragDropInstructionLABEL.Name = "DragDropInstructionLABEL";
            this.DragDropInstructionLABEL.Size = new System.Drawing.Size(706, 483);
            this.DragDropInstructionLABEL.TabIndex = 0;
            this.DragDropInstructionLABEL.Text = "Drop a photo here";
            this.DragDropInstructionLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImagePathVALUE
            // 
            this.ImagePathVALUE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImagePathVALUE.Location = new System.Drawing.Point(243, 571);
            this.ImagePathVALUE.Name = "ImagePathVALUE";
            this.ImagePathVALUE.ReadOnly = true;
            this.ImagePathVALUE.Size = new System.Drawing.Size(529, 20);
            this.ImagePathVALUE.TabIndex = 2;
            this.ImagePathVALUE.Visible = false;
            this.ImagePathVALUE.WordWrap = false;
            // 
            // OperationLoadingPANEL
            // 
            this.OperationLoadingPANEL.BackColor = System.Drawing.Color.Black;
            this.OperationLoadingPANEL.BackColor2 = System.Drawing.Color.Black;
            this.OperationLoadingPANEL.BackColorAngle = 90F;
            this.OperationLoadingPANEL.Border = 0;
            this.OperationLoadingPANEL.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.OperationLoadingPANEL.BorderColor2 = System.Drawing.Color.LightSkyBlue;
            this.OperationLoadingPANEL.BorderColorAngle = 0;
            this.OperationLoadingPANEL.ColorType = SaaUI.PanelColorType.Default;
            this.OperationLoadingPANEL.Controls.Add(this.saaPreloader1);
            this.OperationLoadingPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationLoadingPANEL.EnableDoubleBuffering = true;
            this.OperationLoadingPANEL.ForceDrawRegion = true;
            this.OperationLoadingPANEL.Location = new System.Drawing.Point(0, 0);
            this.OperationLoadingPANEL.Name = "OperationLoadingPANEL";
            this.OperationLoadingPANEL.Size = new System.Drawing.Size(784, 561);
            this.OperationLoadingPANEL.TabIndex = 3;
            this.OperationLoadingPANEL.Transparence = 50;
            this.OperationLoadingPANEL.Visible = false;
            // 
            // saaPreloader1
            // 
            this.saaPreloader1.BackColor = System.Drawing.Color.Transparent;
            this.saaPreloader1.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            this.saaPreloader1.DashOffset = 0F;
            this.saaPreloader1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.saaPreloader1.LineEnd = System.Drawing.Drawing2D.LineCap.Round;
            this.saaPreloader1.LineStart = System.Drawing.Drawing2D.LineCap.Round;
            this.saaPreloader1.LoaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.saaPreloader1.LoaderWidth = 12;
            this.saaPreloader1.Location = new System.Drawing.Point(217, 113);
            this.saaPreloader1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saaPreloader1.MaxAngle = 360;
            this.saaPreloader1.MinAngle = 0;
            this.saaPreloader1.Name = "saaPreloader1";
            this.saaPreloader1.Reverse = false;
            this.saaPreloader1.Size = new System.Drawing.Size(352, 352);
            this.saaPreloader1.SpeedInMilliSeconds = 5;
            this.saaPreloader1.Start = true;
            this.saaPreloader1.StepDown = 6;
            this.saaPreloader1.StepUp = 4;
            this.saaPreloader1.TabIndex = 0;
            // 
            // SaveDialog
            // 
            this.SaveDialog.AddExtension = false;
            this.SaveDialog.Filter = "Trensparent Photos|*.png";
            this.SaveDialog.Title = "Save the trensparent image as";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.OperationLoadingPANEL);
            this.Controls.Add(this.SubColorPanel);
            this.Controls.Add(this.ImagePathVALUE);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RMBackground";
            this.TopMost = true;
            this.SubColorPanel.ResumeLayout(false);
            this.InputFileDraggerPANEL.ResumeLayout(false);
            this.FinalImagePreview.ResumeLayout(false);
            this.PANELpngBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PICBOXFinalPreviewer)).EndInit();
            this.PANELFinalQuickActions.ResumeLayout(false);
            this.PANELFinalQuickActions.PerformLayout();
            this.OperationLoadingPANEL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaaUI.SaaPanel SubColorPanel;
        private System.Windows.Forms.Label DragDropInstructionLABEL;
        private System.Windows.Forms.Panel InputFileDraggerPANEL;
        public System.Windows.Forms.TextBox ImagePathVALUE;
        private SaaUI.SaaPanel OperationLoadingPANEL;
        private SaaUI.SaaPreloader saaPreloader1;
        private System.Windows.Forms.Panel FinalImagePreview;
        private System.Windows.Forms.Panel PANELpngBackground;
        private System.Windows.Forms.PictureBox PICBOXFinalPreviewer;
        private System.Windows.Forms.Panel PANELFinalQuickActions;
        private MaterialSkin.Controls.MaterialButton BTNCopyImage;
        private MaterialSkin.Controls.MaterialButton BTNSaveImage;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
    }
}

