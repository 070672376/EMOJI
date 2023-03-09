using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using TestApp;
using static EMOJI.Form1;

namespace EMOJI
{
    public partial class Form1 : Form
    {
        public const long MAX_EMOJIES = 1000;
        public static Form1 F1;
        public static Form2 F2;
        public static Form3 F3;
        public static Form4 F4;
        public static Form5 F5;
        public static frmMain Properties;

        public static String ThisApp = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public static String ThisAppRootDir = ThisApp.Remove(ThisApp.IndexOf("\\EMOJI\\") + "\\EMOJI\\".Length);
        public static String DataDir = (ThisAppRootDir + "Data\\");
        public static String SourcesPath = (DataDir + "Sources\\");
        public static String BinariesPath = (DataDir + "Binaries\\");
        [Serializable]
        public class CEMOJI
        {
            public String EMOJIFile;
            public String SourceFile;
            public String BinaryFile;
            public CRect Rect;
            public int CharIndexOfPicture;
        }

        [Serializable]
        public class CEMOJIDOC
        {
            public String DocFile;
            public long EMOJIesCount = -1;
            public CEMOJI[] Emojies = new CEMOJI[MAX_EMOJIES];
        }

        public CEMOJIDOC EMOJIDOC;
        public static String EmojiDoc;
        public static class CTouchPad
        {
            public static Point MousePos;
            public static MouseButtons Buttons;
            public static long X;
            public static long Y;
            public static long ClickCount = 0;
        }

        public static class CEMOJISelected
        {
            public static int EMOJIIndex = -1;
            public static Point MousePos;
        }

        public class CRect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public static class CSettings
        {
            public static bool EventMouseMove = false;
            public static bool EventMouseDown = false;
            public static bool EventMouseUp = false;
        }
        public static class CIndexes
        {
            public static int PropertiesIndex = -1;
            public static int PropertiesEMOJIIndex = -1;
            public static int PropertiesEMOJIIndexFromPos = -1;
            public static int EventPropertiesIndex = -1;
            public static int MouseButtonPropertiesIndex = -1;

            public static int EventMouseMoveIndex = -1;
            public static int EventMouseDownIndex = -1;
            public static int EventMouseUpIndex = -1;
        }
        public enum CEvent
        {
            None,
            MouseMove,
            MouseDown,
            MouseUp
        }

        public enum CEnumMouseButton
        {
            None,
            Left,
            Right,
            Middle
        }
        public Form1()
        {
            GlobalMouseHandler gmh = new GlobalMouseHandler();
            gmh.TheMouseMoved += new MouseMovedEvent(gmh_TheMouseMoved);
            gmh.TheMouseDown += new MouseDownEvent(gmh_TheMouseDown);
            gmh.TheMouseUp += new MouseUpEvent(gmh_TheMouseUp);
            Application.AddMessageFilter(gmh);

            InitializeComponent();
            F1 = this;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            RtbeEditor.rtb.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Filter = "EMOJI Documents files (*.EMOJI)|*.EMOJI|Documents files (*.docx)|*.docx|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if ((ofd.FileName != "") & (ofd.FileName != null))
                {
                    EmojiDoc = ofd.FileName;
                    FileInfo fi = new FileInfo(ofd.FileName);
                    if (fi.Extension.ToLower() == ".docx")
                    {
                        RtbeEditor.LoadFile(ofd.FileName);
                    }
                    else if (fi.Extension.ToUpper() == ".EMOJI")
                    {
                        OpenEMOJIFile(ofd.FileName);
                    }
                }
            }
        }

        public void OpenEMOJIFile(String FileName)
        {
            EMOJIDOC = (CEMOJIDOC)CS.LoadFile(null, null, FileName);
            if ((EMOJIDOC.DocFile != "") & (EMOJIDOC.DocFile != null))
            {
                RtbeEditor.LoadFile(EMOJIDOC.DocFile);
            }
        }

        public void SaveEMOJIFile(String FileName)
        {
            if (EMOJIDOC == null)
            {
                EMOJIDOC = new CEMOJIDOC();
            }
            FileInfo fi = new FileInfo(FileName);
            EMOJIDOC.DocFile = (fi.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(fi.Name) + ".docx");
            CS.SaveFile(null, null, FileName, EMOJIDOC);
            if ((EMOJIDOC.DocFile != "") & (EMOJIDOC.DocFile != null))
            {
                RtbeEditor.SaveFile(EMOJIDOC.DocFile);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.Filter = "EMOJI Documents files (*.EMOJI)|*.EMOJI|Documents files (*.docx)|*.docx|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                EmojiDoc = sfd.FileName;
                FileInfo fi = new FileInfo(sfd.FileName);
                if (fi.Extension.ToLower() == ".docx")
                {
                    RtbeEditor.SaveFile(sfd.FileName);
                }
                else if (fi.Extension.ToUpper() == ".EMOJI")
                {
                    SaveEMOJIFile(sfd.FileName);
                }
            }
        }

