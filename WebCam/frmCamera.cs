using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace WebCam
{
    public partial class frmCamera : Form
    {
        private int hWnd;

        const int WM_CAP_START = 1024;
        const int WS_CHILD = 1073741824;
        const int WS_VISIBLE = 268435456;
        const int WM_CAP_DRIVER_CONNECT = (WM_CAP_START + 10);
        const int WM_CAP_DRIVER_DISCONNECT = (WM_CAP_START + 11);
        const int WM_CAP_EDIT_COPY = (WM_CAP_START + 30);
        const int WM_CAP_SEQUENCE = (WM_CAP_START + 62);
        const int WM_CAP_FILE_SAVEAS = (WM_CAP_START + 23);
        const int WM_CAP_SET_SCALE = (WM_CAP_START + 53);
        const int WM_CAP_SET_PREVIEWRATE = (WM_CAP_START + 52);
        const int WM_CAP_SET_PREVIEW = (WM_CAP_START + 50);
        const int SWP_NOMOVE = 2;
        const int SWP_NOSIZE = 1;
        const int SWP_NOZORDER = 4;
        const int HWND_BOTTOM = 1;


        //---The capGetDriverDescription function retrieves the
        // version description of the capture driver---
        [System.Runtime.InteropServices.DllImport("avicap32.dll")]
        static extern bool capGetDriverDescriptionA(
        short wDriverIndex, string lpszName,
        int cbName, string lpszVer, int cbVer);

        //---The capCreateCaptureWindow function creates a capture
        // window---
        [System.Runtime.InteropServices.DllImport("avicap32.dll")]
        static extern int capCreateCaptureWindowA(
        string lpszWindowName, int dwStyle, int x, int y,
        int nWidth, short nHeight, int hWnd, int nID);

        //---This function sends the specified message to a window or
        // windows---
        [System.Runtime.InteropServices.DllImport(
            "user32", EntryPoint = "SendMessageA")]
        static extern int SendMessage(
        int hwnd, int Msg, int wParam,
        [MarshalAs(UnmanagedType.AsAny)] object lParam);

        //---Sets the position of the window relative to the screen
        // buffer---
        [System.Runtime.InteropServices.DllImport(
            "user32", EntryPoint = "SetWindowPos")]
        static extern int SetWindowPos(
        int hwnd, int hWndInsertAfter, int x, int y,
        int cx, int cy, int wFlags);

        //--This function destroys the specified window--
        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool DestroyWindow(int hndw);


        //---preview the selected video source---
        
        public frmCamera()
        {
            InitializeComponent();
        }
        
        private void PreviewVideo(PictureBox pbCtrl)
        {
            hWnd = capCreateCaptureWindowA("0", WS_VISIBLE | WS_CHILD, 0, 0, 0, 0, pbCtrl.Handle.ToInt32(), 0);
            if (SendMessage(hWnd, WM_CAP_DRIVER_CONNECT, 0, 0) != 0)
            {
                SendMessage(hWnd, WM_CAP_SET_SCALE, 1, 0);
                SendMessage(hWnd, WM_CAP_SET_PREVIEWRATE, 30, 0);
                SendMessage(hWnd, WM_CAP_SET_PREVIEW, 1, 0);
                SetWindowPos(hWnd, HWND_BOTTOM, 0, 0, pbCtrl.Width, pbCtrl.Height, SWP_NOMOVE | SWP_NOZORDER);
            }
            else
            {
                DestroyWindow(hWnd);
            }
        }

       

  

   

        private void btnSnapshot_Click(object sender, EventArgs e)
        {

            IDataObject data;
            Image bmap;
            //---copy the image to the Clipboard---
            SendMessage(hWnd, WM_CAP_EDIT_COPY, 0, 0);
            //---retrieve the image from Clipboard and convert it
            // to the bitmap format---
            data = Clipboard.GetDataObject();

            if (data.GetDataPresent(typeof(System.Drawing.Bitmap)))
            {

                SaveFileDialog save = new SaveFileDialog();
                save.ShowDialog();
                bmap =
                    ((Image)(data.GetData(typeof(
                        System.Drawing.Bitmap))));

                bmap.Save((save.FileName)+ ".bmp");
            }


        }

        private void frmCamera_Load(object sender, EventArgs e)
        {
            //Here we put the video from the camera to the picturebox
            
            PreviewVideo(picFrame);

        }

        private void picFrame_Click(object sender, EventArgs e)
        {

        }
    }


    }
