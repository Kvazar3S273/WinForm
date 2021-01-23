using PhoneBook.DAL;
using PhoneBook.WindowsForms.Models;
using PhoneBook.WindowsForms.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.WindowsForms
{
    public partial class MainForm : Form
    {

        private readonly MyContext _context;
        
        // По замовчуванню - завжди будемо виводити першу сторінку з даними
        private int _page = 1;
        public MainForm()
        {
            // З"єднуємось з БД
            _context = new MyContext();
            
            // Відображаємо основну форму
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Відображаємо всіх абонентів (поки що пошуку по фільтру не було)
            SearchHuman();

            // Відображаємо комбобокс з можливістю вибрати бажану кількість записів,
            // що будуть відображатись на одній сторінці
            cbCountShowOnePage.Items.AddRange(
                new List<CustomComboBoxItem> {
                        new CustomComboBoxItem { Id=1, Name="10" },
                        new CustomComboBoxItem { Id=2, Name="20" },
                        new CustomComboBoxItem { Id=3, Name="30" },
                        new CustomComboBoxItem { Id=4, Name="50" }
                   }.ToArray()
                );
            cbCountShowOnePage.SelectedIndex = 0;
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            // Зчитуємо з кнопки її номер
            string s = (sender as Button).Text;

            // Задаємо номер сторінки, яку будемо виводити, згідно номеру кнопки
            _page = int.Parse(s);

            // Виводимо ту сторінку, номер якої натискали
            SearchHuman(GetSearchInputValue());
        }

        private void SearchHuman(SearchHuman search = null)
        {
            // Очищаємо датагрід
            dataGridView1.Rows.Clear();
            
            // Якщо результат пошуку порожній, то робимо новий пошук 
            // (створюємо екземпляр класу пошуку)
            search ??= new SearchHuman();

            // Будемо виводити з тої сторінки, яка на даний момент є, тобто по замовчуванню з першої
            search.Page = _page;

            // Створюємо змінну, яка буде містити дані, отримані в результаті пошуку по фільтру
            var result = HumanService.Search(_context, search);
            foreach (var item in result.Humans)
            {
                object[] row =
                {
                    item.Surname,
                    item.Name,
                    item.Gender,
                    item.Phone
                };
                dataGridView1.Rows.Add(row);
            }

            // Отримуємо значення початкового і кінцевого рядків для відображення цих значень
            // як діапазону знайдених абонентів (наприклад: Показано: 11-20)
            int begin = (_page - 1) * search.CountShowOnePage + 1;
            int end = begin + (search.CountShowOnePage - 1);
            lblRange.Text = $"Показано: {begin} - {end}";
            
            lblCount.Text = "Знайдено: " + result.CountRows.ToString() + " позицій";
            
            // Дізнаємось скільки всього сторінок потрібно вивести, щоб знати яку кількість кнопок 
            // маємо намалювати
            int totalPage = (int)Math.Ceiling((double)result.CountRows / search.CountShowOnePage);
            
            // Стартова позиція першої кнопки в групбоксі
            int positionX = 9;
            // Зміщення для наступної кнопки
            int dx = 45;
            
            // Щоразу очищаємо контроли групбоска
            gbBoxButton.Controls.Clear();

            // Виводимо кнопки
            // Робимо цикл не з 1 сторінки, а з _page, для того, 
            // щоб можна було рухатись кнопками вліво/вправо по всіх кнопках 1, 2, 3, ...
            for (int i = _page; i <= totalPage; i++) 
            {
                Button btn = new Button();
                btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
                btn.Location = new System.Drawing.Point(positionX, 17);
                btn.Name = $"btnPage{i}";
                btn.Size = new System.Drawing.Size(40, 40);
                btn.Text = $"{i}";
                btn.UseVisualStyleBackColor = true;
                btn.Click += new System.EventHandler(this.btnPage_Click);
                gbBoxButton.Controls.Add(btn);
                positionX += dx;
            }
        }

        // Обробка кнопки "Пошук"
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _page = 1;
            SearchHuman(GetSearchInputValue());
        }

        /// <summary>
        /// Отримуємо дані, які вводились користувачем в полях фільтра
        /// </summary>
        /// <returns></returns>
        private SearchHuman GetSearchInputValue()
        {
            SearchHuman search = new SearchHuman();
            search.Surname = tboxSurname.Text;
            search.Name = tboxName.Text;
            search.Phone = tboxPhone.Text;

            // Дізнаємось яку кількість сторінок для відображення вибрав користувач
            var countSelect = cbCountShowOnePage.SelectedItem as CustomComboBoxItem;
            search.CountShowOnePage = int.Parse(countSelect.Name);
            
            // Повертаємо результат пошуку
            return search;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // Рухаємось по сторінках вліво, але не далі першої сторінки
            if (_page > 1)
            {
                _page -= 1;
                SearchHuman(GetSearchInputValue());
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // Рухаємось по сторінках вправо
            _page += 1;
            SearchHuman(GetSearchInputValue());
        }
    }
}
