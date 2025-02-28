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
    public partial class FrmStatistics : Form
    {
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities(); // Veritabanı bağlantısı
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString(); // Toplam lokasyon sayısını ekrana yazdırır.
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString(); // Toplam kapasiteyi ekrana yazdırır.
            lblGuideCount.Text = db.Guide.Count().ToString(); // Toplam rehber sayısını ekrana yazdırır.
            lblAvarageCapacity.Text = db.Location.Average(x => x.Capacity).Value.ToString("F2"); // Ortalama kapasiteyi ekrana yazdırır.
            lblAvarageLocationPrice.Text = db.Location.Average(x => x.Price).Value.ToString("F2")+" TL"; // Ortalama lokasyon fiyatını ekrana yazdırır.
            
            int lastCountryId=db.Location.Max(x => x.LocationId); // En son eklenen lokasyonun Id'sini alır.
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y=>y.Country).FirstOrDefault(); // En son eklenen lokasyonun adını ekrana yazdırır.
            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString(); // Kapadokya'daki toplam kapasiteyi ekrana yazdırır.
            lblTurkeyAvarageCapacity.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString(); // Türkiye'deki ortalama kapasiteyi ekrana yazdırır.

            var RomeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault(); // Roma'daki rehberin Id'sini alır.
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == RomeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString(); // Roma'daki rehberin adını ekrana yazdırır.

            var MaxCapacity = db.Location.Max(x => x.Capacity); // En yüksek kapasiteyi alır.
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == MaxCapacity).Select(y => y.City).FirstOrDefault().ToString(); // En yüksek kapasiteli lokasyonun şehrini ekrana yazdırır.

            var MaxPrice = db.Location.Max(x => x.Price); // En yüksek fiyatı alır.
            lblMaxPriceLocaiton.Text = db.Location.Where(x => x.Price == MaxPrice).Select(y => y.City).FirstOrDefault().ToString(); // En yüksek fiyatlı lokasyonun şehrini ekrana yazdırır.

            var GuideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault(); // Ayşegül Çınar'ın Id'sini alır.
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == GuideIdByNameAysegulCinar).Count().ToString(); // Ayşegül Çınar'ın kaç lokasyonu olduğunu ekrana yazdırır.

        }

        private void lblAvarageLocationPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
