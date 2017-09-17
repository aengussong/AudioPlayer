namespace AudioPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.volumeScrollBar = new System.Windows.Forms.VScrollBar();
            this.lengthScrollBar = new System.Windows.Forms.HScrollBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.playListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(22, 18);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(164, 47);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "openFile";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(22, 131);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(164, 47);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(22, 78);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(164, 47);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // volumeScrollBar
            // 
            this.volumeScrollBar.Location = new System.Drawing.Point(375, 18);
            this.volumeScrollBar.Name = "volumeScrollBar";
            this.volumeScrollBar.Size = new System.Drawing.Size(17, 198);
            this.volumeScrollBar.TabIndex = 3;
            this.volumeScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeScrollBar_Scroll);
            // 
            // lengthScrollBar
            // 
            this.lengthScrollBar.Location = new System.Drawing.Point(9, 199);
            this.lengthScrollBar.Name = "lengthScrollBar";
            this.lengthScrollBar.Size = new System.Drawing.Size(348, 17);
            this.lengthScrollBar.TabIndex = 4;
            this.lengthScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.lengthScrollBar_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // playListBox
            // 
            this.playListBox.FormattingEnabled = true;
            this.playListBox.Location = new System.Drawing.Point(192, 18);
            this.playListBox.Name = "playListBox";
            this.playListBox.Size = new System.Drawing.Size(165, 160);
            this.playListBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playListBox);
            this.Controls.Add(this.lengthScrollBar);
            this.Controls.Add(this.volumeScrollBar);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.openFileButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudioPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.HScrollBar lengthScrollBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.VScrollBar volumeScrollBar;
        private System.Windows.Forms.ListBox playListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

