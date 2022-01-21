namespace Fract
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Zoom = new System.Windows.Forms.TextBox();
            this.oneThread = new System.Windows.Forms.RadioButton();
            this.manyThreads = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.parallel = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FPSTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.benchmarkButton = new System.Windows.Forms.Button();
            this.benchmark = new System.Windows.Forms.TextBox();
            this.frames = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HighRezPfoto = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(688, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "отрисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Значение зума";
            // 
            // Zoom
            // 
            this.Zoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Zoom.Location = new System.Drawing.Point(688, 28);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(79, 20);
            this.Zoom.TabIndex = 6;
            this.Zoom.Text = "1";
            // 
            // oneThread
            // 
            this.oneThread.AutoSize = true;
            this.oneThread.Location = new System.Drawing.Point(6, 28);
            this.oneThread.Name = "oneThread";
            this.oneThread.Size = new System.Drawing.Size(81, 17);
            this.oneThread.TabIndex = 9;
            this.oneThread.TabStop = true;
            this.oneThread.Text = "один поток";
            this.oneThread.UseVisualStyleBackColor = true;
            // 
            // manyThreads
            // 
            this.manyThreads.AutoSize = true;
            this.manyThreads.Location = new System.Drawing.Point(7, 51);
            this.manyThreads.Name = "manyThreads";
            this.manyThreads.Size = new System.Drawing.Size(113, 17);
            this.manyThreads.TabIndex = 10;
            this.manyThreads.TabStop = true;
            this.manyThreads.Text = "многопоточность";
            this.manyThreads.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.parallel);
            this.groupBox2.Controls.Add(this.oneThread);
            this.groupBox2.Controls.Add(this.manyThreads);
            this.groupBox2.Location = new System.Drawing.Point(688, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 98);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "потоки";
            // 
            // parallel
            // 
            this.parallel.AutoSize = true;
            this.parallel.Checked = true;
            this.parallel.Location = new System.Drawing.Point(7, 75);
            this.parallel.Name = "parallel";
            this.parallel.Size = new System.Drawing.Size(165, 17);
            this.parallel.TabIndex = 11;
            this.parallel.TabStop = true;
            this.parallel.Text = "Параллельные вычисления";
            this.parallel.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(12, 487);
            this.trackBar1.Maximum = 250;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(836, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 468);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FPSTextBox
            // 
            this.FPSTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FPSTextBox.Location = new System.Drawing.Point(770, 28);
            this.FPSTextBox.Name = "FPSTextBox";
            this.FPSTextBox.Size = new System.Drawing.Size(79, 20);
            this.FPSTextBox.TabIndex = 17;
            this.FPSTextBox.Text = "1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "FPS";
            // 
            // benchmarkButton
            // 
            this.benchmarkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.benchmarkButton.Location = new System.Drawing.Point(688, 415);
            this.benchmarkButton.Name = "benchmarkButton";
            this.benchmarkButton.Size = new System.Drawing.Size(152, 28);
            this.benchmarkButton.TabIndex = 19;
            this.benchmarkButton.Text = "benchmark";
            this.benchmarkButton.UseVisualStyleBackColor = true;
            this.benchmarkButton.Click += new System.EventHandler(this.benchmarkButton_Click);
            // 
            // benchmark
            // 
            this.benchmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.benchmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.benchmark.ForeColor = System.Drawing.Color.Red;
            this.benchmark.Location = new System.Drawing.Point(688, 449);
            this.benchmark.Name = "benchmark";
            this.benchmark.Size = new System.Drawing.Size(154, 32);
            this.benchmark.TabIndex = 20;
            this.benchmark.Text = "1";
            this.benchmark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frames
            // 
            this.frames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frames.Location = new System.Drawing.Point(688, 337);
            this.frames.Name = "frames";
            this.frames.Size = new System.Drawing.Size(154, 20);
            this.frames.TabIndex = 22;
            this.frames.Text = "1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "количество отрисованных кадров";
            // 
            // HighRezPfoto
            // 
            this.HighRezPfoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HighRezPfoto.Location = new System.Drawing.Point(689, 381);
            this.HighRezPfoto.Name = "HighRezPfoto";
            this.HighRezPfoto.Size = new System.Drawing.Size(152, 28);
            this.HighRezPfoto.TabIndex = 23;
            this.HighRezPfoto.Text = "фотка";
            this.HighRezPfoto.UseVisualStyleBackColor = true;
            this.HighRezPfoto.Click += new System.EventHandler(this.HighRezPfoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.HighRezPfoto);
            this.Controls.Add(this.frames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.benchmark);
            this.Controls.Add(this.benchmarkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FPSTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(304, 570);
            this.Name = "Form1";
            this.Text = "Многопоточность на фрактале";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Zoom;
        private System.Windows.Forms.RadioButton oneThread;
        private System.Windows.Forms.RadioButton manyThreads;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton parallel;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FPSTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button benchmarkButton;
        private System.Windows.Forms.TextBox benchmark;
        private System.Windows.Forms.TextBox frames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HighRezPfoto;
    }
}

