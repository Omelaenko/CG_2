using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2 {
    public partial class Form1 : Form {
        
        Image image;
        Image image2;
        int cnt_images = 0;
        Bitmap res_bitmap;
        public Form1() {
            InitializeComponent();
            openFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
        }

        static double[][,] GetRgbChannelsFromImage(Image sourceImage) {
            Bitmap source = new Bitmap(sourceImage);
            double[][,] result = new double[3][,];
            result[0] = new double[source.Width, source.Height];
            result[1] = new double[source.Width, source.Height];
            result[2] = new double[source.Width, source.Height];
            for (int i = 0; i < source.Width; i++) {
                for (int j = 0; j < source.Height; j++) {
                    Color color = source.GetPixel(i, j);
                    //result[0].SetPixel(i, j, Color.FromArgb(color.A, color.R, 0, 0));
                    //result[1].SetPixel(i, j, Color.FromArgb(color.A, 0, color.G, 0));
                    //result[2].SetPixel(i, j, Color.FromArgb(color.A, 0, 0, color.B));
                    result[0][i, j] = (color.R / 255.0) * (235 / 255.0);
                    result[1][i, j] = (color.G / 255.0) * (235 / 255.0);
                    result[2][i, j] = (color.B / 255.0) * (235 / 255.0);
                }
            }
            return result;
        }

        static double[][,] GetLmsChannels(Image source) {
            double[][,] result = new double[3][,];
            result[0] = new double[source.Width, source.Height];
            result[1] = new double[source.Width, source.Height];
            result[2] = new double[source.Width, source.Height];
            double[][,] rgb_channels = GetRgbChannelsFromImage(source);
            for (int i = 0; i < source.Width; i++) {
                for (int j = 0; j < source.Height; j++) {
                    result[0][i, j] = 0.3811 * rgb_channels[0][i, j] + 0.5783 * rgb_channels[1][i, j] + 0.0402 * rgb_channels[2][i, j];
                    result[1][i, j] = 0.1967 * rgb_channels[0][i, j] + 0.7244 * rgb_channels[1][i, j] + 0.0782 * rgb_channels[2][i, j];
                    result[2][i, j] = 0.0241 * rgb_channels[0][i, j] + 0.1288 * rgb_channels[1][i, j] + 0.8444 * rgb_channels[2][i, j];
                }
            }
            return result;
        }

        static double[][,] GetLabChannels(Image source) {
            double[][,] result = new double[3][,];
            result[0] = new double[source.Width, source.Height];
            result[1] = new double[source.Width, source.Height];
            result[2] = new double[source.Width, source.Height];
            double[][,] lms_channels = GetLmsChannels(source);
            for (int i = 0; i < source.Width; i++) {
                for (int j = 0; j < source.Height; j++) {
                    lms_channels[0][i, j] = Math.Log10(Math.Max(lms_channels[0][i, j], 0.01176));
                    lms_channels[1][i, j] = Math.Log10(Math.Max(lms_channels[1][i, j], 0.01176));
                    lms_channels[2][i, j] = Math.Log10(Math.Max(lms_channels[2][i, j], 0.01176));
                    result[0][i, j] = 0.5774 * lms_channels[0][i, j] + 0.5774 * lms_channels[1][i, j] + 0.5774 * lms_channels[2][i, j];
                    result[1][i, j] = 0.4082 * lms_channels[0][i, j] + 0.4082 * lms_channels[1][i, j] - 0.8164 * lms_channels[2][i, j];
                    result[2][i, j] = 0.7071 * lms_channels[0][i, j] - 0.7071 * lms_channels[1][i, j];
                    //0.5774	0.5774	0.5774
                    //0.4082  0.4082 - 0.8164
                    //0.7071 - 0.7071 0
                }
            }
            return result;
        }

        static double[][,] GetLmsChannelsFromLab(double[][,] lab, int w, int h) {
            double[][,] result = new double[3][,];
            result[0] = new double[w, h];
            result[1] = new double[w, h];
            result[2] = new double[w, h];
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < h; j++) {
                    //lab[0][i, j] = lab[0][i, j] * (255 / 235.0);
                    //lab[1][i, j] = lab[1][i, j] * (255 / 235.0);
                    //lab[2][i, j] = lab[2][i, j] * (255 / 235.0);
                    result[0][i, j] = Math.Pow(10, 0.5774 * lab[0][i, j] + 0.4082 * lab[1][i, j] + 0.7071 * lab[2][i, j]);
                    result[1][i, j] = Math.Pow(10, 0.5774 * lab[0][i, j] + 0.4082 * lab[1][i, j] - 0.7071 * lab[2][i, j]);
                    result[2][i, j] = Math.Pow(10, 0.5774 * lab[0][i, j] - 0.8164 * lab[1][i, j]);
                    //0.5774	0.4082	0.7071
                    //0.5774  0.4082 - 1.4142
                    //0.5774 - 0.4082 0
                }
            }
            return result;
        }

        static double[][,] GetRgbChannelsFromLab(double[][,] lab, int w, int h) {
            double[][,] result = new double[3][,];
            result[0] = new double[w, h];
            result[1] = new double[w, h];
            result[2] = new double[w, h];
            double[][,] lms = GetLmsChannelsFromLab(lab, w, h);
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < h; j++) {
                    result[0][i, j] = 4.4679 * lms[0][i, j] - 3.5873 * lms[1][i, j] + 0.1193 * lms[2][i, j];
                    result[1][i, j] = -1.2186 * lms[0][i, j] + 2.3809 * lms[1][i, j] - 0.1624 * lms[2][i, j];
                    result[2][i, j] = 0.0497 * lms[0][i, j] - 0.2439 * lms[1][i, j] + 1.2045 * lms[2][i, j];

                    result[0][i, j] = result[0][i, j] * 255 * (255 / 235.0);
                    result[1][i, j] = result[1][i, j] * 255 * (255 / 235.0);
                    result[2][i, j] = result[2][i, j] * 255 * (255 / 235.0);

                    //0.5774	0.4082	0.7071
                    //0.5774  0.4082 - 1.4142
                    //0.5774 - 0.4082 0
                }
            }
            return result;
        }

        static double[][,] RGB2HSL(double[][,] rgb, int w, int h) {
            double[][,] result = new double[3][,];
            result[0] = new double[w, h];
            result[1] = new double[w, h];
            result[2] = new double[w, h];
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < h; j++) {
                    double themin, themax, delta;
                    themin = Math.Min(rgb[0][i, j], Math.Min(rgb[1][i, j], rgb[2][i, j]));
                    themax = Math.Max(rgb[0][i, j], Math.Max(rgb[1][i, j], rgb[2][i, j]));
                    delta = themax - themin;
                    result[2][i, j] = (themin + themax) / 2;
                    result[1][i, j] = 0;
                    if (result[2][i, j] > 0 && result[2][i, j] < 1)
                        result[1][i, j] = delta / (result[2][i, j] < 0.5 ? (2 * result[2][i, j]) : (2 - 2 * result[2][i, j]));
                    result[0][i, j] = 0;
                    if (delta > 0) {
                        if (themax == rgb[0][i, j] && themax != rgb[1][i, j])
                            result[0][i, j] += (rgb[1][i, j] - rgb[2][i, j]) / delta;
                        if (themax == rgb[1][i, j] && themax != rgb[2][i, j])
                            result[0][i, j] += (2 + (rgb[2][i, j] - rgb[0][i, j]) / delta);
                        if (themax == rgb[2][i, j] && themax != rgb[0][i, j])
                            result[0][i, j] += (4 + (rgb[0][i, j] - rgb[1][i, j]) / delta);
                        result[0][i, j] *= 60;
                    }

                }
            }
            return result;
        }

        static double[][,] HSL2RGB(double[][,] HSL, int w, int h) {
            double[][,] result = new double[3][,];
            result[0] = new double[w, h];
            result[1] = new double[w, h];
            result[2] = new double[w, h];
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < h; j++) {
                    double[] sat = new double[3];
                    double[] ctmp = new double[3];
                    while (HSL[0][i, j] < 0)
                        HSL[0][i, j] += 360;
                    while (HSL[0][i, j] > 360)
                        HSL[0][i, j] -= 360;
                    if (HSL[0][i, j] < 120) {
                        sat[0] = (120 - HSL[0][i, j]) / 60.0;
                        sat[1] = HSL[0][i, j] / 60.0;
                        sat[2] = 0;
                    } else if (HSL[0][i, j] < 240) {
                        sat[0] = 0;
                        sat[1] = (240 - HSL[0][i, j]) / 60.0;
                        sat[2] = (HSL[0][i, j] - 120) / 60.0;
                    } else {
                        sat[0] = (HSL[0][i, j] - 240) / 60.0;
                        sat[1] = 0;
                        sat[2] = (360 - HSL[0][i, j]) / 60.0;
                    }
                    sat[0] = Math.Min(sat[0], 1);
                    sat[1] = Math.Min(sat[1], 1);
                    sat[2] = Math.Min(sat[2], 1);
                    ctmp[0] = 2 * HSL[1][i, j] * sat[0] + (1 - HSL[1][i, j]);
                    ctmp[1] = 2 * HSL[1][i, j] * sat[1] + (1 - HSL[1][i, j]);
                    ctmp[2] = 2 * HSL[1][i, j] * sat[2] + (1 - HSL[1][i, j]);
                    if (HSL[2][i, j] < 0.5) {
                        result[0][i, j] = HSL[2][i, j] * ctmp[0] * 255 * (255 / 235.0);
                        result[1][i, j] = HSL[2][i, j] * ctmp[1] * 255 * (255 / 235.0);
                        result[2][i, j] = HSL[2][i, j] * ctmp[2] * 255 * (255 / 235.0);
                    } else {
                        result[0][i, j] = ( (1 - HSL[2][i, j]) * ctmp[0] + 2 * HSL[2][i, j] - 1 ) * 255 * (255 / 235.0);
                        result[1][i, j] = ((1 - HSL[2][i, j]) * ctmp[1] + 2 * HSL[2][i, j] - 1 ) * 255 * (255 / 235.0);
                        result[2][i, j] = ((1 - HSL[2][i, j]) * ctmp[2] + 2 * HSL[2][i, j] - 1 ) * 255 * (255 / 235.0);
                    }
                }
            }
            return result;
        }

        static double[][,] RGB2HSV(double[][,] rgb, int w, int h) {
            double[][,] result = new double[3][,];
            result[0] = new double[w, h];
            result[1] = new double[w, h];
            result[2] = new double[w, h];
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < h; j++) {
                    double themin, themax, delta;
                    themin = Math.Min(rgb[0][i, j], Math.Min(rgb[1][i, j], rgb[2][i, j]));
                    themax = Math.Max(rgb[0][i, j], Math.Max(rgb[1][i, j], rgb[2][i, j]));
                    delta = themax - themin;
                    result[2][i, j] = themax;
                    result[1][i, j] = 0;
                    if (themax > 0)
                        result[1][i, j] = delta / themax;
                    result[0][i, j] = 0;
                    if (delta > 0) {
                        if (themax == rgb[0][i, j] && themax != rgb[1][i, j])
                            result[0][i, j] += (rgb[1][i, j] - rgb[2][i, j]) / delta;
                        if (themax == rgb[1][i, j] && themax != rgb[2][i, j])
                            result[0][i, j] += (2 + (rgb[2][i, j] - rgb[0][i, j]) / delta);
                        if (themax == rgb[2][i, j] && themax != rgb[0][i, j])
                            result[0][i, j] += (4 + (rgb[0][i, j] - rgb[1][i, j]) / delta);
                        result[0][i, j] *= 60;
                    }
                }
            }
            return result;
        }

        static double[][,] HSV2RGB(double [][,] HSV, int w, int h) {
            double[][,] result = new double[3][,];
            result[0] = new double[w, h];
            result[1] = new double[w, h];
            result[2] = new double[w, h];
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < h; j++) {
                    double[] sat = new double[3];
                    while (HSV[0][i, j] < 0)
                        HSV[0][i, j] += 360;
                    while (HSV[0][i, j] > 360)
                        HSV[0][i, j] -= 360;
                    if (HSV[0][i, j] < 120) {
                        sat[0] = (120 - HSV[0][i, j]) / 60.0;
                        sat[1] = HSV[0][i, j] / 60.0;
                        sat[2] = 0;
                    } else if (HSV[0][i, j] < 240) {
                        sat[0] = 0;
                        sat[1] = (240 - HSV[0][i, j]) / 60.0;
                        sat[2] = (HSV[0][i, j] - 120) / 60.0;
                    } else {
                        sat[0] = (HSV[0][i, j] - 240) / 60.0;
                        sat[1] = 0;
                        sat[2] = (360 - HSV[0][i, j]) / 60.0;
                    }
                    sat[0] = Math.Min(sat[0], 1);
                    sat[1] = Math.Min(sat[1], 1);
                    sat[2] = Math.Min(sat[2], 1);
                    result[0][i, j] = (1 - HSV[1][i, j] + HSV[1][i, j] * sat[0]) * HSV[2][i, j] * 255 * (255 / 235);
                    result[1][i, j] = (1 - HSV[1][i, j] + HSV[1][i, j] * sat[1]) * HSV[2][i, j] * 255 * (255 / 235);
                    result[2][i, j] = (1 - HSV[1][i, j] + HSV[1][i, j] * sat[2]) * HSV[2][i, j] * 255 * (255 / 235);
                }
            }
            return result;
        }

        static double[][,] RGB2YIQ(double[][,] RGB, int w, int h)
        {
            double[][,] result = new double[3][,];
            result[0] = new double[w, h];
            result[1] = new double[w, h];
            result[2] = new double[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    result[0][i, j] = 0.299 * RGB[0][i, j] + 0.578 * RGB[1][i, j] + 0.114 * RGB[2][i, j];
                    result[1][i, j] = 0.596 * RGB[0][i, j] - 0.275 * RGB[1][i, j] - 0.321 * RGB[2][i, j];
                    result[2][i, j] = 0.212 * RGB[0][i, j] - 0.528 * RGB[1][i, j] + 0.311 * RGB[2][i, j];
                }
            }
            return result;
        }

        static double[][,] YIQ2RGB(double[][,] YIQ, int w, int h)
        {
            double[][,] result = new double[3][,];
            result[0] = new double[w, h];
            result[1] = new double[w, h];
            result[2] = new double[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    result[0][i, j] = YIQ[0][i, j] + 0.956 * YIQ[1][i, j] + 0.621 * YIQ[2][i, j];
                    result[1][i, j] = YIQ[0][i, j] - 0.272 * YIQ[1][i, j] - 0.647 * YIQ[2][i, j];
                    result[2][i, j] = YIQ[0][i, j] - 1.106 * YIQ[1][i, j] + 1.703 * YIQ[2][i, j];
                }
            }
            return result;
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            try {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                    image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = image;
                    refreshGistogram(image, "source");
                    cnt_images += 1;
                    if (cnt_images > 1) {
                        applyBtn.Enabled = true;
                    }
                }
            } catch {
                MessageBox.Show("Error open file\nPlease, try another file", "Error", MessageBoxButtons.OK);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            try {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                    image2 = Image.FromFile(openFileDialog1.FileName);
                    pictureBox2.Image = image2;
                    refreshGistogram(image2, "target");
                    cnt_images += 1;
                    if(cnt_images > 1) {
                        applyBtn.Enabled = true;
                    }
                }
            } catch {
                MessageBox.Show("Error open file\nPlease, try another file", "Error", MessageBoxButtons.OK);
            }
        }

        private void applyBtn_Click(object sender, EventArgs e) {
            try {
                double[][,] res = new double[3][,];
                double[][,] res2 = new double[3][,];
                if (radioLab.Checked) {
                    res = GetLabChannels(image);
                    res2 = GetLabChannels(image2);
                }
                if (radioHSL.Checked) {
                    res = RGB2HSL(GetRgbChannelsFromImage(image), image.Width, image.Height);
                    res2 = RGB2HSL(GetRgbChannelsFromImage(image2), image2.Width, image2.Height);
                }
                if (radioHSV.Checked) {
                    res = RGB2HSV(GetRgbChannelsFromImage(image), image.Width, image.Height);
                    res2 = RGB2HSV(GetRgbChannelsFromImage(image2), image2.Width, image2.Height);
                }
                if (radioYIQ.Checked)
                {
                    res = RGB2YIQ(GetRgbChannelsFromImage(image), image.Width, image.Height);
                    res2 = RGB2YIQ(GetRgbChannelsFromImage(image2), image2.Width, image2.Height);
                }

                double[] e_s = new double[3] { 0, 0, 0 };
                for (int i = 0; i < image.Width; i++) {
                    for (int j = 0; j < image.Height; j++) {
                        e_s[0] += res[0][i, j];
                        e_s[1] += res[1][i, j];
                        e_s[2] += res[2][i, j];
                    }
                }
                e_s[0] /= (image.Height * image.Width);
                e_s[1] /= (image.Height * image.Width);
                e_s[2] /= (image.Height * image.Width);

                double[] d_s = new double[3] { 0, 0, 0 };
                for (int i = 0; i < image.Width; i++) {
                    for (int j = 0; j < image.Height; j++) {
                        d_s[0] += Math.Pow((res[0][i, j] - e_s[0]), 2);
                        d_s[1] += Math.Pow((res[1][i, j] - e_s[1]), 2);
                        d_s[2] += Math.Pow((res[2][i, j] - e_s[2]), 2);
                    }
                }
                d_s[0] = Math.Sqrt(d_s[0] / (image.Height * image.Width));
                d_s[1] = Math.Sqrt(d_s[1] / (image.Height * image.Width));
                d_s[2] = Math.Sqrt(d_s[2] / (image.Height * image.Width));

                double[] e_t = new double[3] { 0, 0, 0 };
                for (int i = 0; i < image2.Width; i++) {
                    for (int j = 0; j < image2.Height; j++) {
                        e_t[0] += res2[0][i, j];
                        e_t[1] += res2[1][i, j];
                        e_t[2] += res2[2][i, j];
                    }
                }
                e_t[0] /= (image2.Height * image2.Width);
                e_t[1] /= (image2.Height * image2.Width);
                e_t[2] /= (image2.Height * image2.Width);

                double[] d_t = new double[3] { 0, 0, 0 };
                for (int i = 0; i < image2.Width; i++) {
                    for (int j = 0; j < image2.Height; j++) {
                        d_t[0] += Math.Pow((res2[0][i, j] - e_t[0]), 2);
                        d_t[1] += Math.Pow((res2[1][i, j] - e_t[1]), 2);
                        d_t[2] += Math.Pow((res2[2][i, j] - e_t[2]), 2);
                    }
                }
                d_t[0] = Math.Sqrt(d_t[0] / (image2.Height * image2.Width));
                d_t[1] = Math.Sqrt(d_t[1] / (image2.Height * image2.Width));
                d_t[2] = Math.Sqrt(d_t[2] / (image2.Height * image2.Width));

                res = new double[3][,];
                res[0] = new double[image2.Width, image2.Height];
                res[1] = new double[image2.Width, image2.Height];
                res[2] = new double[image2.Width, image2.Height];

                for (int i = 0; i < image2.Width; i++) {
                    for (int j = 0; j < image2.Height; j++) {
                        res[0][i, j] = e_s[0] + (res2[0][i, j] - e_t[0]) * (d_s[0] / d_t[0]);
                        res[1][i, j] = e_s[1] + (res2[1][i, j] - e_t[1]) * (d_s[1] / d_t[1]);
                        res[2][i, j] = e_s[2] + (res2[2][i, j] - e_t[2]) * (d_s[2] / d_t[2]);
                    }
                }

                if (radioLab.Checked) {
                    res = GetRgbChannelsFromLab(res, image2.Width, image2.Height);
                }
                if (radioHSL.Checked) {
                    res = HSL2RGB(res, image2.Width, image2.Height);
                }
                if (radioHSV.Checked) {
                    res = HSV2RGB(res, image2.Width, image2.Height);
                }
                if (radioYIQ.Checked) {
                    res = YIQ2RGB(res, image2.Width, image2.Height);
                }

                res_bitmap = new Bitmap(image2.Width, image2.Height);
                Bitmap image2_btm = new Bitmap(image2);
                for (int i = 0; i < image2.Width; i++) {
                    for (int j = 0; j < image2.Height; j++) {
                        Color color = image2_btm.GetPixel(i, j);
                        if (!checkBoxR.Checked) {
                            res[0][i, j] = color.R;
                        }
                        if (!checkBoxG.Checked) {
                            res[1][i, j] = color.G;
                        }
                        if (!checkBoxB.Checked) {
                            res[2][i, j] = color.B;
                        }
                        res_bitmap.SetPixel(i, j, Color.FromArgb(color.A, (int)Math.Min(255, Math.Max(res[0][i, j], 0)), (int)Math.Min(255, Math.Max(res[1][i, j], 0)), (int)Math.Min(255, Math.Max(res[2][i, j], 0))));
                    }
                }
                pictureBoxOut.Image = res_bitmap;
                saveBtn.Enabled = true;
                refreshGistogram(res_bitmap, "res");
            } catch {
                MessageBox.Show("Error processing", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            try {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                    res_bitmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            } catch {
                MessageBox.Show("Error save file", "Error", MessageBoxButtons.OK);
            }
        }

        private void checkBoxR_CheckedChanged(object sender, EventArgs e) {

        }

        private void checkBoxG_CheckedChanged(object sender, EventArgs e) {

        }

        private void checkBoxB_CheckedChanged(object sender, EventArgs e) {

        }

        private void refreshGistogram(Image img, string gist) {
            if (img == null)
                return;
            Bitmap btm = new Bitmap(img);
            List<int> red = new List<int>();
            List<int> green = new List<int>();
            List<int> blue = new List<int>();
            double mx = 0;
            for (int i = 0; i < 256; i++) {
                red.Add(0);
                green.Add(0);
                blue.Add(0);
            }
            for (int i = 0; i < btm.Width; i++) {
                for (int j = 0; j < btm.Height; j++) {
                    Color c = btm.GetPixel(i, j);
                    red[c.R]++;
                    green[c.G]++;
                    blue[c.B]++;
                    mx = Math.Max(Math.Max(red[c.R], Math.Max(green[c.G], blue[c.B])), mx);
                }
            }
            //int redscalar = red.Max() / 255 + 1;
            //int greenscalar = green.Max() / 255 + 1;
            //int bluescalar = blue.Max() / 255 + 1;
            Bitmap GistMap = new Bitmap(255, 163);
            double scalar = GistMap.Height / mx;
            //Console.WriteLine(red.Max());
            //Console.WriteLine(green.Max());
            //Console.WriteLine(blue.Max());
            
            Graphics g = Graphics.FromImage(GistMap);
            for(int i = 0;i < 256; ++i) {
                if ((gist == "source" && FilterGistogramSourceRed.Checked) || (gist == "target" && FilterGistogramTargetRed.Checked) || (gist == "res" && FilterGistogramResRed.Checked)) {
                    g.DrawLine(new Pen(Brushes.Red), i, GistMap.Height, i, GistMap.Height - (int)(red[i] * scalar));
                }
                if ((gist == "source" && FilterGistogramSourceGreen.Checked) || (gist == "target" && FilterGistogramTargetGreen.Checked) || (gist == "res" && FilterGistogramResGreen.Checked)) {
                    g.DrawLine(new Pen(Brushes.Green), i, GistMap.Height, i, GistMap.Height - (int)(green[i] * scalar));
                }
                if ((gist == "source" && FilterGistogramSourceBlue.Checked) || (gist == "target" && FilterGistogramTargetBlue.Checked) || (gist == "res" && FilterGistogramResBlue.Checked)) {
                    g.DrawLine(new Pen(Brushes.Blue), i, GistMap.Height, i, GistMap.Height - (int)(blue[i] * scalar));
                }
            }

            if(gist == "source") {
                GistogramSource.Image = GistMap;
            }
            if (gist == "target") {
                GistogramTarget.Image = GistMap;
            }
            if (gist == "res") {
                GistogramRes.Image = GistMap;
            }
        }

        private void FilterGistogramSourceRed_CheckedChanged(object sender, EventArgs e) {
            if (image != null) {
                refreshGistogram(image, "source");
            }
        }

        private void FilterGistogramSourceGreen_CheckedChanged(object sender, EventArgs e) {
            if (image != null) {
                refreshGistogram(image, "source");
            }
        }

        private void FilterGistogramSourceBlue_CheckedChanged(object sender, EventArgs e) {
            if (image != null) {
                refreshGistogram(image, "source");
            }
        }

        private void FilterGistogramTargetRed_CheckedChanged(object sender, EventArgs e) {
            if (image2 != null) {
                refreshGistogram(image2, "target");
            }
        }

        private void FilterGistogramTargetGreen_CheckedChanged(object sender, EventArgs e) {
            if (image2 != null) {
                refreshGistogram(image2, "target");
            }
        }

        private void FilterGistogramTargetBlue_CheckedChanged(object sender, EventArgs e) {
            if (image2 != null) {
                refreshGistogram(image2, "target");
            }
        }

        private void FilterGistogramResRed_CheckedChanged(object sender, EventArgs e) {
            if(res_bitmap != null) { 
                refreshGistogram(res_bitmap, "res");
            }
        }

        private void FilterGistogramResGreen_CheckedChanged(object sender, EventArgs e) {
            if (res_bitmap != null) {
                refreshGistogram(res_bitmap, "res");
            }
        }

        private void FilterGistogramResBlue_CheckedChanged(object sender, EventArgs e) {
            if (res_bitmap != null) {
                refreshGistogram(res_bitmap, "res");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
