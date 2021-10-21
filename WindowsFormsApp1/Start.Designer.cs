
namespace WindowsFormsApp1
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkX = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkO = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 2);
            this.label2.TabIndex = 1;
            // 
            // checkX
            // 
            this.checkX.AutoSize = true;
            this.checkX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkX.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkX.Location = new System.Drawing.Point(226, 152);
            this.checkX.Name = "checkX";
            this.checkX.Size = new System.Drawing.Size(35, 20);
            this.checkX.TabIndex = 2;
            this.checkX.Text = "X";
            this.checkX.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(39, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pirmą ėjimą pradės: ";
            // 
            // checkO
            // 
            this.checkO.AutoSize = true;
            this.checkO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkO.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkO.Location = new System.Drawing.Point(267, 152);
            this.checkO.Name = "checkO";
            this.checkO.Size = new System.Drawing.Size(37, 20);
            this.checkO.TabIndex = 4;
            this.checkO.Text = "O";
            this.checkO.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 2);
            this.label4.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(95, 205);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 30);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Pradėti naują žaidimą";
            this.toolTip1.SetToolTip(this.startButton, "  Jeigu pasirinkote, jog žaidimą pradės X ir O arba\r\nnepasirinkote nei vieno, tuo" +
        "met žaidimas už jus \r\nautomatiškai sugeneruos pirmąjį žaidėja.");
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(39, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Žaidimo lygis:";
            // 
            // levelBox
            // 
            this.levelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "3x3",
            "4x4",
            "5x5",
            "6x6"});
            this.levelBox.Location = new System.Drawing.Point(170, 100);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(134, 24);
            this.levelBox.TabIndex = 9;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(362, 259);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MaximizeBox = false;
            this.Name = "Start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe - Pradžia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox levelBox;
    }
}

