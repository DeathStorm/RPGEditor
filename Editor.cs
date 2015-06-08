using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGEditor
{
    public partial class Editor : Form
    {


        private Dictionary<int, Scene> scenes = new Dictionary<int, Scene>();
        private int nextSceneNumber = 0;

        private struct Scene
        {
            public String title;
            public String Story;
        }




        public Editor()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            scenes.Add(nextSceneNumber, new Scene());
            nextSceneNumber++;

        }
    }
}
