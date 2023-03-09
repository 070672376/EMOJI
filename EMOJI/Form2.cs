using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Manina.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static EMOJI.Form1;

namespace EMOJI
{
    public partial class Form2 : Form
    {
        public static Form1 F1;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            F1 = f1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.F2 = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (F1.EMOJIDOC == null)
            {
                F1.EMOJIDOC = new Form1.CEMOJIDOC();
            }
            if (F1.EMOJIDOC.EMOJIesCount < Form1.MAX_EMOJIES)
            {
                F1.EMOJIDOC.EMOJIesCount++;
            }
            Image img = Image.FromFile(ImageListView1.SelectedItems[0].FileName);
            Point p = F1.RtbeEditor.rtb.GetPositionFromCharIndex(F1.RtbeEditor.rtb.SelectionStart);
            F1.EMOJIDOC.Emojies[F1.EMOJIDOC.EMOJIesCount] = new Form1.CEMOJI();
            F1.EMOJIDOC.Emojies[F1.EMOJIDOC.EMOJIesCount].EMOJIFile = ImageListView1.SelectedItems[0].FileName;
            F1.EMOJIDOC.Emojies[F1.EMOJIDOC.EMOJIesCount].Rect = new Form1.CRect();
            F1.EMOJIDOC.Emojies[F1.EMOJIDOC.EMOJIesCount].Rect.left = p.X;
            F1.EMOJIDOC.Emojies[F1.EMOJIDOC.EMOJIesCount].Rect.top = p.Y;
            F1.EMOJIDOC.Emojies[F1.EMOJIDOC.EMOJIesCount].Rect.right = (p.X + img.Width);
            F1.EMOJIDOC.Emojies[F1.EMOJIDOC.EMOJIesCount].Rect.bottom = (p.Y + img.Height);
            F1.EMOJIDOC.Emojies[F1.EMOJIDOC.EMOJIesCount].CharIndexOfPicture = F1.RtbeEditor.rtb.SelectionStart;
            F1.RtbeEditor.InsertPicture(img);
            img.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(Form1.ThisAppRootDir + "Resources\\EMOJI\\emoji");
            PopulateListView(di);
        }

        private void PopulateListView(DirectoryInfo path)
        {
            ImageListView1.Items.Clear();
            ImageListView1.SuspendLayout();
            Random rnd = new Random();
            FileInfo[] files = new FileInfo[0];
            try
            {
                files = path.GetFiles("*.*");
            }
            catch
            {
                files = new FileInfo[0];
            }
            foreach (FileInfo p in files)
            {
                if (p.Name.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".ico", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".cur", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".emf", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".wmf", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".tif", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".tiff", StringComparison.OrdinalIgnoreCase) ||
                    p.Name.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                {
                    ImageListViewItem item = new ImageListViewItem(p.FullName);
                    item.SubItems.Add("random", rnd.Next(0, 999).ToString("000"));
                    ImageListView1.Items.Add(item);
                }
            }
            ImageListView1.ResumeLayout();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = (Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if ((fbd.SelectedPath != "") & (fbd.SelectedPath != null))
                {
                    DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                    PopulateListView(di);
                }
            }
        }
    }
}
