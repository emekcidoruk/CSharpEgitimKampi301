using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList(); // Location tablosundaki tüm verileri alır.
            dataGridView1.DataSource = values; // Alınan verileri datagridview'e yazar.
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName=x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList(); // Guide tablosundaki tüm verileri alır.
            
            cmbGuide.DisplayMember = "GuideName"; // Guide tablosundaki GuideName ve GuideSurname alanlarını birleştirir.
            cmbGuide.ValueMember = "GuideID"; // Guide tablosundaki GuideID alanını alır.
            cmbGuide.DataSource = values; // Alınan verileri combobox'a yazar.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location(); // Location sınıfından bir nesne oluşturur.
            location.Capacity = byte.Parse(nudCapacity.Value.ToString()); // Capacity alanına numericupdown'dan alınan değeri atar.
            location.City = txtCity.Text; // City alanına textbox'tan alınan değeri atar.
            location.Country = txtCountry.Text; // Country alanına textbox'tan alınan değeri atar.
            location.DayNight = txtDayNight.Text; // DayNight alanına textbox'tan alınan değeri atar.
            location.Price = decimal.Parse(txtPrice.Text); // Price alanına textbox'tan alınan değeri atar.
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString()); // GuideId alanına combobox'tan alınan değeri atar.
            db.Location.Add(location); // Location tablosuna location nesnesini ekler.
            db.SaveChanges(); // Değişiklikleri kaydeder.
            MessageBox.Show("Ekleme İşlemi Başarılı !!"); // Kullanıcıya ekleme işleminin başarılı olduğunu bildirir.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text); // Id alanına textbox'tan alınan değeri atar.
            var deletedValue = db.Location.Find(id); // Location tablosundan id'si alınan veriyi bulur.
            db.Location.Remove(deletedValue); // Location tablosundan id'si alınan veriyi siler.
            db.SaveChanges(); // Değişiklikleri kaydeder.
            MessageBox.Show("Silme İşlemi Başarılı !!"); // Kullanıcıya silme işleminin başarılı olduğunu bildirir.
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text); // Id alanına textbox'tan alınan değeri atar.
            var updatedValue = db.Location.Find(id); // Location tablosundan id'si alınan veriyi bulur.
            updatedValue.DayNight = txtDayNight.Text; // DayNight alanına textbox'tan alınan değeri atar.
            updatedValue.Price = decimal.Parse(txtPrice.Text); // Price alanına textbox'tan alınan değeri atar.
            updatedValue.Capacity = byte.Parse(nudCapacity.Value.ToString()); // Capacity alanına numericupdown'dan alınan değeri atar.
            updatedValue.City = txtCity.Text; // City alanına textbox'tan alınan değeri atar.
            updatedValue.Country = txtCountry.Text; // Country alanına textbox'tan alınan değeri atar.
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString()); // GuideId alanına combobox'tan alınan değeri atar.
            db.SaveChanges(); // Değişiklikleri kaydeder.
            MessageBox.Show("Güncelleme İşlemi Başarılı !!"); // Kullanıcıya güncelleme işleminin başarılı olduğunu bildirir.195

        }
    }
}
