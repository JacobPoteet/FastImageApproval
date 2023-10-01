namespace FIA_Project
{
    public partial class Form1 : Form
    {
        //create a variable to hold the base folder file paths
        private string[] baseFiles;
        //create an int to store the file index
        private int fileIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        #region Button and Text Box Events
        private void Button_Load_Click(object sender, EventArgs e)
        {
            if (ValidateFolders() == true)
            {
                //call StoreBaseFiles()
                StoreBaseFiles();
                //call DisplayFile() with the first file in baseFiles
                DisplayFile(baseFiles[0]);

                //reset the file index
                fileIndex = 0;
            }
        }

        private void Button_SetBaseFolder_Click(object sender, EventArgs e)
        {
            //set Text_BaseFolder.Text to the path returned by OpenFolderBrowserDialog()
            Text_BaseFolder.Text = OpenFolderBrowserDialog();
        }

        private void Button_SetApproveFolder_Click_1(object sender, EventArgs e)
        {
            //set Text_BaseFolder.Text to the path returned by OpenFolderBrowserDialog()
            Text_ApproveFolder.Text = OpenFolderBrowserDialog();
        }

        private void Button_Approve_Click(object sender, EventArgs e)
        {
            // call CopyFile() with the file in baseFiles at the file index
            CopyFile(baseFiles[fileIndex]);
            //call NextFile()
            NextFile();

        }

        private void Button_Reject_Click(object sender, EventArgs e)
        {
            //call NextFile()
            NextFile();

        }
        #endregion


        #region Helper Functions
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

        //write a function to copy a file from the base folder to the approve folder
        private void CopyFile(string file)
        {
            //create a string to hold the destination file path
            string destination = "";
            //create a string to hold the file name
            string fileName = Path.GetFileName(file);
            //create a string to hold the destination file path
            destination = Path.Combine(Text_ApproveFolder.Text, fileName);
            //copy the file to the destination using File.Copy()
            File.Copy(file, destination);
        }

        //write a function to increase the index and display the next file
        private void NextFile()
        {
            //check if baseFiles is null
            if (baseFiles == null)
            {
                //if it is, return
                return;
            }
            //increase the file index
            fileIndex++;
            //if the file index is greater than the length of base files
            if (fileIndex > baseFiles.Length - 1)
            {
                //set the file index to 0
                fileIndex = 0;
            }
            //call DisplayFile() with the file at the file index
            DisplayFile(baseFiles[fileIndex]);
        }
        #endregion

    }
}