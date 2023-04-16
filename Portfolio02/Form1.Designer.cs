namespace Portfolio02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            btnEnviar = new Bunifu.Framework.UI.BunifuFlatButton();
            btnSair = new Bunifu.Framework.UI.BunifuFlatButton();
            selectVideoType = new Label();
            panel1 = new Panel();
            button1 = new Button();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            groupBox1 = new GroupBox();
            Variacao4 = new RadioButton();
            Variacao3 = new RadioButton();
            Variacao2 = new RadioButton();
            Variacao1 = new RadioButton();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 414);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.DimGray;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.DarkOrange;
            splitContainer1.Panel1.Controls.Add(btnEnviar);
            splitContainer1.Panel1.Controls.Add(btnSair);
            splitContainer1.Panel1.Controls.Add(selectVideoType);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.DimGray;
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(786, 408);
            splitContainer1.SplitterDistance = 231;
            splitContainer1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Active = false;
            btnEnviar.Activecolor = Color.FromArgb(46, 139, 87);
            btnEnviar.BackColor = Color.FromArgb(46, 139, 87);
            btnEnviar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEnviar.BorderRadius = 0;
            btnEnviar.ButtonText = "Selecionar";
            btnEnviar.DisabledColor = Color.Gray;
            btnEnviar.Iconcolor = Color.Transparent;
            btnEnviar.Iconimage = null;
            btnEnviar.Iconimage_right = null;
            btnEnviar.Iconimage_right_Selected = null;
            btnEnviar.Iconimage_Selected = null;
            btnEnviar.IconMarginLeft = 0;
            btnEnviar.IconMarginRight = 0;
            btnEnviar.IconRightVisible = false;
            btnEnviar.IconRightZoom = 0D;
            btnEnviar.IconVisible = false;
            btnEnviar.IconZoom = 90D;
            btnEnviar.IsTab = false;
            btnEnviar.Location = new Point(7, 133);
            btnEnviar.Margin = new Padding(4, 3, 4, 3);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Normalcolor = Color.FromArgb(46, 139, 87);
            btnEnviar.OnHovercolor = Color.FromArgb(36, 129, 77);
            btnEnviar.OnHoverTextColor = Color.White;
            btnEnviar.selected = false;
            btnEnviar.Size = new Size(221, 49);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Selecionar";
            btnEnviar.TextAlign = ContentAlignment.MiddleCenter;
            btnEnviar.Textcolor = Color.White;
            btnEnviar.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnSair
            // 
            btnSair.Active = false;
            btnSair.Activecolor = Color.Red;
            btnSair.BackColor = Color.DarkRed;
            btnSair.BackgroundImageLayout = ImageLayout.Stretch;
            btnSair.BorderRadius = 0;
            btnSair.ButtonText = "Sair";
            btnSair.DisabledColor = Color.Gray;
            btnSair.Iconcolor = Color.Transparent;
            btnSair.Iconimage = null;
            btnSair.Iconimage_right = null;
            btnSair.Iconimage_right_Selected = null;
            btnSair.Iconimage_Selected = null;
            btnSair.IconMarginLeft = 0;
            btnSair.IconMarginRight = 0;
            btnSair.IconRightVisible = false;
            btnSair.IconRightZoom = 0D;
            btnSair.IconVisible = false;
            btnSair.IconZoom = 90D;
            btnSair.IsTab = false;
            btnSair.Location = new Point(3, 359);
            btnSair.Margin = new Padding(6, 5, 6, 5);
            btnSair.Name = "btnSair";
            btnSair.Normalcolor = Color.DarkRed;
            btnSair.OnHovercolor = Color.Red;
            btnSair.OnHoverTextColor = Color.White;
            btnSair.selected = false;
            btnSair.Size = new Size(224, 49);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleCenter;
            btnSair.Textcolor = Color.White;
            btnSair.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Click += sair;
            // 
            // selectVideoType
            // 
            selectVideoType.AllowDrop = true;
            selectVideoType.AutoEllipsis = true;
            selectVideoType.AutoSize = true;
            selectVideoType.Dock = DockStyle.Top;
            selectVideoType.FlatStyle = FlatStyle.Flat;
            selectVideoType.Location = new Point(0, 0);
            selectVideoType.MaximumSize = new Size(200, 0);
            selectVideoType.Name = "selectVideoType";
            selectVideoType.Size = new Size(185, 72);
            selectVideoType.TabIndex = 2;
            selectVideoType.Text = "Clique no botão abaixo para selecionar o video desejado";
            selectVideoType.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(videoView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 408);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(243, 369);
            button1.Name = "button1";
            button1.Size = new Size(78, 34);
            button1.TabIndex = 6;
            button1.Text = "pause";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Dock = DockStyle.Fill;
            videoView1.Location = new Point(0, 0);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(551, 408);
            videoView1.TabIndex = 0;
            videoView1.Text = "videoView1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Imagens";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.DarkOrange;
            splitContainer2.Panel1.Controls.Add(bunifuFlatButton1);
            splitContainer2.Panel1.Controls.Add(groupBox1);
            splitContainer2.Panel1.Controls.Add(comboBox1);
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.DimGray;
            splitContainer2.Panel2.BackgroundImageLayout = ImageLayout.Zoom;
            splitContainer2.Size = new Size(786, 408);
            splitContainer2.SplitterDistance = 262;
            splitContainer2.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            bunifuFlatButton1.Active = false;
            bunifuFlatButton1.Activecolor = Color.Red;
            bunifuFlatButton1.BackColor = Color.DarkRed;
            bunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuFlatButton1.BorderRadius = 0;
            bunifuFlatButton1.ButtonText = "Sair";
            bunifuFlatButton1.DisabledColor = Color.Gray;
            bunifuFlatButton1.Dock = DockStyle.Bottom;
            bunifuFlatButton1.Iconcolor = Color.Transparent;
            bunifuFlatButton1.Iconimage = null;
            bunifuFlatButton1.Iconimage_right = null;
            bunifuFlatButton1.Iconimage_right_Selected = null;
            bunifuFlatButton1.Iconimage_Selected = null;
            bunifuFlatButton1.IconMarginLeft = 0;
            bunifuFlatButton1.IconMarginRight = 0;
            bunifuFlatButton1.IconRightVisible = false;
            bunifuFlatButton1.IconRightZoom = 0D;
            bunifuFlatButton1.IconVisible = false;
            bunifuFlatButton1.IconZoom = 90D;
            bunifuFlatButton1.IsTab = false;
            bunifuFlatButton1.Location = new Point(0, 353);
            bunifuFlatButton1.Margin = new Padding(4, 3, 4, 3);
            bunifuFlatButton1.Name = "bunifuFlatButton1";
            bunifuFlatButton1.Normalcolor = Color.DarkRed;
            bunifuFlatButton1.OnHovercolor = Color.Red;
            bunifuFlatButton1.OnHoverTextColor = Color.White;
            bunifuFlatButton1.selected = false;
            bunifuFlatButton1.Size = new Size(262, 55);
            bunifuFlatButton1.TabIndex = 4;
            bunifuFlatButton1.Text = "Sair";
            bunifuFlatButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuFlatButton1.Textcolor = Color.White;
            bunifuFlatButton1.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuFlatButton1.Click += sair;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Variacao4);
            groupBox1.Controls.Add(Variacao3);
            groupBox1.Controls.Add(Variacao2);
            groupBox1.Controls.Add(Variacao1);
            groupBox1.Location = new Point(5, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 173);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // Variacao4
            // 
            Variacao4.AutoSize = true;
            Variacao4.Location = new Point(6, 128);
            Variacao4.Name = "Variacao4";
            Variacao4.Size = new Size(106, 27);
            Variacao4.TabIndex = 5;
            Variacao4.TabStop = true;
            Variacao4.Text = "Variação 4";
            Variacao4.UseVisualStyleBackColor = true;
            Variacao4.CheckedChanged += radioChecked;
            // 
            // Variacao3
            // 
            Variacao3.AutoSize = true;
            Variacao3.Location = new Point(3, 95);
            Variacao3.Name = "Variacao3";
            Variacao3.Size = new Size(106, 27);
            Variacao3.TabIndex = 4;
            Variacao3.TabStop = true;
            Variacao3.Text = "Variação 3";
            Variacao3.UseVisualStyleBackColor = true;
            Variacao3.CheckedChanged += radioChecked;
            // 
            // Variacao2
            // 
            Variacao2.AutoSize = true;
            Variacao2.Location = new Point(6, 62);
            Variacao2.Name = "Variacao2";
            Variacao2.Size = new Size(106, 27);
            Variacao2.TabIndex = 3;
            Variacao2.TabStop = true;
            Variacao2.Text = "Variação 2";
            Variacao2.UseVisualStyleBackColor = true;
            Variacao2.CheckedChanged += radioChecked;
            // 
            // Variacao1
            // 
            Variacao1.AutoSize = true;
            Variacao1.Location = new Point(6, 29);
            Variacao1.Name = "Variacao1";
            Variacao1.Size = new Size(103, 27);
            Variacao1.TabIndex = 2;
            Variacao1.TabStop = true;
            Variacao1.Text = "Variação 1";
            Variacao1.UseVisualStyleBackColor = true;
            Variacao1.CheckedChanged += radioChecked;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cachorro", "Gato", "Salamandra", "Tartaruga" });
            comboBox1.Location = new Point(5, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 31);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 9);
            label1.MaximumSize = new Size(250, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 46);
            label1.TabIndex = 0;
            label1.Text = "Selecione alguma opção na combo box";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            tabPage2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private Label selectVideoType;
        private Bunifu.Framework.UI.BunifuFlatButton btnSair;
        private TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnviar;
        private Panel panel1;
        private Button button1;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private SplitContainer splitContainer2;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton Variacao4;
        private RadioButton Variacao3;
        private RadioButton Variacao2;
        private RadioButton Variacao1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}