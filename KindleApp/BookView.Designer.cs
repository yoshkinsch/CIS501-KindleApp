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
            PageNumberLabel = new Label();
            GoToBookmarkButton = new Button();
            GoToPageButton = new Button();
            SuspendLayout();
            // 
            // AddBookmarkButton
            // 
            AddBookmarkButton.Location = new Point(1016, 23);
            AddBookmarkButton.Margin = new Padding(6, 4, 6, 4);
            AddBookmarkButton.Name = "AddBookmarkButton";
            AddBookmarkButton.Size = new Size(262, 47);
            AddBookmarkButton.TabIndex = 0;
            AddBookmarkButton.Text = "Add Bookmark";
            AddBookmarkButton.UseVisualStyleBackColor = true;
            AddBookmarkButton.Click += AddBookmarkButton_Click;
            // 
            // RemoveBookmarkButton
            // 
            RemoveBookmarkButton.Location = new Point(1016, 79);
            RemoveBookmarkButton.Margin = new Padding(6, 4, 6, 4);
            RemoveBookmarkButton.Name = "RemoveBookmarkButton";
            RemoveBookmarkButton.Size = new Size(262, 47);
            RemoveBookmarkButton.TabIndex = 1;
            RemoveBookmarkButton.Text = "Remove Bookmark";
            RemoveBookmarkButton.UseVisualStyleBackColor = true;
            RemoveBookmarkButton.Click += RemoveBookmarkButton_Click;
            // 
            // CloseBookButton
            // 
            CloseBookButton.Location = new Point(1016, 631);
            CloseBookButton.Margin = new Padding(6, 4, 6, 4);
            CloseBookButton.Name = "CloseBookButton";
            CloseBookButton.Size = new Size(262, 47);
            CloseBookButton.TabIndex = 2;
            CloseBookButton.Text = "Close";
            CloseBookButton.UseVisualStyleBackColor = true;
            CloseBookButton.Click += CloseBookButton_Click;
            // 
            // FlipBackwardButton
            // 
            FlipBackwardButton.Location = new Point(1064, 258);
            FlipBackwardButton.Margin = new Padding(6, 4, 6, 4);
            FlipBackwardButton.Name = "FlipBackwardButton";
            FlipBackwardButton.Size = new Size(46, 49);
            FlipBackwardButton.TabIndex = 4;
            FlipBackwardButton.Text = "<";
            FlipBackwardButton.UseVisualStyleBackColor = true;
            FlipBackwardButton.Click += FlipBackwardButton_Click;
            // 
            // FlipForwardButton
            // 
            FlipForwardButton.Location = new Point(1179, 258);
            FlipForwardButton.Margin = new Padding(6, 4, 6, 4);
            FlipForwardButton.Name = "FlipForwardButton";
            FlipForwardButton.Size = new Size(46, 49);
            FlipForwardButton.TabIndex = 5;
            FlipForwardButton.Text = ">";
            FlipForwardButton.UseVisualStyleBackColor = true;
            FlipForwardButton.Click += FlipForwardButton_Click;
            // 
            // BookmarkComboBox
            // 
            BookmarkComboBox.FormattingEnabled = true;
            BookmarkComboBox.Location = new Point(1016, 137);
            BookmarkComboBox.Margin = new Padding(6, 6, 6, 6);
            BookmarkComboBox.Name = "BookmarkComboBox";
            BookmarkComboBox.Size = new Size(258, 40);
            BookmarkComboBox.TabIndex = 6;
            // 
            // PageNumberTextBox
            // 
            PageNumberTextBox.Location = new Point(1122, 260);
            PageNumberTextBox.Margin = new Padding(6, 6, 6, 6);
            PageNumberTextBox.Name = "PageNumberTextBox";
            PageNumberTextBox.Size = new Size(43, 39);
            PageNumberTextBox.TabIndex = 7;
            // 
            // PageNumberLabel
            // 
            PageNumberLabel.AutoSize = true;
            PageNumberLabel.Location = new Point(448, 311);
            PageNumberLabel.Margin = new Padding(6, 0, 6, 0);
            PageNumberLabel.Name = "PageNumberLabel";
            PageNumberLabel.Size = new Size(78, 32);
            PageNumberLabel.TabIndex = 8;
            PageNumberLabel.Text = "label1";
            // 
            // GoToBookmarkButton
            // 
            GoToBookmarkButton.Location = new Point(1016, 198);
            GoToBookmarkButton.Margin = new Padding(6, 6, 6, 6);
            GoToBookmarkButton.Name = "GoToBookmarkButton";
            GoToBookmarkButton.Size = new Size(262, 49);
            GoToBookmarkButton.TabIndex = 9;
            GoToBookmarkButton.Text = "Go To Bookmark";
            GoToBookmarkButton.UseVisualStyleBackColor = true;
            GoToBookmarkButton.Click += GoToBookmarkButton_Click;
            // 
            // GoToPageButton
            // 
            GoToPageButton.Location = new Point(1064, 314);
            GoToPageButton.Name = "GoToPageButton";
            GoToPageButton.Size = new Size(161, 46);
            GoToPageButton.TabIndex = 10;
            GoToPageButton.Text = "Go To Page";
            GoToPageButton.UseVisualStyleBackColor = true;
            GoToPageButton.Click += GoToPageButton_Click;
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 721);
            Controls.Add(GoToPageButton);
            Controls.Add(GoToBookmarkButton);
            Controls.Add(PageNumberLabel);
            Controls.Add(PageNumberTextBox);
            Controls.Add(BookmarkComboBox);
            Controls.Add(FlipForwardButton);
            Controls.Add(FlipBackwardButton);
            Controls.Add(CloseBookButton);
            Controls.Add(RemoveBookmarkButton);
            Controls.Add(AddBookmarkButton);
            Margin = new Padding(6, 4, 6, 4);
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
        private Label PageNumberLabel;
        private Button GoToBookmarkButton;
        private Button GoToPageButton;
    }
}