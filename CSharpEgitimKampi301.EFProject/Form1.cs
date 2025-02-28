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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities(); // Veritabanı nesnesi oluşturulur.
        private void btnList_Click(object sender, EventArgs e)
        {            
            var values = db.Guide.ToList(); // Guide tablosundaki tüm verileri getirir.
            dataGridView1.DataSource = values; // Verileri datagridview'e yazar.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide(); // Guide sınıfından yeni bir nesne oluşturur.
            guide.GuideName = txtName.Text; // Formdaki verileri alır.
            guide.GuideSurname = txtSurname.Text; // Formdaki verileri alır.
            db.Guide.Add(guide); // Guide tablosuna veri ekler.
            db.SaveChanges(); // Değişiklikleri kaydeder.
            MessageBox.Show("Rehber başarıyla eklendi", "!! UYARI !!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Ekleme işlemi başarılı olursa mesaj verir.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text); // Silinecek verinin Id'si alınır.
            var removeValue = db.Guide.Find(id); // Find metodu ile veriye ulaşılır.
            db.Guide.Remove(removeValue); // Remove metodu ile veri silme işlemi yapılır.
            db.SaveChanges(); // Değişiklikler kaydedilir.
            MessageBox.Show("Rehber başarıyla silindi", "!! UYARI !!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Silme işlemi başarılı olursa mesaj verir.
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text); // Güncellenecek verinin Id'si alınır.
            var updateValue = db.Guide.Find(id); // Find metodu ile veriye ulaşılır.
            updateValue.GuideName = txtName.Text; // Formdaki verileri alır.
            updateValue.GuideSurname = txtSurname.Text; // Formdaki verileri alır.
            db.SaveChanges(); // Değişiklikler kaydedilir.
            MessageBox.Show("Rehber başarıyla güncellendi", "!! UYARI !!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Güncelleme işlemi başarılı olursa mesaj verir.
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text); // Getirilecek verinin Id'si alınır.
            var getValue = db.Guide.Where(x=>x.GuideId == id).ToList(); // Where metodu ile veriye ulaşılır.
            dataGridView1.DataSource = getValue; // Verileri datagridview'e yazar.
        }
    }
}
