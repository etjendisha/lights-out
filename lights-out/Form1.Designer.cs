
namespace lights_out
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
            this.panel = new System.Windows.Forms.Panel();
            this.movesLabel = new System.Windows.Forms.Label();
            this.gridLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.gridY = new System.Windows.Forms.NumericUpDown();
            this.gridX = new System.Windows.Forms.NumericUpDown();
            this.restartButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1562, 823);
            this.panel.TabIndex = 0;
            // 
            // movesLabel
            // 
            this.movesLabel.AutoSize = true;
            this.movesLabel.Location = new System.Drawing.Point(242, 870);
            this.movesLabel.Name = "movesLabel";
            this.movesLabel.Size = new System.Drawing.Size(55, 20);
            this.movesLabel.TabIndex = 0;
            this.movesLabel.Text = "Moves:";
            this.movesLabel.Click += new System.EventHandler(this.movesLabel_Click);
            // 
            // gridLabel
            // 
            this.gridLabel.AutoSize = true;
            this.gridLabel.Location = new System.Drawing.Point(12, 843);
            this.gridLabel.Name = "gridLabel";
            this.gridLabel.Size = new System.Drawing.Size(40, 20);
            this.gridLabel.TabIndex = 1;
            this.gridLabel.Text = "Grid:";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(132, 843);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(16, 20);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "x";
            // 
            // gridY
            // 
            this.gridY.Location = new System.Drawing.Point(154, 840);
            this.gridY.Name = "gridY";
            this.gridY.Size = new System.Drawing.Size(73, 27);
            this.gridY.TabIndex = 7;
            this.gridY.ValueChanged += new System.EventHandler(this.gridY_ValueChanged);
            // 
            // gridX
            // 
            this.gridX.Location = new System.Drawing.Point(58, 840);
            this.gridX.Name = "gridX";
            this.gridX.Size = new System.Drawing.Size(73, 27);
            this.gridX.TabIndex = 6;
            this.gridX.ValueChanged += new System.EventHandler(this.gridX_ValueChanged);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(54, 870);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(94, 29);
            this.restartButton.TabIndex = 5;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(262, 837);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(88, 31);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 899);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.gridX);
            this.Controls.Add(this.gridY);
            this.Controls.Add(this.movesLabel);
            this.Controls.Add(this.gridLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label movesLabel;
        private System.Windows.Forms.Label gridLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.NumericUpDown gridY;
        private System.Windows.Forms.NumericUpDown gridX;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button generateButton;
    }
}
