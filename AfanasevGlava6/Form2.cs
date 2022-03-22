using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace AfanasevGlava6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            // Create a root node.
            TreeNode rootNode = treeView1.Nodes.Add("Коты");
            TreeNode childNode = rootNode.Nodes.Add("Барсик");
            childNode.Tag = "Барсик - большой и умный кот";
            childNode = rootNode.Nodes.Add("Рыжик");
            childNode.Tag = "Рыжик - очень любопытный кот";
            childNode = rootNode.Nodes.Add("Мурзик");
            childNode.Tag = "Мурзик - ленивый кот";
            childNode = rootNode.Nodes.Add("Пушок");
            childNode.Tag = "Пушок - белый и пушистый кот";
            // Раскрываем все узлы дерева
            rootNode.ExpandAll();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
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
            // Create a root node.
            TreeNode rootNode = treeView1.Nodes.Add("Коты");
            TreeNode childNode = rootNode.Nodes.Add("Барсик");
            childNode.Tag = "Барсик - большой и умный кот";
            childNode = rootNode.Nodes.Add("Рыжик");
            childNode.Tag = "Рыжик - очень любопытный кот";
            childNode = rootNode.Nodes.Add("Мурзик");
            childNode.Tag = "Мурзик - ленивый кот";
            childNode = rootNode.Nodes.Add("Пушок");
            childNode.Tag = "Пушок - белый и пушистый кот";
            // Раскрываем все узлы дерева
            rootNode.ExpandAll();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Вставляем следующий код в событие ColumnClick для элемента ListView
            // Определяем, является ли колонка, на которой щелкнули, уже
            // отсортированной колонкой
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Переворачиваем направление сортировки
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Устанавливаем колонку для сортировки
                // По умолчанию сортировка по возрастанию
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            // Сортируем с новыми настройками
            this.listView1.Sort();
        }


            public class ListViewColumnSorter : IComparer
        {
            /// <summary>
            /// Номер колонки, по которой проводится сортировка
            /// </summary>
            private int ColumnToSort;
            /// <summary>
            /// Порядок, в котором проводится сортировка (например 'Ascending')
            /// </summary>
            private SortOrder OrderOfSort;
            /// <summary>
            /// Объект, проводящий нечувствительную к регистру сортировку
            /// </summary>
            private CaseInsensitiveComparer ObjectCompare;
            /// <summary>
            /// Конструктор. Инициализирует различные элементы
            /// </summary>
            public ListViewColumnSorter()
            {
                // Инициализировать колонку значением 0
                ColumnToSort = 0;
                // Иниацилизировать порядок сортировки значением 'none'
                OrderOfSort = SortOrder.None;
                // Инициализировать объект CaseInsensitiveComparer
                ObjectCompare = new CaseInsensitiveComparer();
            }
            /// <summary>
            /// Этот метод унаследован от интерфейса IComparer. Он сравнивает
            /// два переданных ему объекта, не обращая внимания на регистр
            /// </summary>
            /// <param name="x">Первый объект для сравнения</param>
            /// <param name="y">Второй объект для сравнения</param>
            /// <returns>Результат сравнения. '0' в случае равенства,
            /// отрицательный если 'x' меньше 'y' и положительный
            /// если 'x' больше 'y'</returns>
            public int Compare(object x, object y)
            {
                int compareResult;
                ListViewItem listviewX, listviewY;
             
            // Преобразует объекты для сравнения в объекты ListViewItem
 listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;
                // Сравнивает 2 значения
                compareResult = ObjectCompare.Compare(
                listviewX.SubItems[ColumnToSort].Text,
                listviewY.SubItems[ColumnToSort].Text);
                // Подсчитывает возвращаемый результат, базируясь на результате
                // сравнения
                if (OrderOfSort == SortOrder.Ascending)
                {
                    // Выбрана сортировка по возрастанию, возвращаем результат
                    // операции сравнения
                    return compareResult;
                }
                else if (OrderOfSort == SortOrder.Descending)
                {
                    // Выбрана сортировка по убыванию, возвращаем результат
                    // операции сравнения со знаком минус
                    return (-compareResult);
                }
                else
                {
                    // Возвращаем 0, чтобы показать равенство
                    return 0;
                }
            }
            /// <summary>
            /// Получает или возвращает номер колонки, к которой применять
            /// сортировку (по умолчанию 0).
            /// </summary>
            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }
            }
            
 /// <summary>
 /// Устанавливает порядок сортировки (например, 'Ascending').
 /// </summary>
            public SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView2.Items.Add("Алла");
            listView2.Items.Add("София");
            listView2.Items[0].UseItemStyleForSubItems = false;
            listView2.Items[0].SubItems.Add("Пугачева", Color.Pink,
            Color.Yellow, Font);
            listView2.Items[1].UseItemStyleForSubItems = false;
            listView2.Items[1].SubItems.Add("Ротару", Color.Teal,
            Color.Violet, Font);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.button2,
 "Это кнопка\r\nСамая обычная кнопка");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            if ((int)Microsoft.Win32.Registry.GetValue(
        @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Ad
vanced",


         "EnableBalloonTips", 1) == 0)
            {
                // Не использовать стиль Balloon
                this.Text = "Not use Balloon style";
            }
            else
            {
                this.toolTip1.IsBalloon = true;
            }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Получим узел в текущей позиции мыши
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);
            // Установим ToolTip, только если мышь задержалась на узле
            if ((theNode != null))
               
 {
                // Проверяем, что свойство tag не пустое
                if (theNode.Tag != null)
                {
                    // Меняем ToolTip, если мышь переместилась на другой узел
                    if (theNode.Tag.ToString() !=
                    this.toolTip1.GetToolTip(this.treeView1))
                    {
                        this.toolTip1.SetToolTip(this.treeView1,
                        theNode.Tag.ToString());
                    }
                }
                else
                {
                    this.toolTip1.SetToolTip(this.treeView1, "");
                }
                }
                else // Если указатель не над узлом, то очистим подсказку
                {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }
    }
}
    

