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
            FlipBackwardButton = new Button();
            FlipForwardButton = new Button();
            BookmarkComboBox = new ComboBox();
            PageNumberTextBox = new TextBox();
            PageNumberaLabel = new Label();
            GoToBookmarkButton = new Button();
            SuspendLayout();
            // 
            // AddBookmarkButton
            // 
            AddBookmarkButton.Location = new Point(547, 11);
            AddBookmarkButton.Margin = new Padding(3, 2, 3, 2);
            AddBookmarkButton.Name = "AddBookmarkButton";
            AddBookmarkButton.Size = new Size(141, 22);
            AddBookmarkButton.TabIndex = 0;
            AddBookmarkButton.Text = "Add Bookmark";
            AddBookmarkButton.UseVisualStyleBackColor = true;
            AddBookmarkButton.Click += AddBookmarkButton_Click;
            // 
            // RemoveBookmarkButton
            // 
            RemoveBookmarkButton.Location = new Point(547, 37);
            RemoveBookmarkButton.Margin = new Padding(3, 2, 3, 2);
            RemoveBookmarkButton.Name = "RemoveBookmarkButton";
            RemoveBookmarkButton.Size = new Size(141, 22);
            RemoveBookmarkButton.TabIndex = 1;
            RemoveBookmarkButton.Text = "Remove Bookmark";
            RemoveBookmarkButton.UseVisualStyleBackColor = true;
            RemoveBookmarkButton.Click += RemoveBookmarkButton_Click;
            // 
            // CloseBookButton
            // 
            CloseBookButton.Location = new Point(547, 296);
            CloseBookButton.Margin = new Padding(3, 2, 3, 2);
            CloseBookButton.Name = "CloseBookButton";
            CloseBookButton.Size = new Size(141, 22);
            CloseBookButton.TabIndex = 2;
            CloseBookButton.Text = "Close";
            CloseBookButton.UseVisualStyleBackColor = true;
            CloseBookButton.Click += CloseBookButton_Click;
            // 
            // FlipBackwardButton
            // 
            FlipBackwardButton.Location = new Point(573, 121);
            FlipBackwardButton.Margin = new Padding(3, 2, 3, 2);
            FlipBackwardButton.Name = "FlipBackwardButton";
            FlipBackwardButton.Size = new Size(25, 23);
            FlipBackwardButton.TabIndex = 4;
            FlipBackwardButton.Text = "<";
            FlipBackwardButton.UseVisualStyleBackColor = true;
            FlipBackwardButton.Click += FlipBackwardButton_Click;
            // 
            // FlipForwardButton
            // 
            FlipForwardButton.Location = new Point(635, 121);
            FlipForwardButton.Margin = new Padding(3, 2, 3, 2);
            FlipForwardButton.Name = "FlipForwardButton";
            FlipForwardButton.Size = new Size(25, 23);
            FlipForwardButton.TabIndex = 5;
            FlipForwardButton.Text = ">";
            FlipForwardButton.UseVisualStyleBackColor = true;
            FlipForwardButton.Click += FlipForwardButton_Click;
            // 
            // BookmarkComboBox
            // 
            BookmarkComboBox.FormattingEnabled = true;
            BookmarkComboBox.Location = new Point(547, 64);
            BookmarkComboBox.Name = "BookmarkComboBox";
            BookmarkComboBox.Size = new Size(141, 23);
            BookmarkComboBox.TabIndex = 6;
            // 
            // PageNumberTextBox
            // 
            PageNumberTextBox.Location = new Point(604, 122);
            PageNumberTextBox.Name = "PageNumberTextBox";
            PageNumberTextBox.Size = new Size(25, 23);
            PageNumberTextBox.TabIndex = 7;
            PageNumberTextBox.TextChanged += PageNumberTextBox_TextChanged;
            // 
            // PageNumberaLabel
            // 
            PageNumberaLabel.AutoSize = true;
            PageNumberaLabel.Location = new Point(241, 146);
            PageNumberaLabel.Name = "PageNumberaLabel";
            PageNumberaLabel.Size = new Size(38, 15);
            PageNumberaLabel.TabIndex = 8;
            PageNumberaLabel.Text = "label1";
            // 
            // GoToBookmarkButton
            // 
            GoToBookmarkButton.Location = new Point(547, 93);
            GoToBookmarkButton.Name = "GoToBookmarkButton";
            GoToBookmarkButton.Size = new Size(141, 23);
            GoToBookmarkButton.TabIndex = 9;
            GoToBookmarkButton.Text = "Go To Bookmark";
            GoToBookmarkButton.UseVisualStyleBackColor = true;
            GoToBookmarkButton.Click += GoToBookmarkButton_Click;
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(GoToBookmarkButton);
            Controls.Add(PageNumberaLabel);
            Controls.Add(PageNumberTextBox);
            Controls.Add(BookmarkComboBox);
            Controls.Add(FlipForwardButton);
            Controls.Add(FlipBackwardButton);
            Controls.Add(CloseBookButton);
            Controls.Add(RemoveBookmarkButton);
            Controls.Add(AddBookmarkButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookView";
            Text = "BookView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBookmarkButton;
        private Button RemoveBookmarkButton;
        private Button CloseBookButton;
        private Button FlipBackwardButton;
        private Button FlipForwardButton;
        private ComboBox BookmarkComboBox;
        private TextBox PageNumberTextBox;
        private Label PageNumberaLabel;
        private Button GoToBookmarkButton;
    }
}