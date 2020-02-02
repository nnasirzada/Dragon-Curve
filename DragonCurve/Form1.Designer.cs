namespace DragonCurve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberOfSteps = new System.Windows.Forms.NumericUpDown();
            this.length = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.angle = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfStpes = new System.Windows.Forms.Label();
            this.labelAngle = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfSteps
            // 
            this.numberOfSteps.Location = new System.Drawing.Point(13, 33);
            this.numberOfSteps.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfSteps.Name = "numberOfSteps";
            this.numberOfSteps.Size = new System.Drawing.Size(297, 22);
            this.numberOfSteps.TabIndex = 0;
            this.numberOfSteps.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // length
            // 
            this.length.DecimalPlaces = 1;
            this.length.Location = new System.Drawing.Point(13, 83);
            this.length.Margin = new System.Windows.Forms.Padding(4);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(297, 22);
            this.length.TabIndex = 1;
            this.length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // height
            // 
            this.height.DecimalPlaces = 1;
            this.height.Location = new System.Drawing.Point(13, 133);
            this.height.Margin = new System.Windows.Forms.Padding(4);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(297, 22);
            this.height.TabIndex = 2;
            this.height.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(13, 183);
            this.angle.Margin = new System.Windows.Forms.Padding(4);
            this.angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(297, 22);
            this.angle.TabIndex = 3;
            this.angle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // labelNumberOfStpes
            // 
            this.labelNumberOfStpes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberOfStpes.AutoSize = true;
            this.labelNumberOfStpes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfStpes.Location = new System.Drawing.Point(9, 9);
            this.labelNumberOfStpes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfStpes.Name = "labelNumberOfStpes";
            this.labelNumberOfStpes.Size = new System.Drawing.Size(118, 20);
            this.labelNumberOfStpes.TabIndex = 4;
            this.labelNumberOfStpes.Text = "Iteration Count";
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngle.Location = new System.Drawing.Point(9, 159);
            this.labelAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(51, 20);
            this.labelAngle.TabIndex = 5;
            this.labelAngle.Text = "Angle";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLength.Location = new System.Drawing.Point(9, 59);
            this.labelLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(194, 20);
            this.labelLength.TabIndex = 6;
            this.labelLength.Text = "Length of each segment ";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(9, 109);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(187, 20);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "Height of each segment";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(13, 217);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(297, 36);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.createHandler);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(13, 261);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(297, 36);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.openHandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 310);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.labelNumberOfStpes);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.height);
            this.Controls.Add(this.length);
            this.Controls.Add(this.numberOfSteps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dragon Curve";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberOfSteps;
        private System.Windows.Forms.NumericUpDown length;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.Label labelNumberOfStpes;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonOpen;
    }
}

