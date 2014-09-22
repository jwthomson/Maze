namespace Jthomson.Maze
{
    partial class Form1
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.trkRows = new System.Windows.Forms.TrackBar();
            this.trkCols = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCols)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(354, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 45);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // trkRows
            // 
            this.trkRows.Location = new System.Drawing.Point(12, 33);
            this.trkRows.Maximum = 100;
            this.trkRows.Minimum = 1;
            this.trkRows.Name = "trkRows";
            this.trkRows.Size = new System.Drawing.Size(165, 29);
            this.trkRows.TabIndex = 2;
            this.trkRows.TickFrequency = 5;
            this.trkRows.Value = 30;
            // 
            // trkCols
            // 
            this.trkCols.Location = new System.Drawing.Point(183, 33);
            this.trkCols.Maximum = 100;
            this.trkCols.Minimum = 1;
            this.trkCols.Name = "trkCols";
            this.trkCols.Size = new System.Drawing.Size(165, 29);
            this.trkCols.TabIndex = 3;
            this.trkCols.TickFrequency = 5;
            this.trkCols.Value = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columns";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkCols);
            this.Controls.Add(this.trkRows);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "A maze ing";
            ((System.ComponentModel.ISupportInitialize)(this.trkRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TrackBar trkRows;
        private System.Windows.Forms.TrackBar trkCols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

