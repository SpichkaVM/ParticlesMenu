
namespace ParticlesMenu
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RadPaint1 = new System.Windows.Forms.TrackBar();
            this.YPaint1 = new System.Windows.Forms.TrackBar();
            this.XPaint1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.XPaint2 = new System.Windows.Forms.TrackBar();
            this.YPaint2 = new System.Windows.Forms.TrackBar();
            this.RadPaint2 = new System.Windows.Forms.TrackBar();
            this.ColorPaint1_1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadPaint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPaint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPaint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPaint2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPaint2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadPaint2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(776, 426);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RadPaint1
            // 
            this.RadPaint1.Location = new System.Drawing.Point(15, 595);
            this.RadPaint1.Maximum = 100;
            this.RadPaint1.Name = "RadPaint1";
            this.RadPaint1.Size = new System.Drawing.Size(189, 45);
            this.RadPaint1.TabIndex = 1;
            this.RadPaint1.Scroll += new System.EventHandler(this.RadPaint1_Scroll);
            // 
            // YPaint1
            // 
            this.YPaint1.Location = new System.Drawing.Point(15, 531);
            this.YPaint1.Maximum = 400;
            this.YPaint1.Name = "YPaint1";
            this.YPaint1.Size = new System.Drawing.Size(189, 45);
            this.YPaint1.TabIndex = 2;
            this.YPaint1.Scroll += new System.EventHandler(this.YPaint1_Scroll);
            // 
            // XPaint1
            // 
            this.XPaint1.Location = new System.Drawing.Point(12, 458);
            this.XPaint1.Maximum = 800;
            this.XPaint1.Name = "XPaint1";
            this.XPaint1.Size = new System.Drawing.Size(189, 45);
            this.XPaint1.TabIndex = 3;
            this.XPaint1.Scroll += new System.EventHandler(this.XPaint1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Перемещение по вертикали";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Перемещение по горизонтали";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Радиус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Радиус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Перемещение по горизонтали";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Перемещение по вертикали";
            // 
            // XPaint2
            // 
            this.XPaint2.Location = new System.Drawing.Point(279, 458);
            this.XPaint2.Maximum = 800;
            this.XPaint2.Name = "XPaint2";
            this.XPaint2.Size = new System.Drawing.Size(189, 45);
            this.XPaint2.TabIndex = 9;
            this.XPaint2.Scroll += new System.EventHandler(this.XPaint2_Scroll);
            // 
            // YPaint2
            // 
            this.YPaint2.Location = new System.Drawing.Point(279, 531);
            this.YPaint2.Maximum = 400;
            this.YPaint2.Name = "YPaint2";
            this.YPaint2.Size = new System.Drawing.Size(189, 45);
            this.YPaint2.TabIndex = 8;
            this.YPaint2.Scroll += new System.EventHandler(this.YPaint2_Scroll);
            // 
            // RadPaint2
            // 
            this.RadPaint2.Location = new System.Drawing.Point(279, 595);
            this.RadPaint2.Maximum = 100;
            this.RadPaint2.Name = "RadPaint2";
            this.RadPaint2.Size = new System.Drawing.Size(189, 45);
            this.RadPaint2.TabIndex = 7;
            this.RadPaint2.Scroll += new System.EventHandler(this.RadPaint2_Scroll);
            // 
            // ColorPaint1_1
            // 
            this.ColorPaint1_1.Location = new System.Drawing.Point(12, 646);
            this.ColorPaint1_1.Name = "ColorPaint1_1";
            this.ColorPaint1_1.Size = new System.Drawing.Size(75, 23);
            this.ColorPaint1_1.TabIndex = 13;
            this.ColorPaint1_1.Text = "button1";
            this.ColorPaint1_1.UseVisualStyleBackColor = true;
            this.ColorPaint1_1.Click += new System.EventHandler(this.ColorPaint1_1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 646);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 675);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 763);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ColorPaint1_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.XPaint2);
            this.Controls.Add(this.YPaint2);
            this.Controls.Add(this.RadPaint2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XPaint1);
            this.Controls.Add(this.YPaint1);
            this.Controls.Add(this.RadPaint1);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadPaint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPaint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPaint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPaint2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPaint2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadPaint2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar RadPaint1;
        private System.Windows.Forms.TrackBar YPaint1;
        private System.Windows.Forms.TrackBar XPaint1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar XPaint2;
        private System.Windows.Forms.TrackBar YPaint2;
        private System.Windows.Forms.TrackBar RadPaint2;
        private System.Windows.Forms.Button ColorPaint1_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

