
namespace AfanasevGlava6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lnkMySite = new System.Windows.Forms.LinkLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.lnkSearchUrl = new System.Windows.Forms.LinkLabel();
            this.lnkCommon = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(179, 73);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 71);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Получить строку";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Управление цветом и шрифтом в RichTextBox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(557, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = " Вывод пустого текста в DateTimePicker";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = " Программное раскрытие списка DateTimePicker";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(401, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Проверочная надпись на панеле";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(344, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "6.38. Создание полупрозрачной надписи и панели";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lnkMySite
            // 
            this.lnkMySite.AutoSize = true;
            this.lnkMySite.Location = new System.Drawing.Point(441, 434);
            this.lnkMySite.Name = "lnkMySite";
            this.lnkMySite.Size = new System.Drawing.Size(55, 13);
            this.lnkMySite.TabIndex = 9;
            this.lnkMySite.TabStop = true;
            this.lnkMySite.Text = "linkLabel1";
            this.lnkMySite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMySite_LinkClicked);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(344, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 40);
            this.button6.TabIndex = 10;
            this.button6.Text = " 6.40. Обработчик события LinkClicked";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(344, 385);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 40);
            this.button7.TabIndex = 11;
            this.button7.Text = " 6.44. Создание мигающего значка";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(344, 293);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(152, 40);
            this.button8.TabIndex = 12;
            this.button8.Text = " 6.39. Установка свойств для LinkLabel";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lnkSearchUrl
            // 
            this.lnkSearchUrl.AutoSize = true;
            this.lnkSearchUrl.Location = new System.Drawing.Point(655, 307);
            this.lnkSearchUrl.Name = "lnkSearchUrl";
            this.lnkSearchUrl.Size = new System.Drawing.Size(62, 13);
            this.lnkSearchUrl.TabIndex = 13;
            this.lnkSearchUrl.TabStop = true;
            this.lnkSearchUrl.Text = "lnkCommon";
            // 
            // lnkCommon
            // 
            this.lnkCommon.AutoSize = true;
            this.lnkCommon.Location = new System.Drawing.Point(655, 366);
            this.lnkCommon.Name = "lnkCommon";
            this.lnkCommon.Size = new System.Drawing.Size(62, 13);
            this.lnkCommon.TabIndex = 14;
            this.lnkCommon.TabStop = true;
            this.lnkCommon.Text = "lnkCommon";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(543, 104);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(152, 40);
            this.button9.TabIndex = 15;
            this.button9.Text = " 6.47. Снятие выделения с элемента";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 234);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 155);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(543, 150);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(152, 40);
            this.button10.TabIndex = 17;
            this.button10.Text = "6.48. Программное выделение элемента в ListView";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(543, 201);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(152, 40);
            this.button11.TabIndex = 18;
            this.button11.Text = " 6.50. Код, добавляемый в обработчик события Load";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(625, 551);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(132, 36);
            this.button12.TabIndex = 19;
            this.button12.Text = "Переход на другую форму";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 599);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.lnkCommon);
            this.Controls.Add(this.lnkSearchUrl);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lnkMySite);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.LinkLabel lnkMySite;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.LinkLabel lnkSearchUrl;
        private System.Windows.Forms.LinkLabel lnkCommon;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

