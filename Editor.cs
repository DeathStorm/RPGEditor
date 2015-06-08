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

        private List<int> allScenes = new List<int>();
        private Scene curScene;

        private struct Scene
        {
            public String title;
            public String story;
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
            allScenes.Add(nextSceneNumber);
            RefreshDropDowns();
            cbStoryID.SelectedValue = nextSceneNumber;
            nextSceneNumber++;

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            curScene.story = tbStory.Text;
            curScene.title = tbStoryTitle.Text;

        }


        private void RefreshDropDowns()
        {
            cbB1GoToScreen.Items.Clear();
            cbStoryID.Items.Clear();


            foreach (int sceneInt in allScenes)
            { 
                cbB1GoToScreen.Items.Add(sceneInt);
                cbStoryID.Items.Add(sceneInt);
            }
            
            
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            allScenes.Add(0);
            allScenes.Add(99999);
        }

    }
}
