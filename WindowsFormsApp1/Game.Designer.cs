
namespace WindowsFormsApp1
{
    partial class Game
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
            this.gameBoard = new System.Windows.Forms.Panel();
            this.currentMoveLbl = new System.Windows.Forms.Label();
            this.movesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameBoard
            // 
            this.gameBoard.Location = new System.Drawing.Point(12, 46);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(445, 234);
            this.gameBoard.TabIndex = 0;
            // 
            // currentMoveLbl
            // 
            this.currentMoveLbl.AutoSize = true;
            this.currentMoveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentMoveLbl.Location = new System.Drawing.Point(12, 9);
            this.currentMoveLbl.Name = "currentMoveLbl";
            this.currentMoveLbl.Size = new System.Drawing.Size(84, 20);
            this.currentMoveLbl.TabIndex = 1;
            this.currentMoveLbl.Text = "Žaidėjas X";
            // 
            // movesLbl
            // 
            this.movesLbl.AutoSize = true;
            this.movesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesLbl.Location = new System.Drawing.Point(418, 9);
            this.movesLbl.Name = "movesLbl";
            this.movesLbl.Size = new System.Drawing.Size(39, 20);
            this.movesLbl.TabIndex = 2;
            this.movesLbl.Text = "0 / 9";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 296);
            this.Controls.Add(this.movesLbl);
            this.Controls.Add(this.currentMoveLbl);
            this.Controls.Add(this.gameBoard);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Žaidimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameBoard;
        private System.Windows.Forms.Label currentMoveLbl;
        private System.Windows.Forms.Label movesLbl;
    }
}