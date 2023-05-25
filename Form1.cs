using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            boxpic.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int track = trackBar1.Value;


            switch (track)
            {
                case 0:
                    debuglbl.Text = "Has puesto 0";
                    boxpic.ImageLocation = "./homer1.jpg";
                    boxpic.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;

                case 1:
                    debuglbl.Text = "Has puesto 1";
                    boxpic.ImageLocation = "./homer2.jpg";
                    boxpic.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;

                case 2:
                    debuglbl.Text = "Has puesto 2";
                    boxpic.ImageLocation = "./homer3.jpg";
                    boxpic.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;

                case 3:
                    debuglbl.Text = "Has puesto 3";
                    boxpic.ImageLocation = "./homer4.jpg";
                    boxpic.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;

                case 4:
                    debuglbl.Text = "Has puesto 4";
                    boxpic.ImageLocation = "./homer5.jpg";
                    boxpic.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;

                case 5:
                    debuglbl.Text = "Has puesto 5";
                    boxpic.ImageLocation = "./homer6.jpg";
                    boxpic.SizeMode = PictureBoxSizeMode.CenterImage;

                    break;


            }
        }
    }
}