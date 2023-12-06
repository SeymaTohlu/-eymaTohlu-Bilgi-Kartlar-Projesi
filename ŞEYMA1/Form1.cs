using OfficeOpenXml;
using System.Diagnostics;
using System.Text;

namespace ŞEYMA1
{
    public partial class Form1 : Form
    {
        private ExcelWorksheet page1, page2;

        private List<CategoryItem> categoryList;
        private List<SubCategoryItem> subCategoryList;

        public Form1()
        {
            InitializeComponent();
            LoadDataToComboBox();

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            ShowDetails.Click += ShowDetails_Click;
            ShowDetails.Visible = true;
            textBox1.Visible = false;

        }

        private void LoadDataToComboBox()
        {
            // EPPlus kütüphanesinin lisans kontrolünü belirtiyoruz
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


            // Excel dosyasının adını belirliyoruz
            string excelFileName = "Katagoriler Tablosu.xlsx";

            // Excel dosyasının tam yolunu oluşturuyoruz
            string excelFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), excelFileName);

            try
            {
                // Excel dosyasını okumak için bir paket oluşturuyoruz
                using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
                {
                    // Excel dosyasındaki ilk çalışma sayfasını seçiyoruz
                    page1 = package.Workbook.Worksheets[0];
                    page2 = package.Workbook.Worksheets[1];

                    // Verileri Excel'den al
                    categoryList = GetCategoryData();
                    subCategoryList = GetSubCategoryData();

                    // ComboBox'a veri aktar
                    LoadComboBoxFromSelectedCategory(categoryList);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda hatayı konsola yazdırıyoruz
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        private List<CategoryItem> GetCategoryData()
        {
            List<CategoryItem> data = new List<CategoryItem>();

            for (int row = 2; row <= page1.Dimension.End.Row; row++)
            {
                if (string.IsNullOrEmpty(page1.Cells[row, 1].Text))
                    continue;

                int categoryId = int.Parse(page1.Cells[row, 1].Text);
                string categoryName = page1.Cells[row, 2].Text;

                data.Add(new CategoryItem { CategoryID = categoryId, CategoryName = categoryName });
            }

            return data;
        }


        private List<SubCategoryItem> GetSubCategoryData()
        {
            List<SubCategoryItem> data = new List<SubCategoryItem>();

            for (int row = 2; row <= page2.Dimension.End.Row; row++)
            {
                if (string.IsNullOrEmpty(page2.Cells[row, 1].Text))
                    continue;

                SubCategoryItem item = new SubCategoryItem();

                item.ImageID = int.Parse(page2.Cells[row, 1].Text);
                item.CategoryID = int.Parse(page2.Cells[row, 2].Text);
                item.CategoryName = page2.Cells[row, 3].Text;
                item.ImageURL = page2.Cells[row, 4].Text;
                item.ImagePhotoDescription = page2.Cells[row, 5].Text;
                data.Add(item);
            }

            return data;
        }

        private void LoadComboBoxFromSelectedCategory(List<CategoryItem> dataSource)
        {
            if (dataSource != null)
            {

                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryID";

                comboBox1.DataSource = dataSource;
            }
            else
            {
                throw new NullReferenceException("Data Source is Null !");
            }
        }

        private void LoadComboBox2FromSelectedCategory(List<SubCategoryItem> dataSource)
        {
            if (dataSource != null)
            {
                comboBox2.DisplayMember = "CategoryName";
                comboBox2.ValueMember = "ImageID";

                comboBox2.DataSource = dataSource;
            }
            else
            {
                throw new NullReferenceException("Data Source is Null !");
            }
        }


        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Debug.WriteLine("Secilen Kategori ID : " + comboBox1.SelectedValue);

            int selectedCategoryID = (int)comboBox1.SelectedValue;

            List<SubCategoryItem> availableSubCategries = subCategoryList.Where(x => x.CategoryID == selectedCategoryID).ToList();

            LoadComboBox2FromSelectedCategory(availableSubCategries);
        }


        private void ComboBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Debug.WriteLine("Secilen Alt Kategorinin Image ID'si : " + comboBox2.SelectedValue);

            int selectedSubCategoryImageID = (int)comboBox2.SelectedValue;

            SubCategoryItem selectedSubCategory = subCategoryList.First(x => x.ImageID == selectedSubCategoryImageID);

            pictureBox1.ImageLocation = selectedSubCategory.ImageURL;
        }
        private void ShowDetails_Click(object sender, EventArgs e)
        {
            // ComboBox2'de bir öğe seçilip seçilmediğini kontrol edin
            if (comboBox2.SelectedItem != null)
            {
                // Seçilen öğe ile istenen işlemi gerçekleştirin
                SubCategoryItem selectedSubCategory = (SubCategoryItem)comboBox2.SelectedItem;

                // Burada seçilen alt kategori ile ilgili bilgiyi TextBox'a ekleyebilirsiniz
                string subCategoryInfo = GetSubCategoryInfo(selectedSubCategory);
                textBox1.Text = subCategoryInfo;

                // Butonun görünürlüğünü kapat
                ShowDetails.Visible = false;
                textBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen düğmeye tıklamadan önce bir alt kategori seçin.");
            }
        }

        private string GetSubCategoryInfo(SubCategoryItem subCategory)
        {
            // Burada seçilen alt kategori ile ilgili bilgiyi oluşturabilirsiniz
            // Örneğin:
            // return $"Alt Kategori Adı: {subCategory.CategoryName}, Bilgi: {subCategory.Description}";

            // Eğer sadece ImagePhotoDescription'ı istiyorsanız:
            return subCategory.ImagePhotoDescription;
        }




        private class CategoryItem
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
        }

        private class SubCategoryItem
        {
            public int ImageID { get; set; }
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public string ImageURL { get; set; }
            public string ImagePhotoDescription { get; set; }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowDetails_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