        public void F2Show(object o)
        {
            if (F2 == null)
            {
                F2 = new Form2((Form1)o);
                F2.Show((Form1)o);
            }
            F2.Visible = true;
            F2.BringToFront();
        }

        public void F3Show(object o)
        {
            if (F3 == null)
            {
                F3 = new Form3((Form1)o);
                F3.Show((Form1)o);
            }
            F3.Visible = true;
            F3.BringToFront();
        }

        public void F4Show(object o)
        {
            if (F4 == null)
            {
                F4 = new Form4((Form1)o);
                F4.Show((Form1)o);
            }
            F4.Visible = true;
            F4.BringToFront();
        }

        public void F5Show(object o)
        {
            if (F5 == null)
            {
                F5 = new Form5((Form1)o);
                F5.Show((Form1)o);
            }
            F5.Visible = true;
            F5.BringToFront();
        }
        private void TurnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EMOJIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F2Show(F1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitSettings();
        }

        public void InitSettings()
        {
            if (!(Directory.Exists(DataDir)))
            {
                Directory.CreateDirectory(DataDir);
            }
            if (!(Directory.Exists(SourcesPath)))
            {
                Directory.CreateDirectory(SourcesPath);
            }
            if (!(Directory.Exists(BinariesPath)))
            {
                Directory.CreateDirectory(BinariesPath);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            F2Show(F1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            F3Show(F1);
        }

        private void IDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F3Show(F1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            F4Show(F1);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            F5Show(F1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RtbeEditor.rtb.Modified)
            {
                if ((EmojiDoc == null) | (EmojiDoc == ""))
                {
                    saveToolStripButton_Click(sender, e);
                }
                if (EMOJIDOC != null)
                {
                    FileInfo fi = new FileInfo(EmojiDoc);
                    SaveEMOJIFile((fi.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(fi.Name) + ".EMOJI"));
                }
            }
        }

        private void RtbeEditor_MouseMove(object sender, MouseEventArgs e)
        {
            // Get Picture Clicked
            Point p = new Point(e.X, e.Y);
            int CharIndex = F1.RtbeEditor.rtb.GetCharIndexFromPosition(p);
            if (CharIndex != -1)
            {
                if (F1.EMOJIDOC != null)
                {
                    for (int i = 0; i <= F1.EMOJIDOC.EMOJIesCount; i++)
                    {
                        if (F1.EMOJIDOC.Emojies[i].CharIndexOfPicture == CharIndex)
                        {
                            if (MouseIsInsideRect(i, p))
                            {
                                if ((F1.EMOJIDOC.Emojies[i].BinaryFile != null) & (F1.EMOJIDOC.Emojies[i].BinaryFile != ""))
                                {
                                    // Start code atached on given Picture = EMOJI
                                    try
                                    {
                                        ProcessStartInfo si = new ProcessStartInfo(F1.EMOJIDOC.Emojies[i].BinaryFile);
                                        Process.Start(si);
                                    }
                                    catch { }
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool MouseIsInsideRect(int i, Point MousePos)
        {
            if ((MousePos.X >= F1.EMOJIDOC.Emojies[i].Rect.left) & (MousePos.X <= F1.EMOJIDOC.Emojies[i].Rect.right))
            {
                if ((MousePos.Y >= F1.EMOJIDOC.Emojies[i].Rect.top) & (MousePos.Y <= F1.EMOJIDOC.Emojies[i].Rect.bottom))
                {
                    return true;
                }
            }
            return false;
        }

        // To mouse event work
        void gmh_TheMouseMoved()
        {
            // Handlers
            MouseEventArgs e = new MouseEventArgs(CTouchPad.Buttons, 0, CTouchPad.MousePos.X, CTouchPad.MousePos.Y, 0);
            F1.RtbeEditor_MouseMove(F1, e);           
        }

        void gmh_TheMouseDown()
        {
            // Handlers
            MouseEventArgs e = new MouseEventArgs(CTouchPad.Buttons, 0, CTouchPad.MousePos.X, CTouchPad.MousePos.Y, 0);
            F1.RtbeEditor_MouseDown(F1, e);
        }

        void gmh_TheMouseUp()
        {
            // Handlers
            MouseEventArgs e = new MouseEventArgs(CTouchPad.Buttons, 0, CTouchPad.MousePos.X, CTouchPad.MousePos.Y, 0);
            F1.RtbeEditor_MouseUp(F1, e);
        }

        private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ImageIndex = GetEMOJIImagePosition(CEMOJISelected.MousePos);
            if (ImageIndex != -1)
            {
                CIndexes.PropertiesEMOJIIndex = ImageIndex;
                PropertiesShow(F1);
            }
        }

        public int GetEMOJIImageIndex()
        {
            Control c = F1.GetChildAtPoint(CTouchPad.MousePos);
            if (c != null)
            {
                int CharIndex = F1.RtbeEditor.rtb.GetCharIndexFromPosition(CTouchPad.MousePos);
                if (F1.EMOJIDOC != null)
                {
                    for (int i = 0; i <= F1.EMOJIDOC.EMOJIesCount; i++)
                    {
                        if (F1.EMOJIDOC.Emojies[i].CharIndexOfPicture == CharIndex)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        public int GetEMOJIImagePosition(Point MousePos)
        {
            Point p = CEMOJISelected.MousePos;
            if (F1.EMOJIDOC != null)
            {
                for (int i = 0; i <= F1.EMOJIDOC.EMOJIesCount; i++)
                {
                    if (MouseIsInsideRect(i, p))
                    {
                        return i;
                    }
                }
            }
            return - 1;
        }

        public void PropertiesShow(object o)
        {
            if (Properties == null)
            {
                Properties = new frmMain((Form1)o);
                Properties.Show((Form1)o);
            }
            Properties.Visible = true;
            Properties.BringToFront();
        }

        private void RtbeEditor_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void RtbeEditor_MouseUp(object sender, MouseEventArgs e)
        {
            CEMOJISelected.MousePos = e.Location;
        }
    }

    public class Macro
    {
        public static short MAKEWORD(byte a, byte b)
        {
            return ((short)(((byte)(a & 0xff)) | ((short)((byte)(b & 0xff))) << 8));
        }

        public static byte LOBYTE(short a)
        {
            return ((byte)(a & 0xff));
        }

        public static byte HIBYTE(short a)
        {
            return ((byte)(a >> 8));
        }

        public static int MAKELONG(short a, short b)
        {
            return (((int)(a & 0xffff)) | (((int)(b & 0xffff)) << 16));
        }

        public static short HIWORD(long a)
        {
            return ((short)(a >> 16));
        }

        public static short LOWORD(long a)
        {
            return ((short)(a & 0xffff));
        }
    }

    // To mouse event work

    public delegate void MouseMovedEvent();
    public delegate void MouseDownEvent();
    public delegate void MouseUpEvent();

    public class GlobalMouseHandler : IMessageFilter
    {
        private const int WM_MOUSEMOVE = 0x0200;

        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_RBUTTONDOWN = 0x0204;
        public const int WM_MBUTTONDOWN = 0x0207;

        public const int WM_LBUTTONUP = 0x0202;
        public const int WM_RBUTTONUP = 0x0205;
        public const int WM_MBUTTONUP = 0x0208;

        public const int WM_LBUTTONDBLCLK = 0x0203;
        public const int WM_RBUTTONDBLCLK = 0x0206;

        public event MouseMovedEvent TheMouseMoved;
        public event MouseDownEvent TheMouseDown;
        public event MouseUpEvent TheMouseUp;

        #region IMessageFilter Members

        public bool PreFilterMessage(ref Message m)
        {
            // Check if RtbEditor Mouse event
            IntPtr wnd = F1.RtbeEditor.rtb.Handle;
            if (m.HWnd == wnd)
            {
                // Mouse            
                CTouchPad.X = Macro.LOWORD((long)m.LParam);
                CTouchPad.Y = Macro.HIWORD((long)m.LParam);
                CTouchPad.MousePos = new Point((int)CTouchPad.X, (int)CTouchPad.Y);

                MouseButtons button = MouseButtons.None;
                uint clickCount = 0;

                switch ((long)m.WParam)
                {
                    case WM_LBUTTONDOWN:
                        button = MouseButtons.Left;
                        clickCount = 1;
                        break;
                    case WM_LBUTTONUP:
                        button = MouseButtons.Left;
                        clickCount = 2;
                        break;
                    case WM_LBUTTONDBLCLK:
                        button = MouseButtons.Left;
                        clickCount = 3;
                        break;
                    case WM_RBUTTONDOWN:
                        button = MouseButtons.Right;
                        clickCount = 4;
                        break;
                    case WM_RBUTTONUP:
                        button = MouseButtons.Right;
                        clickCount = 5;
                        break;
                    case WM_RBUTTONDBLCLK:
                        button = MouseButtons.Right;
                        clickCount = 6;
                        break;
                }
                CTouchPad.Buttons = button;
                CTouchPad.ClickCount = clickCount;
                if (m.Msg == WM_MOUSEMOVE)
                {
                    if (TheMouseMoved != null)
                    {
                        TheMouseMoved();
                    }
                }
                else if ((m.Msg == WM_LBUTTONDOWN) | (m.Msg == WM_RBUTTONDOWN) | (m.Msg == WM_MBUTTONDOWN))
                {
                    if (TheMouseDown != null)
                    {
                        TheMouseDown();
                    }
                }
                else if ((m.Msg == WM_LBUTTONUP) | (m.Msg == WM_RBUTTONUP) | (m.Msg == WM_MBUTTONUP))
                {
                    if (TheMouseUp != null)
                    {
                        TheMouseUp();
                    }
                }
            }
            // Always allow message to continue to the next filter control
            return false;
        }

        #endregion
    }
}
