﻿namespace SharpGL
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.openGLControl = new SharpGL.OpenGLControl();
			this.Icon_List = new System.Windows.Forms.ImageList(this.components);
			this.bt_Palette = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.lb_Time = new System.Windows.Forms.Label();
			this.tb_Time = new System.Windows.Forms.TextBox();
			this.pnl_Tool_Bar = new System.Windows.Forms.Panel();
			this.lb_Color2 = new System.Windows.Forms.Label();
			this.lb_Color1 = new System.Windows.Forms.Label();
			this.bt_Right_Color = new System.Windows.Forms.Button();
			this.bt_Left_Color = new System.Windows.Forms.Button();
			this.lb_Size = new System.Windows.Forms.Label();
			this.bt_Hexagon = new System.Windows.Forms.Button();
			this.bt_Pentagon = new System.Windows.Forms.Button();
			this.cBox_Choose_Size = new System.Windows.Forms.ComboBox();
			this.bt_Rec = new System.Windows.Forms.Button();
			this.bt_Triangle = new System.Windows.Forms.Button();
			this.bt_Line = new System.Windows.Forms.Button();
			this.bt_Flood_Fill = new System.Windows.Forms.Button();
			this.bt_Circle = new System.Windows.Forms.Button();
			this.bt_Ellipse = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
			this.pnl_Tool_Bar.SuspendLayout();
			this.SuspendLayout();
			// 
			// openGLControl
			// 
			this.openGLControl.Cursor = System.Windows.Forms.Cursors.Cross;
			this.openGLControl.DrawFPS = false;
			this.openGLControl.Location = new System.Drawing.Point(0, 109);
			this.openGLControl.Name = "openGLControl";
			this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
			this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
			this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
			this.openGLControl.Size = new System.Drawing.Size(1368, 642);
			this.openGLControl.TabIndex = 0;
			this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
			this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
			this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
			this.openGLControl.Load += new System.EventHandler(this.openGLControl1_Load);
			this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrl_OpenGLControl_MouseDown);
			this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctrl_OpenGLControl_MouseMove);
			this.openGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ctrl_OpenGLControl_MouseUp);
			// 
			// Icon_List
			// 
			this.Icon_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icon_List.ImageStream")));
			this.Icon_List.TransparentColor = System.Drawing.Color.Transparent;
			this.Icon_List.Images.SetKeyName(0, "icons8-line-96.png");
			this.Icon_List.Images.SetKeyName(1, "if_button_shape_triangle_352894.png");
			this.Icon_List.Images.SetKeyName(2, "icons8-rectangular-100.png");
			this.Icon_List.Images.SetKeyName(3, "if_check-circle-outline-blank_326565.png");
			this.Icon_List.Images.SetKeyName(4, "Actions-fill-color-icon.png");
			this.Icon_List.Images.SetKeyName(5, "pentagon- (3).png");
			this.Icon_List.Images.SetKeyName(6, "polygon (1).png");
			this.Icon_List.Images.SetKeyName(7, "hexagon.png");
			// 
			// bt_Palette
			// 
			this.bt_Palette.Image = ((System.Drawing.Image)(resources.GetObject("bt_Palette.Image")));
			this.bt_Palette.Location = new System.Drawing.Point(702, 14);
			this.bt_Palette.Name = "bt_Palette";
			this.bt_Palette.Size = new System.Drawing.Size(70, 70);
			this.bt_Palette.TabIndex = 3;
			this.bt_Palette.UseVisualStyleBackColor = true;
			this.bt_Palette.Click += new System.EventHandler(this.bt_Palette_Click);
			// 
			// lb_Time
			// 
			this.lb_Time.AutoSize = true;
			this.lb_Time.Location = new System.Drawing.Point(1212, 82);
			this.lb_Time.Name = "lb_Time";
			this.lb_Time.Size = new System.Drawing.Size(36, 13);
			this.lb_Time.TabIndex = 4;
			this.lb_Time.Text = "Time: ";
			// 
			// tb_Time
			// 
			this.tb_Time.HideSelection = false;
			this.tb_Time.Location = new System.Drawing.Point(1251, 79);
			this.tb_Time.Name = "tb_Time";
			this.tb_Time.Size = new System.Drawing.Size(100, 20);
			this.tb_Time.TabIndex = 7;
			this.tb_Time.Text = "0.0000000 (sec)";
			this.tb_Time.TextChanged += new System.EventHandler(this.openGLControl1_Load);
			// 
			// pnl_Tool_Bar
			// 
			this.pnl_Tool_Bar.Controls.Add(this.bt_Ellipse);
			this.pnl_Tool_Bar.Controls.Add(this.lb_Color2);
			this.pnl_Tool_Bar.Controls.Add(this.lb_Color1);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Right_Color);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Left_Color);
			this.pnl_Tool_Bar.Controls.Add(this.lb_Size);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Hexagon);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Pentagon);
			this.pnl_Tool_Bar.Controls.Add(this.cBox_Choose_Size);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Rec);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Triangle);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Line);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Palette);
			this.pnl_Tool_Bar.Controls.Add(this.tb_Time);
			this.pnl_Tool_Bar.Controls.Add(this.lb_Time);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Flood_Fill);
			this.pnl_Tool_Bar.Controls.Add(this.bt_Circle);
			this.pnl_Tool_Bar.Location = new System.Drawing.Point(-1, 2);
			this.pnl_Tool_Bar.Name = "pnl_Tool_Bar";
			this.pnl_Tool_Bar.Size = new System.Drawing.Size(1368, 110);
			this.pnl_Tool_Bar.TabIndex = 9;
			// 
			// lb_Color2
			// 
			this.lb_Color2.AutoSize = true;
			this.lb_Color2.Location = new System.Drawing.Point(642, 71);
			this.lb_Color2.Name = "lb_Color2";
			this.lb_Color2.Size = new System.Drawing.Size(40, 13);
			this.lb_Color2.TabIndex = 20;
			this.lb_Color2.Text = "Color 2";
			// 
			// lb_Color1
			// 
			this.lb_Color1.AutoSize = true;
			this.lb_Color1.Location = new System.Drawing.Point(573, 71);
			this.lb_Color1.Name = "lb_Color1";
			this.lb_Color1.Size = new System.Drawing.Size(40, 13);
			this.lb_Color1.TabIndex = 19;
			this.lb_Color1.Text = "Color 1";
			// 
			// bt_Right_Color
			// 
			this.bt_Right_Color.BackColor = System.Drawing.Color.Black;
			this.bt_Right_Color.Location = new System.Drawing.Point(642, 19);
			this.bt_Right_Color.Name = "bt_Right_Color";
			this.bt_Right_Color.Size = new System.Drawing.Size(40, 40);
			this.bt_Right_Color.TabIndex = 18;
			this.bt_Right_Color.UseVisualStyleBackColor = false;
			this.bt_Right_Color.Click += new System.EventHandler(this.bt_Right_Color_Click);
			// 
			// bt_Left_Color
			// 
			this.bt_Left_Color.BackColor = System.Drawing.Color.White;
			this.bt_Left_Color.Location = new System.Drawing.Point(567, 14);
			this.bt_Left_Color.Name = "bt_Left_Color";
			this.bt_Left_Color.Size = new System.Drawing.Size(50, 50);
			this.bt_Left_Color.TabIndex = 17;
			this.bt_Left_Color.UseVisualStyleBackColor = false;
			this.bt_Left_Color.Click += new System.EventHandler(this.bt_Left_Color_Click);
			// 
			// lb_Size
			// 
			this.lb_Size.AutoSize = true;
			this.lb_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Size.Location = new System.Drawing.Point(366, 17);
			this.lb_Size.Name = "lb_Size";
			this.lb_Size.Size = new System.Drawing.Size(35, 17);
			this.lb_Size.TabIndex = 16;
			this.lb_Size.Text = "Size";
			// 
			// bt_Hexagon
			// 
			this.bt_Hexagon.Image = ((System.Drawing.Image)(resources.GetObject("bt_Hexagon.Image")));
			this.bt_Hexagon.Location = new System.Drawing.Point(192, 10);
			this.bt_Hexagon.Name = "bt_Hexagon";
			this.bt_Hexagon.Size = new System.Drawing.Size(30, 30);
			this.bt_Hexagon.TabIndex = 15;
			this.bt_Hexagon.UseVisualStyleBackColor = true;
			this.bt_Hexagon.Click += new System.EventHandler(this.bt_Hexagon_Click);
			// 
			// bt_Pentagon
			// 
			this.bt_Pentagon.Image = ((System.Drawing.Image)(resources.GetObject("bt_Pentagon.Image")));
			this.bt_Pentagon.Location = new System.Drawing.Point(156, 10);
			this.bt_Pentagon.Name = "bt_Pentagon";
			this.bt_Pentagon.Size = new System.Drawing.Size(30, 30);
			this.bt_Pentagon.TabIndex = 14;
			this.bt_Pentagon.UseVisualStyleBackColor = true;
			this.bt_Pentagon.Click += new System.EventHandler(this.bt_Pentagon_Click);
			// 
			// cBox_Choose_Size
			// 
			this.cBox_Choose_Size.CausesValidation = false;
			this.cBox_Choose_Size.FormattingEnabled = true;
			this.cBox_Choose_Size.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.cBox_Choose_Size.Location = new System.Drawing.Point(407, 16);
			this.cBox_Choose_Size.Name = "cBox_Choose_Size";
			this.cBox_Choose_Size.Size = new System.Drawing.Size(121, 21);
			this.cBox_Choose_Size.TabIndex = 13;
			this.cBox_Choose_Size.SelectedIndexChanged += new System.EventHandler(this.cBox_Choose_Size_SelectedIndexChanged);
			// 
			// bt_Rec
			// 
			this.bt_Rec.ImageIndex = 2;
			this.bt_Rec.ImageList = this.Icon_List;
			this.bt_Rec.Location = new System.Drawing.Point(84, 10);
			this.bt_Rec.Name = "bt_Rec";
			this.bt_Rec.Size = new System.Drawing.Size(30, 30);
			this.bt_Rec.TabIndex = 12;
			this.bt_Rec.UseVisualStyleBackColor = true;
			this.bt_Rec.Click += new System.EventHandler(this.bt_Rec_Click);
			// 
			// bt_Triangle
			// 
			this.bt_Triangle.ImageIndex = 1;
			this.bt_Triangle.ImageList = this.Icon_List;
			this.bt_Triangle.Location = new System.Drawing.Point(120, 10);
			this.bt_Triangle.Name = "bt_Triangle";
			this.bt_Triangle.Size = new System.Drawing.Size(30, 30);
			this.bt_Triangle.TabIndex = 11;
			this.bt_Triangle.UseVisualStyleBackColor = true;
			this.bt_Triangle.Click += new System.EventHandler(this.bt_Triangle_Click);
			// 
			// bt_Line
			// 
			this.bt_Line.ForeColor = System.Drawing.Color.Black;
			this.bt_Line.ImageIndex = 0;
			this.bt_Line.ImageList = this.Icon_List;
			this.bt_Line.Location = new System.Drawing.Point(12, 10);
			this.bt_Line.Name = "bt_Line";
			this.bt_Line.Size = new System.Drawing.Size(30, 30);
			this.bt_Line.TabIndex = 1;
			this.bt_Line.UseVisualStyleBackColor = true;
			this.bt_Line.Click += new System.EventHandler(this.bt_Line_Click);
			// 
			// bt_Flood_Fill
			// 
			this.bt_Flood_Fill.BackColor = System.Drawing.SystemColors.ControlLight;
			this.bt_Flood_Fill.ForeColor = System.Drawing.Color.Black;
			this.bt_Flood_Fill.ImageIndex = 4;
			this.bt_Flood_Fill.ImageList = this.Icon_List;
			this.bt_Flood_Fill.Location = new System.Drawing.Point(258, 10);
			this.bt_Flood_Fill.Name = "bt_Flood_Fill";
			this.bt_Flood_Fill.Size = new System.Drawing.Size(45, 45);
			this.bt_Flood_Fill.TabIndex = 8;
			this.bt_Flood_Fill.UseVisualStyleBackColor = false;
			this.bt_Flood_Fill.Click += new System.EventHandler(this.bt_Flood_Fill_Click);
			// 
			// bt_Circle
			// 
			this.bt_Circle.Image = ((System.Drawing.Image)(resources.GetObject("bt_Circle.Image")));
			this.bt_Circle.Location = new System.Drawing.Point(48, 10);
			this.bt_Circle.Name = "bt_Circle";
			this.bt_Circle.Size = new System.Drawing.Size(30, 30);
			this.bt_Circle.TabIndex = 2;
			this.bt_Circle.UseVisualStyleBackColor = true;
			this.bt_Circle.Click += new System.EventHandler(this.bt_Circle_Click);
			// 
			// bt_Ellipse
			// 
			this.bt_Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("bt_Ellipse.Image")));
			this.bt_Ellipse.Location = new System.Drawing.Point(12, 62);
			this.bt_Ellipse.Name = "bt_Ellipse";
			this.bt_Ellipse.Size = new System.Drawing.Size(30, 30);
			this.bt_Ellipse.TabIndex = 21;
			this.bt_Ellipse.UseVisualStyleBackColor = true;
			this.bt_Ellipse.Click += new System.EventHandler(this.bt_Ellipse_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1366, 745);
			this.Controls.Add(this.pnl_Tool_Bar);
			this.Controls.Add(this.openGLControl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
			this.pnl_Tool_Bar.ResumeLayout(false);
			this.pnl_Tool_Bar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGLControl openGLControl;
		private System.Windows.Forms.Button bt_Line;
		private System.Windows.Forms.Button bt_Circle;
		private System.Windows.Forms.Button bt_Palette;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label lb_Time;
		private System.Windows.Forms.TextBox tb_Time;
		private System.Windows.Forms.Button bt_Flood_Fill;
		private System.Windows.Forms.ImageList Icon_List;
		private System.Windows.Forms.Button bt_Triangle;
		private System.Windows.Forms.Button bt_Rec;
		private System.Windows.Forms.ComboBox cBox_Choose_Size;
		private System.Windows.Forms.Panel pnl_Tool_Bar;
		private System.Windows.Forms.Button bt_Hexagon;
		private System.Windows.Forms.Button bt_Pentagon;
		private System.Windows.Forms.Label lb_Size;
		private System.Windows.Forms.Button bt_Right_Color;
		private System.Windows.Forms.Button bt_Left_Color;
		private System.Windows.Forms.Label lb_Color2;
		private System.Windows.Forms.Label lb_Color1;
		private System.Windows.Forms.Button bt_Ellipse;
	}
}

