namespace TimedMathQuiz
{
    partial class TimedMathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimedMathQuiz));
            this.date = new System.Windows.Forms.Label();
            this.tineLeft = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(33, 36);
            this.date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 14);
            this.date.TabIndex = 0;
            // 
            // tineLeft
            // 
            this.tineLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tineLeft.Location = new System.Drawing.Point(170, 28);
            this.tineLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tineLeft.Name = "tineLeft";
            this.tineLeft.Size = new System.Drawing.Size(112, 25);
            this.tineLeft.TabIndex = 1;
            this.tineLeft.Text = "Time Left";
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.timeLabel.Location = new System.Drawing.Point(304, 28);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(150, 25);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AllowDrop = true;
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plusLeftLabel.Location = new System.Drawing.Point(34, 81);
            this.plusLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(24, 29);
            this.plusLeftLabel.TabIndex = 12;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(216, 326);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 26);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AllowDrop = true;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plusRightLabel.Location = new System.Drawing.Point(170, 81);
            this.plusRightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(24, 29);
            this.plusRightLabel.TabIndex = 17;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(107, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(248, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(306, 87);
            this.sum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(150, 20);
            this.sum.TabIndex = 2;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(306, 145);
            this.difference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(150, 20);
            this.difference.TabIndex = 3;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(248, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(107, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AllowDrop = true;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minusRightLabel.Location = new System.Drawing.Point(170, 140);
            this.minusRightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(24, 29);
            this.minusRightLabel.TabIndex = 22;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AllowDrop = true;
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minusLeftLabel.Location = new System.Drawing.Point(34, 140);
            this.minusLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(24, 29);
            this.minusLeftLabel.TabIndex = 21;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(306, 207);
            this.product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(150, 20);
            this.product.TabIndex = 4;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(248, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(107, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.AllowDrop = true;
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timesRightLabel.Location = new System.Drawing.Point(170, 202);
            this.timesRightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(24, 29);
            this.timesRightLabel.TabIndex = 27;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.AllowDrop = true;
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timesLeftLabel.Location = new System.Drawing.Point(34, 202);
            this.timesLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(24, 29);
            this.timesLeftLabel.TabIndex = 26;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Location = new System.Drawing.Point(306, 266);
            this.quotient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(150, 20);
            this.quotient.TabIndex = 5;
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label11.Location = new System.Drawing.Point(248, 260);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 29);
            this.label11.TabIndex = 34;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label12.Location = new System.Drawing.Point(107, 260);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 29);
            this.label12.TabIndex = 33;
            this.label12.Text = "/";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.AllowDrop = true;
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dividedRightLabel.Location = new System.Drawing.Point(170, 260);
            this.dividedRightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(24, 29);
            this.dividedRightLabel.TabIndex = 32;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.AllowDrop = true;
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dividedLeftLabel.Location = new System.Drawing.Point(34, 260);
            this.dividedLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(24, 29);
            this.dividedLeftLabel.TabIndex = 31;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(36, 35);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(114, 16);
            this.dateLabel.TabIndex = 35;
            this.dateLabel.Text = "DD MMMM YYYY";
            // 
            // TimedMathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 376);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.tineLeft);
            this.Controls.Add(this.date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TimedMathQuiz";
            this.Text = "Alex Matheson\'s Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label tineLeft;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.Label dateLabel;
    }
}

