namespace FIA_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button_Reject = new Button();
            Button_Approve = new Button();
            ImageBox = new PictureBox();
            FileNameTextBox = new TextBox();
            Text_BaseFolder = new TextBox();
            Text_ApproveFolder = new TextBox();
            Button_SetBaseFolder = new Button();
            Button_SetApproveFolder = new Button();
            Button_Load = new Button();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // Button_Reject
            // 
            Button_Reject.Anchor = AnchorStyles.Top;
            Button_Reject.Location = new Point(362, 469);
            Button_Reject.Name = "Button_Reject";
            Button_Reject.Size = new Size(100, 54);
            Button_Reject.TabIndex = 0;
            Button_Reject.Text = "Reject";
            Button_Reject.UseVisualStyleBackColor = true;
            Button_Reject.Click += Button_Reject_Click;
            // 
            // Button_Approve
            // 
            Button_Approve.Anchor = AnchorStyles.Top;
            Button_Approve.Location = new Point(548, 469);
            Button_Approve.Name = "Button_Approve";
            Button_Approve.Size = new Size(100, 54);
            Button_Approve.TabIndex = 1;
            Button_Approve.Text = "Approve";
            Button_Approve.UseVisualStyleBackColor = true;
            Button_Approve.Click += Button_Approve_Click;
            // 
            // ImageBox
            // 
            ImageBox.Anchor = AnchorStyles.Top;
            ImageBox.Location = new Point(362, 27);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(286, 402);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 2;
            ImageBox.TabStop = false;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Anchor = AnchorStyles.Top;
            FileNameTextBox.Location = new Point(375, 436);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.ReadOnly = true;
            FileNameTextBox.Size = new Size(264, 23);
            FileNameTextBox.TabIndex = 3;
            FileNameTextBox.Text = "FileText.png";
            FileNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Text_BaseFolder
            // 
            Text_BaseFolder.Anchor = AnchorStyles.Top;
            Text_BaseFolder.Location = new Point(410, 545);
            Text_BaseFolder.Name = "Text_BaseFolder";
            Text_BaseFolder.ReadOnly = true;
            Text_BaseFolder.Size = new Size(314, 23);
            Text_BaseFolder.TabIndex = 4;
            // 
            // Text_ApproveFolder
            // 
            Text_ApproveFolder.Anchor = AnchorStyles.Top;
            Text_ApproveFolder.Location = new Point(410, 574);
            Text_ApproveFolder.Name = "Text_ApproveFolder";
            Text_ApproveFolder.ReadOnly = true;
            Text_ApproveFolder.Size = new Size(314, 23);
            Text_ApproveFolder.TabIndex = 5;
            // 
            // Button_SetBaseFolder
            // 
            Button_SetBaseFolder.Anchor = AnchorStyles.Top;
            Button_SetBaseFolder.Location = new Point(283, 545);
            Button_SetBaseFolder.Name = "Button_SetBaseFolder";
            Button_SetBaseFolder.Size = new Size(121, 23);
            Button_SetBaseFolder.TabIndex = 6;
            Button_SetBaseFolder.Text = "Set Base Folder";
            Button_SetBaseFolder.UseVisualStyleBackColor = true;
            Button_SetBaseFolder.Click += Button_SetBaseFolder_Click;
            // 
            // Button_SetApproveFolder
            // 
            Button_SetApproveFolder.Anchor = AnchorStyles.Top;
            Button_SetApproveFolder.Location = new Point(283, 573);
            Button_SetApproveFolder.Name = "Button_SetApproveFolder";
            Button_SetApproveFolder.Size = new Size(121, 23);
            Button_SetApproveFolder.TabIndex = 7;
            Button_SetApproveFolder.Text = "Set Approve Folder";
            Button_SetApproveFolder.UseVisualStyleBackColor = true;
            Button_SetApproveFolder.Click += Button_SetApproveFolder_Click_1;
            // 
            // Button_Load
            // 
            Button_Load.Anchor = AnchorStyles.Top;
            Button_Load.Location = new Point(457, 615);
            Button_Load.Name = "Button_Load";
            Button_Load.Size = new Size(100, 22);
            Button_Load.TabIndex = 8;
            Button_Load.Text = "Load";
            Button_Load.UseVisualStyleBackColor = true;
            Button_Load.Click += Button_Load_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 672);
            Controls.Add(Button_Load);
            Controls.Add(Button_SetApproveFolder);
            Controls.Add(Button_SetBaseFolder);
            Controls.Add(Text_ApproveFolder);
            Controls.Add(Text_BaseFolder);
            Controls.Add(FileNameTextBox);
            Controls.Add(ImageBox);
            Controls.Add(Button_Approve);
            Controls.Add(Button_Reject);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Reject;
        private Button Button_Approve;
        private PictureBox ImageBox;
        private TextBox FileNameTextBox;
        private TextBox Text_BaseFolder;
        private TextBox Text_ApproveFolder;
        private Button Button_SetBaseFolder;
        private Button Button_SetApproveFolder;
        private Button Button_Load;
    }
}