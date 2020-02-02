namespace DragonCurve
{
    partial class OpenObject
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
            this.SuspendLayout();
            // 
            // OpenObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 672);
            this.Name = "OpenObject";
            this.Text = "OpenObject";
            this.Shown += new System.EventHandler(this.OpenObject_Shown);
            this.SizeChanged += new System.EventHandler(this.OpenObject_SizeChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OpenObject_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
    }
}