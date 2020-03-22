namespace MathCalculatio
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxForX = new System.Windows.Forms.TextBox();
            this.textBoxForY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInputKeyBoard = new System.Windows.Forms.Button();
            this.buttonInputRand = new System.Windows.Forms.Button();
            this.buttonInputFile = new System.Windows.Forms.Button();
            this.pictureGraphic = new System.Windows.Forms.PictureBox();
            this.picturePoint = new System.Windows.Forms.PictureBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonSaveRes = new System.Windows.Forms.Button();
            this.buttonInputOnGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "По заданным координатам точки определить, где находится точка:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберете способ ввода координат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "x:";
            // 
            // textBoxForX
            // 
            this.textBoxForX.Enabled = false;
            this.textBoxForX.Location = new System.Drawing.Point(61, 135);
            this.textBoxForX.Name = "textBoxForX";
            this.textBoxForX.Size = new System.Drawing.Size(100, 20);
            this.textBoxForX.TabIndex = 6;
            // 
            // textBoxForY
            // 
            this.textBoxForY.Enabled = false;
            this.textBoxForY.Location = new System.Drawing.Point(208, 135);
            this.textBoxForY.Name = "textBoxForY";
            this.textBoxForY.Size = new System.Drawing.Size(100, 20);
            this.textBoxForY.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "y:";
            // 
            // buttonInputKeyBoard
            // 
            this.buttonInputKeyBoard.Location = new System.Drawing.Point(33, 80);
            this.buttonInputKeyBoard.Name = "buttonInputKeyBoard";
            this.buttonInputKeyBoard.Size = new System.Drawing.Size(130, 23);
            this.buttonInputKeyBoard.TabIndex = 9;
            this.buttonInputKeyBoard.Text = "Ввод с клавиатуры";
            this.buttonInputKeyBoard.UseVisualStyleBackColor = true;
            this.buttonInputKeyBoard.Click += new System.EventHandler(this.buttonInputKeyBoard_Click);
            // 
            // buttonInputRand
            // 
            this.buttonInputRand.Location = new System.Drawing.Point(201, 80);
            this.buttonInputRand.Name = "buttonInputRand";
            this.buttonInputRand.Size = new System.Drawing.Size(177, 23);
            this.buttonInputRand.TabIndex = 10;
            this.buttonInputRand.Text = "Ввод с помощью функции rand()";
            this.buttonInputRand.UseVisualStyleBackColor = true;
            this.buttonInputRand.Click += new System.EventHandler(this.buttonInputRand_Click);
            // 
            // buttonInputFile
            // 
            this.buttonInputFile.Location = new System.Drawing.Point(412, 80);
            this.buttonInputFile.Name = "buttonInputFile";
            this.buttonInputFile.Size = new System.Drawing.Size(113, 23);
            this.buttonInputFile.TabIndex = 11;
            this.buttonInputFile.Text = "Ввод из файла";
            this.buttonInputFile.UseVisualStyleBackColor = true;
            this.buttonInputFile.Click += new System.EventHandler(this.buttonInputFile_Click);
            // 
            // pictureGraphic
            // 
            this.pictureGraphic.Image = ((System.Drawing.Image)(resources.GetObject("pictureGraphic.Image")));
            this.pictureGraphic.Location = new System.Drawing.Point(721, 22);
            this.pictureGraphic.Name = "pictureGraphic";
            this.pictureGraphic.Size = new System.Drawing.Size(600, 600);
            this.pictureGraphic.TabIndex = 13;
            this.pictureGraphic.TabStop = false;
            this.pictureGraphic.Click += new System.EventHandler(this.pictureGraphic_Click);
            // 
            // picturePoint
            // 
            this.picturePoint.Image = ((System.Drawing.Image)(resources.GetObject("picturePoint.Image")));
            this.picturePoint.Location = new System.Drawing.Point(460, 143);
            this.picturePoint.Name = "picturePoint";
            this.picturePoint.Size = new System.Drawing.Size(8, 8);
            this.picturePoint.TabIndex = 14;
            this.picturePoint.TabStop = false;
            this.picturePoint.Visible = false;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(328, 211);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(197, 23);
            this.buttonResult.TabIndex = 15;
            this.buttonResult.Text = "Определение положения точки";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonSaveRes
            // 
            this.buttonSaveRes.Enabled = false;
            this.buttonSaveRes.Location = new System.Drawing.Point(328, 262);
            this.buttonSaveRes.Name = "buttonSaveRes";
            this.buttonSaveRes.Size = new System.Drawing.Size(197, 23);
            this.buttonSaveRes.TabIndex = 16;
            this.buttonSaveRes.Text = "Сохранение результата в файл";
            this.buttonSaveRes.UseVisualStyleBackColor = true;
            this.buttonSaveRes.Click += new System.EventHandler(this.buttonSaveRes_Click);
            // 
            // buttonInputOnGraph
            // 
            this.buttonInputOnGraph.Location = new System.Drawing.Point(552, 80);
            this.buttonInputOnGraph.Name = "buttonInputOnGraph";
            this.buttonInputOnGraph.Size = new System.Drawing.Size(150, 23);
            this.buttonInputOnGraph.TabIndex = 17;
            this.buttonInputOnGraph.Text = "Ввод с помощью мыши";
            this.buttonInputOnGraph.UseMnemonic = false;
            this.buttonInputOnGraph.UseVisualStyleBackColor = true;
            this.buttonInputOnGraph.Click += new System.EventHandler(this.buttonInputOnGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 642);
            this.Controls.Add(this.buttonInputOnGraph);
            this.Controls.Add(this.buttonSaveRes);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.picturePoint);
            this.Controls.Add(this.pictureGraphic);
            this.Controls.Add(this.buttonInputFile);
            this.Controls.Add(this.buttonInputRand);
            this.Controls.Add(this.buttonInputKeyBoard);
            this.Controls.Add(this.textBoxForY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxForX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MathCalculatio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGraphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxForX;
        private System.Windows.Forms.TextBox textBoxForY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInputKeyBoard;
        private System.Windows.Forms.Button buttonInputRand;
        private System.Windows.Forms.Button buttonInputFile;
        private System.Windows.Forms.PictureBox pictureGraphic;
        private System.Windows.Forms.PictureBox picturePoint;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonSaveRes;
        private System.Windows.Forms.Button buttonInputOnGraph;
    }
}

