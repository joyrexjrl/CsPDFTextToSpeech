
namespace Bed_Time_Story
{
    partial class AddNotes
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
            this.NotesBackButton = new System.Windows.Forms.Button();
            this.notesTextbox = new System.Windows.Forms.TextBox();
            this.notesSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotesBackButton
            // 
            this.NotesBackButton.Location = new System.Drawing.Point(390, 657);
            this.NotesBackButton.Name = "NotesBackButton";
            this.NotesBackButton.Size = new System.Drawing.Size(75, 23);
            this.NotesBackButton.TabIndex = 0;
            this.NotesBackButton.Text = "Back";
            this.NotesBackButton.UseVisualStyleBackColor = true;
            this.NotesBackButton.Click += new System.EventHandler(this.NotesBackButton_Click);
            // 
            // notesTextbox
            // 
            this.notesTextbox.Location = new System.Drawing.Point(12, 12);
            this.notesTextbox.Multiline = true;
            this.notesTextbox.Name = "notesTextbox";
            this.notesTextbox.Size = new System.Drawing.Size(453, 639);
            this.notesTextbox.TabIndex = 1;
            // 
            // notesSaveButton
            // 
            this.notesSaveButton.Location = new System.Drawing.Point(309, 657);
            this.notesSaveButton.Name = "notesSaveButton";
            this.notesSaveButton.Size = new System.Drawing.Size(75, 23);
            this.notesSaveButton.TabIndex = 2;
            this.notesSaveButton.Text = "Save";
            this.notesSaveButton.UseVisualStyleBackColor = true;
            this.notesSaveButton.Click += new System.EventHandler(this.notesSaveButton_Click);
            // 
            // AddNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 692);
            this.Controls.Add(this.notesSaveButton);
            this.Controls.Add(this.notesTextbox);
            this.Controls.Add(this.NotesBackButton);
            this.Name = "AddNotes";
            this.Text = "AddNotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NotesBackButton;
        private System.Windows.Forms.TextBox notesTextbox;
        private System.Windows.Forms.Button notesSaveButton;
    }
}