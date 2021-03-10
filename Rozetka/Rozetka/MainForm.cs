using Rozetka.Entities;
using Rozetka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozetka
{
    public partial class MainForm : Form
    {
        private readonly EFContext _context;
        public IQueryable<FilterName> filter { get; set; }

        /// <summary>
        /// Точка відліку для першого графічного елемента (відступ по осі Х)
        /// </summary>
        const int startX = 15;

        /// <summary>
        /// Точка відліку для першого графічного елемента (відступ по осі У)
        /// </summary>
        const int startY = 15;
        public int StartByY { get; set; } = 1;

        /// <summary>
        /// Інтервал між графічними елементами в пікселях
        /// </summary>
        const int interval = 8;
        
        /// <summary>
        /// Висота одного чекбокса
        /// </summary>
        const int checkBoxHeight = 15;

        /// <summary>
        /// Зміщення по осі У для першого фільтра
        /// </summary>
        public int dy1 { get; set; } 

        /// <summary>
        /// Зміщення по осі У для другого фільтра
        /// </summary>
        public int dy2 { get; set; }

        /// <summary>
        /// Кількість дітей першого фільтра
        /// </summary>
        public int CountOfBrands { get; set; }

        /// <summary>
        /// Кількість дітей фільтра
        /// </summary>
        public int CountChildrenOfFilter { get; set; }

        /// <summary>
        /// Кількість дітей першого фільтра
        /// </summary>
        public int CountOfPowers { get; set; }






        /// <summary>
        /// Кількість елементів у Лісті значень імен(кількість імен фільтрів)
        /// </summary>
        public int count { get; set; }

        public int count_child { get; set; }

        int X { get; set; } = 10;

        int Y { get; set; } = 10;

        const int chb_height = 15;

        int kol = 0;

        Panel pan;

        public int btnHeight { get; set; } = 48;
        public int btnWidth { get; set; } = 125;

        public MainForm()
        {
            InitializeComponent();
            _context = new EFContext();
            //Seeder.SeedDatabase(_context);
            LoadForm();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
            SuspendLayout();
            Seeder.SeedDatabase(_context);
            LoadForm();
        }
        private void LoadForm()
        {


            var collection = GetListFilters();
            List<string> names = new List<string>();

            //Отримую множину значень імен.
            var result = from b in collection select b.Name;

            foreach (var item in result)
            {
                names.Add(item);
            }
            count = names.Count;



            for (int i = 0; i < count; i++)
            {
                
                Button[] btnNameFilter = new Button[count];
                btnNameFilter[i] = new Button();
                btnNameFilter[i].Location = new Point(X, Y + i * 50);
                btnNameFilter[i].Name = $"btnNameFilter{i}";
                btnNameFilter[i].Size = new Size(btnWidth, btnHeight);
                btnNameFilter[i].Text = names[i];
                Controls.Add(btnNameFilter[i]);
                btnNameFilter[i].Click += new EventHandler(btnNameFilter_Click);

                ///Panel[] panel = new Panel[count];
                ///panel[i] = new Panel();
                ///panel[i].BackColor = System.Drawing.Color.Transparent;
                ///panel[i].Location = new Point(X * 2, Y + btnNameFilter[i].Height + interval);
                ///panel[i].Name = $"{panel[i]}";
                ///panel[i].Size = new Size(173, 0);
                ///panel[i].Controls.Add(btnNameFilter[i]);
                ///Controls.Add(panel[i]);
                ///panel[i].Visible = false;
                ///List<string> child = new List<string>();
                ///var res_child = from b in collection
                ///                where b.Name == btnNameFilter[i].Text
                ///                select b.Children;
                ///foreach (var item in res_child)
                ///{
                ///    foreach (var it in item)
                ///    {
                ///        child.Add(it.Name);
                ///    }
                ///}
                ///count_child = child.Count();
                ///foreach (var item in child)
                ///{
                ///    CheckBox chb = new CheckBox();
                ///    chb.AutoSize = true;
                ///    chb.Location = new System.Drawing.Point(1, dy1);
                ///    chb.Size = new System.Drawing.Size(82, chb_height);
                ///    chb.Text = item.ToString();
                ///    chb.UseVisualStyleBackColor = true;
                ///    btnNameFilter[i].Controls.Add(chb);
                ///    // Зміщуємо виведення наступного чекбокса на його висоту + інтервал
                ///    dy1 = dy1 + chb_height + interval;
                ///}


                void btnNameFilter_Click(object sender, EventArgs e)
                {

                    //Panel pan = new Panel();                   
                    kol++;

                    if (kol % 2 != 0)
                    {

                        pan = new Panel();
                        List<string> child = new List<string>();
                        var res_child = from b in collection
                                        where b.Name == (sender as Button).Text
                                        select b.Children;

                        foreach (var item in res_child)
                        {
                            foreach (var it in item)
                            {
                                child.Add(it.Value);
                            }
                        }
                        count_child = child.Count();
                       
                        pan.Location = new Point(X, btnHeight * i + interval * 2);
                        pan.Size = new Size(btnWidth, 0);
                        pan.BackColor = Color.Transparent;
                        //pan.AutoScroll = true;
                        Controls.Add(pan);
                        pan.Visible = true;
                        dy1 = 0;
                        foreach (var item in child)
                        {
                            CheckBox chb = new CheckBox();
                            chb.AutoSize = true;
                            chb.Location = new System.Drawing.Point(1, dy1);
                            chb.Size = new System.Drawing.Size(82, chb_height);
                            chb.Text = item.ToString();
                            chb.UseVisualStyleBackColor = true;
                            pan.Controls.Add(chb);
                            // Зміщуємо виведення наступного чекбокса на його висоту + інтервал
                            dy1 = dy1 + chb_height + interval;
                        }
                        var height = (chb_height + interval) * count_child;
                        pan.Height = height;
                    }
                    else
                    {
                        pan.Controls.Clear();
                        for (int i = 0; i < pan.Controls.Count; i++)
                        {
                            pan.Controls[i].Enabled = false;
                            pan.Controls[i].Dispose();
                            i--;
                        }

                        if (pan.Controls.Count == 0)
                        {
                            Controls.Remove(pan);
                            pan.Dispose();
                        }
                    }
                }
            }








            #region Спроба вивести динамічно
            //List<string> namesOfFilter = new List<string>();
            //var takeFilters = GetListFilters();
            //var allFilters = from x in takeFilters
            //                 where x.Id != 0
            //                 select x.Name;
            //int countsFilters = 0;
            //foreach (var item in allFilters)
            //{
            //    namesOfFilter.Add(item);
            //    countsFilters++;
            //}
            //MessageBox.Show($"{countsFilters}");


            //for (int i = 0; i < countsFilters; i++)
            //{
            //    // Кнопка збереження вибраних значень чекбоксів
            //    Button[] btnSaveChoiceFilter = new Button[countsFilters];

            //    // Панель фільтра
            //    Panel[] pnlFilter = new Panel[countsFilters];

            //    // Кнопка фільтра
            //    Button[] btnFilter = new Button[countsFilters];



            //    btnFilter[i] = new System.Windows.Forms.Button();
            //    btnFilter[i].Location = new System.Drawing.Point(startX, startY + i*100);
            //    btnFilter[i].Name = $"{btnFilter[i]}";
            //    btnFilter[i].Size = new System.Drawing.Size(131, 38);
            //    btnFilter[i].Text = $"{namesOfFilter[i]}";
            //    btnFilter[i].UseVisualStyleBackColor = true;
            //    Controls.Add(btnFilter[i]);
            //    btnFilter[i].Click += new System.EventHandler(btnFilter_Click);

            //    // Створюємо список дітей фільтра (витягуємо з БД)
            //    List<string> childrensItemFilter = new List<string>();
            //    var result = from x in GetListFilters()
            //                 where x.Name == btnFilter[i].Text
            //                 select x.Children;
            //    foreach (var item in result)
            //    {
            //        foreach (var it in item)
            //        {
            //            childrensItemFilter.Add(it.Value);
            //        }
            //    }

            //    // Отримуємо кількість значень по фільтру
            //    CountChildrenOfFilter = childrensItemFilter.Count();

            //    // Виводимо панель фільтра
            //    pnlFilter[i] = new System.Windows.Forms.Panel();
            //    pnlFilter[i].BackColor = System.Drawing.Color.Transparent;
            //    pnlFilter[i].Location = new System.Drawing.Point(startX*2, startY + btnFilter[i].Height + interval);
            //    pnlFilter[i].Name = $"{pnlFilter[i]}";
            //    pnlFilter[i].Size = new System.Drawing.Size(173, 0);
            //    Controls.Add(pnlFilter[i]);
            //    pnlFilter[i].Visible = false;

            //    // Виводимо кнопку "Зберегти вибрані значення чекбоксів"
            //    btnSaveChoiceFilter[i] = new System.Windows.Forms.Button();
            //    btnSaveChoiceFilter[i].Location = new Point(0, 2 * checkBoxHeight * (CountChildrenOfFilter - 1));
            //    btnSaveChoiceFilter[i].Name = $"{btnSaveChoiceFilter[i]}";
            //    btnSaveChoiceFilter[i].Size = new System.Drawing.Size(172, 29);
            //    btnSaveChoiceFilter[i].Text = "Застосувати фільтр";
            //    btnSaveChoiceFilter[i].UseVisualStyleBackColor = true;
            //    btnSaveChoiceFilter[i].Visible = true;

            //    // Додаємо кнопку збереження на панель чекбоксів
            //    pnlFilter[i].Controls.Add(btnSaveChoiceFilter[i]);

            //    //MessageBox.Show("Hello 2");

            //    // Виводимо чекбокси
            //    foreach (var item in childrensItemFilter)
            //    {
            //        CheckBox chb = new CheckBox();
            //        chb.AutoSize = true;
            //        chb.Location = new System.Drawing.Point(1, dy1);
            //        chb.Size = new System.Drawing.Size(82, checkBoxHeight);
            //        chb.Text = item.ToString();
            //        chb.UseVisualStyleBackColor = true;
            //        pnlFilter[i].Controls.Add(chb);
            //        // Зміщуємо виведення наступного чекбокса на його висоту + інтервал
            //        dy1 = dy1 + checkBoxHeight + interval;
            //    }


            //    // Обробка кліка кнопки фільтра
            //    void btnFilter_Click(object sender, EventArgs e)
            //    {
            //        MessageBox.Show("Hello");
            //        pnlFilter[i].Visible = true;

            //        // Задаємо висоту панелі виведення чекбоксів
            //        //pnlFilter[i].Height = 2 * checkBoxHeight * (CountChildrenOfFilter - 1)
            //        //    + interval + btnSaveChoiceFilter[i].Height;
            //    }

            //}

            //foreach (var item in namesOfFilter)
            //{
            //    MessageBox.Show(item.ToString());
            //}
            #endregion

            //this.AutoScroll = true;

            #region Old buttons and panels
            //    // Виводимо кнопки для фільтра брендів і для його очищення
            //    btnFilterBrand.Location = new Point(startX, startY);
            //    btnClosedBrand.Location = new Point(startX + btnFilterBrand.Width + interval, startY);

            //    // Виводимо панель фільтрів по бренду
            //    pnlFilterBrand.Location = new Point(startX, startY + btnFilterBrand.Height + interval / 2);
            //    pnlFilterBrand.Height = 0;

            //    // Виводимо кнопки для фільтра по потужності і для його очищення
            //    btnFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval);
            //    btnClosedPower.Location = new Point(startX + btnFilterPower.Width + interval,
            //        startY + btnClosedBrand.Height + interval);

            //    // Виводимо панель фільтрів по потужності
            //    pnlFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height
            //        + interval + btnFilterPower.Height + interval / 2);
            //    pnlFilterPower.Height = 0;
            #endregion

        }

       

        #region Зсунення вниз кнопки Потужність
        ///// <summary>
        ///// Зсунення вниз кнопки Потужність
        ///// </summary>
        ///// <param name="move"></param>
        //private void MoveFilterPower(bool move)
        //{
        //    // Якщо передаємо в параметрі тру, то зсовуємо кнопку вниз
        //    if (move)
        //    {
        //        btnFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval + pnlFilterBrand.Height);
        //        btnClosedPower.Location = new Point(startX + btnFilterPower.Width + interval, startY + btnClosedBrand.Height + interval + pnlFilterBrand.Height);
        //        pnlFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval + pnlFilterBrand.Height + btnFilterPower.Height + interval / 2);
        //        pnlFilterPower.Height = 0;
        //    }
        //    // інакше лишаємо її на місці
        //    else
        //    {
        //        btnFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval);
        //        btnClosedPower.Location = new Point(startX + btnFilterPower.Width + interval, startY + btnClosedBrand.Height + interval);
        //        pnlFilterPower.Location = new Point(startX, startY + btnFilterBrand.Height + interval + btnFilterPower.Height + interval / 2);
        //        pnlFilterPower.Height = 0;
        //    }
        //}
        #endregion

        #region btnFilterBrand_Click
        //private void btnFilterBrand_Click(object sender, EventArgs e)
        //{
        //    // Очищаємо панель чекбоксів
        //    pnlFilterBrand.Controls.Clear();
        //    // Перший чекбокс буде виводитись з нульової позиції
        //    dy1 = 0;
        //    // Отримуємо з БД список значень по даному фільтру
        //    List<string> checksBrand = new List<string>();
        //    var filters = GetListFilters();
        //    var result = from x in filters
        //                 where x.Name == btnFilterBrand.Text
        //                 select x.Children;
        //    foreach (var item in result)
        //    {
        //        foreach (var it in item)
        //        {
        //            checksBrand.Add(it.Value);
        //        }
        //    }
        //    // Отримуємо кількість значень по фільтру
        //    CountOfBrands = checksBrand.Count();
        //    // Задаємо висоту панелі виведення чекбоксів
        //    pnlFilterBrand.Height = 2 * checkBoxHeight * (CountOfBrands - 1)
        //        + interval + btnSaveChoiceBrand.Height;
        //    // Виводимо чекбокси
        //    foreach (var item in checksBrand)
        //    {
        //        CheckBox chb = new CheckBox();
        //        chb.AutoSize = true;
        //        chb.Location = new System.Drawing.Point(1, dy1);
        //        chb.Size = new System.Drawing.Size(82, checkBoxHeight);
        //        chb.Text = item.ToString();
        //        chb.UseVisualStyleBackColor = true;
        //        pnlFilterBrand.Controls.Add(chb);
        //        // Зміщуємо виведення наступного чекбокса на його висоту + інтервал
        //        dy1 = dy1 + checkBoxHeight + interval;
        //    }
        //    // Відображуємо кнопку Застосувати фільтр 
        //    btnSaveChoiceBrand.Visible = true;
        //    btnSaveChoiceBrand.Location = new Point(0, 2 * checkBoxHeight * (CountOfBrands - 1));
        //    pnlFilterBrand.Controls.Add(btnSaveChoiceBrand);
        //    // Зсовуємо наступну кнопку вниз
        //    MoveFilterPower(true);
        //}
        //private void btnClosedBrand_Click(object sender, EventArgs e)
        //{
        //    // Очищуємо панель з чекбоксами
        //    pnlFilterBrand.Controls.Clear();
        //    // Ховаємо панель чекбоксів
        //    pnlFilterBrand.Height = 0;
        //    // Підтягуємо наступну кнопку назад
        //    MoveFilterPower(false);
        //}
        #endregion

        #region btnFilterPower_Click
        //private void btnFilterPower_Click(object sender, EventArgs e)
        //{
        //    // Очищаємо панель чекбоксів
        //    pnlFilterPower.Controls.Clear();
        //    // Перший чекбокс буде виводитись з нульової позиції
        //    dy2 = 0;
        //    // Отримуємо з БД список значень по даному фільтру
        //    List<string> checksPower = new List<string>();
        //    var filters = GetListFilters();
        //    var result = from x in filters
        //                 where x.Name == btnFilterPower.Text
        //                 select x.Children;
        //    foreach (var items in result)
        //    {
        //        foreach (var it in items)
        //        {
        //            checksPower.Add(it.Value);
        //        }
        //    }
        //    // Отримуємо кількість значень по фільтру
        //    CountOfPowers = checksPower.Count();
        //    // Задаємо висоту панелі виведення чекбоксів
        //    pnlFilterPower.Height = 2 * checkBoxHeight * (CountOfPowers - 1)
        //        + interval + btnSaveChoicePower.Height;
        //    // Виводимо чекбокси
        //    foreach (var item in checksPower)
        //    {
        //        CheckBox chb = new CheckBox();
        //        chb.AutoSize = true;
        //        chb.Location = new System.Drawing.Point(1, dy2);
        //        chb.Size = new System.Drawing.Size(82, checkBoxHeight);
        //        chb.Text = item.ToString();
        //        chb.UseVisualStyleBackColor = true;
        //        pnlFilterPower.Controls.Add(chb);
        //        // Зміщуємо виведення наступного чекбокса на його висоту + інтервал
        //        dy2 = dy2 + checkBoxHeight + interval;
        //    }
        //    // Відображуємо кнопку Застосувати фільтр 
        //    btnSaveChoicePower.Visible = true;
        //    btnSaveChoicePower.Location = new Point(0, 2 * checkBoxHeight * (CountOfPowers - 1));
        //    pnlFilterPower.Controls.Add(btnSaveChoicePower);
        //}
        //private void btnClosedPower_Click(object sender, EventArgs e)
        //{
        //    // Очищуємо панель з чекбоксами
        //    pnlFilterPower.Controls.Clear();
        //    // Ховаємо панель чекбоксів
        //    pnlFilterPower.Height = 0;
        //}
        #endregion

        private List<FNameViewModel> GetListFilters()
        {
            var queryName = from f in _context.FilterNames.AsQueryable()
                            select f;
            var queryGroup = from g in _context.FilterNameGroups.AsQueryable()
                             select g;
            //Отримуємо загальну множину значень
            var query = from u in queryName
                        join g in queryGroup on u.Id equals g.FilterNameId into ua
                        from aEmp in ua.DefaultIfEmpty()
                        select new
                        {
                            FNameId = u.Id,
                            FName = u.Name,
                            FValueId = aEmp != null ? aEmp.FilterValueId : 0,
                            FValue = aEmp != null ? aEmp.FilterValueOf.Name : null,
                        };

            //Групуємо по іменам і сортуємо по спаданню імен
            var groupNames = query.AsEnumerable()
                      .GroupBy(f => new { Id = f.FNameId, Name = f.FName })
                      .Select(g => g)
                      .OrderByDescending(p => p.Key.Name);

            //По групах отримуємо
            var result = from fName in groupNames
                         select
                         new FNameViewModel
                         {
                             Id = fName.Key.Id,
                             Name = fName.Key.Name,
                             Children = fName.Select(x =>
                                   new FValueViewModel
                                   {
                                       Id = x.FValueId,
                                       Value = x.FValue
                                   }).OrderBy(l => l.Value).ToList()
                         };

            return result.ToList();
        }
        /// <summary>
        /// Додавання значення в фільтр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnAddFilterValue_Click(object sender, EventArgs e)
        {
            AddValueForm avf = new AddValueForm();
            avf.ShowDialog();
        }

        
    }
}
