using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfanasevGlava6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.AllowDrop = true;
            this.richTextBox1.DragEnter +=
            new System.Windows.Forms.DragEventHandler(
            this.richTextBox1_DragEnter);
            this.richTextBox1.DragDrop +=
            new System.Windows.Forms.DragEventHandler(
            this.richTextBox1_DragEnter);

            RichTextBoxEx rboxex = new RichTextBoxEx();
            rboxex.Parent = this;
            rboxex.Top = 400;
        }
        class RichTextBoxEx : RichTextBox
        {
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                //Проверяем на нажатие Shift+Insert и Ctrl+V
                if ((keyData & (Keys.Shift | Keys.Insert)) ==
                (Keys.Shift | Keys.Insert)
                || ((keyData & (Keys.Control | Keys.V)) ==
                (Keys.Control | Keys.V)))

                    return true;
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void richTextBox1_DragEnter(object sender,
            System.Windows.Forms.DragEventArgs e)
        {
            if (((DragEventArgs)e).Data.GetDataPresent(DataFormats.Text))
                ((DragEventArgs)e).Effect = DragDropEffects.Move;
            else
                ((DragEventArgs)e).Effect = DragDropEffects.None;
        }
        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            richTextBox1.LoadFile((String)e.Data.GetData("Text"),
            System.Windows.Forms.RichTextBoxStreamType.RichText);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Rtf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус на richTextBox
            richTextBox1.Focus();
            // Устанавливаем цвет для выделенного текста
            richTextBox1.SelectionColor = Color.Red;
            // Устанавливаем шрифт
            richTextBox1.SelectionFont = new Font("Courier", 10, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус
            dateTimePicker1.Focus();
            // Посылаем команду
            SendKeys.Send("{F4}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(60, 255, 192, 192);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lnkMySite.Text = "На нашем сайте вы найдете дополнительную информацию";
            lnkMySite.LinkArea = new LinkArea(3, 17);
        }

        private void lnkMySite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://rusproject.narod.ru/");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (notifyIcon1.Visible)
                notifyIcon1.Visible = false;
            else
                notifyIcon1.Visible = true;
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            notifyIcon1.Visible = true;
            MessageBox.Show("Мигание приостановлено");
        }


        private void button8_Click(object sender, EventArgs e)
        {
            lnkMySite.Text = "На нашем сайте вы найдете дополнительную информацию";
            lnkMySite.LinkArea = new LinkArea(3, 11);
        }
        private void lnkCommon_LinkClicked(object sender,
       LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel lnk = new LinkLabel();
            lnk = (LinkLabel)sender;
            lnk.Links[lnk.Links.IndexOf(e.Link)].Visited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lnkSearchUrl.Text = "Yandex Google Rambler GoGo";
            lnkSearchUrl.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkSearchUrl.Links.Add(0, 6, "www.yandex.ru");
            lnkSearchUrl.Links.Add(7, 6, "www.google.ru");
            lnkSearchUrl.Links.Add(14, 7, "www.rambler.ru");
            lnkSearchUrl.Links.Add(22, 4, "www.gogo.ru");
            lnkSearchUrl.LinkClicked += new LinkLabelLinkClickedEventHandler(lnkCommon_LinkClicked);
        }
        private void notifyIcon1_DoubleClick(object sender,System.EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.listView1.SelectedItems.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Установим фокус
            listView1.Focus();
            // Выбираем второй элемент
            listView1.Items[1].Selected = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Вставьте следующий код в обработчик события Load формы
            // Используется для создания заголовков
            ColumnHeader columnheader;
            // Используется для создания элементов в ListView
            ListViewItem listviewitem;
            // Устанавливаем нужный вид
            listView1.View = View.Details;
            // Создаем несколько элементов, содержащих имена и фамилии
            listviewitem = new ListViewItem("Александр");
            listviewitem.SubItems.Add("Суворов");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Наполеон");
            listviewitem.SubItems.Add("Бонапарт");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Михаил");
            listviewitem.SubItems.Add("Кутузов");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Юлий");
            listviewitem.SubItems.Add("Цезарь");
            this.listView1.Items.Add(listviewitem);
            // Создаем колонки
            columnheader = new ColumnHeader();
            columnheader.Text = "Имя";
            this.listView1.Columns.Add(columnheader);
            columnheader = new ColumnHeader();
            columnheader.Text = "Фамилия";
            this.listView1.Columns.Add(columnheader);
 // Проходим через все элементы и устанавливаем размер каждого
 // заголовка колонки равным тексту
            foreach (ColumnHeader ch in this.listView1.Columns) { ch.Width = -2; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}