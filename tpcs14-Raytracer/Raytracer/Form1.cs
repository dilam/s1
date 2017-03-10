using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Globalization;

using Raytracer;
using Raytracer.shapes;
using Raytracer.lights;
using Raytracer.utils;

namespace Raytracer
{
    public partial class Form1 : Form
    {
        private Raytracer       raytracer_;
        private List<Shape>     nodes_;
        private List<Light>     lights_;
        private NormalizedColor ambient_;
        private Camera          camera_;
        private utils.Screen    screen_;

        public Form1()
        {
            InitializeComponent();

            raytracer_ = Raytracer.Instance;
            nodes_ = new List<Shape>();
            lights_ = new List<Light>();
            ambient_ = null;

            camera_ = new Camera(new Vector3(0, 0, 0), new Vector3(1, 0, 0), new Vector3(0, 1, 0));
            screen_ = new utils.Screen(500, 500);

            progressBar.Maximum = Convert.ToInt32(textBox2.Text);
        }

        /// <summary>
        /// Opens a dialog to load an XML scene file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.InitialDirectory + openFileDialog.FileName;
                load_scene(path);
            }
        }

        /// <summary>
        /// Renders the loaded scene into a new image of size width * height
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void renderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reinit the progress bar
            progressBar.Value = 0;

            if (screen_.Width == 0 || screen_.Height == 0)
            {
                MessageBox.Show("One of the image composant is null.");
                return;
            }
            else if (nodes_.Count == 0)
            {
                MessageBox.Show("There is no loaded scene or the scene is empty.");
                return;
            }
            else if (ambient_ == null)
            {
                MessageBox.Show("Impossible to render the scene : no ambient light found.");
                return;
            }

            // Reload the screen center
            screen_.set_center(camera_);

            // Clear the previous picture
            pictureBox.Image = null;
            pictureBox.Image = raytracer_.render_image(camera_, screen_, nodes_, lights_, ambient_, progressBar);
        }

        /// <summary>
        /// Saves the rendered image to the asset folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog.OpenFile();
                raytracer_.Img.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                fs.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                screen_.Width = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Please provide number only.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                screen_.Height = Convert.ToInt32(textBox2.Text);
                progressBar.Maximum = screen_.Height;
            }
            catch
            {
                MessageBox.Show("Please provide number only");
            }
        }

        /// <summary>
        /// Loads the XML file located at "path" inside the node lists
        /// </summary>
        /// <param name="path">The path where the XML file is located</param>
        private void load_scene(string path)
        {
            // Clean previous loading
            nodes_.Clear();
            lights_.Clear();
            ambient_ = new NormalizedColor();

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList nl = doc.SelectNodes("root");
            XmlNode root = nl[0];

            try
            {
                foreach (XmlNode node in root.ChildNodes)
                {
                    if (node.LocalName.Equals("camera"))
                        camera_ = Parser.parse_camera(node);
                    else if (node.LocalName.Equals("shape"))
                    {
                        switch (node.Attributes["id"].Value)
                        {
                            case "sphere":
                                nodes_.Add(Parser.parse_sphere(node));
                                break;
                            case "plane":
                                nodes_.Add(Parser.parse_plane(node));
                                break;
                            case "cube":
                                nodes_.Add(Parser.parse_cube(node));
                                break;
                            case "pyramid":
                                nodes_.Add(Parser.parse_pyramid(node));
                                break;
                            default:
                                throw new ParsingException("'<shape>' tag unknown id");
                        }
                    }
                    else if (node.LocalName.Equals("light"))
                    {
                        switch (node.Attributes["id"].Value)
                        {
                            case "ambient":
                                ambient_ = Parser.parse_ambient(node);
                                break;
                            case "directional":
                                lights_.Add(Parser.parse_directional(node));
                                break;
                            case "point":
                                lights_.Add(Parser.parse_point_light(node));
                                break;
                            case "spot":
                                lights_.Add(Parser.parse_spot_light(node));
                                break;
                            default:
                                throw new ParsingException("'<light>' tag unknown id");
                        }
                    }
                    else
                        throw new ParsingException("'<root>' has unknown tag '<" + node.LocalName + ">'");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
