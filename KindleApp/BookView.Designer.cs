namespace KindleApp
{
    partial class BookView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddBookmarkButton = new Button();
            RemoveBookmarkButton = new Button();
            CloseBookButton = new Button();
            GoToPageButton = new Button();
            FlipBackwardButton = new Button();
            FlipForwardButton = new Button();
            SuspendLayout();
            // 
            // AddBookmarkButton
            // 
            AddBookmarkButton.Location = new Point(583, 41);
            AddBookmarkButton.Name = "AddBookmarkButton";
            AddBookmarkButton.Size = new Size(129, 29);
            AddBookmarkButton.TabIndex = 0;
            AddBookmarkButton.Text = "Add Bookmark";
            AddBookmarkButton.UseVisualStyleBackColor = true;
            AddBookmarkButton.Click += AddBookmarkButton_Click;
            // 
            // RemoveBookmarkButton
            // 
            RemoveBookmarkButton.Location = new Point(561, 76);
            RemoveBookmarkButton.Name = "RemoveBookmarkButton";
            RemoveBookmarkButton.Size = new Size(161, 29);
            RemoveBookmarkButton.TabIndex = 1;
            RemoveBookmarkButton.Text = "Remove Bookmark";
            RemoveBookmarkButton.UseVisualStyleBackColor = true;
            RemoveBookmarkButton.Click += RemoveBookmarkButton_Click;
            // 
            // CloseBookButton
            // 
            CloseBookButton.Location = new Point(36, 397);
            CloseBookButton.Name = "CloseBookButton";
            CloseBookButton.Size = new Size(94, 29);
            CloseBookButton.TabIndex = 2;
            CloseBookButton.Text = "Close";
            CloseBookButton.UseVisualStyleBackColor = true;
            CloseBookButton.Click += CloseBookButton_Click;
            // 
            // GoToPageButton
            // 
            GoToPageButton.Location = new Point(36, 76);
            GoToPageButton.Name = "GoToPageButton";
            GoToPageButton.Size = new Size(94, 29);
            GoToPageButton.TabIndex = 3;
            GoToPageButton.Text = "Go To Page";
            GoToPageButton.UseVisualStyleBackColor = true;
            GoToPageButton.Click += GoToPageButton_Click;
            // 
            // FlipBackwardButton
            // 
            FlipBackwardButton.Location = new Point(240, 397);
            FlipBackwardButton.Name = "FlipBackwardButton";
            FlipBackwardButton.Size = new Size(94, 29);
            FlipBackwardButton.TabIndex = 4;
            FlipBackwardButton.Text = "<";
            FlipBackwardButton.UseVisualStyleBackColor = true;
            FlipBackwardButton.Click += FlipBackwardButton_Click;
            // 
            // FlipForwardButton
            // 
            FlipForwardButton.Location = new Point(409, 399);
            FlipForwardButton.Name = "FlipForwardButton";
            FlipForwardButton.Size = new Size(94, 29);
            FlipForwardButton.TabIndex = 5;
            FlipForwardButton.Text = ">";
            FlipForwardButton.UseVisualStyleBackColor = true;
            FlipForwardButton.Click += FlipForwardButton_Click;
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FlipForwardButton);
            Controls.Add(FlipBackwardButton);
            Controls.Add(GoToPageButton);
            Controls.Add(CloseBookButton);
            Controls.Add(RemoveBookmarkButton);
            Controls.Add(AddBookmarkButton);
            Name = "BookView";
            Text = "BookView";
            ResumeLayout(false);
        }

        #endregion

        private Button AddBookmarkButton;
        private Button RemoveBookmarkButton;
        private Button CloseBookButton;
        private Button GoToPageButton;
        private Button FlipBackwardButton;
        private Button FlipForwardButton;
    }
}