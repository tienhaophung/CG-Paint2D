﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SharpGL
{
	// Kieu enum cho nut chon mau
	public enum ButtonColor {
		LEFT,
		RIGHT
	}

	// Kieu enum cho nut chon hinh ve
	public enum Shape {
		LINE,
		CIRCLE,
		RECTANGLE,
		ELLIPSE,
		TRIANGLE,
		PENTAGON,
		HEXAGON
	}

	public partial class Form1 : Form
	{
		Color colorUserColor; // Bien mau de ve hinh
		Shape shShape; // 0 neu muon ve duong thang, 1 neu duong tron, ...

		Point pStart, pEnd; // Toa do diem dau va diem cuoi
							// Point thuoc lop System.Drawing
		int isDown; // Bien kiem soat con tro chuot co dang duoc giu khong
		int currentSize; // Kich co ve hien tai

		ButtonColor currentButtonColor; // Nut chon mau hien tai

		// De repaint duoc thi can mot doi tuong Bitmap de luu tru lại tat cac nhung gi user ve
		// Ý tưởng: Khi người dùng mouse up (dứt chuột) thì cùng lúc đó ta vẽ lên bitmap bằng Graphics
		Bitmap bm; // Dung de luu lai tat ca nhung gi nguoi dung ve tren OpenGLControll
		Graphics gr; // Dung doi tuong Graphics de ve len Bitmap

		public Form1()
		{
			InitializeComponent();
			colorUserColor = Color.White; // Gia tri mac dinh la mau trang
			currentButtonColor = ButtonColor.LEFT; // Mac dinh la nut ben trai
			shShape = Shape.LINE; // Mac dinh ve duong thang
			cBox_Choose_Size.SelectedIndex = 0; // Mac dinh net ve hien thi la 1


			// Cap phat vung nho cho Bitmap
			bm = new Bitmap(this.Width, this.Height); // kich thuoc bitmap bang voi form1
			gr = Graphics.FromImage(bm); // Truyen doi tuong Bitmap vao de ve
		}

		private void openGLControl1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void bt_Palette_Click(object sender, EventArgs e)
		{
			// Goi hop thoai chon mau
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				// Neu nguoi dung chon mau tai button trai thi cap nhat back color cho nut do
				// va nguoc lai
				if (currentButtonColor == ButtonColor.LEFT)
					bt_Left_Color.BackColor = colorDialog1.Color;
				else
					bt_Right_Color.BackColor = colorDialog1.Color;

				colorUserColor = colorDialog1.Color; // Luu lai mau user chon
			}
		}

		// Nguoi dung chon chuc nang ve duong thang
		private void bt_Line_Click(object sender, EventArgs e)
		{
			shShape = Shape.LINE; // Nguoi dung chon ve duong thang
		}
		
		// Nguoi dung chon chuc nang ve hinh chu nhat
		private void bt_Rec_Click(object sender, EventArgs e)
		{
			shShape = Shape.RECTANGLE;
		}

		// Nguoi dung chon chuc nang ve tam giac deu
		private void bt_Triangle_Click(object sender, EventArgs e)
		{
			shShape = Shape.TRIANGLE;
		}

		// Ham khoi tao cho opengl
		private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
		{
			// get the openGL object
			OpenGL gl = openGLControl.OpenGL;
			// set the clear color: dat mau nen
			// alpha: do trong suot
			gl.ClearColor(0, 0, 0, 0);
			// set the projection matrix
			// Xet ma tran phep chieu
			// 2D: chỉ quan tam projection matrix
			gl.MatrixMode(OpenGL.GL_PROJECTION);
			// load the identify
			// Xét ma trận hiện hành là ma trận đơn vị
			gl.LoadIdentity();
		}

		// Ham ve doan thang
		private void drawLine(OpenGL gl) {
			gl.Enable(OpenGL.GL_LINE_SMOOTH); // Lam tron cac diem ve, cho duong thang muot hon
			gl.Begin(OpenGL.GL_LINES);
			gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pStart.Y);
			gl.Vertex(pEnd.X, gl.RenderContextProvider.Height - pEnd.Y);
			gl.End();
			gl.Flush();
			gl.Disable(OpenGL.GL_LINE_SMOOTH);
		}

		// Ham ve hinh tron
		private void drawCircle(OpenGL gl)
		{
				
		}

		// Ham ve hinh chu nhat
		private void drawRec(OpenGL gl) {
			gl.Enable(OpenGL.GL_LINE_SMOOTH); // Lam tron cac diem ve, cho duong thang muot hon
			gl.Begin(OpenGL.GL_LINE_LOOP);
			// Toa do diem dau (x1, y1)
			// Toa do diem cuoi (x2, y2)
			gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pStart.Y);
			// Toa do diem 2 (x2, y1)
			gl.Vertex(pEnd.X, gl.RenderContextProvider.Height - pStart.Y);
			// Toa do diem 3 (x2, y2)
			gl.Vertex(pEnd.X, gl.RenderContextProvider.Height - pEnd.Y);
			// Toa do diem 4 (x1, y2)
			gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pEnd.Y);
			gl.End();
			gl.Flush();
			gl.Disable(OpenGL.GL_LINE_SMOOTH);
		}

		// Ham ve tam giac
		private void drawTriangle(OpenGL gl) {
			gl.Enable(OpenGL.GL_LINE_SMOOTH); // Lam tron cac diem ve, cho duong thang muot hon
			gl.Begin(OpenGL.GL_LINE_LOOP); // Ve tam giac
			if (pStart.X > pEnd.X) {
				Point t = pEnd;
				pEnd = pStart;
				pStart = t;
			}

			gl.Vertex(pStart.X, gl.RenderContextProvider.Height - pStart.Y); // Dinh A(x1, y1)
			gl.Vertex(pEnd.X, gl.RenderContextProvider.Height - pEnd.Y); // Dinh B(x2, y2)
			gl.Vertex(pStart.X - Math.Abs(pStart.X - pEnd.X), gl.RenderContextProvider.Height - pEnd.Y);
																		// Dinh C(x1 - abs(x2 - x1), y2)
			gl.End(); // Kết thúc
			gl.Flush(); // Thuc hien ve ngay thay vi phai doi sau 1 thoi gian
						// Bản chất khi vẽ thì nó vẽ lên vùng nhớ Buffer
						// Do đó cần dùng hàm Flush để đẩy vùng nhớ Buffer này lên màn hình
			gl.Disable(OpenGL.GL_LINE_SMOOTH);
		}

		// Cac ham ve khac ...

		private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
		{
			if (isDown == 1) // Neu nguoi dung dang Mouse down thi moi ve
			{
				// get the OpenGL object
				OpenGL gl = openGLControl.OpenGL;
				// clear the color and depth buffer
				// Xóa màn hình
				gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

				// Chon mau
				gl.Color(colorUserColor.R / 255.0, colorUserColor.G / 255.0, colorUserColor.B / 255.0, 0);

				// Thiet lap size cua net ve
				gl.LineWidth(currentSize);

				// Stopwatch ho tro do thoi gian
				Stopwatch myTimer = new Stopwatch();
				myTimer.Start(); // bat dau do
				
				// Ve voi cho nay
				// ...
				switch (shShape)
				{
					case Shape.LINE:
						// Ve doan thang
						drawLine(gl);
						break;
					case Shape.CIRCLE:
						// Ve duong tron

						break;
					case Shape.RECTANGLE:
						// Ve hinh chu nhat
						drawRec(gl);
						break;
					case Shape.ELLIPSE:
						// Ve ellipse
						break;
					case Shape.TRIANGLE:
						// Ve tam giac deu
						drawTriangle(gl);
						break;
					case Shape.PENTAGON:
						// Ve ngu giac deu

						break;
					case Shape.HEXAGON:
						// Ve luc giac deu
						break;
				}
				myTimer.Stop(); // ket thuc do
				TimeSpan Time = myTimer.Elapsed; // Lay thoi gian troi qua
				tb_Time.Text = String.Format("{0} (sec)", Time.TotalSeconds); // In ra tb_Time
			}
			#region ViDuVeTamGiac
			/* 
			
			gl.Begin(OpenGL.GL_TRIANGLES); // Ve tam giac
			gl.Vertex2sv(new short[] { 0, 0 }); // Dinh A(0, 0)
			gl.Vertex2sv(new short[] { 200, 200 }); // Dinh B(100, 100)
			gl.Vertex2sv(new short[] { 500, 0 }); // Dinh C(200, 0)
			gl.End(); // Kết thúc
			gl.Flush(); // Thuc hien ve ngay thay vi phai doi sau 1 thoi gian
						// Bản chất khi vẽ thì nó vẽ lên vùng nhớ Buffer
						// Do đó cần dùng hàm Flush để đẩy vùng nhớ Buffer này lên màn hình
			*/
			#endregion
		}


		private void openGLControl_Resized(object sender, EventArgs e)
		{
			// get the OpenGL object
			OpenGL gl = openGLControl.OpenGL;
			// set the projection matrix
			gl.MatrixMode(OpenGL.GL_PROJECTION);
			// load the identify
			gl.LoadIdentity();
			// Create a perspective transformation
			gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height); // Xét cái màn hình: Vẽ toàn bộ cái khung của OpenGL control

			// Hàm set up cái phép chiếu trực giao
			// Ở đây chính là cái size của khung OpenGL control
			gl.Ortho2D(0, openGLControl.Width, 0, openGLControl.Height);
		}

		// Ham xu ly su kien to mau theo vet loang
		private void bt_Flood_Fill_Click(object sender, EventArgs e)
		{
			// Thuat toan to mau theo vet loang
			
		}

		// Khi nguoi dung click button chon mau ben trai
		private void bt_Left_Color_Click(object sender, EventArgs e)
		{
			currentButtonColor = ButtonColor.LEFT;
			colorUserColor = bt_Left_Color.BackColor; // cap nhat mau hien tai
		}

		// Khi nguoi dung click button chon mau ben phai
		private void bt_Right_Color_Click(object sender, EventArgs e)
		{
			currentButtonColor = ButtonColor.RIGHT;
			colorUserColor = bt_Right_Color.BackColor; // Cap nhat mau  hien tai 
													   //khi nguoi dung click button phai
		}

		// Cap nhat diem cuoi khi nguoi dung dang keo chuot
		private void ctrl_OpenGLControl_MouseMove(object sender, MouseEventArgs e)
		{
			// Neu chuot dang di chuyen thi moi cap nhat diem pEnd
			if(isDown == 1 && pEnd.X != -1 && pEnd.Y != -1)
				// Cap nhat diem cuoi
				pEnd = new Point(e.Location.X, e.Location.Y);
			
		}

		// Cap nhat toa do diem cuoi khi nguoi dung buong chuot ra
		private void ctrl_OpenGLControl_MouseUp(object sender, MouseEventArgs e)
		{
			openGLControl.Cursor = Cursors.Default; // Tra ve con tro chuot nhu cu
			isDown = 0; // chuot het di chuyen

			// Ve len bitmap
			Pen pen = new Pen(colorUserColor);
			gr.DrawLine(pen, pStart, pEnd);
			this.BackgroundImage = (Bitmap)bm.Clone(); // Set lai background
		}

		private void cBox_Choose_Size_SelectedIndexChanged(object sender, EventArgs e)
		{
			currentSize = int.Parse(cBox_Choose_Size.Text);
		}

		// Cap nhat diem dau khi nguoi dung bat dau giu chuot
		private void ctrl_OpenGLControl_MouseDown(object sender, MouseEventArgs e)
		{
			// Cap nhat toa do diem dau
			pStart = new Point(e.Location.X, e.Location.Y); // e la tham so lien quan den su kien chon diem
			pEnd = pStart; // Mac dinh pEnd = pStart
			openGLControl.Cursor = Cursors.Cross; // Thay doi hinh dang con tro chuot khi ve
			isDown = 1; // Chuot dang bat dau di chuyen
		}

	}
}