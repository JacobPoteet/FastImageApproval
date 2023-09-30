namespace FIA_Project
{
    public partial class Form1 : Form
    {
        //create a variable to hold the base folder file paths
        private string[] baseFiles;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            if (ValidateFolders() == true)
            {

            }
        }

        //write a function to get all the files in the base folder
        private string[] GetBaseFiles()
        {
            //return all the files in the base folder using Directory.GetFiles()
            return Directory.GetFiles(Text_BaseFolder.Text);
        }

        //write a function to store all the files in the base folder into a variable
        private void StoreBaseFiles()
        {
            //set the baseFiles variable to the return value of GetBaseFiles()
            baseFiles = GetBaseFiles();
        }

        //write a function to display a file in the image box
        private void DisplayFile(string file)
        {
            //set the image box image to the file
            ImageBox.Image = Image.FromFile(file);
            //set the file name text box text to the file name
            FileNameTextBox.Text = Path.GetFileName(file);
        }

        //write a function to validate the base and approve folders
        private bool ValidateFolders()
        {
            return (ValidatePath(Text_BaseFolder.Text) && ValidatePath(Text_ApproveFolder.Text));
        }

        //write a function to validate a windows file path
        private bool ValidatePath(string path)
        {
            //return true is path is valid using Path.IsPathRooted()
            return Path.IsPathRooted(path);
        }

        private void Button_SetBaseFolder_Click(object sender, EventArgs e)
        {
            //set Text_BaseFolder.Text to the path returned by OpenFolderBrowserDialog()
            Text_BaseFolder.Text = OpenFolderBrowserDialog();
        }

        private void Button_SetApproveFolder_Click(object sender, EventArgs e)
        {
            //set Text_BaseFolder.Text to the path returned by OpenFolderBrowserDialog()
            Text_ApproveFolder.Text = OpenFolderBrowserDialog();
        }

        //write a function that opens a folder browser dialog and returns the path
        private string OpenFolderBrowserDialog()
        {
            string selectedPath = "";
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = folderBrowserDialog.SelectedPath;
                }
            }
            return selectedPath;
        }

    }
}