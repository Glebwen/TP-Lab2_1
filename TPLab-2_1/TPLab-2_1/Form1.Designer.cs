namespace TPLab_2_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ABox = new TextBox();
            BBox = new TextBox();
            CBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // ABox
            // 
            ABox.Location = new Point(330, 109);
            ABox.Name = "ABox";
            ABox.Size = new Size(125, 27);
            ABox.TabIndex = 0;
            // 
            // BBox
            // 
            BBox.Location = new Point(330, 142);
            BBox.Name = "BBox";
            BBox.Size = new Size(125, 27);
            BBox.TabIndex = 1;
            // 
            // CBox
            // 
            CBox.Location = new Point(330, 175);
            CBox.Name = "CBox";
            CBox.Size = new Size(125, 27);
            CBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(257, 20);
            label1.TabIndex = 3;
            label1.Text = "Вложено денег при открытии счёта";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(301, 20);
            label2.TabIndex = 4;
            label2.Text = "Ожидаемое месячное увеличение вклада";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 5;
            label3.Text = "Ожидаемая сумма на счету";
            // 
            // button1
            // 
            button1.Location = new Point(330, 225);
            button1.Name = "button1";
            button1.Size = new Size(243, 31);
            button1.TabIndex = 6;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(448, 262);
            button2.Name = "button2";
            button2.Size = new Size(125, 31);
            button2.TabIndex = 7;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(550, 88);
            label4.TabIndex = 8;
            label4.Text = resources.GetString("label4.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 305);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CBox);
            Controls.Add(BBox);
            Controls.Add(ABox);
            KeyPreview = true;
            Name = "Form1";
            Text = "Калькулятор вклада";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ABox;
        private TextBox BBox;
        private TextBox CBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}
