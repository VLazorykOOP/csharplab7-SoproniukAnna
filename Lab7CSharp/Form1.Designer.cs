namespace WindowsFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Button buttonMirrorImage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonMirrorImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(60, 74);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(200, 20);
            this.textBoxInfo.TabIndex = 0;
            this.textBoxInfo.TextChanged += new System.EventHandler(this.textBoxInfo_TextChanged);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(60, 114);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(100, 30);
            this.buttonInfo.TabIndex = 8;
            this.buttonInfo.Text = "Інформація";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(166, 114);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 30);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.MouseHover += new System.EventHandler(this.buttonExit_MouseHover);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(350, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(754, 533);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "Коло",
            "Квадрат",
            "Прямокутник"});
            this.comboBoxShape.Location = new System.Drawing.Point(60, 199);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(200, 21);
            this.comboBoxShape.TabIndex = 4;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(116, 254);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(100, 30);
            this.buttonDraw.TabIndex = 6;
            this.buttonDraw.Text = "Намалювати";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 315);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(315, 150);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "saveFileDialog";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(32, 503);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(100, 30);
            this.buttonLoadImage.TabIndex = 2;
            this.buttonLoadImage.Text = "Завантажити";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(116, 553);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveImage.TabIndex = 1;
            this.buttonSaveImage.Text = "Зберегти";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // buttonMirrorImage
            // 
            this.buttonMirrorImage.Location = new System.Drawing.Point(194, 503);
            this.buttonMirrorImage.Name = "buttonMirrorImage";
            this.buttonMirrorImage.Size = new System.Drawing.Size(100, 30);
            this.buttonMirrorImage.TabIndex = 0;
            this.buttonMirrorImage.Text = "Відзеркалити";
            this.buttonMirrorImage.UseVisualStyleBackColor = true;
            this.buttonMirrorImage.Click += new System.EventHandler(this.buttonMirrorImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 608);
            this.Controls.Add(this.buttonMirrorImage);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Name = "Form1";
            this.Text = "Task 1-3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}