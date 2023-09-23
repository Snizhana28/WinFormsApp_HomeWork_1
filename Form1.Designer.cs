namespace WinFormsApp_HomeWork_1
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
            label1 = new Label();
            bt_guessNum = new Button();
            label_X = new Label();
            label_Y = new Label();
            ptr = new Label();
            bt_clickTheLeftMouse = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 0;
            label1.Text = "Резюме";
            label1.Click += label1_Click;
            // 
            // bt_guessNum
            // 
            bt_guessNum.BackColor = SystemColors.ActiveCaption;
            bt_guessNum.FlatAppearance.BorderColor = Color.Black;
            bt_guessNum.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            bt_guessNum.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            bt_guessNum.FlatStyle = FlatStyle.Flat;
            bt_guessNum.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_guessNum.Location = new Point(625, 409);
            bt_guessNum.Name = "bt_guessNum";
            bt_guessNum.Size = new Size(154, 29);
            bt_guessNum.TabIndex = 1;
            bt_guessNum.Text = "Вгадай число";
            bt_guessNum.UseVisualStyleBackColor = false;
            bt_guessNum.MouseMove += bt_guessNum_MouseMove;
            // 
            // label_X
            // 
            label_X.AutoSize = true;
            label_X.BackColor = Color.FromArgb(255, 128, 128);
            label_X.FlatStyle = FlatStyle.Flat;
            label_X.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_X.Location = new Point(96, 81);
            label_X.Name = "label_X";
            label_X.Size = new Size(18, 20);
            label_X.TabIndex = 0;
            label_X.Text = "X";
            label_X.Click += label_X_Click;
            // 
            // label_Y
            // 
            label_Y.AutoSize = true;
            label_Y.BackColor = Color.FromArgb(128, 255, 128);
            label_Y.FlatStyle = FlatStyle.Flat;
            label_Y.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Y.Location = new Point(12, 116);
            label_Y.Name = "label_Y";
            label_Y.Size = new Size(18, 20);
            label_Y.TabIndex = 1;
            label_Y.Text = "Y";
            label_Y.Click += label_Y_Click;
            // 
            // ptr
            // 
            ptr.AutoSize = true;
            ptr.BackColor = Color.FromArgb(192, 192, 255);
            ptr.FlatStyle = FlatStyle.Flat;
            ptr.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ptr.Location = new Point(12, 81);
            ptr.Name = "ptr";
            ptr.Size = new Size(63, 20);
            ptr.TabIndex = 2;
            ptr.Text = "poiner";
            ptr.Click += ptr_Click;
            // 
            // bt_clickTheLeftMouse
            // 
            bt_clickTheLeftMouse.Location = new Point(17, 172);
            bt_clickTheLeftMouse.Name = "bt_clickTheLeftMouse";
            bt_clickTheLeftMouse.Size = new Size(94, 29);
            bt_clickTheLeftMouse.TabIndex = 3;
            bt_clickTheLeftMouse.Text = "button1";
            bt_clickTheLeftMouse.UseVisualStyleBackColor = true;
            bt_clickTheLeftMouse.MouseClick += bt_clickTheLeftMouse_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_clickTheLeftMouse);
            Controls.Add(label_Y);
            Controls.Add(ptr);
            Controls.Add(bt_guessNum);
            Controls.Add(label_X);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bt_guessNum;
        private Label label_X;
        private Label label_Y;
        private Label ptr;
        private Button bt_clickTheLeftMouse;
    }
}