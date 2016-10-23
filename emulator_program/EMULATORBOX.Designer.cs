// COPYRIGHT 2014-2016 JESSE WAGNER ALL RIGHTS RESERVED

using System.Drawing;
using System.Windows.Forms;
namespace emulator_program
{
    partial class EMULATORBOX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMULATORBOX));
            this.nesPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nesBackButton = new System.Windows.Forms.Button();
            this.nesOpenFileButton = new System.Windows.Forms.Button();
            this.nesEmuOpenButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.nesPicture = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.nesLabel = new System.Windows.Forms.Label();
            this.neogeoLabel = new System.Windows.Forms.Label();
            this.snesPicture = new System.Windows.Forms.PictureBox();
            this.neogeoPicture = new System.Windows.Forms.PictureBox();
            this.genesisLabel = new System.Windows.Forms.Label();
            this.snesLabel = new System.Windows.Forms.Label();
            this.ndsLabel = new System.Windows.Forms.Label();
            this.genesisPicture = new System.Windows.Forms.PictureBox();
            this.n64Picture = new System.Windows.Forms.PictureBox();
            this.ndsPicture = new System.Windows.Forms.PictureBox();
            this.gameboyLabel = new System.Windows.Forms.Label();
            this.n64Label = new System.Windows.Forms.Label();
            this.gameboyPicture = new System.Windows.Forms.PictureBox();
            this.neogeoPanel = new System.Windows.Forms.Panel();
            this.neogeoEmuOpenButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.neogeoBackButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.snesPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.snesOpenFileButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.snesBackButton = new System.Windows.Forms.Button();
            this.snesEmuOpenButton = new System.Windows.Forms.Button();
            this.n64Panel = new System.Windows.Forms.Panel();
            this.n64EmuOpenButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.n64OpenFileButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.n64BackButton = new System.Windows.Forms.Button();
            this.gameboyPanel = new System.Windows.Forms.Panel();
            this.gameboyEmuOpenButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.gameboyOpenFileButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.gameboyBackButton = new System.Windows.Forms.Button();
            this.NDSPanel = new System.Windows.Forms.Panel();
            this.NDSEmuOpenButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.NDSOpenFileButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.NDSBackButton = new System.Windows.Forms.Button();
            this.genesisPanel = new System.Windows.Forms.Panel();
            this.genesisEmuOpenButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.genesisOpenFileButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.genesisBackButton = new System.Windows.Forms.Button();
            this.nesPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neogeoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n64Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameboyPicture)).BeginInit();
            this.neogeoPanel.SuspendLayout();
            this.snesPanel.SuspendLayout();
            this.n64Panel.SuspendLayout();
            this.gameboyPanel.SuspendLayout();
            this.NDSPanel.SuspendLayout();
            this.genesisPanel.SuspendLayout();
            this.SuspendLayout();
            this.Location = new System.Drawing.Point(0, 0);
            // 
            // nesPanel
            // 
            this.nesPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nesPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nesPanel.BackgroundImage")));
            this.nesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nesPanel.Controls.Add(this.label8);
            this.nesPanel.Controls.Add(this.richTextBox1);
            this.nesPanel.Controls.Add(this.label9);
            this.nesPanel.Controls.Add(this.nesBackButton);
            this.nesPanel.Controls.Add(this.nesOpenFileButton);
            this.nesPanel.Controls.Add(this.nesEmuOpenButton);
            this.nesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nesPanel.Location = new System.Drawing.Point(0, 0);
            this.nesPanel.Name = "nesPanel";
            this.nesPanel.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.nesPanel.TabIndex = 19;
            this.nesPanel.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "History of the Nintendo Entertainment System";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 675);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(648, 174);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(909, 51);
            this.label9.TabIndex = 9;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // nesBackButton
            // 
            this.nesBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nesBackButton.Image = ((System.Drawing.Image)(resources.GetObject("nesBackButton.Image")));
            this.nesBackButton.Location = new System.Drawing.Point(12, 12);
            this.nesBackButton.Name = "nesBackButton";
            this.nesBackButton.Size = new System.Drawing.Size(75, 32);
            this.nesBackButton.TabIndex = 8;
            this.nesBackButton.Text = "Back";
            this.nesBackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nesBackButton.UseVisualStyleBackColor = true;
            this.nesBackButton.Click += new System.EventHandler(this.nesBackButton_Click);
            // 
            // nesOpenFileButton
            // 
            this.nesOpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nesOpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("nesOpenFileButton.Image")));
            this.nesOpenFileButton.Location = new System.Drawing.Point(12, 118);
            this.nesOpenFileButton.Name = "nesOpenFileButton";
            this.nesOpenFileButton.Size = new System.Drawing.Size(120, 35);
            this.nesOpenFileButton.TabIndex = 7;
            this.nesOpenFileButton.Text = "Open File";
            this.nesOpenFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nesOpenFileButton.UseVisualStyleBackColor = true;
            this.nesOpenFileButton.Click += new System.EventHandler(this.nesOpenFileButton_Click);
            // 
            // nesEmuOpenButton
            // 
            this.nesEmuOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nesEmuOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("nesEmuOpenButton.Image")));
            this.nesEmuOpenButton.Location = new System.Drawing.Point(148, 118);
            this.nesEmuOpenButton.Name = "nesEmuOpenButton";
            this.nesEmuOpenButton.Size = new System.Drawing.Size(141, 35);
            this.nesEmuOpenButton.TabIndex = 12;
            this.nesEmuOpenButton.Text = "Open the Emulator";
            this.nesEmuOpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nesEmuOpenButton.UseVisualStyleBackColor = true;
            this.nesEmuOpenButton.Click += new System.EventHandler(this.nesEmuOpenButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = ImageLayout.Center;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainPanel.Controls.Add(this.nesPicture);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.nesLabel);
            this.mainPanel.Controls.Add(this.neogeoLabel);
            this.mainPanel.Controls.Add(this.snesPicture);
            this.mainPanel.Controls.Add(this.neogeoPicture);
            this.mainPanel.Controls.Add(this.genesisLabel);
            this.mainPanel.Controls.Add(this.snesLabel);
            this.mainPanel.Controls.Add(this.ndsLabel);
            this.mainPanel.Controls.Add(this.genesisPicture);
            this.mainPanel.Controls.Add(this.n64Picture);
            this.mainPanel.Controls.Add(this.ndsPicture);
            this.mainPanel.Controls.Add(this.gameboyLabel);
            this.mainPanel.Controls.Add(this.n64Label);
            this.mainPanel.Controls.Add(this.gameboyPicture);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.mainPanel.TabIndex = 19;
            this.toolTip1.SetToolTip(this.mainPanel, "Click on the picture of the system you would like to play");

            int sideMargin = 10;
            int marginBetweenBox = 32;
            int combinedSpacesWidth = (sideMargin * 2) + (marginBetweenBox * 2);
            int mainPanelSizeWidth = this.mainPanel.Size.Width;
            int pictureBoxSizeWidth = (mainPanelSizeWidth - combinedSpacesWidth) / 3;
            int topBottomMarginHeight = 12;
            int marginBetweenBoxAndLabelHeight = 13;
            int labelHeight = 20;
            int marginBetweenLabelAndNextBoxHeight = 29;
            int combinedSpacesHeight = (topBottomMarginHeight * 2) + (marginBetweenBoxAndLabelHeight * 3) + (labelHeight * 3) + (marginBetweenBoxAndLabelHeight * 2);
            int mainPanelSizeHeight = this.mainPanel.Size.Height;
            int pictureBoxSizeHeight = (mainPanelSizeHeight - combinedSpacesHeight) / 3;
            // 
            // nesPicture
            // 
            this.nesPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nesPicture.BackColor = System.Drawing.SystemColors.Window;
            this.nesPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nesPicture.Image = ((System.Drawing.Image)(resources.GetObject("nesPicture.Image")));
            this.nesPicture.Location = new System.Drawing.Point(mainPanel.Location.X + sideMargin, mainPanel.Location.Y + topBottomMarginHeight);
            this.nesPicture.Name = "nesPicture";
            this.nesPicture.Size = new System.Drawing.Size(pictureBoxSizeWidth, pictureBoxSizeHeight);
            this.nesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nesPicture.TabIndex = 1;
            this.nesPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.nesPicture, "Nintendo Entertainment System");
            this.nesPicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // nesLabel
            // 
            this.nesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nesLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nesLabel.Location = new System.Drawing.Point(mainPanel.Location.X + sideMargin, nesPicture.Location.Y + nesPicture.Size.Height + marginBetweenBoxAndLabelHeight);
            this.nesLabel.Name = "nesLabel";
            this.nesLabel.Size = new System.Drawing.Size(pictureBoxSizeWidth, labelHeight);
            this.nesLabel.TabIndex = 11;
            this.nesLabel.Text = "Nintendo Entertainment System";
            this.nesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // snesPicture
            // 
            this.snesPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.snesPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.snesPicture.Image = ((System.Drawing.Image)(resources.GetObject("snesPicture.Image")));
            this.snesPicture.Location = new System.Drawing.Point(nesPicture.Location.X + nesPicture.Size.Width + marginBetweenBox, topBottomMarginHeight);
            this.snesPicture.Name = "snesPicture";
            this.snesPicture.Size = new System.Drawing.Size(pictureBoxSizeWidth, pictureBoxSizeHeight);
            this.snesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snesPicture.TabIndex = 2;
            this.snesPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.snesPicture, "Super Nintendo Entertainment System");
            this.snesPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // snesLabel
            // 
            this.snesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.snesLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.snesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.snesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snesLabel.Location = new System.Drawing.Point(nesLabel.Location.X + nesLabel.Size.Width + marginBetweenBox, snesPicture.Location.Y + snesPicture.Size.Height + marginBetweenBoxAndLabelHeight);
            this.snesLabel.Name = "snesLabel";
            this.snesLabel.Size = new System.Drawing.Size(pictureBoxSizeWidth, labelHeight);
            this.snesLabel.TabIndex = 12;
            this.snesLabel.Text = "Super Nintendo Entertainment System";
            this.snesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameboyPicture
            // 
            this.gameboyPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameboyPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameboyPicture.Image = ((System.Drawing.Image)(resources.GetObject("gameboyPicture.Image")));
            this.gameboyPicture.Location = new System.Drawing.Point(sideMargin, nesLabel.Location.Y + nesLabel.Size.Height + marginBetweenLabelAndNextBoxHeight);
            this.gameboyPicture.Name = "gameboyPicture";
            this.gameboyPicture.Size = new System.Drawing.Size(pictureBoxSizeWidth, pictureBoxSizeHeight);
            this.gameboyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameboyPicture.TabIndex = 4;
            this.gameboyPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.gameboyPicture, "Gameboy & Gameboy Advance");
            this.gameboyPicture.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // gameboyLabel
            // 
            this.gameboyLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameboyLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gameboyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameboyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameboyLabel.Location = new System.Drawing.Point(mainPanel.Location.X + sideMargin, gameboyPicture.Location.Y + gameboyPicture.Size.Height + marginBetweenBoxAndLabelHeight);
            this.gameboyLabel.Name = "gameboyLabel";
            this.gameboyLabel.Size = new System.Drawing.Size(pictureBoxSizeWidth, labelHeight);
            this.gameboyLabel.TabIndex = 14;
            this.gameboyLabel.Text = "GameBoy and GameBoy Advance";
            this.gameboyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genesisPicture
            // 
            this.genesisPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.genesisPicture.BackColor = System.Drawing.SystemColors.Window;
            this.genesisPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genesisPicture.Image = ((System.Drawing.Image)(resources.GetObject("genesisPicture.Image")));
            this.genesisPicture.Location = new System.Drawing.Point(sideMargin, gameboyLabel.Location.Y + gameboyLabel.Size.Height + marginBetweenLabelAndNextBoxHeight);
            this.genesisPicture.Name = "genesisPicture";
            this.genesisPicture.Size = new System.Drawing.Size(pictureBoxSizeWidth, pictureBoxSizeHeight);
            this.genesisPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.genesisPicture.TabIndex = 6;
            this.genesisPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.genesisPicture, "Sega Genesis");
            this.genesisPicture.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // genesisLabel
            // 
            this.genesisLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.genesisLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genesisLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genesisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genesisLabel.Location = new System.Drawing.Point(mainPanel.Location.X + sideMargin, genesisPicture.Location.Y + genesisPicture.Size.Height + marginBetweenBoxAndLabelHeight);
            this.genesisLabel.Name = "genesisLabel";
            this.genesisLabel.Size = new System.Drawing.Size(pictureBoxSizeWidth, labelHeight);
            this.genesisLabel.TabIndex = 16;
            this.genesisLabel.Text = "Sega Genesis";
            this.genesisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n64Picture
            // 
            this.n64Picture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n64Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n64Picture.Image = ((System.Drawing.Image)(resources.GetObject("n64Picture.Image")));
            this.n64Picture.Location = new System.Drawing.Point(snesPicture.Location.X + snesPicture.Size.Width + marginBetweenBox, topBottomMarginHeight);
            this.n64Picture.Name = "n64Picture";
            this.n64Picture.Size = new System.Drawing.Size(pictureBoxSizeWidth, pictureBoxSizeHeight);
            this.n64Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.n64Picture.TabIndex = 3;
            this.n64Picture.TabStop = false;
            this.toolTip1.SetToolTip(this.n64Picture, "Nintendo 64");
            this.n64Picture.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // n64Label
            // 
            this.n64Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.n64Label.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.n64Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n64Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n64Label.Location = new System.Drawing.Point(snesLabel.Location.X + snesLabel.Size.Width + marginBetweenBox, n64Picture.Location.Y + n64Picture.Size.Height + marginBetweenBoxAndLabelHeight);
            this.n64Label.Name = "n64Label";
            this.n64Label.Size = new System.Drawing.Size(pictureBoxSizeWidth, labelHeight);
            this.n64Label.TabIndex = 13;
            this.n64Label.Text = "Nintendo 64";
            this.n64Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ndsPicture
            // 
            this.ndsPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ndsPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ndsPicture.Image = ((System.Drawing.Image)(resources.GetObject("ndsPicture.Image")));
            this.ndsPicture.Location = new System.Drawing.Point(gameboyLabel.Location.X + gameboyLabel.Size.Width + marginBetweenBox, snesLabel.Location.Y + snesLabel.Size.Height + marginBetweenLabelAndNextBoxHeight);
            this.ndsPicture.Name = "ndsPicture";
            this.ndsPicture.Size = new System.Drawing.Size(pictureBoxSizeWidth, pictureBoxSizeHeight);
            this.ndsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ndsPicture.TabIndex = 5;
            this.ndsPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.ndsPicture, "Nintendo DS");
            this.ndsPicture.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // ndsLabel
            // 
            this.ndsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ndsLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ndsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ndsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndsLabel.Location = new System.Drawing.Point(gameboyLabel.Location.X + gameboyLabel.Size.Width + marginBetweenBox, ndsPicture.Location.Y + ndsPicture.Size.Height + marginBetweenBoxAndLabelHeight);
            this.ndsLabel.Name = "ndsLabel";
            this.ndsLabel.Size = new System.Drawing.Size(pictureBoxSizeWidth, labelHeight);
            this.ndsLabel.TabIndex = 15;
            this.ndsLabel.Text = "Nintendo DS";
            this.ndsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // neogeoPicture
            // 
            this.neogeoPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.neogeoPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.neogeoPicture.Image = ((System.Drawing.Image)(resources.GetObject("neogeoPicture.Image")));
            this.neogeoPicture.Location = new System.Drawing.Point(genesisPicture.Location.X + genesisPicture.Size.Width + marginBetweenBox, ndsLabel.Location.Y + ndsLabel.Size.Height + marginBetweenLabelAndNextBoxHeight);
            this.neogeoPicture.Name = "neogeoPicture";
            this.neogeoPicture.Size = new System.Drawing.Size(pictureBoxSizeWidth, pictureBoxSizeHeight);
            this.neogeoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.neogeoPicture.TabIndex = 7;
            this.neogeoPicture.TabStop = false;
            this.neogeoPicture.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // neogeoLabel
            // 
            this.neogeoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.neogeoLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.neogeoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.neogeoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neogeoLabel.Location = new System.Drawing.Point(genesisLabel.Location.X + genesisLabel.Size.Width + marginBetweenBox, neogeoPicture.Location.Y + neogeoPicture.Size.Height + marginBetweenBoxAndLabelHeight);
            this.neogeoLabel.Name = "neogeoLabel";
            this.neogeoLabel.Size = new System.Drawing.Size(pictureBoxSizeWidth, labelHeight);
            this.neogeoLabel.TabIndex = 17;
            this.neogeoLabel.Text = "NEOGEO and Capcom Arcade Games";
            this.neogeoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(ndsPicture.Location.X + ndsPicture.Size.Width + marginBetweenBox, n64Label.Location.Y + n64Label.Size.Height + marginBetweenLabelAndNextBoxHeight);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 32);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // neogeoPanel
            // 
            this.neogeoPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.neogeoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("neogeoPanel.BackgroundImage")));
            this.neogeoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.neogeoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.neogeoPanel.Controls.Add(this.neogeoEmuOpenButton);
            this.neogeoPanel.Controls.Add(this.label20);
            this.neogeoPanel.Controls.Add(this.richTextBox7);
            this.neogeoPanel.Controls.Add(this.label21);
            this.neogeoPanel.Controls.Add(this.neogeoBackButton);
            this.neogeoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neogeoPanel.Location = new System.Drawing.Point(0, 0);
            this.neogeoPanel.Name = "neogeoPanel";
            this.neogeoPanel.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.neogeoPanel.TabIndex = 19;
            this.neogeoPanel.Visible = false;
            // 
            // neogeoEmuOpenButton
            // 
            this.neogeoEmuOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neogeoEmuOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("neogeoEmuOpenButton.Image")));
            this.neogeoEmuOpenButton.Location = new System.Drawing.Point(13, 121);
            this.neogeoEmuOpenButton.Name = "neogeoEmuOpenButton";
            this.neogeoEmuOpenButton.Size = new System.Drawing.Size(141, 32);
            this.neogeoEmuOpenButton.TabIndex = 19;
            this.neogeoEmuOpenButton.Text = "Open the Emulator";
            this.neogeoEmuOpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.neogeoEmuOpenButton.UseVisualStyleBackColor = true;
            this.neogeoEmuOpenButton.Click += new System.EventHandler(this.neogeoEmuOpenButton_Click);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 628);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 23);
            this.label20.TabIndex = 18;
            this.label20.Text = "History of the NEOGEO";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(12, 668);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox7.Size = new System.Drawing.Size(648, 174);
            this.richTextBox7.TabIndex = 17;
            this.richTextBox7.Text = "";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(909, 51);
            this.label21.TabIndex = 16;
            this.label21.Text = "To play a game for the NEOGEO or Capcom Arcade, click on the Open Emulator button" +
    " below. Otherwise, click the button labeled Back to go back to the previous scre" +
    "en.";
            // 
            // neogeoBackButton
            // 
            this.neogeoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neogeoBackButton.Image = ((System.Drawing.Image)(resources.GetObject("neogeoBackButton.Image")));
            this.neogeoBackButton.Location = new System.Drawing.Point(13, 18);
            this.neogeoBackButton.Name = "neogeoBackButton";
            this.neogeoBackButton.Size = new System.Drawing.Size(75, 26);
            this.neogeoBackButton.TabIndex = 15;
            this.neogeoBackButton.Text = "Back";
            this.neogeoBackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.neogeoBackButton.UseVisualStyleBackColor = true;
            this.neogeoBackButton.Click += new System.EventHandler(this.neogeoBackButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // snesPanel
            // 
            this.snesPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.snesPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("snesPanel.BackgroundImage")));
            this.snesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.snesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.snesPanel.Controls.Add(this.label10);
            this.snesPanel.Controls.Add(this.richTextBox2);
            this.snesPanel.Controls.Add(this.snesOpenFileButton);
            this.snesPanel.Controls.Add(this.label11);
            this.snesPanel.Controls.Add(this.snesBackButton);
            this.snesPanel.Controls.Add(this.snesEmuOpenButton);
            this.snesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snesPanel.Location = new System.Drawing.Point(0, 0);
            this.snesPanel.Name = "snesPanel";
            this.snesPanel.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.snesPanel.TabIndex = 19;
            this.snesPanel.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 637);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "History of the Super Nintendo Entertainment System";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 675);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(648, 174);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // snesOpenFileButton
            // 
            this.snesOpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snesOpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("snesOpenFileButton.Image")));
            this.snesOpenFileButton.Location = new System.Drawing.Point(12, 114);
            this.snesOpenFileButton.Name = "snesOpenFileButton";
            this.snesOpenFileButton.Size = new System.Drawing.Size(120, 29);
            this.snesOpenFileButton.TabIndex = 11;
            this.snesOpenFileButton.Text = "Open File";
            this.snesOpenFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.snesOpenFileButton.UseVisualStyleBackColor = true;
            this.snesOpenFileButton.Click += new System.EventHandler(this.snesOpenFileButton_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(909, 51);
            this.label11.TabIndex = 10;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // snesBackButton
            // 
            this.snesBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snesBackButton.Image = ((System.Drawing.Image)(resources.GetObject("snesBackButton.Image")));
            this.snesBackButton.Location = new System.Drawing.Point(12, 12);
            this.snesBackButton.Name = "snesBackButton";
            this.snesBackButton.Size = new System.Drawing.Size(75, 29);
            this.snesBackButton.TabIndex = 9;
            this.snesBackButton.Text = "Back";
            this.snesBackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.snesBackButton.UseVisualStyleBackColor = true;
            this.snesBackButton.Click += new System.EventHandler(this.snesBackButton_Click);
            // 
            // snesEmuOpenButton
            // 
            this.snesEmuOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snesEmuOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("snesEmuOpenButton.Image")));
            this.snesEmuOpenButton.Location = new System.Drawing.Point(149, 114);
            this.snesEmuOpenButton.Name = "snesEmuOpenButton";
            this.snesEmuOpenButton.Size = new System.Drawing.Size(143, 30);
            this.snesEmuOpenButton.TabIndex = 14;
            this.snesEmuOpenButton.Text = "Open the Emulator";
            this.snesEmuOpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.snesEmuOpenButton.UseVisualStyleBackColor = true;
            this.snesEmuOpenButton.Click += new System.EventHandler(this.snesEmuOpenButton_Click);
            // 
            // n64Panel
            // 
            this.n64Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n64Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n64Panel.BackgroundImage")));
            this.n64Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.n64Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n64Panel.Controls.Add(this.n64EmuOpenButton);
            this.n64Panel.Controls.Add(this.label12);
            this.n64Panel.Controls.Add(this.richTextBox3);
            this.n64Panel.Controls.Add(this.n64OpenFileButton);
            this.n64Panel.Controls.Add(this.label13);
            this.n64Panel.Controls.Add(this.n64BackButton);
            this.n64Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n64Panel.Location = new System.Drawing.Point(0, 0);
            this.n64Panel.Name = "n64Panel";
            this.n64Panel.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.n64Panel.TabIndex = 19;
            this.n64Panel.Visible = false;
            // 
            // n64EmuOpenButton
            // 
            this.n64EmuOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n64EmuOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("n64EmuOpenButton.Image")));
            this.n64EmuOpenButton.Location = new System.Drawing.Point(149, 114);
            this.n64EmuOpenButton.Name = "n64EmuOpenButton";
            this.n64EmuOpenButton.Size = new System.Drawing.Size(140, 30);
            this.n64EmuOpenButton.TabIndex = 20;
            this.n64EmuOpenButton.Text = "Open the Emulator";
            this.n64EmuOpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.n64EmuOpenButton.UseVisualStyleBackColor = true;
            this.n64EmuOpenButton.Click += new System.EventHandler(this.n64EmuOpenButton_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 637);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(267, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "History of the Nintendo 64";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(15, 675);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox3.Size = new System.Drawing.Size(648, 174);
            this.richTextBox3.TabIndex = 18;
            this.richTextBox3.Text = "";
            // 
            // n64OpenFileButton
            // 
            this.n64OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n64OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("n64OpenFileButton.Image")));
            this.n64OpenFileButton.Location = new System.Drawing.Point(12, 114);
            this.n64OpenFileButton.Name = "n64OpenFileButton";
            this.n64OpenFileButton.Size = new System.Drawing.Size(120, 29);
            this.n64OpenFileButton.TabIndex = 17;
            this.n64OpenFileButton.Text = "Open File";
            this.n64OpenFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.n64OpenFileButton.UseVisualStyleBackColor = true;
            this.n64OpenFileButton.Click += new System.EventHandler(this.n64OpenFileButton_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(909, 51);
            this.label13.TabIndex = 16;
            this.label13.Text = "To play a game for the Nintendo 64, click on the Open File button below and selec" +
    "t the game you would like to play. Otherwise, click the button labeled Back to g" +
    "o back to the previous screen.";
            // 
            // n64BackButton
            // 
            this.n64BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n64BackButton.Image = ((System.Drawing.Image)(resources.GetObject("n64BackButton.Image")));
            this.n64BackButton.Location = new System.Drawing.Point(12, 12);
            this.n64BackButton.Name = "n64BackButton";
            this.n64BackButton.Size = new System.Drawing.Size(75, 29);
            this.n64BackButton.TabIndex = 15;
            this.n64BackButton.Text = "Back";
            this.n64BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.n64BackButton.UseVisualStyleBackColor = true;
            this.n64BackButton.Click += new System.EventHandler(this.n64BackButton_Click);
            // 
            // gameboyPanel
            // 
            this.gameboyPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameboyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameboyPanel.BackgroundImage")));
            this.gameboyPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gameboyPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameboyPanel.Controls.Add(this.gameboyEmuOpenButton);
            this.gameboyPanel.Controls.Add(this.label14);
            this.gameboyPanel.Controls.Add(this.richTextBox4);
            this.gameboyPanel.Controls.Add(this.gameboyOpenFileButton);
            this.gameboyPanel.Controls.Add(this.label15);
            this.gameboyPanel.Controls.Add(this.gameboyBackButton);
            this.gameboyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameboyPanel.Location = new System.Drawing.Point(0, 0);
            this.gameboyPanel.Name = "gameboyPanel";
            this.gameboyPanel.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.gameboyPanel.TabIndex = 19;
            this.gameboyPanel.Visible = false;
            // 
            // gameboyEmuOpenButton
            // 
            this.gameboyEmuOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameboyEmuOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("gameboyEmuOpenButton.Image")));
            this.gameboyEmuOpenButton.Location = new System.Drawing.Point(149, 114);
            this.gameboyEmuOpenButton.Name = "gameboyEmuOpenButton";
            this.gameboyEmuOpenButton.Size = new System.Drawing.Size(140, 30);
            this.gameboyEmuOpenButton.TabIndex = 20;
            this.gameboyEmuOpenButton.Text = "Open the Emulator";
            this.gameboyEmuOpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gameboyEmuOpenButton.UseVisualStyleBackColor = true;
            this.gameboyEmuOpenButton.Click += new System.EventHandler(this.gameboyEmuOpenButton_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 637);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 23);
            this.label14.TabIndex = 19;
            this.label14.Text = "History of the GameBoy";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(12, 675);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox4.Size = new System.Drawing.Size(648, 174);
            this.richTextBox4.TabIndex = 18;
            this.richTextBox4.Text = "";
            // 
            // gameboyOpenFileButton
            // 
            this.gameboyOpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameboyOpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("gameboyOpenFileButton.Image")));
            this.gameboyOpenFileButton.Location = new System.Drawing.Point(12, 114);
            this.gameboyOpenFileButton.Name = "gameboyOpenFileButton";
            this.gameboyOpenFileButton.Size = new System.Drawing.Size(120, 30);
            this.gameboyOpenFileButton.TabIndex = 17;
            this.gameboyOpenFileButton.Text = "Open File";
            this.gameboyOpenFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gameboyOpenFileButton.UseVisualStyleBackColor = true;
            this.gameboyOpenFileButton.Click += new System.EventHandler(this.gameboyOpenFileButton_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(909, 51);
            this.label15.TabIndex = 16;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // gameboyBackButton
            // 
            this.gameboyBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameboyBackButton.Image = ((System.Drawing.Image)(resources.GetObject("gameboyBackButton.Image")));
            this.gameboyBackButton.Location = new System.Drawing.Point(12, 12);
            this.gameboyBackButton.Name = "gameboyBackButton";
            this.gameboyBackButton.Size = new System.Drawing.Size(75, 29);
            this.gameboyBackButton.TabIndex = 15;
            this.gameboyBackButton.Text = "Back";
            this.gameboyBackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gameboyBackButton.UseVisualStyleBackColor = true;
            this.gameboyBackButton.Click += new System.EventHandler(this.gameboyBackButton_Click);
            // 
            // NDSPanel
            // 
            this.NDSPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NDSPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NDSPanel.BackgroundImage")));
            this.NDSPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NDSPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NDSPanel.Controls.Add(this.NDSEmuOpenButton);
            this.NDSPanel.Controls.Add(this.label16);
            this.NDSPanel.Controls.Add(this.richTextBox5);
            this.NDSPanel.Controls.Add(this.NDSOpenFileButton);
            this.NDSPanel.Controls.Add(this.label17);
            this.NDSPanel.Controls.Add(this.NDSBackButton);
            this.NDSPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NDSPanel.Location = new System.Drawing.Point(0, 0);
            this.NDSPanel.Name = "NDSPanel";
            this.NDSPanel.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.NDSPanel.TabIndex = 19;
            this.NDSPanel.Visible = false;
            // 
            // NDSEmuOpenButton
            // 
            this.NDSEmuOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDSEmuOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("NDSEmuOpenButton.Image")));
            this.NDSEmuOpenButton.Location = new System.Drawing.Point(149, 114);
            this.NDSEmuOpenButton.Name = "NDSEmuOpenButton";
            this.NDSEmuOpenButton.Size = new System.Drawing.Size(143, 30);
            this.NDSEmuOpenButton.TabIndex = 20;
            this.NDSEmuOpenButton.Text = "Open the Emulator";
            this.NDSEmuOpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NDSEmuOpenButton.UseVisualStyleBackColor = true;
            this.NDSEmuOpenButton.Click += new System.EventHandler(this.NDSEmuOpenButton_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 637);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 23);
            this.label16.TabIndex = 19;
            this.label16.Text = "History of the Nintendo DS";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(12, 675);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox5.Size = new System.Drawing.Size(648, 174);
            this.richTextBox5.TabIndex = 18;
            this.richTextBox5.Text = "";
            // 
            // NDSOpenFileButton
            // 
            this.NDSOpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDSOpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("NDSOpenFileButton.Image")));
            this.NDSOpenFileButton.Location = new System.Drawing.Point(12, 114);
            this.NDSOpenFileButton.Name = "NDSOpenFileButton";
            this.NDSOpenFileButton.Size = new System.Drawing.Size(120, 30);
            this.NDSOpenFileButton.TabIndex = 17;
            this.NDSOpenFileButton.Text = "Open File";
            this.NDSOpenFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NDSOpenFileButton.UseVisualStyleBackColor = true;
            this.NDSOpenFileButton.Click += new System.EventHandler(this.NDSOpenFileButton_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(909, 51);
            this.label17.TabIndex = 16;
            this.label17.Text = "To play a game for the Nintendo DS, click on the Open File button below and selec" +
    "t the game you would like to play. Otherwise, click the button labeled Back to g" +
    "o back to the previous screen.";
            // 
            // NDSBackButton
            // 
            this.NDSBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDSBackButton.Image = ((System.Drawing.Image)(resources.GetObject("NDSBackButton.Image")));
            this.NDSBackButton.Location = new System.Drawing.Point(12, 12);
            this.NDSBackButton.Name = "NDSBackButton";
            this.NDSBackButton.Size = new System.Drawing.Size(75, 29);
            this.NDSBackButton.TabIndex = 15;
            this.NDSBackButton.Text = "Back";
            this.NDSBackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NDSBackButton.UseVisualStyleBackColor = true;
            this.NDSBackButton.Click += new System.EventHandler(this.NDSBackButton_Click);
            // 
            // genesisPanel
            // 
            this.genesisPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genesisPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("genesisPanel.BackgroundImage")));
            this.genesisPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.genesisPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genesisPanel.Controls.Add(this.genesisEmuOpenButton);
            this.genesisPanel.Controls.Add(this.label18);
            this.genesisPanel.Controls.Add(this.richTextBox6);
            this.genesisPanel.Controls.Add(this.genesisOpenFileButton);
            this.genesisPanel.Controls.Add(this.label19);
            this.genesisPanel.Controls.Add(this.genesisBackButton);
            this.genesisPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genesisPanel.Location = new System.Drawing.Point(0, 0);
            this.genesisPanel.Name = "genesisPanel";
            this.genesisPanel.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.genesisPanel.TabIndex = 19;
            this.genesisPanel.Visible = false;
            // 
            // genesisEmuOpenButton
            // 
            this.genesisEmuOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genesisEmuOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("genesisEmuOpenButton.Image")));
            this.genesisEmuOpenButton.Location = new System.Drawing.Point(150, 120);
            this.genesisEmuOpenButton.Name = "genesisEmuOpenButton";
            this.genesisEmuOpenButton.Size = new System.Drawing.Size(139, 33);
            this.genesisEmuOpenButton.TabIndex = 20;
            this.genesisEmuOpenButton.Text = "Open the Emulator";
            this.genesisEmuOpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.genesisEmuOpenButton.UseVisualStyleBackColor = true;
            this.genesisEmuOpenButton.Click += new System.EventHandler(this.genesisEmuOpenButton_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 628);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 23);
            this.label18.TabIndex = 19;
            this.label18.Text = "History of the Sega Genesis";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(12, 668);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox6.Size = new System.Drawing.Size(648, 174);
            this.richTextBox6.TabIndex = 18;
            this.richTextBox6.Text = "";
            // 
            // genesisOpenFileButton
            // 
            this.genesisOpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genesisOpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("genesisOpenFileButton.Image")));
            this.genesisOpenFileButton.Location = new System.Drawing.Point(13, 120);
            this.genesisOpenFileButton.Name = "genesisOpenFileButton";
            this.genesisOpenFileButton.Size = new System.Drawing.Size(120, 33);
            this.genesisOpenFileButton.TabIndex = 17;
            this.genesisOpenFileButton.Text = "Open File";
            this.genesisOpenFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.genesisOpenFileButton.UseVisualStyleBackColor = true;
            this.genesisOpenFileButton.Click += new System.EventHandler(this.genesisOpenFileButton_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(909, 51);
            this.label19.TabIndex = 16;
            this.label19.Text = "To play a game for the Sega Genesis, click on the Open File button below and sele" +
    "ct the game you would like to play. Otherwise, click the button labeled Back to " +
    "go back to the previous screen.";
            // 
            // genesisBackButton
            // 
            this.genesisBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genesisBackButton.Image = ((System.Drawing.Image)(resources.GetObject("genesisBackButton.Image")));
            this.genesisBackButton.Location = new System.Drawing.Point(13, 18);
            this.genesisBackButton.Name = "genesisBackButton";
            this.genesisBackButton.Size = new System.Drawing.Size(75, 30);
            this.genesisBackButton.TabIndex = 15;
            this.genesisBackButton.Text = "Back";
            this.genesisBackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.genesisBackButton.UseVisualStyleBackColor = true;
            this.genesisBackButton.Click += new System.EventHandler(this.genesisBackButton_Click);
            // 
            // EMULATORBOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1920, 1160);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.nesPanel);
            this.Controls.Add(this.snesPanel);
            this.Controls.Add(this.n64Panel);
            this.Controls.Add(this.gameboyPanel);
            this.Controls.Add(this.NDSPanel);
            this.Controls.Add(this.genesisPanel);
            this.Controls.Add(this.neogeoPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EMULATORBOX";
            this.Text = "EMULATORBOX";
            this.nesPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neogeoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n64Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameboyPicture)).EndInit();
            this.neogeoPanel.ResumeLayout(false);
            this.snesPanel.ResumeLayout(false);
            this.n64Panel.ResumeLayout(false);
            this.gameboyPanel.ResumeLayout(false);
            this.NDSPanel.ResumeLayout(false);
            this.genesisPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel nesPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox nesPicture;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label nesLabel;
        private System.Windows.Forms.Label neogeoLabel;
        private System.Windows.Forms.PictureBox snesPicture;
        private System.Windows.Forms.PictureBox neogeoPicture;
        private System.Windows.Forms.Label genesisLabel;
        private System.Windows.Forms.Label snesLabel;
        private System.Windows.Forms.Label ndsLabel;
        private System.Windows.Forms.PictureBox genesisPicture;
        private System.Windows.Forms.PictureBox n64Picture;
        private System.Windows.Forms.PictureBox ndsPicture;
        private System.Windows.Forms.Label gameboyLabel;
        private System.Windows.Forms.Label n64Label;
        private System.Windows.Forms.PictureBox gameboyPicture;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button nesBackButton;
        private System.Windows.Forms.Button nesOpenFileButton;
        private System.Windows.Forms.Button nesEmuOpenButton;
        private System.Windows.Forms.Panel snesPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button snesOpenFileButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button snesBackButton;
        private System.Windows.Forms.Button snesEmuOpenButton;
        private System.Windows.Forms.Panel n64Panel;
        private System.Windows.Forms.Button n64EmuOpenButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button n64OpenFileButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button n64BackButton;
        private System.Windows.Forms.Panel gameboyPanel;
        private System.Windows.Forms.Button gameboyEmuOpenButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button gameboyOpenFileButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button gameboyBackButton;
        private System.Windows.Forms.Panel NDSPanel;
        private System.Windows.Forms.Button NDSEmuOpenButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Button NDSOpenFileButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button NDSBackButton;
        private System.Windows.Forms.Panel genesisPanel;
        private System.Windows.Forms.Button genesisEmuOpenButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Button genesisOpenFileButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button genesisBackButton;
        private System.Windows.Forms.Panel neogeoPanel;
        private System.Windows.Forms.Button neogeoEmuOpenButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button neogeoBackButton;
    }
}