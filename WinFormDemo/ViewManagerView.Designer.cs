namespace WinFormDemo
{
    

    public partial class ViewManagerView
    {
        /// <summary>
        /// This is the view in the MVP design pattern
        /// </summary>
        private System.ComponentModel.IContainer components = null;

       
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.BasicCalculatorButton = new System.Windows.Forms.Button();
            this.ScientificCalculatorButton = new System.Windows.Forms.Button();
            this.BasicCalculatorController = new WinFormDemo.BasicCalculatorView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BasicCalculatorController);
            this.splitContainer1.Size = new System.Drawing.Size(904, 453);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.HistoryButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BasicCalculatorButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ScientificCalculatorButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 438);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.HistoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.HistoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HistoryButton.Location = new System.Drawing.Point(3, 330);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(280, 105);
            this.HistoryButton.TabIndex = 3;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HandleState);
            // 
            // BasicCalculatorButton
            // 
            this.BasicCalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BasicCalculatorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicCalculatorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.BasicCalculatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.BasicCalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BasicCalculatorButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicCalculatorButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BasicCalculatorButton.Location = new System.Drawing.Point(3, 3);
            this.BasicCalculatorButton.Name = "BasicCalculatorButton";
            this.BasicCalculatorButton.Size = new System.Drawing.Size(280, 103);
            this.BasicCalculatorButton.TabIndex = 1;
            this.BasicCalculatorButton.Text = "Basic";
            this.BasicCalculatorButton.UseVisualStyleBackColor = false;
            this.BasicCalculatorButton.Click += new System.EventHandler(this.HandleState);
            // 
            // ScientificCalculatorButton
            // 
            this.ScientificCalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ScientificCalculatorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScientificCalculatorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ScientificCalculatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.ScientificCalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScientificCalculatorButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScientificCalculatorButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ScientificCalculatorButton.Location = new System.Drawing.Point(3, 112);
            this.ScientificCalculatorButton.Name = "ScientificCalculatorButton";
            this.ScientificCalculatorButton.Size = new System.Drawing.Size(280, 103);
            this.ScientificCalculatorButton.TabIndex = 2;
            this.ScientificCalculatorButton.Text = "Scientific";
            this.ScientificCalculatorButton.UseVisualStyleBackColor = false;
            this.ScientificCalculatorButton.Click += new System.EventHandler(this.HandleState);
            // 
            // BasicCalculatorController
            // 
            this.BasicCalculatorController.AutoSize = true;
            this.BasicCalculatorController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.BasicCalculatorController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicCalculatorController.EquationLabelValue = "";
            this.BasicCalculatorController.Location = new System.Drawing.Point(0, 0);
            this.BasicCalculatorController.Name = "BasicCalculatorController";
            this.BasicCalculatorController.Size = new System.Drawing.Size(602, 453);
            this.BasicCalculatorController.TabIndex = 0;
            this.BasicCalculatorController.UserInputTextValue = "";
            this.BasicCalculatorController.Load += new System.EventHandler(this.BasicCalculatorController_Load);
            // 
            // ViewManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(904, 453);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ViewManagerView";
            this.Text = "Calculator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button BasicCalculatorButton;
        private System.Windows.Forms.Button ScientificCalculatorButton;
        private BasicCalculatorView BasicCalculatorController;
    }
}

