
namespace SnakeGame.Modules.UI.Windows {
  partial class Main {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.Panel_Arena = new System.Windows.Forms.Panel();
      this.Label_PressToStart = new System.Windows.Forms.Label();
      this.Label_Score_Player1 = new System.Windows.Forms.Label();
      this.Label_Score_Player2 = new System.Windows.Forms.Label();
      this.Panel_Arena.SuspendLayout();
      this.SuspendLayout();
      // 
      // Panel_Arena
      // 
      this.Panel_Arena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.Panel_Arena.Controls.Add(this.Label_PressToStart);
      this.Panel_Arena.Location = new System.Drawing.Point(0, 49);
      this.Panel_Arena.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
      this.Panel_Arena.Name = "Panel_Arena";
      this.Panel_Arena.Size = new System.Drawing.Size(512, 513);
      this.Panel_Arena.TabIndex = 0;
      this.Panel_Arena.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Arena_Paint);
      // 
      // Label_PressToStart
      // 
      this.Label_PressToStart.AutoSize = true;
      this.Label_PressToStart.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.Label_PressToStart.ForeColor = System.Drawing.Color.White;
      this.Label_PressToStart.Location = new System.Drawing.Point(120, 263);
      this.Label_PressToStart.Margin = new System.Windows.Forms.Padding(0);
      this.Label_PressToStart.Name = "Label_PressToStart";
      this.Label_PressToStart.Size = new System.Drawing.Size(288, 19);
      this.Label_PressToStart.TabIndex = 3;
      this.Label_PressToStart.Text = "Press any key to start the game";
      this.Label_PressToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Label_Score_Player1
      // 
      this.Label_Score_Player1.AutoSize = true;
      this.Label_Score_Player1.ForeColor = System.Drawing.Color.White;
      this.Label_Score_Player1.Location = new System.Drawing.Point(16, 16);
      this.Label_Score_Player1.Margin = new System.Windows.Forms.Padding(0);
      this.Label_Score_Player1.Name = "Label_Score_Player1";
      this.Label_Score_Player1.Size = new System.Drawing.Size(96, 17);
      this.Label_Score_Player1.TabIndex = 1;
      this.Label_Score_Player1.Text = "Blue: 00000";
      this.Label_Score_Player1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label_Score_Player2
      // 
      this.Label_Score_Player2.AutoSize = true;
      this.Label_Score_Player2.ForeColor = System.Drawing.Color.White;
      this.Label_Score_Player2.Location = new System.Drawing.Point(409, 16);
      this.Label_Score_Player2.Margin = new System.Windows.Forms.Padding(0);
      this.Label_Score_Player2.Name = "Label_Score_Player2";
      this.Label_Score_Player2.Size = new System.Drawing.Size(88, 17);
      this.Label_Score_Player2.TabIndex = 2;
      this.Label_Score_Player2.Text = "Red: 00000";
      this.Label_Score_Player2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Main
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
      this.ClientSize = new System.Drawing.Size(513, 562);
      this.Controls.Add(this.Label_Score_Player2);
      this.Controls.Add(this.Label_Score_Player1);
      this.Controls.Add(this.Panel_Arena);
      this.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Main";
      this.Padding = new System.Windows.Forms.Padding(16);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SnakeGame";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
      this.Panel_Arena.ResumeLayout(false);
      this.Panel_Arena.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel Panel_Arena;
    private System.Windows.Forms.Label Label_Score_Player1;
    private System.Windows.Forms.Label Label_Score_Player2;
    private System.Windows.Forms.Label Label_PressToStart;
  }
}