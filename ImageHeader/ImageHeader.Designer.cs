namespace ImageHeader
{
    partial class ImageHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageHeader));
            this.TitleBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.SizeButton = new System.Windows.Forms.Label();
            this.MinButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Tip_1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TitleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBox.AutoSize = true;
            this.TitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.TitleBox.Controls.Add(this.pictureBox1);
            this.TitleBox.Controls.Add(this.Title);
            this.TitleBox.Controls.Add(this.SizeButton);
            this.TitleBox.Controls.Add(this.MinButton);
            this.TitleBox.Controls.Add(this.CloseButton);
            this.TitleBox.Location = new System.Drawing.Point(3, 2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(794, 53);
            this.TitleBox.TabIndex = 6;
            this.TitleBox.DoubleClick += new System.EventHandler(this.PictureBox1_DoubleClick);
            this.TitleBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::ImageHeader.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(334, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.PictureBox1_DoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(360, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(104, 19);
            this.Title.TabIndex = 6;
            this.Title.Text = "ImageHeader";
            this.Tip_1.SetToolTip(this.Title, "ImageHeader");
            this.Title.DoubleClick += new System.EventHandler(this.PictureBox1_DoubleClick);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // SizeButton
            // 
            this.SizeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SizeButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(5)))));
            this.SizeButton.Location = new System.Drawing.Point(29, 7);
            this.SizeButton.Name = "SizeButton";
            this.SizeButton.Size = new System.Drawing.Size(17, 17);
            this.SizeButton.TabIndex = 5;
            this.SizeButton.Text = "●";
            this.SizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tip_1.SetToolTip(this.SizeButton, "Maximized");
            this.SizeButton.Click += new System.EventHandler(this.SizeButton_Click);
            this.SizeButton.MouseLeave += new System.EventHandler(this.SizeButton_MouseLeave);
            this.SizeButton.MouseHover += new System.EventHandler(this.SizeButton_MouseHover);
            this.SizeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizeButton_MouseMove);
            // 
            // MinButton
            // 
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MinButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.MinButton.Location = new System.Drawing.Point(50, 7);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(17, 17);
            this.MinButton.TabIndex = 4;
            this.MinButton.Text = "●";
            this.MinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tip_1.SetToolTip(this.MinButton, "Minimized");
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            this.MinButton.MouseLeave += new System.EventHandler(this.MinButton_MouseLeave);
            this.MinButton.MouseHover += new System.EventHandler(this.MinButton_MouseHover);
            this.MinButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MinButton_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CloseButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(82)))));
            this.CloseButton.Location = new System.Drawing.Point(8, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(17, 17);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "●";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tip_1.SetToolTip(this.CloseButton, "Exit");
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseMove);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(10, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Import";
            this.Tip_1.SetToolTip(this.button1, "Import a image");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(10, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 50);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Output";
            this.Tip_1.SetToolTip(this.button2, "Output a Header");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(10, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 50);
            this.button3.TabIndex = 6;
            this.button3.TabStop = false;
            this.button3.Text = "Change Size";
            this.Tip_1.SetToolTip(this.button3, "Import a image");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Controls.Add(this.button3);
            this.Back.Controls.Add(this.label2);
            this.Back.Controls.Add(this.label1);
            this.Back.Controls.Add(this.panel1);
            this.Back.Controls.Add(this.button2);
            this.Back.Controls.Add(this.pictureBox2);
            this.Back.Controls.Add(this.button1);
            this.Back.Location = new System.Drawing.Point(3, 49);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(794, 399);
            this.Back.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panel1.Location = new System.Drawing.Point(145, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 375);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.BackgroundImage = global::ImageHeader.Properties.Resources.icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(157, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(627, 375);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ImageHeader
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 310);
            this.Name = "ImageHeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageHeader";
            this.TitleBox.ResumeLayout(false);
            this.TitleBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Back.ResumeLayout(false);
            this.Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ToolTip Tip_1;
        private System.Windows.Forms.Label SizeButton;
        private System.Windows.Forms.Label MinButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}