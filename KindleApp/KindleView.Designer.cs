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
            SuspendLayout();
            // 
            // SyncButton
            // 
            SyncButton.Location = new Point(118, 364);
            SyncButton.Name = "SyncButton";
            SyncButton.Size = new Size(153, 67);
            SyncButton.TabIndex = 0;
            SyncButton.Text = "Sync";
            SyncButton.UseVisualStyleBackColor = true;
            SyncButton.Click += SyncButton_Click;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(525, 364);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(159, 67);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // KindleView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OpenButton);
            Controls.Add(SyncButton);
            Name = "KindleView";
            Text = "Kindle";
            ResumeLayout(false);
        }

        #endregion

        private Button SyncButton;
        private Button OpenButton;
    }
}
