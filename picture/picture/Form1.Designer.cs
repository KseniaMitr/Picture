namespace picture
{
    partial class drawing_machine
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
            this.butExit = new System.Windows.Forms.Button();
            this.RectBut = new System.Windows.Forms.Button();
            this.CirclBut = new System.Windows.Forms.Button();
            this.butMoving = new System.Windows.Forms.Button();
            this.butVagon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.Location = new System.Drawing.Point(717, 411);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 33);
            this.butExit.TabIndex = 0;
            this.butExit.Text = "выход";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // RectBut
            // 
            this.RectBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RectBut.Location = new System.Drawing.Point(646, 16);
            this.RectBut.Name = "RectBut";
            this.RectBut.Size = new System.Drawing.Size(137, 33);
            this.RectBut.TabIndex = 1;
            this.RectBut.Text = "прямоугольник";
            this.RectBut.UseVisualStyleBackColor = true;
            this.RectBut.Click += new System.EventHandler(this.RectBut_Click);
            // 
            // CirclBut
            // 
            this.CirclBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CirclBut.Location = new System.Drawing.Point(646, 55);
            this.CirclBut.Name = "CirclBut";
            this.CirclBut.Size = new System.Drawing.Size(137, 30);
            this.CirclBut.TabIndex = 2;
            this.CirclBut.Text = "круг";
            this.CirclBut.UseVisualStyleBackColor = true;
            this.CirclBut.Click += new System.EventHandler(this.CirclBut_Click);
            // 
            // butMoving
            // 
            this.butMoving.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butMoving.Location = new System.Drawing.Point(646, 168);
            this.butMoving.Name = "butMoving";
            this.butMoving.Size = new System.Drawing.Size(137, 132);
            this.butMoving.TabIndex = 3;
            this.butMoving.Text = "перемещать";
            this.butMoving.UseVisualStyleBackColor = true;
            this.butMoving.Click += new System.EventHandler(this.butMoving_Click);
            // 
            // butVagon
            // 
            this.butVagon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butVagon.Location = new System.Drawing.Point(646, 91);
            this.butVagon.Name = "butVagon";
            this.butVagon.Size = new System.Drawing.Size(142, 34);
            this.butVagon.TabIndex = 4;
            this.butVagon.Text = "вагончик";
            this.butVagon.UseVisualStyleBackColor = true;
            this.butVagon.Click += new System.EventHandler(this.butVagon_Click);
            // 
            // drawing_machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butVagon);
            this.Controls.Add(this.butMoving);
            this.Controls.Add(this.CirclBut);
            this.Controls.Add(this.RectBut);
            this.Controls.Add(this.butExit);
            this.Name = "drawing_machine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "picture";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_machine_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawing_machine_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawing_machine_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button RectBut;
        private System.Windows.Forms.Button CirclBut;
        private System.Windows.Forms.Button butMoving;
        private System.Windows.Forms.Button butVagon;
    }
}

