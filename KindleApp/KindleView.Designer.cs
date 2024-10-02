namespace KindleApp
{
    partial class KindleView
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
            SyncButton = new Button();
            OpenButton = new Button();
            BookListView = new ListView();
            SuspendLayout();
            // 
            // SyncButton
            // 
            SyncButton.Location = new Point(103, 273);
            SyncButton.Margin = new Padding(3, 2, 3, 2);
            SyncButton.Name = "SyncButton";
            SyncButton.Size = new Size(134, 50);
            SyncButton.TabIndex = 0;
            SyncButton.Text = "Sync";
            SyncButton.UseVisualStyleBackColor = true;
            SyncButton.Click += SyncButton_Click;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(459, 273);
            OpenButton.Margin = new Padding(3, 2, 3, 2);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(139, 50);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // BookListView
            // 
            BookListView.Location = new Point(7, 10);
            BookListView.Name = "BookListView";
            BookListView.Size = new Size(681, 258);
            BookListView.TabIndex = 2;
            BookListView.UseCompatibleStateImageBehavior = false;
            // 
            // KindleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(BookListView);
            Controls.Add(OpenButton);
            Controls.Add(SyncButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KindleView";
            Text = "Kindle";
            ResumeLayout(false);
        }

        #endregion

        private Button SyncButton;
        private Button OpenButton;
        private ListView BookListView;
    }
}
