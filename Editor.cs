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
        private List<String> sceneDialogueList = new List<String>();
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
            sceneDialogueList.Add(nextSceneNumber.ToString());
            RefreshDropDowns();
            //cbStoryID.SelectedText = nextSceneNumber.ToString();
            //cbStoryID.SelectedValue = nextSceneNumber.ToString();
            cbStoryID.SelectedItem = nextSceneNumber.ToString();
            nextSceneNumber++;

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            curScene.story = tbStory.Text;
            curScene.title = tbStoryTitle.Text;

        }


        private void RefreshDropDowns()
        {

            cbStoryID.DataSource = null; 
            cbStoryID.DataSource = sceneDialogueList;

            cbB1GoToScreen.DataSource = null;
            cbB1GoToScreen.DataSource = sceneDialogueList;

            cbB2GoToScreen.DataSource = null;
            cbB2GoToScreen.DataSource = sceneDialogueList;
            
            cbB3GoToScreen.DataSource = null;
            cbB3GoToScreen.DataSource = sceneDialogueList;
            
            cbB4GoToScreen.DataSource = null;
            cbB4GoToScreen.DataSource = sceneDialogueList;

            cbB5GoToScreen.DataSource = null;
            cbB5GoToScreen.DataSource = sceneDialogueList;

            cbB6GoToScreen.DataSource = null;
            cbB6GoToScreen.DataSource = sceneDialogueList;
            return;

            cbB1GoToScreen.Items.Clear();
            cbB2GoToScreen.Items.Clear();
            cbB3GoToScreen.Items.Clear();
            cbB4GoToScreen.Items.Clear();
            cbB5GoToScreen.Items.Clear();
            cbB6GoToScreen.Items.Clear();
            cbStoryID.Items.Clear();


            foreach (String sceneString in sceneDialogueList)
            {
                cbB1GoToScreen.Items.Add(sceneString);
                cbB2GoToScreen.Items.Add(sceneString);
                cbB3GoToScreen.Items.Add(sceneString);  
                cbB4GoToScreen.Items.Add(sceneString);
                cbB5GoToScreen.Items.Add(sceneString);
                cbB6GoToScreen.Items.Add(sceneString);
                cbStoryID.Items.Add(sceneString);
            }
            
            
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            sceneDialogueList.Add("START");
            //sceneDialogueList.Add("END");

            cbStoryID.DataSource = sceneDialogueList;
            cbB1GoToScreen.DataSource = sceneDialogueList;
            cbB2GoToScreen.DataSource = sceneDialogueList;
            cbB3GoToScreen.DataSource = sceneDialogueList;
            cbB4GoToScreen.DataSource = sceneDialogueList;
            cbB5GoToScreen.DataSource = sceneDialogueList;
            cbB6GoToScreen.DataSource = sceneDialogueList;

        }

    }
}
