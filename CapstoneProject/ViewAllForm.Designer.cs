namespace CapstoneProject
{
    partial class ViewAllForm
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
            this.viewAllListBox = new System.Windows.Forms.ListBox();
            this.addTaskButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewAllListBox
            // 
            this.viewAllListBox.FormattingEnabled = true;
            this.viewAllListBox.ItemHeight = 15;
            this.viewAllListBox.Location = new System.Drawing.Point(29, 22);
            this.viewAllListBox.Name = "viewAllListBox";
            this.viewAllListBox.ScrollAlwaysVisible = true;
            this.viewAllListBox.Size = new System.Drawing.Size(397, 439);
            this.viewAllListBox.TabIndex = 0;
            // 
            // addTaskButton2
            // 
            this.addTaskButton2.Location = new System.Drawing.Point(351, 467);
            this.addTaskButton2.Name = "addTaskButton2";
            this.addTaskButton2.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton2.TabIndex = 1;
            this.addTaskButton2.Text = "Add Task";
            this.addTaskButton2.UseVisualStyleBackColor = true;
            // 
            // ViewAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 507);
            this.Controls.Add(this.addTaskButton2);
            this.Controls.Add(this.viewAllListBox);
            this.Name = "ViewAllForm";
            this.Text = "ViewAllForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox viewAllListBox;
        private Button addTaskButton2;
    }
}