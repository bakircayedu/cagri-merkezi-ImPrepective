using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SinglyLinkedList<Call> waitingCallListIndividual = new SinglyLinkedList<Call>();
        SinglyLinkedList<Call> waitingCallListCommercial = new SinglyLinkedList<Call>();
        private void btnAra_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Ad = txtAd.Text;
            customer.Soyad = txtSoyad.Text;
            customer.TelNo = txtTelNo.Text;
            if (rbCommercial.Checked)
             customer.MusteriTipi = Type.Commercial;
            
            else if (rbIndividual.Checked)
             customer.MusteriTipi = Type.Individual;

            Call call = new Call {Customer=customer,CallType=customer.MusteriTipi,Date=DateTime.Now };
            if (call.CallType==Type.Commercial)
            {
                waitingCallListCommercial.AddLast(call);
            }
            else
            {
                waitingCallListIndividual.AddLast(call);
            }
            
            txtSiraBildir.Text+=("sıradasınız.");
        }
        SinglyLinkedList<CustomerService> customerServiceList = new SinglyLinkedList<CustomerService>();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerService individual1 = new CustomerService {Id=1, FirstName="Ahmet", WorkType=Type.Individual };
            CustomerService individual2 = new CustomerService { Id = 2, FirstName = "Mehmet", WorkType = Type.Individual };
            CustomerService commercial1 = new CustomerService { Id = 3, FirstName = "Ali", WorkType = Type.Commercial };
            CustomerService commercial2 = new CustomerService { Id = 4, FirstName = "Veli", WorkType = Type.Commercial };
            customerServiceList.AddLast(individual1);
            customerServiceList.AddLast(individual2);
            customerServiceList.AddLast(commercial1);
            customerServiceList.AddLast(commercial2);
            
        }

        private void btnGuncelle1_Click(object sender, EventArgs e)
        {
            BireyselTemsilci1.Items.Clear();
            if (customerServiceList.Head.Value.Statu)
                BireyselTemsilci1.Items.Add("! Bireysel Temsilci !" + "  İsim: " + customerServiceList.Head.Value.FirstName + " Durum: Uygun" );
            else
                BireyselTemsilci1.Items.Add("! Bireysel Temsilci !" + "  İsim: " + customerServiceList.Head.Value.FirstName + " Durum: Meşgul");


        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            BireyselTemsilci2.Items.Clear();
            if (customerServiceList.Head.Next.Value.Statu)
                BireyselTemsilci2.Items.Add("! Bireysel Temsilci !" + "  İsim: " + customerServiceList.Head.Next.Value.FirstName + " Durum: Uygun") ;
            else
                BireyselTemsilci2.Items.Add("! Bireysel Temsilci !" + "  İsim: " + customerServiceList.Head.Next.Value.FirstName + " Durum: Meşgul");
        }

        private void btnGuncelle3_Click(object sender, EventArgs e)
        {
            TicariTemsilci1.Items.Clear();
            if(customerServiceList.Head.Next.Next.Value.Statu)
                TicariTemsilci1.Items.Add("! Ticari Temsilci !" + "  İsim: " + customerServiceList.Head.Next.Next.Value.FirstName + " Durum: Uygun" );
            else
                TicariTemsilci1.Items.Add("! Ticari Temsilci !" + "  İsim: " + customerServiceList.Head.Next.Next.Value.FirstName + " Durum: Meşgul");
        }

        private void btnGuncelle4_Click(object sender, EventArgs e)
        {
            TicariTemsilci2.Items.Clear();
            if(customerServiceList.Head.Next.Next.Next.Value.Statu)
                TicariTemsilci2.Items.Add("! Ticari Temsilci !"+"  İsim: " + customerServiceList.Head.Next.Next.Next.Value.FirstName + " Durum: Uygun" );
            else
                TicariTemsilci2.Items.Add("! Ticari Temsilci !" + "  İsim: " + customerServiceList.Head.Next.Next.Next.Value.FirstName + " Durum: Meşgul");
        }

        private void btnCagriListele_Click(object sender, EventArgs e)
        {
            BekleyenCagriBireysel.Items.Clear();
            int count = 1;
            
            foreach (var call in waitingCallListIndividual)
            { 
                BekleyenCagriBireysel.Items.Add("Müşteri İsmi: " + call.Customer.Ad + " Çağrı Oluşturma Zamanı: " + call.Date + " Sırası: " + count);
                count++;
            }
           
        }

        private void btnTicariCagriListele_Click(object sender, EventArgs e)
        {
            BekleyenCagriTicari.Items.Clear();
           
            int count = 1;
            foreach (var call in waitingCallListCommercial)
            {
                BekleyenCagriTicari.Items.Add("Müşteri İsmi: " + call.Customer.Ad + " Çağrı Oluşturma Zamanı: " + call.Date + " Sırası: " + count);
                count++;
                
            }
            
        }

        private void btnCagriBaslat_Click(object sender, EventArgs e)
        {

        }
    }
}
