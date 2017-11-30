using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedianFiltering_Images
{

    public partial class FilteringForm : Form
    {
        private Program utils;
        private Bitmap source;
        private Stopwatch stopWatch;

        public FilteringForm()
        {
            InitializeComponent();

            utils = new Program();

            saveFileDialog.Filter = "Image File | *.bmp";
            saveFileDialog.DefaultExt = "bmp";


            stopWatch = new Stopwatch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog.FileName;
                source = new Bitmap(path);
                this.Size = new Size(source.Size.Width+10, source.Size.Height+60);
                pictureBox.Image = source;
                 
                stopWatch.Reset();
            }
        }

        private void OneThreadB_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            utils.MedianFilter(source, 3);
            pictureBox.Image = source;
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;


            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            timeL.Text = "Run time: " + elapsedTime;
           // stopWatch.Reset();
        }

        private void TwoThreadsB_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            Bitmap FirstPartImage = utils.CropImage(source, new Rectangle(new Point(0, 0), new Size(source.Width, source.Height / 2)));
            Console.WriteLine(source.Width);

//            FirstPartImage.Save(@"C:\Users\Juli\source\repos\MedianFiltering Images\MedianFiltering Images\source images\oto.bmp");
            Bitmap SecondPartImage = utils.CropImage(source, new Rectangle(new Point(0, source.Height / 2), new Size(source.Width, source.Height / 2)));
  //          SecondPartImage.Save(@"C:\Users\Juli\source\repos\MedianFiltering Images\MedianFiltering Images\source images\ddd.bmp");


            var task1 = new Task(() => utils.MedianFilter(FirstPartImage, 3));
            var task2 = new Task(() => utils.MedianFilter(SecondPartImage, 3));


            task1.Start();
            task2.Start();


            Task.WaitAll(task1, task2);

            Bitmap result = utils.MergeTwoImages(FirstPartImage, SecondPartImage);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;


            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            timeL.Text = "Run time: " + elapsedTime;
            pictureBox.Image = result;

        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                pictureBox.Image.Save(saveFileDialog.FileName);
        }
    }
}
