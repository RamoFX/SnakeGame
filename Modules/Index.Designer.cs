
namespace Snake {
  partial class Window {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && ( components != null )) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.Label_Score = new System.Windows.Forms.Label();
      this.Panel_GameField = new System.Windows.Forms.Panel();
      this.Label_PressToStart = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // Label_Score
      // 
      this.Label_Score.AutoSize = true;
      this.Label_Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
      this.Label_Score.Location = new System.Drawing.Point(16, 16);
      this.Label_Score.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
      this.Label_Score.Name = "Label_Score";
      this.Label_Score.Size = new System.Drawing.Size(104, 17);
      this.Label_Score.TabIndex = 0;
      this.Label_Score.Text = "Score: 00000";
      // 
      // Panel_GameField
      // 
      this.Panel_GameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.Panel_GameField.Location = new System.Drawing.Point(0, 49);
      this.Panel_GameField.Margin = new System.Windows.Forms.Padding(0);
      this.Panel_GameField.Name = "Panel_GameField";
      this.Panel_GameField.Size = new System.Drawing.Size(544, 544);
      this.Panel_GameField.TabIndex = 1;
      this.Panel_GameField.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_GameField_Paint);
      // 
      // Label_PressToStart
      // 
      this.Label_PressToStart.AutoSize = true;
      this.Label_PressToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.Label_PressToStart.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
      this.Label_PressToStart.Location = new System.Drawing.Point(128, 438);
      this.Label_PressToStart.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
      this.Label_PressToStart.Name = "Label_PressToStart";
      this.Label_PressToStart.Size = new System.Drawing.Size(288, 19);
      this.Label_PressToStart.TabIndex = 3;
      this.Label_PressToStart.Text = "Press any key to start the game";
      // 
      // Window
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
      this.ClientSize = new System.Drawing.Size(544, 593);
      this.Controls.Add(this.Label_PressToStart);
      this.Controls.Add(this.Panel_GameField);
      this.Controls.Add(this.Label_Score);
      this.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Window";
      this.Padding = new System.Windows.Forms.Padding(16);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SnakeGame@1.0.0";
      this.Load += new System.EventHandler(this.Window_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Window_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label Label_Score;
    private System.Windows.Forms.Panel Panel_GameField;
    private System.Windows.Forms.Label Label_PressToStart;
  }
}

