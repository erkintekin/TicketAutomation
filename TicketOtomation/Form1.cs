using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TicketOtomation
{
    public partial class Pamukkale : Form
    {
        public Pamukkale()
        {
            InitializeComponent();
            leftseat.Text = "50";
            ciro.Text = "0 TL";
        }

        string isim;
        int age;
        string route;
        double price;
        int koltuk;

        private List<Ticket> biletListesi = new List<Ticket>();

        public void TicketList()
        {
            biletler.Items.Clear();

            foreach (var item in biletListesi)
            {
                biletler.Items.Add($" ");
                biletler.Items.Add($"Nereden-Nereye: {item.Route}\n");
                biletler.Items.Add($"Yolcu Adý-Soyadý: Sn.{item.Name}\n");
                biletler.Items.Add($"Yaþý: {item.Age}\n");
                biletler.Items.Add($"Tutar: {item.Price} TL");
                MessageBox.Show("      Ýyi yolculuklar dileriz!     ");
            }
        }

        public void SeatLeft()
        {
            int initSeat = 50;

            int totalSeat = initSeat - biletListesi.Sum(x => x.Koltuk);

            leftseat.Text = totalSeat.ToString();

            if (totalSeat == 0)
            {
                olustur.Enabled = false;
            }
            else
                olustur.Enabled = true;
        }

        public void totalMoney()
        {
            double totalMoney = biletListesi.Sum(x => x.Price);

            ciro.Text = totalMoney.ToString() + "TL";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            age = Convert.ToInt32(yas.Text);

            if (age >= 18 && checkBox1.Checked == true)
            {
                MessageBox.Show("Sadece 18 yaþýndan küçükler indirimden yararlanabilir!");
                checkBox1.Checked = false;
                checkBox1.Cursor = Cursors.No;

            }
            else if (age < 18)
            {
                MessageBox.Show("Tebrikler! %50 indirimden faydalanacaksýnýz!");
                checkBox1.Cursor = Cursors.Hand;
            };


        }

        private void guzergah_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (name.Text == string.Empty || guzergah.Text == string.Empty || koltuk_sayisi.Value == 0 || fiyat.Text == string.Empty || yas.Text == string.Empty)
            {
                MessageBox.Show("Zorunlu alanlarý doldurunuz!");
            }
            else
            {
                isim = name.Text;
                route = guzergah.Text;
                koltuk = Convert.ToInt32(koltuk_sayisi.Value);
                price = Convert.ToDouble(fiyat.Text) * koltuk;
                age = Convert.ToInt32(yas.Text);
                Ticket ticket = new Ticket(price, route, isim, age, koltuk);
                biletListesi.Add(ticket);
            }

            TicketList();
            SeatLeft();
            totalMoney();



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userDeleted = user_Delete.Text;

            if (!string.IsNullOrEmpty(userDeleted))
            {
                if (biletListesi.Any(x => x.Name == userDeleted))
                {

                    MessageBox.Show("Kullanýcý silme baþarýsýz!");
                }
                else
                {
                    biletler.Items.Clear();
                    MessageBox.Show("Kullanýcý bulunamadý! Tekrardan bilet almak ister misiniz?");
                }
            }
            else
            {
                biletler.Items.Clear();
                MessageBox.Show("Ýade et kýsmýna ad-soyad giriþi yapýnýz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userDeleted = user_Delete.Text;
            if (!string.IsNullOrEmpty(userDeleted))
            {
                if (biletListesi.Any(x => x.Name == userDeleted))
                {
                    biletler.Items.Clear();
                    biletListesi.RemoveAll(x => x.Name == userDeleted);
                    TicketList();
                    SeatLeft();
                    totalMoney();
                }
                else
                {
                    MessageBox.Show("Kullanýcý bulunamadý! Tekrar deneyiniz!");
                }
            }
            else
            {
                biletler.Items.Clear();
                MessageBox.Show("Ad-Soyad giriniz!");
            }
        }

        private void leftseat_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

    class Ticket
    {
        public double BasePrice { get; set; }
        public string Name { get; set; }
        public string Route { get; set; }
        public double Price { get; set; }
        public int Age { get; set; }
        public int Koltuk { get; set; }

        public Ticket(double price, string route, string name, int age, int koltuk)
        {
            BasePrice = price;
            Route = route;
            Name = name;
            Age = age;
            Price = Discount();
            Koltuk = koltuk;
        }

        public double Discount()
        {
            if (Age < 18)
            {
                return BasePrice * 0.5;
            }
            return BasePrice;
        }

    }



}
