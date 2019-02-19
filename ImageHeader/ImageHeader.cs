using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;

namespace ImageHeader{
    public partial class ImageHeader : Form{
        public ImageHeader(){
            InitializeComponent();
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        private const int HTCAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public static int WM_SYSCOMMAND = 0x0112;
        public static int SC_MOVE = 0xF010;
        #region
        const int WM_NCHITTEST = 0x0084;
        const int HTLEFT = 10;          //左边界
        const int HTRIGHT = 11;         //右边界
        const int HTTOP = 12;           //上边界
        const int HTTOPLEFT = 13;       //左上角
        const int HTTOPRIGHT = 14;      //右上角
        const int HTBOTTOM = 15;        //下边界
        const int HTBOTTOMLEFT = 0x10;  //左下角
        const int HTBOTTOMRIGHT = 17;   //右下角
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else m.Result = (IntPtr)HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)HTBOTTOM;
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        private void PictureBox1_DoubleClick(object sender, EventArgs e){
            if(this.WindowState==FormWindowState.Maximized){
                this.WindowState=FormWindowState.Normal;
            }
            else{
                this.WindowState=FormWindowState.Maximized;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e){
            this.Close();
            this.Dispose();
            Application.Exit();
        }
        private void SizeButton_Click(object sender, EventArgs e){
            if(this.WindowState==FormWindowState.Maximized){
                this.WindowState=FormWindowState.Normal;
            }
            else{
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void MinButton_Click(object sender, EventArgs e){
            this.WindowState = FormWindowState.Minimized;
        }
        private void CloseButton_MouseHover(object sender, EventArgs e){
            CloseButton.ForeColor=Color.FromArgb(193,193,193);
        }
        private void CloseButton_MouseMove(object sender, MouseEventArgs e){
            CloseButton.ForeColor=Color.FromArgb(193,193,193);
        }
        private void CloseButton_MouseLeave(object sender, EventArgs e){
            CloseButton.ForeColor=Color.FromArgb(255,96,82);
        }
        private void SizeButton_MouseHover(object sender, EventArgs e){
            SizeButton.ForeColor=Color.FromArgb(193,193,193);
            if(this.WindowState==FormWindowState.Maximized){
                Tip_1.SetToolTip(SizeButton,"Normal");
            }
            else{
                Tip_1.SetToolTip(SizeButton,"Maximized");
            }
        }
        private void SizeButton_MouseMove(object sender, MouseEventArgs e){
            SizeButton.ForeColor=Color.FromArgb(193,193,193);
        }
        private void SizeButton_MouseLeave(object sender, EventArgs e){
            SizeButton.ForeColor=Color.FromArgb(255,190,5);
        }
        private void MinButton_MouseHover(object sender, EventArgs e){
            MinButton.ForeColor=Color.FromArgb(193,193,193);
        }
        private void MinButton_MouseMove(object sender, MouseEventArgs e){
            MinButton.ForeColor = Color.FromArgb(193,193,193);
        }
        private void MinButton_MouseLeave(object sender, EventArgs e){
            MinButton.ForeColor=Color.FromArgb(21,204,55);
        }

        string url;
        private void Button1_Click(object sender, EventArgs e){
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Open a picture";
            fileDialog.Filter = "Image File|*.bmp;*.jpg;*.png|All File|*.*";
            DialogResult result = fileDialog.ShowDialog();
            if(result == DialogResult.OK){
                pictureBox2.BackgroundImage = Properties.Resources.tran;
                pictureBox2.BackgroundImageLayout = ImageLayout.Tile;
                pictureBox2.Image = Image.FromFile(fileDialog.FileName);
                label1.Text = "Width:  " + pictureBox2.Image.Width + "px";
                label2.Text = "Height:  " + pictureBox2.Image.Height + "px";
                url = fileDialog.FileName;
                button3.Visible = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e){
            if (pictureBox2.SizeMode == PictureBoxSizeMode.Normal)
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void Button2_Click(object sender, EventArgs e){
            if (pictureBox2.Image == null){
                MessageBox.Show("None Image!", "ImageHeader Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Please select the path to save";
            sf.InitialDirectory = @"";
            sf.FileName = "Image.h";
            sf.Filter = "Header|*.h|All File|*.*";
            if (sf.ShowDialog() == DialogResult.OK){
                string path = sf.FileName;
                using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)){
                int x, y, number = pictureBox2.Image.Width * pictureBox2.Image.Height, xl = pictureBox2.Image.Width, yl = pictureBox2.Image.Height;
                StreamWriter fw = new StreamWriter(fsWrite);
                fw.Write("//Image width: "+ pictureBox2.Image.Width+", "+ "Height: "+ pictureBox2.Image.Height+";\n\r");
                fw.Write("const unsigned char image[] = {\n");
                using (Bitmap bmp = new Bitmap(url)){
                    for (y = 0; y < yl; y++){
                        for (x = 0; x < xl; x++){
                            Color pixelColor = bmp.GetPixel(x, y);
                            //byte alpha = pixelColor.A;
                            byte red = pixelColor.R;
                            byte green = pixelColor.G;
                            byte blue = pixelColor.B;
                            if(red <= 15 && green <= 15 && blue <= 15)
                                fw.Write("0x0" + Convert.ToString(red, 16) + "," + "0x0" + Convert.ToString(green, 16) + "," + "0x0" + Convert.ToString(blue, 16) + ",");
                            if (red > 15 && green <= 15 && blue <= 15)
                                fw.Write("0x" + Convert.ToString(red, 16) + "," + "0x0" + Convert.ToString(green, 16) + "," + "0x0" + Convert.ToString(blue, 16) + ",");
                            if (red <= 15 && green > 15 && blue <= 15)
                                fw.Write("0x0" + Convert.ToString(red, 16) + "," + "0x" + Convert.ToString(green, 16) + "," + "0x0" + Convert.ToString(blue, 16) + ",");
                            if (red <= 15 && green <= 15 && blue > 15)
                                fw.Write("0x0" + Convert.ToString(red, 16) + "," + "0x0" + Convert.ToString(green, 16) + "," + "0x" + Convert.ToString(blue, 16) + ",");
                            if (red > 15 && green > 15 && blue <= 15)
                                fw.Write("0x" + Convert.ToString(red, 16) + "," + "0x" + Convert.ToString(green, 16) + "," + "0x0" + Convert.ToString(blue, 16) + ",");
                            if (red > 15 && green <= 15 && blue > 15)
                                fw.Write("0x" + Convert.ToString(red, 16) + "," + "0x0" + Convert.ToString(green, 16) + "," + "0x" + Convert.ToString(blue, 16) + ",");
                            if (red <= 15 && green > 15 && blue > 15)
                                fw.Write("0x0" + Convert.ToString(red, 16) + "," + "0x" + Convert.ToString(green, 16) + "," + "0x" + Convert.ToString(blue, 16) + ",");
                            if (red > 15 && green > 15 && blue > 15)
                                fw.Write("0x" + Convert.ToString(red, 16) + "," + "0x" + Convert.ToString(green, 16) + "," + "0x" + Convert.ToString(blue, 16) + ",");
                            }
                            fw.Write("\n");  
                        }
                        fw.Write("};\n");
                        fw.Close();
                        MessageBox.Show("Successfully saved!", "ImageHeader Tip", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            else{
                MessageBox.Show("Save failed!", "ImageHeader Tip", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
