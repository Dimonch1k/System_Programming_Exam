namespace Exam
{
    partial class SemaphoreApp
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
            this.workingList = new System.Windows.Forms.ListBox();
            this.waitingList = new System.Windows.Forms.ListBox();
            this.creatingList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.semaphorePlaces = new System.Windows.Forms.NumericUpDown();
            this.createThreadBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.semaphorePlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // workingList
            // 
            this.workingList.FormattingEnabled = true;
            this.workingList.Location = new System.Drawing.Point(560, 53);
            this.workingList.Name = "workingList";
            this.workingList.Size = new System.Drawing.Size(251, 95);
            this.workingList.TabIndex = 1;
            // 
            // waitingList
            // 
            this.waitingList.FormattingEnabled = true;
            this.waitingList.Location = new System.Drawing.Point(292, 53);
            this.waitingList.Name = "waitingList";
            this.waitingList.Size = new System.Drawing.Size(251, 95);
            this.waitingList.TabIndex = 2;
            // 
            // creatingList
            // 
            this.creatingList.FormattingEnabled = true;
            this.creatingList.Location = new System.Drawing.Point(24, 53);
            this.creatingList.Name = "creatingList";
            this.creatingList.Size = new System.Drawing.Size(251, 95);
            this.creatingList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Working threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Waiting threads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Created threads";
            // 
            // semaphorePlaces
            // 
            this.semaphorePlaces.Location = new System.Drawing.Point(292, 181);
            this.semaphorePlaces.Name = "semaphorePlaces";
            this.semaphorePlaces.Size = new System.Drawing.Size(119, 20);
            this.semaphorePlaces.TabIndex = 7;
            // 
            // createThreadBtn
            // 
            this.createThreadBtn.Location = new System.Drawing.Point(430, 178);
            this.createThreadBtn.Name = "createThreadBtn";
            this.createThreadBtn.Size = new System.Drawing.Size(113, 23);
            this.createThreadBtn.TabIndex = 8;
            this.createThreadBtn.Text = "Create Thread";
            this.createThreadBtn.UseVisualStyleBackColor = true;
            this.createThreadBtn.Click += new System.EventHandler(this.createThreadBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Places in semaphore";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(560, 230);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 95);
            this.listBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Completed threads";
            // 
            // SemaphoreApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 435);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createThreadBtn);
            this.Controls.Add(this.semaphorePlaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creatingList);
            this.Controls.Add(this.waitingList);
            this.Controls.Add(this.workingList);
            this.Name = "SemaphoreApp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.semaphorePlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox workingList;
        private System.Windows.Forms.ListBox waitingList;
        private System.Windows.Forms.ListBox creatingList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown semaphorePlaces;
        private System.Windows.Forms.Button createThreadBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
    }
}

